import { createTestHost, TestHost } from "@typespec/compiler/testing";
import { RestTestLibrary } from "@typespec/rest/testing";
import { HttpTestLibrary } from "@typespec/http/testing";
import { VersioningTestLibrary } from "@typespec/versioning/testing";
import { AzureCoreTestLibrary } from "@azure-tools/typespec-azure-core/testing";
import {
    EmitContext,
    isGlobalNamespace,
    Namespace,
    navigateTypesInNamespace,
    Program,
    Type
} from "@typespec/compiler";
import { NetEmitterOptions } from "../../../src/options.js";
import { InputEnumType, InputModelType } from "../../../src/type/inputType.js";
import { getFormattedType, getInputType } from "../../../src/lib/model.js";
import { SdkContext } from "@azure-tools/typespec-client-generator-core";
import { SdkTestLibrary } from "@azure-tools/typespec-client-generator-core/testing";

export async function createEmitterTestHost(): Promise<TestHost> {
    return createTestHost({
        libraries: [
            RestTestLibrary,
            HttpTestLibrary,
            VersioningTestLibrary,
            AzureCoreTestLibrary,
            SdkTestLibrary
        ]
    });
}

export interface TypeSpecCompileOptions {
    IsNamespaceNeeded?: boolean;
    IsAzureCoreNeeded?: boolean;
    IsTCGCNeeded?: boolean;
}

export async function typeSpecCompile(
    content: string,
    host: TestHost,
    options?: TypeSpecCompileOptions
) {
    const needNamespaces = options?.IsNamespaceNeeded ?? true;
    const needAzureCore = options?.IsAzureCoreNeeded ?? false;
    const needTCGC = options?.IsTCGCNeeded ?? false;
    const namespace = `
    @useAuth(ApiKeyAuth<ApiKeyLocation.header, "api-key">)
    @service({
      title: "Azure Csharp emitter Testing",
      version: "2023-01-01-preview",
    })
    ${needAzureCore ? "@useDependency(Azure.Core.Versions.v1_0_Preview_1)" : ""}
    namespace Azure.Csharp.Testing;
    `;
    const fileContent = `
    import "@typespec/rest";
    import "@typespec/http";
    import "@typespec/versioning";
    ${needAzureCore ? 'import "@azure-tools/typespec-azure-core";' : ""}
    ${needTCGC ? 'import "@azure-tools/typespec-client-generator-core";' : ""}
    using TypeSpec.Rest; 
    using TypeSpec.Http;
    using TypeSpec.Versioning;
    ${needAzureCore ? "using Azure.Core;" : ""}
    ${needTCGC ? "using Azure.ClientGenerator.Core;" : ""}
    
    ${needNamespaces ? namespace : ""}
    ${content}
    `;
    host.addTypeSpecFile("main.tsp", fileContent);
    await host.compile("./", {
        warningAsError: false
    });
    return host.program;
}

export function createEmitterContext(
    program: Program
): EmitContext<NetEmitterOptions> {
    return {
        program: program,
        emitterOutputDir: "./",
        options: {
            outputFile: "tspCodeModel.json",
            logFile: "log.json",
            skipSDKGeneration: false,
            "new-project": false,
            "clear-output-folder": false,
            "save-inputs": false,
            "generate-protocol-methods": true,
            "generate-convenience-methods": true,
            "package-name": undefined
        } as NetEmitterOptions
    } as EmitContext<NetEmitterOptions>;
}

/* Navigate all the models in the whole namespace. */
export function navigateModels(
    context: SdkContext,
    namespace: Namespace,
    models: Map<string, InputModelType>,
    enums: Map<string, InputEnumType>
) {
    const computeModel = (x: Type) =>
        getInputType(
            context,
            getFormattedType(context.program, x),
            models,
            enums
        ) as any;
    const skipSubNamespaces = isGlobalNamespace(context.program, namespace);
    navigateTypesInNamespace(
        namespace,
        {
            model: (x) =>
                x.name !== "" && x.kind === "Model" && computeModel(x),
            scalar: computeModel,
            enum: computeModel,
            union: (x) => x.name !== undefined && computeModel(x)
        },
        { skipSubNamespaces }
    );
}
