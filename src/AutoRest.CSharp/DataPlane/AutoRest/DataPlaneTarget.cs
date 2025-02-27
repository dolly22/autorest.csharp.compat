// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Linq;
using AutoRest.CSharp.Common.Input;
using AutoRest.CSharp.Common.Output.Builders;
using AutoRest.CSharp.DataPlane.Generation;
using AutoRest.CSharp.Generation.Writers;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Input.Source;
using AutoRest.CSharp.Output.Models.Responses;
using AutoRest.CSharp.Output.Models.Types;

namespace AutoRest.CSharp.AutoRest.Plugins
{
    internal class DataPlaneTarget
    {
        public static void Execute(GeneratedCodeWorkspace project, CodeModel codeModel, SourceInputModel? sourceInputModel)
        {
            BuildContext<DataPlaneOutputLibrary> context = new BuildContext<DataPlaneOutputLibrary>(codeModel, sourceInputModel);

            var library = context.Library;
            var modelWriter = new ModelWriter();
            var clientWriter = new DataPlaneClientWriter();
            var clientInterfaceWriter = new DataPlaneClientInterfaceWriter();
            var restClientWriter = new RestClientWriter();
            var serializeWriter = new SerializationWriter();
            var headerModelModelWriter = new DataPlaneResponseHeaderGroupWriter();
            var longRunningOperationWriter = new LongRunningOperationWriter();
            var clientFactoryWriter = new DataPlaneClientFactoryWriter();

            foreach (var model in library.Models)
            {
                var codeWriter = new CodeWriter();
                modelWriter.WriteModel(codeWriter, model);

                var serializerCodeWriter = new CodeWriter();
                serializeWriter.WriteSerialization(serializerCodeWriter, model);

                var name = model.Type.Name;
                project.AddGeneratedFile($"Models/{name}.cs", codeWriter.ToString());
                project.AddGeneratedFile($"Models/{name}.Serialization.cs", serializerCodeWriter.ToString());
            }

            var modelFactoryType = library.ModelFactory;
            if (modelFactoryType != default)
            {
                var modelFactoryWriter = new ModelFactoryWriter(modelFactoryType);
                modelFactoryWriter.Write();
                project.AddGeneratedFile($"{modelFactoryType.Type.Name}.cs", modelFactoryWriter.ToString());
            }

            foreach (var client in library.RestClients)
            {
                var restCodeWriter = new CodeWriter();
                restClientWriter.WriteClient(restCodeWriter, client);

                project.AddGeneratedFile($"{client.Type.Name}.cs", restCodeWriter.ToString());
            }

            foreach (DataPlaneResponseHeaderGroupType responseHeaderModel in library.HeaderModels)
            {
                var headerModelCodeWriter = new CodeWriter();
                headerModelModelWriter.WriteHeaderModel(headerModelCodeWriter, responseHeaderModel);

                project.AddGeneratedFile($"{responseHeaderModel.Type.Name}.cs", headerModelCodeWriter.ToString());
            }

            if (library.ClientOptions is not null)
            {
                var codeWriter = new CodeWriter();
                ClientOptionsWriter.WriteClientOptions(codeWriter, library.ClientOptions);
                project.AddGeneratedFile($"{library.ClientOptions.Type.Name}.cs", codeWriter.ToString());
            }

            foreach (var client in library.Clients)
            {
                var codeWriter = new CodeWriter();
                clientWriter.WriteClient(codeWriter, client, library);
                project.AddGeneratedFile($"{client.Type.Name}.cs", codeWriter.ToString());

                if (client.ClientInterface is not null)
                {
                    var interfaceWriter = new CodeWriter();
                    clientInterfaceWriter.WriteClientInterface(interfaceWriter, client, client.ClientInterface, library);
                    project.AddGeneratedFile($"{client.ClientInterface.Type.Name}.cs", interfaceWriter.ToString());
                }
            }

            if (library.DataPlaneClientFactory is not null)
            {
                var codeWriter = new CodeWriter();
                clientFactoryWriter.WriteClientFactory(codeWriter, library.DataPlaneClientFactory, library);

                var interfaceWriter = new CodeWriter();
                clientFactoryWriter.WriteClientFactoryInterface(interfaceWriter, library.DataPlaneClientFactory, library);

                project.AddGeneratedFile($"{library.DataPlaneClientFactory.Type.Name}.cs", codeWriter.ToString());
                project.AddGeneratedFile($"{library.DataPlaneClientFactory.ClientInterface.Type.Name}.cs", interfaceWriter.ToString());
            }

            foreach (var operation in library.LongRunningOperations)
            {
                var codeWriter = new CodeWriter();
                longRunningOperationWriter.Write(codeWriter, operation);

                project.AddGeneratedFile($"{operation.Type.Name}.cs", codeWriter.ToString());
            }
        }
    }
}
