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
using Azure.ResourceManager.Resources;
using MgmtCollectionParent.Mocking;

namespace MgmtCollectionParent
{
    /// <summary> A class to add extension methods to MgmtCollectionParent. </summary>
    public static partial class MgmtCollectionParentExtensions
    {
        private static MockableMgmtCollectionParentArmClient GetMockableMgmtCollectionParentArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableMgmtCollectionParentArmClient(client0));
        }

        private static MockableMgmtCollectionParentResourceGroupResource GetMockableMgmtCollectionParentResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableMgmtCollectionParentResourceGroupResource(client, resource.Id));
        }

        private static MockableMgmtCollectionParentSubscriptionResource GetMockableMgmtCollectionParentSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableMgmtCollectionParentSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing an <see cref="OrderResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="OrderResource.CreateResourceIdentifier" /> to create an <see cref="OrderResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtCollectionParentArmClient.GetOrderResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OrderResource" /> object. </returns>
        public static OrderResource GetOrderResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableMgmtCollectionParentArmClient(client).GetOrderResource(id);
        }

        /// <summary>
        /// Gets a collection of OrderResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtCollectionParentResourceGroupResource.GetOrderResources()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of OrderResources and their operations over a OrderResource. </returns>
        public static OrderResourceCollection GetOrderResources(this ResourceGroupResource resourceGroupResource)
        {
            return GetMockableMgmtCollectionParentResourceGroupResource(resourceGroupResource).GetOrderResources();
        }

        /// <summary>
        /// Gets an order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetOrderByName</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtCollectionParentResourceGroupResource.GetOrderResourceAsync(string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="orderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<OrderResource>> GetOrderResourceAsync(this ResourceGroupResource resourceGroupResource, string location, string orderName, CancellationToken cancellationToken = default)
        {
            return await GetMockableMgmtCollectionParentResourceGroupResource(resourceGroupResource).GetOrderResourceAsync(location, orderName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetOrderByName</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtCollectionParentResourceGroupResource.GetOrderResource(string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="orderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<OrderResource> GetOrderResource(this ResourceGroupResource resourceGroupResource, string location, string orderName, CancellationToken cancellationToken = default)
        {
            return GetMockableMgmtCollectionParentResourceGroupResource(resourceGroupResource).GetOrderResource(location, orderName, cancellationToken);
        }

        /// <summary>
        /// Lists order at subscription level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListOrderAtSubscriptionLevel</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtCollectionParentSubscriptionResource.GetOrderResources(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OrderResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<OrderResource> GetOrderResourcesAsync(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetMockableMgmtCollectionParentSubscriptionResource(subscriptionResource).GetOrderResourcesAsync(skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists order at subscription level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ListOrderAtSubscriptionLevel</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableMgmtCollectionParentSubscriptionResource.GetOrderResources(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OrderResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<OrderResource> GetOrderResources(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetMockableMgmtCollectionParentSubscriptionResource(subscriptionResource).GetOrderResources(skipToken, cancellationToken);
        }
    }
}
