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

namespace MgmtPartialResource
{
    /// <summary>
    /// A class representing a collection of <see cref="PublicIPAddressResource" /> and their operations.
    /// Each <see cref="PublicIPAddressResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="PublicIPAddressCollection" /> instance call the GetPublicIPAddresses method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class PublicIPAddressCollection : ArmCollection, IEnumerable<PublicIPAddressResource>, IAsyncEnumerable<PublicIPAddressResource>
    {
        private readonly ClientDiagnostics _publicIPAddressClientDiagnostics;
        private readonly PublicIPAddressesRestOperations _publicIPAddressRestClient;

        /// <summary> Initializes a new instance of the <see cref="PublicIPAddressCollection"/> class for mocking. </summary>
        protected PublicIPAddressCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PublicIPAddressCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PublicIPAddressCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _publicIPAddressClientDiagnostics = new ClientDiagnostics("MgmtPartialResource", PublicIPAddressResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PublicIPAddressResource.ResourceType, out string publicIPAddressApiVersion);
            _publicIPAddressRestClient = new PublicIPAddressesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, publicIPAddressApiVersion);
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
        /// Creates or updates a static or dynamic public IP address.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPAddresses/{publicIpAddressName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicIPAddresses_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="publicIpAddressName"> The name of the public IP address. </param>
        /// <param name="data"> Parameters supplied to the create or update public IP address operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIpAddressName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpAddressName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PublicIPAddressResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string publicIpAddressName, PublicIPAddressData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIpAddressName, nameof(publicIpAddressName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _publicIPAddressClientDiagnostics.CreateScope("PublicIPAddressCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _publicIPAddressRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, publicIpAddressName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtPartialResourceArmOperation<PublicIPAddressResource>(new PublicIPAddressOperationSource(Client), _publicIPAddressClientDiagnostics, Pipeline, _publicIPAddressRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, publicIpAddressName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a static or dynamic public IP address.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPAddresses/{publicIpAddressName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicIPAddresses_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="publicIpAddressName"> The name of the public IP address. </param>
        /// <param name="data"> Parameters supplied to the create or update public IP address operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIpAddressName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpAddressName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PublicIPAddressResource> CreateOrUpdate(WaitUntil waitUntil, string publicIpAddressName, PublicIPAddressData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIpAddressName, nameof(publicIpAddressName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _publicIPAddressClientDiagnostics.CreateScope("PublicIPAddressCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _publicIPAddressRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, publicIpAddressName, data, cancellationToken);
                var operation = new MgmtPartialResourceArmOperation<PublicIPAddressResource>(new PublicIPAddressOperationSource(Client), _publicIPAddressClientDiagnostics, Pipeline, _publicIPAddressRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, publicIpAddressName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified public IP address in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPAddresses/{publicIpAddressName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicIPAddresses_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicIpAddressName"> The name of the public IP address. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIpAddressName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpAddressName"/> is null. </exception>
        public virtual async Task<Response<PublicIPAddressResource>> GetAsync(string publicIpAddressName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIpAddressName, nameof(publicIpAddressName));

            using var scope = _publicIPAddressClientDiagnostics.CreateScope("PublicIPAddressCollection.Get");
            scope.Start();
            try
            {
                var response = await _publicIPAddressRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, publicIpAddressName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PublicIPAddressResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified public IP address in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPAddresses/{publicIpAddressName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicIPAddresses_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicIpAddressName"> The name of the public IP address. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIpAddressName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpAddressName"/> is null. </exception>
        public virtual Response<PublicIPAddressResource> Get(string publicIpAddressName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIpAddressName, nameof(publicIpAddressName));

            using var scope = _publicIPAddressClientDiagnostics.CreateScope("PublicIPAddressCollection.Get");
            scope.Start();
            try
            {
                var response = _publicIPAddressRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, publicIpAddressName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PublicIPAddressResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all public IP addresses in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPAddresses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicIPAddresses_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PublicIPAddressResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PublicIPAddressResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _publicIPAddressRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _publicIPAddressRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PublicIPAddressResource(Client, PublicIPAddressData.DeserializePublicIPAddressData(e)), _publicIPAddressClientDiagnostics, Pipeline, "PublicIPAddressCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all public IP addresses in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPAddresses</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicIPAddresses_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PublicIPAddressResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PublicIPAddressResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _publicIPAddressRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _publicIPAddressRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PublicIPAddressResource(Client, PublicIPAddressData.DeserializePublicIPAddressData(e)), _publicIPAddressClientDiagnostics, Pipeline, "PublicIPAddressCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPAddresses/{publicIpAddressName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicIPAddresses_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicIpAddressName"> The name of the public IP address. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIpAddressName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpAddressName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string publicIpAddressName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIpAddressName, nameof(publicIpAddressName));

            using var scope = _publicIPAddressClientDiagnostics.CreateScope("PublicIPAddressCollection.Exists");
            scope.Start();
            try
            {
                var response = await _publicIPAddressRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, publicIpAddressName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPAddresses/{publicIpAddressName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicIPAddresses_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicIpAddressName"> The name of the public IP address. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIpAddressName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpAddressName"/> is null. </exception>
        public virtual Response<bool> Exists(string publicIpAddressName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIpAddressName, nameof(publicIpAddressName));

            using var scope = _publicIPAddressClientDiagnostics.CreateScope("PublicIPAddressCollection.Exists");
            scope.Start();
            try
            {
                var response = _publicIPAddressRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, publicIpAddressName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPAddresses/{publicIpAddressName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicIPAddresses_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicIpAddressName"> The name of the public IP address. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIpAddressName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpAddressName"/> is null. </exception>
        public virtual async Task<NullableResponse<PublicIPAddressResource>> GetIfExistsAsync(string publicIpAddressName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIpAddressName, nameof(publicIpAddressName));

            using var scope = _publicIPAddressClientDiagnostics.CreateScope("PublicIPAddressCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _publicIPAddressRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, publicIpAddressName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PublicIPAddressResource>(response.GetRawResponse());
                return Response.FromValue(new PublicIPAddressResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPAddresses/{publicIpAddressName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicIPAddresses_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicIpAddressName"> The name of the public IP address. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publicIpAddressName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpAddressName"/> is null. </exception>
        public virtual NullableResponse<PublicIPAddressResource> GetIfExists(string publicIpAddressName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(publicIpAddressName, nameof(publicIpAddressName));

            using var scope = _publicIPAddressClientDiagnostics.CreateScope("PublicIPAddressCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _publicIPAddressRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, publicIpAddressName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PublicIPAddressResource>(response.GetRawResponse());
                return Response.FromValue(new PublicIPAddressResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PublicIPAddressResource> IEnumerable<PublicIPAddressResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PublicIPAddressResource> IAsyncEnumerable<PublicIPAddressResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
