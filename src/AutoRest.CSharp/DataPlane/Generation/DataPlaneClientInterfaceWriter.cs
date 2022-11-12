// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoRest.CSharp.AutoRest.Plugins;
using AutoRest.CSharp.Common.Generation.Writers;
using AutoRest.CSharp.Common.Output.Builders;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Output.Models;
using AutoRest.CSharp.Output.Models.Requests;
using AutoRest.CSharp.Output.Models.Shared;
using AutoRest.CSharp.Output.Models.Types;
using AutoRest.CSharp.Utilities;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Response = Azure.Response;

namespace AutoRest.CSharp.Generation.Writers
{
    internal class DataPlaneClientInterfaceWriter : ClientWriter
    {
        public void WriteClientInterface(CodeWriter writer, DataPlaneClient client, DataPlaneOutputLibrary library)
        {
            var cs = client.Type;
            var @namespace = cs.Namespace;
            using (writer.Namespace(@namespace))
            {
                writer.WriteXmlDocumentationSummary($"{client.Description}");

                using (writer.Scope($"{client.Declaration.Accessibility} partial interface I{cs.Name}"))
                {
                    foreach (var clientMethod in client.Methods)
                    {
                        WriteClientMethodInterface(writer, clientMethod, true);
                        WriteClientMethodInterface(writer, clientMethod, false);
                    }

                    foreach (var pagingMethod in client.PagingMethods)
                    {
                        WritePagingOperationInterface(writer, pagingMethod, true);
                        WritePagingOperationInterface(writer, pagingMethod, false);
                    }

                    foreach (var longRunningOperation in client.LongRunningOperationMethods)
                    {
                        WriteStartOperationOperationInterface(writer, longRunningOperation, true);
                        WriteStartOperationOperationInterface(writer, longRunningOperation, false);
                    }
                }
            }
        }

        private void WriteClientMethodInterface(CodeWriter writer, ClientMethod clientMethod, bool async)
        {
            CSharpType? bodyType = clientMethod.RestClientMethod.ReturnType;
            CSharpType responseType = bodyType != null ?
                new CSharpType(typeof(Response<>), bodyType) :
                typeof(Response);

            responseType = async ? new CSharpType(typeof(Task<>), responseType) : responseType;

            var parameters = clientMethod.RestClientMethod.Parameters;
            writer.WriteXmlDocumentationSummary($"{clientMethod.RestClientMethod.SummaryText}");

            foreach (Parameter parameter in parameters)
            {
                writer.WriteXmlDocumentationParameter(parameter.Name, $"{parameter.Description}");
            }

            writer.WriteXmlDocumentationParameter("cancellationToken", $"The cancellation token to use.");
            writer.WriteXmlDocumentation("remarks", $"{clientMethod.RestClientMethod.DescriptionText}");

            var methodName = CreateMethodName(clientMethod.Name, async);
            writer.Append($"{clientMethod.Accessibility} {responseType} {methodName}(");

            foreach (Parameter parameter in parameters)
            {
                writer.WriteParameter(parameter);
            }
            writer.Line($"{typeof(CancellationToken)} cancellationToken = default);");
            writer.Line();
        }

        private void WritePagingOperationInterface(CodeWriter writer, PagingMethod pagingMethod, bool async)
        {
            var pageType = pagingMethod.PagingResponse.ItemType;
            CSharpType responseType = async ? new CSharpType(typeof(AsyncPageable<>), pageType) : new CSharpType(typeof(Pageable<>), pageType);
            var parameters = pagingMethod.Method.Parameters;

            writer.WriteXmlDocumentationSummary($"{pagingMethod.Method.SummaryText}");

            foreach (Parameter parameter in parameters)
            {
                writer.WriteXmlDocumentationParameter(parameter.Name, $"{parameter.Description}");
            }

            writer.WriteXmlDocumentationParameter("cancellationToken", $"The cancellation token to use.");
            writer.WriteXmlDocumentationRequiredParametersException(parameters);
            writer.WriteXmlDocumentation("remarks", $"{pagingMethod.Method.DescriptionText}");

            writer.Append($"{pagingMethod.Accessibility} {responseType} {CreateMethodName(pagingMethod.Name, async)}(");
            foreach (Parameter parameter in parameters)
            {
                writer.WriteParameter(parameter);
            }

            writer.Line($"{typeof(CancellationToken)} cancellationToken = default);");
            writer.Line();
        }

        private void WriteStartOperationOperationInterface(CodeWriter writer, LongRunningOperationMethod lroMethod, bool async)
        {
            RestClientMethod originalMethod = lroMethod.StartMethod;
            CSharpType returnType = async ? new CSharpType(typeof(Task<>), lroMethod.Operation.Type) : lroMethod.Operation.Type;
            var parameters = originalMethod.Parameters;

            writer.WriteXmlDocumentationSummary($"{originalMethod.SummaryText}");

            foreach (Parameter parameter in parameters)
            {
                writer.WriteXmlDocumentationParameter(parameter.Name, $"{parameter.Description}");
            }
            writer.WriteXmlDocumentationParameter("cancellationToken", $"The cancellation token to use.");
            writer.WriteXmlDocumentationRequiredParametersException(parameters);
            writer.WriteXmlDocumentation("remarks", $"{originalMethod.DescriptionText}");

            writer.Append($"{lroMethod.Accessibility} {returnType} {CreateStartOperationName(lroMethod.Name, async)}(");
            foreach (Parameter parameter in parameters)
            {
                writer.WriteParameter(parameter);
            }
            writer.Line($"{typeof(CancellationToken)} cancellationToken = default);");
            writer.Line();
        }

        private string CreateStartOperationName(string name, bool async) => $"Start{name}{(async ? "Async" : string.Empty)}";
    }
}
