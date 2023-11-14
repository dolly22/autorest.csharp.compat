// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtDiscriminator
{
    /// <summary>
    /// A class representing a collection of <see cref="DeliveryRuleResource" /> and their operations.
    /// Each <see cref="DeliveryRuleResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="DeliveryRuleCollection" /> instance call the GetDeliveryRules method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class DeliveryRuleCollection : ArmCollection, IEnumerable<DeliveryRuleResource>, IAsyncEnumerable<DeliveryRuleResource>
    {
        private readonly ClientDiagnostics _deliveryRuleClientDiagnostics;
        private readonly DeliveryRulesRestOperations _deliveryRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeliveryRuleCollection"/> class for mocking. </summary>
        protected DeliveryRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeliveryRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DeliveryRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deliveryRuleClientDiagnostics = new ClientDiagnostics("MgmtDiscriminator", DeliveryRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DeliveryRuleResource.ResourceType, out string deliveryRuleApiVersion);
            _deliveryRuleRestClient = new DeliveryRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deliveryRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new CDN endpoint with the specified endpoint name under the specified subscription, resource group and profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/deliveryRules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeliveryRules_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="data"> Endpoint properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DeliveryRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, DeliveryRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deliveryRuleClientDiagnostics.CreateScope("DeliveryRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _deliveryRuleRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtDiscriminatorArmOperation<DeliveryRuleResource>(new DeliveryRuleOperationSource(Client), _deliveryRuleClientDiagnostics, Pipeline, _deliveryRuleRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a new CDN endpoint with the specified endpoint name under the specified subscription, resource group and profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/deliveryRules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeliveryRules_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="data"> Endpoint properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DeliveryRuleResource> CreateOrUpdate(WaitUntil waitUntil, string name, DeliveryRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deliveryRuleClientDiagnostics.CreateScope("DeliveryRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _deliveryRuleRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, name, data, cancellationToken);
                var operation = new MgmtDiscriminatorArmOperation<DeliveryRuleResource>(new DeliveryRuleOperationSource(Client), _deliveryRuleClientDiagnostics, Pipeline, _deliveryRuleRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing CDN endpoint with the specified endpoint name under the specified subscription, resource group and profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/deliveryRules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeliveryRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<DeliveryRuleResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _deliveryRuleClientDiagnostics.CreateScope("DeliveryRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _deliveryRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeliveryRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing CDN endpoint with the specified endpoint name under the specified subscription, resource group and profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/deliveryRules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeliveryRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DeliveryRuleResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _deliveryRuleClientDiagnostics.CreateScope("DeliveryRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _deliveryRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeliveryRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing CDN endpoint with the specified endpoint name under the specified subscription, resource group and profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/deliveryRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeliveryRules_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeliveryRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeliveryRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deliveryRuleRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new DeliveryRuleResource(Client, DeliveryRuleData.DeserializeDeliveryRuleData(e)), _deliveryRuleClientDiagnostics, Pipeline, "DeliveryRuleCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets an existing CDN endpoint with the specified endpoint name under the specified subscription, resource group and profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/deliveryRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeliveryRules_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeliveryRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeliveryRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _deliveryRuleRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new DeliveryRuleResource(Client, DeliveryRuleData.DeserializeDeliveryRuleData(e)), _deliveryRuleClientDiagnostics, Pipeline, "DeliveryRuleCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/deliveryRules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeliveryRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _deliveryRuleClientDiagnostics.CreateScope("DeliveryRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _deliveryRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/deliveryRules/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeliveryRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _deliveryRuleClientDiagnostics.CreateScope("DeliveryRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _deliveryRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DeliveryRuleResource> IEnumerable<DeliveryRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeliveryRuleResource> IAsyncEnumerable<DeliveryRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
