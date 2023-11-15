// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using AutoRest.CSharp.Common.Input;
using AutoRest.CSharp.Output.Models.Types;

namespace AutoRest.CSharp.DataPlane.Output
{
    internal class DataPlaneClientFactory : TypeProvider
    {
        private readonly BuildContext<DataPlaneOutputLibrary> _context;

        public DataPlaneClientFactory(BuildContext<DataPlaneOutputLibrary> context) :
            this(context, context.Library.ClientShortName, "ClientFactory")
        {
        }

        private DataPlaneClientFactory(BuildContext<DataPlaneOutputLibrary> context, string clientPrefix, string clientSuffix) :
            base(context)
        {
            _context = context;
            DefaultName = clientPrefix + clientSuffix;
            ClientInterface = new DataPlaneClientFactoryInterface($"I{clientPrefix}", context);
        }

        public DataPlaneClientFactoryInterface ClientInterface { get; }

        protected override string DefaultName { get; }

        protected override string DefaultAccessibility { get; } = "public";

        public static DataPlaneClientFactory? TryCreate(IEnumerable<InputClient> clients, BuildContext<DataPlaneOutputLibrary> context)
        {
            if (!Configuration.CompatClientFactory)
                return null;

            return new DataPlaneClientFactory(context);
        }
    }
}
