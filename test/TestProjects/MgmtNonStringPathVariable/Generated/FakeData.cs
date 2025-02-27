// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using MgmtNonStringPathVariable.Models;

namespace MgmtNonStringPathVariable
{
    /// <summary>
    /// A class representing the Fake data model.
    /// Specifies information about the fake that the virtual machine should be assigned to. Virtual machines specified in the same fake are allocated to different nodes to maximize availability. For more information about fakes, see [Manage the availability of virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-manage-availability?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json). &lt;br&gt;&lt;br&gt; For more information on Azure planned maintenance, see [Planned maintenance for virtual machines in Azure](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-planned-maintenance?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) &lt;br&gt;&lt;br&gt; Currently, a VM can only be added to fake at creation time. An existing VM cannot be added to an fake.
    /// </summary>
    public partial class FakeData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of FakeData. </summary>
        /// <param name="location"> The location. </param>
        public FakeData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of FakeData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The instance view of a resource. </param>
        internal FakeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, FakeProperties properties) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
        }

        /// <summary> The instance view of a resource. </summary>
        public FakeProperties Properties { get; set; }
    }
}
