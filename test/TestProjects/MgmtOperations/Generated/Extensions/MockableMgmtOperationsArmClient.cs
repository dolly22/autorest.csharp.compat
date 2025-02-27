// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using MgmtOperations;

namespace MgmtOperations.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableMgmtOperationsArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableMgmtOperationsArmClient"/> class for mocking. </summary>
        protected MockableMgmtOperationsArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMgmtOperationsArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMgmtOperationsArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableMgmtOperationsArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing an <see cref="AvailabilitySetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AvailabilitySetResource.CreateResourceIdentifier" /> to create an <see cref="AvailabilitySetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvailabilitySetResource" /> object. </returns>
        public virtual AvailabilitySetResource GetAvailabilitySetResource(ResourceIdentifier id)
        {
            AvailabilitySetResource.ValidateResourceId(id);
            return new AvailabilitySetResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AvailabilitySetChildResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AvailabilitySetChildResource.CreateResourceIdentifier" /> to create an <see cref="AvailabilitySetChildResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvailabilitySetChildResource" /> object. </returns>
        public virtual AvailabilitySetChildResource GetAvailabilitySetChildResource(ResourceIdentifier id)
        {
            AvailabilitySetChildResource.ValidateResourceId(id);
            return new AvailabilitySetChildResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AvailabilitySetGrandChildResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AvailabilitySetGrandChildResource.CreateResourceIdentifier" /> to create an <see cref="AvailabilitySetGrandChildResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvailabilitySetGrandChildResource" /> object. </returns>
        public virtual AvailabilitySetGrandChildResource GetAvailabilitySetGrandChildResource(ResourceIdentifier id)
        {
            AvailabilitySetGrandChildResource.ValidateResourceId(id);
            return new AvailabilitySetGrandChildResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="UnpatchableResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="UnpatchableResource.CreateResourceIdentifier" /> to create an <see cref="UnpatchableResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="UnpatchableResource" /> object. </returns>
        public virtual UnpatchableResource GetUnpatchableResource(ResourceIdentifier id)
        {
            UnpatchableResource.ValidateResourceId(id);
            return new UnpatchableResource(Client, id);
        }
    }
}
