﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using AutoRest.CSharp.AutoRest.Communication;

namespace AutoRest.CSharp.Input
{
    internal static class Configuration
    {
        internal static readonly string ProjectFolderDefault = "../";

        public static class Options
        {
            public const string OutputFolder = "output-folder";
            public const string Namespace = "namespace";
            public const string LibraryName = "library-name";
            public const string SharedSourceFolders = "shared-source-folders";
            public const string SaveInputs = "save-inputs";
            public const string AzureArm = "azure-arm";
            public const string PublicClients = "public-clients";
            public const string ModelNamespace = "model-namespace";
            public const string HeadAsBoolean = "head-as-boolean";
            public const string SkipCSProjPackageReference = "skip-csproj-packagereference";
            public const string Generation1ConvenienceClient = "generation1-convenience-client";
            public const string SingleTopLevelClient = "single-top-level-client";
            public const string AttachDebuggerFormat = "{0}.attach";
            public const string ProjectFolder = "project-folder";
            public const string ProtocolMethodList = "protocol-method-list";
            public const string SkipSerializationFormatXml = "skip-serialization-format-xml";
            public const string DisablePaginationTopRenaming = "disable-pagination-top-renaming";
            public const string SuppressAbstractBaseClasses = "suppress-abstract-base-class";

            // options added for compatibility with v2 generators
            public const string CompatClientInterfaces = "compat-client-interfaces";
            public const string CompatErrorResponses = "compat-error-responses";
            public const string CompatAnonymousClientCtor = "compat-anonymous-client-ctor";
        }

        public static void Initialize(
            string outputFolder,
            string? ns,
            string? name,
            string[] sharedSourceFolders,
            bool saveInputs,
            bool azureArm,
            bool publicClients,
            bool modelNamespace,
            bool headAsBoolean,
            bool skipCSProjPackageReference,
            bool generation1ConvenienceClient,
            bool singleTopLevelClient,
            bool skipSerializationFormatXml,
            bool disablePaginationTopRenaming,
            string? projectFolder,
            string[] protocolMethodList,
            IReadOnlyList<string> suppressAbstractBaseClasses,
            bool compatClientInterfaces,
            bool compatErrorResponses,
            bool compatAnonymousClientCtor,
            MgmtConfiguration mgmtConfiguration)
        {
            _outputFolder = outputFolder;
            Namespace = ns;
            LibraryName = name;
            _sharedSourceFolders = sharedSourceFolders;
            SaveInputs = saveInputs;
            AzureArm = azureArm;
            PublicClients = publicClients || AzureArm;
            ModelNamespace = azureArm || modelNamespace;
            HeadAsBoolean = headAsBoolean;
            SkipCSProjPackageReference = skipCSProjPackageReference;
            Generation1ConvenienceClient = generation1ConvenienceClient;
            SingleTopLevelClient = singleTopLevelClient;

            // compat options
            CompatClientInterfaces = compatClientInterfaces;
            CompatErrorResponses = compatErrorResponses;
            CompatAnonymousClientCtor = compatAnonymousClientCtor;

            projectFolder ??= ProjectFolderDefault;
            if (Path.IsPathRooted(projectFolder))
            {
                _absoluteProjectFolder = projectFolder;
                projectFolder = Path.GetRelativePath(outputFolder, projectFolder);
            }
            else
            {
                _absoluteProjectFolder = Path.GetFullPath(Path.Combine(outputFolder, projectFolder));
            }
            _relativeProjectFolder = projectFolder;
            _protocolMethodList = protocolMethodList;
            SkipSerializationFormatXml = skipSerializationFormatXml;
            DisablePaginationTopRenaming = disablePaginationTopRenaming;
            _mgmtConfiguration = mgmtConfiguration;
            _suppressAbstractBaseClasses = suppressAbstractBaseClasses;
        }

        private static string? _outputFolder;
        public static string OutputFolder => _outputFolder ?? throw new InvalidOperationException("Configuration has not been initialized");
        public static string? Namespace { get; private set; }
        public static string? LibraryName { get; private set; }

        private static string[]? _sharedSourceFolders;
        public static string[] SharedSourceFolders => _sharedSourceFolders ?? throw new InvalidOperationException("Configuration has not been initialized");
        public static bool SaveInputs { get; private set; }
        public static bool AzureArm { get; private set; }
        public static bool PublicClients { get; private set; }
        public static bool ModelNamespace { get; private set; }
        public static bool HeadAsBoolean { get; private set; }
        public static bool SkipCSProjPackageReference { get; private set; }
        public static bool Generation1ConvenienceClient { get; private set; }
        public static bool SingleTopLevelClient { get; private set; }
        public static bool SkipSerializationFormatXml { get; private set; }
        public static bool DisablePaginationTopRenaming { get; private set; }
        public static bool CompatClientInterfaces { get; private set; }
        public static bool CompatErrorResponses { get; private set; }
        public static bool CompatAnonymousClientCtor { get; private set; }

