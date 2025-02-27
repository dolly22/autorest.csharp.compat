// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace MgmtOmitOperationGroups.Models
{
    /// <summary> The ModelQ. </summary>
    public partial class ModelQ : ResourceData
    {
        /// <summary> Initializes a new instance of ModelQ. </summary>
        public ModelQ()
        {
        }

        /// <summary> Initializes a new instance of ModelQ. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="m"></param>
        internal ModelQ(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string m) : base(id, name, resourceType, systemData)
        {
            M = m;
        }

        /// <summary> Gets or sets the m. </summary>
        public string M { get; set; }
    }
}
