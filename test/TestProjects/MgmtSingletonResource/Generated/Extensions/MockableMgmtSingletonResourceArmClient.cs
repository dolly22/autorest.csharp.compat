// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using MgmtSingletonResource;

namespace MgmtSingletonResource.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableMgmtSingletonResourceArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableMgmtSingletonResourceArmClient"/> class for mocking. </summary>
        protected MockableMgmtSingletonResourceArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMgmtSingletonResourceArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMgmtSingletonResourceArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableMgmtSingletonResourceArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="CarResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CarResource.CreateResourceIdentifier" /> to create a <see cref="CarResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CarResource" /> object. </returns>
        public virtual CarResource GetCarResource(ResourceIdentifier id)
        {
            CarResource.ValidateResourceId(id);
            return new CarResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="IgnitionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IgnitionResource.CreateResourceIdentifier" /> to create an <see cref="IgnitionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="IgnitionResource" /> object. </returns>
        public virtual IgnitionResource GetIgnitionResource(ResourceIdentifier id)
        {
            IgnitionResource.ValidateResourceId(id);
            return new IgnitionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BrakeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BrakeResource.CreateResourceIdentifier" /> to create a <see cref="BrakeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BrakeResource" /> object. </returns>
        public virtual BrakeResource GetBrakeResource(ResourceIdentifier id)
        {
            BrakeResource.ValidateResourceId(id);
            return new BrakeResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SingletonResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SingletonResource.CreateResourceIdentifier" /> to create a <see cref="SingletonResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SingletonResource" /> object. </returns>
        public virtual SingletonResource GetSingletonResource(ResourceIdentifier id)
        {
            SingletonResource.ValidateResourceId(id);
            return new SingletonResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ParentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ParentResource.CreateResourceIdentifier" /> to create a <see cref="ParentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ParentResource" /> object. </returns>
        public virtual ParentResource GetParentResource(ResourceIdentifier id)
        {
            ParentResource.ValidateResourceId(id);
            return new ParentResource(Client, id);
        }
    }
}
