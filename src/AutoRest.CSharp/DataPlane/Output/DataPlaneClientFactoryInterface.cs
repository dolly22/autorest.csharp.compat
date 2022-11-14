// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using AutoRest.CSharp.Output.Models.Types;

namespace AutoRest.CSharp.DataPlane.Output
{
    internal class DataPlaneClientFactoryInterface : TypeProvider
    {
        public DataPlaneClientFactoryInterface(string defaultName, BuildContext<DataPlaneOutputLibrary> context) :
            base(context)
        {
            DefaultName = defaultName;
        }

        protected override string DefaultName { get; }

        protected override string DefaultAccessibility { get; } = "public";
    }
}
