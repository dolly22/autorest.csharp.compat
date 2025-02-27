// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using MgmtCustomizations;

namespace MgmtCustomizations.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableMgmtCustomizationsArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableMgmtCustomizationsArmClient"/> class for mocking. </summary>
        protected MockableMgmtCustomizationsArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMgmtCustomizationsArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMgmtCustomizationsArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableMgmtCustomizationsArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="PetStoreResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PetStoreResource.CreateResourceIdentifier" /> to create a <see cref="PetStoreResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PetStoreResource" /> object. </returns>
        public virtual PetStoreResource GetPetStoreResource(ResourceIdentifier id)
        {
            PetStoreResource.ValidateResourceId(id);
            return new PetStoreResource(Client, id);
        }
    }
}
