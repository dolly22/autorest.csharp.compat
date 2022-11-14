// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using AutoRest.CSharp.Output.Models.Types;

namespace AutoRest.CSharp.Output.Models
{
    internal class DataPlaneClientInterface : TypeProvider
    {
        public DataPlaneClientInterface(string defaultName, BuildContext<DataPlaneOutputLibrary> context) :
            base(context)
        {
            DefaultName = defaultName;
        }

        protected override string DefaultName { get; }

        protected override string DefaultAccessibility { get; } = "public";
    }
}
