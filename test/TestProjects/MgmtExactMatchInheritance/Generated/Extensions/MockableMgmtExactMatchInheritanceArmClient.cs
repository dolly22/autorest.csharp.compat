// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using MgmtExactMatchInheritance;

namespace MgmtExactMatchInheritance.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableMgmtExactMatchInheritanceArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableMgmtExactMatchInheritanceArmClient"/> class for mocking. </summary>
        protected MockableMgmtExactMatchInheritanceArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMgmtExactMatchInheritanceArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMgmtExactMatchInheritanceArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableMgmtExactMatchInheritanceArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing an <see cref="ExactMatchModel1Resource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ExactMatchModel1Resource.CreateResourceIdentifier" /> to create an <see cref="ExactMatchModel1Resource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ExactMatchModel1Resource" /> object. </returns>
        public virtual ExactMatchModel1Resource GetExactMatchModel1Resource(ResourceIdentifier id)
        {
            ExactMatchModel1Resource.ValidateResourceId(id);
            return new ExactMatchModel1Resource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="ExactMatchModel5Resource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ExactMatchModel5Resource.CreateResourceIdentifier" /> to create an <see cref="ExactMatchModel5Resource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ExactMatchModel5Resource" /> object. </returns>
        public virtual ExactMatchModel5Resource GetExactMatchModel5Resource(ResourceIdentifier id)
        {
            ExactMatchModel5Resource.ValidateResourceId(id);
            return new ExactMatchModel5Resource(Client, id);
        }
    }
}
