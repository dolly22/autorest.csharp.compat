// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using MgmtSubscriptionNameParameter;

namespace MgmtSubscriptionNameParameter.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableMgmtSubscriptionNameParameterResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableMgmtSubscriptionNameParameterResourceGroupResource"/> class for mocking. </summary>
        protected MockableMgmtSubscriptionNameParameterResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMgmtSubscriptionNameParameterResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMgmtSubscriptionNameParameterResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of SBSubscriptionResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of SBSubscriptionResources and their operations over a SBSubscriptionResource. </returns>
        public virtual SBSubscriptionCollection GetSBSubscriptions()
        {
            return GetCachedClient(client => new SBSubscriptionCollection(client, Id));
        }

        /// <summary>
        /// Returns a subscription description for the specified topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscriptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SBSubscriptionResource>> GetSBSubscriptionAsync(string subscriptionName, CancellationToken cancellationToken = default)
        {
            return await GetSBSubscriptions().GetAsync(subscriptionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a subscription description for the specified topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Subscriptions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SBSubscriptionResource> GetSBSubscription(string subscriptionName, CancellationToken cancellationToken = default)
        {
            return GetSBSubscriptions().Get(subscriptionName, cancellationToken);
        }
    }
}
