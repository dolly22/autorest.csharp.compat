// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using AutoRest.CSharp.Generation.Writers;
using AutoRest.CSharp.Output.Models.Types;
using AutoRest.CSharp.Output.Models;
using AutoRest.CSharp.DataPlane.Output;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Output.Models.Shared;
using Azure.Core.Pipeline;
using Azure.Core;
using Azure;
using AutoRest.CSharp.Common.Generation.Writers;

namespace AutoRest.CSharp.DataPlane.Generation
{
    internal class DataPlaneClientFactoryWriter : ClientWriter
    {
        public void WriteClientFactory(CodeWriter writer, DataPlaneClientFactory clientFactory, DataPlaneOutputLibrary library)
        {
            var cs = clientFactory.Type;
            var csInterface = clientFactory.ClientInterface.Type;

            var @namespace = cs.Namespace;
            using (writer.Namespace(@namespace))
            {
                using (writer.Scope($"{clientFactory.Declaration.Accessibility} partial class {cs.Name} : {csInterface}"))
                {
                    WriteFactoryFields(writer, library.ClientOptions!, true);
                    WriteFactoryCtors(writer, clientFactory, library);

                    foreach (var dataPlaneClient in library.Clients)
                    {
                        WriteDataPlaneClientFactory(writer, dataPlaneClient);
                    }
                }
            }
        }

        public void WriteClientFactoryInterface(CodeWriter writer, DataPlaneClientFactory clientFactory, DataPlaneOutputLibrary library)
        {
            var cs = clientFactory.ClientInterface.Type;
            var @namespace = cs.Namespace;
            using (writer.Namespace(@namespace))
            {
                using (writer.Scope($"{clientFactory.Declaration.Accessibility} interface {cs.Name}"))
                {
                    foreach (var dataPlaneClient in library.Clients)
                    {
                        WriteDataPlaneClientFactoryDeclarations(writer, dataPlaneClient);
                    }
                }
            }
        }

        private void WriteFactoryFields(CodeWriter writer, ClientOptionsTypeProvider clientOptions, bool writePipelineField)
        {
            writer.Line($"private readonly {typeof(Uri)} {EndpointField};");
            writer.Line($"private readonly {clientOptions.Type} {OptionsField};");
            writer.Line($"private readonly {typeof(ClientDiagnostics)} {ClientDiagnosticsField.GetReferenceFormattable()};");
            writer.Line($"private {typeof(HttpPipeline)} {PipelineField};");
        }

        private const string PoliciesVariable = "perRetryPolicies";
        private const string EndpointVariable = "endpoint";
        private const string EndpointField = "_" + EndpointVariable;
        private const string OptionsVariable = "options";
        private const string OptionsField = "_" + OptionsVariable;

        private void WriteFactoryCtors(CodeWriter writer, DataPlaneClientFactory client, DataPlaneOutputLibrary library)
        {
            writer.Line();
            writer.WriteXmlDocumentationSummary($"Initializes a new instance of {client.Type.Name} for mocking.");
            using (writer.Scope($"protected {client.Type.Name:D}()"))
            {
            }
            writer.Line();

            var clientOptionsName = library.ClientOptions!.Declaration.Name;

            var commonParams = new Parameter[] { KnownParameters.Endpoint with { DefaultValue = Constant.Default(new CSharpType(typeof(Uri), true)) } };

            {
                var ctorParams = RestClientBuilder.GetConstructorParameters(commonParams, null);

                writer.WriteXmlDocumentationSummary($"Initializes a new instance of {client.Type.Name}");
                foreach (Parameter parameter in ctorParams)
                {
                    writer.WriteXmlDocumentationParameter(parameter.Name, $"{parameter.Description}");
                }
                writer.WriteXmlDocumentationParameter(OptionsVariable, $"The options for configuring the client.");
                writer.WriteXmlDocumentationParameter(PoliciesVariable, $"Per retry pipeline policies.");

                writer.Append($"public {client.Type.Name:D}(");
                foreach (Parameter parameter in ctorParams)
                {
                    writer.WriteParameter(parameter);
                }
                writer.Append($" {clientOptionsName} {OptionsVariable} = null,");
                writer.Append($" params {typeof(HttpPipelinePolicy[])} {PoliciesVariable})");

                using (writer.Scope())
                {
                    writer.WriteParameterNullChecks(ctorParams);
                    writer.Line();

                    writer.Line($"{OptionsVariable} ??= new {clientOptionsName}();");
                    writer.Line($"{ClientDiagnosticsField.GetReferenceFormattable()} = new {typeof(ClientDiagnostics)}({OptionsVariable});");

                    writer.Line($"{PipelineField} = {typeof(HttpPipelineBuilder)}.Build({OptionsVariable}, {PoliciesVariable});");
                    writer.Line($"{EndpointField} = {EndpointVariable};");
                    writer.Line($"{OptionsField} = {OptionsVariable};");
                }
                writer.Line();
            }

            writer.Line();
        }

        private void WriteDataPlaneClientFactory(CodeWriter writer, DataPlaneClient client)
        {
            var responseType = client.ClientInterface is not null ? client.ClientInterface.Type : client.Type;

            writer.WriteXmlDocumentationSummary($"Creates {client.Type.Name} instance.");
            writer.Append($"public virtual {responseType} {client.ClientShortName}() => ");

            writer.Append($"new {client.Type}(");
            foreach (var parameter in client.RestClient.Parameters)
            {
                if (parameter.IsApiVersionParameter)
                {
                    writer.Append($"{OptionsField}.Version, ");
                }
                else if (parameter == KnownParameters.ClientDiagnostics)
                {
                    writer.Append($"{ClientDiagnosticsField.GetReferenceFormattable()}, ");
                }
                else if (parameter == KnownParameters.Pipeline)
                {
                    writer.Append($"{PipelineField}, ");
                }
                else if (parameter.Type.Equals(typeof(Uri)) && parameter.Name == KnownParameters.Endpoint.Name)
                {
                    writer.Append($"{EndpointField}, ");
                }
                else
                {
                    writer.Append($"{parameter.Name}, ");
                }
            }
            writer.RemoveTrailingComma();
            writer.Line($");");
            writer.Line();
        }

        private void WriteDataPlaneClientFactoryDeclarations(CodeWriter writer, DataPlaneClient client)
        {
            var responseType = client.ClientInterface is not null ? client.ClientInterface.Type : client.Type;

            writer.WriteXmlDocumentationSummary($"Creates {client.Type.Name} instance.");
            writer.Line($"{responseType} {client.ClientShortName}();");
            writer.Line();
        }
    }
}