        private static IReadOnlyList<string>? _suppressAbstractBaseClasses;
        public static IReadOnlyList<string> SuppressAbstractBaseClasses => _suppressAbstractBaseClasses ?? throw new InvalidOperationException("Configuration has not been initialized");

        private static string[]? _protocolMethodList;
        public static string[] ProtocolMethodList => _protocolMethodList ?? throw new InvalidOperationException("Configuration has not been initialized");

        private static MgmtConfiguration? _mgmtConfiguration;
        public static MgmtConfiguration MgmtConfiguration => _mgmtConfiguration ?? throw new InvalidOperationException("Configuration has not been initialized");

        private static string? _relativeProjectFolder;
        public static string RelativeProjectFolder => _relativeProjectFolder ?? throw new InvalidOperationException("Configuration has not been initialized");
        private static string? _absoluteProjectFolder;
        public static string AbsoluteProjectFolder => _absoluteProjectFolder ?? throw new InvalidOperationException("Configuration has not been initialized");

        public static void Initialize(IPluginCommunication autoRest)
        {
            Initialize(
                outputFolder: TrimFileSuffix(GetRequiredOption<string>(autoRest, Options.OutputFolder)),
                ns: autoRest.GetValue<string?>(Options.Namespace).GetAwaiter().GetResult(),
                name: autoRest.GetValue<string?>(Options.LibraryName).GetAwaiter().GetResult(),
                sharedSourceFolders: GetRequiredOption<string[]>(autoRest, Options.SharedSourceFolders).Select(TrimFileSuffix).ToArray(),
                saveInputs: GetOptionValue(autoRest, Options.SaveInputs),
                azureArm: GetOptionValue(autoRest, Options.AzureArm),
                publicClients: GetOptionValue(autoRest, Options.PublicClients),
                modelNamespace: GetOptionValue(autoRest, Options.ModelNamespace),
                headAsBoolean: GetOptionValue(autoRest, Options.HeadAsBoolean),
                skipCSProjPackageReference: GetOptionValue(autoRest, Options.SkipCSProjPackageReference),
                generation1ConvenienceClient: GetOptionValue(autoRest, Options.Generation1ConvenienceClient),
                singleTopLevelClient: GetOptionValue(autoRest, Options.SingleTopLevelClient),
                skipSerializationFormatXml: GetOptionValue(autoRest, Options.SkipSerializationFormatXml),
                disablePaginationTopRenaming: GetOptionValue(autoRest, Options.DisablePaginationTopRenaming),
                projectFolder: autoRest.GetValue<string?>(Options.ProjectFolder).GetAwaiter().GetResult(),
                protocolMethodList: autoRest.GetValue<string[]?>(Options.ProtocolMethodList).GetAwaiter().GetResult() ?? Array.Empty<string>(),
                suppressAbstractBaseClasses: autoRest.GetValue<string[]?>(Options.SuppressAbstractBaseClasses).GetAwaiter().GetResult() ?? Array.Empty<string>(),
                compatClientInterfaces: GetOptionValue(autoRest, Options.CompatClientInterfaces),
                compatErrorResponses: GetOptionValue(autoRest, Options.CompatErrorResponses),
                compatAnonymousClientCtor: GetOptionValue(autoRest, Options.CompatAnonymousClientCtor),
                mgmtConfiguration: MgmtConfiguration.GetConfiguration(autoRest)
            );
        }

        private static bool GetOptionValue(IPluginCommunication autoRest, string option)
        {
            return autoRest.GetValue<bool?>(option).GetAwaiter().GetResult() ?? GetDefaultOptionValue(option)!.Value;
        }

        public static bool? GetDefaultOptionValue(string option)
        {
            switch (option)
            {
                case Options.SaveInputs:
                    return false;
                case Options.AzureArm:
                    return false;
                case Options.PublicClients:
                    return false;
                case Options.ModelNamespace:
                    return true;
                case Options.HeadAsBoolean:
                    return false;
                case Options.SkipCSProjPackageReference:
                    return false;
                case Options.Generation1ConvenienceClient:
                    return false;
                case Options.SingleTopLevelClient:
                    return false;
                case Options.SkipSerializationFormatXml:
                    return false;
                case Options.DisablePaginationTopRenaming:
                    return false;
                case Options.CompatClientInterfaces:
                    return false;
                case Options.CompatErrorResponses:
                    return false;
                case Options.CompatAnonymousClientCtor:
                    return false;
                default:
                    return null;
            }
        }

        private static T GetRequiredOption<T>(IPluginCommunication autoRest, string name)
        {
            return autoRest.GetValue<T>(name).GetAwaiter().GetResult() ?? throw new InvalidOperationException($"{name} configuration parameter is required");
        }

        private static string TrimFileSuffix(string path)
        {
            if (Uri.IsWellFormedUriString(path, UriKind.Absolute))
            {
                path = new Uri(path).LocalPath;
            }

            return path;
        }
        public static IReadOnlyList<string> DeserializeArray(JsonElement jsonElement)
            => jsonElement.ValueKind != JsonValueKind.Array ? Array.Empty<string>() : jsonElement.EnumerateArray().Select(t => t.ToString()).ToArray();
    }
}
