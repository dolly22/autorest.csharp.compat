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

namespace MgmtListMethods
{
    /// <summary>
    /// A class representing a collection of <see cref="ResGrpParentWithAncestorWithLocResource" /> and their operations.
    /// Each <see cref="ResGrpParentWithAncestorWithLocResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ResGrpParentWithAncestorWithLocCollection" /> instance call the GetResGrpParentWithAncestorWithLocs method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ResGrpParentWithAncestorWithLocCollection : ArmCollection, IEnumerable<ResGrpParentWithAncestorWithLocResource>, IAsyncEnumerable<ResGrpParentWithAncestorWithLocResource>
    {
        private readonly ClientDiagnostics _resGrpParentWithAncestorWithLocClientDiagnostics;
        private readonly ResGrpParentWithAncestorWithLocsRestOperations _resGrpParentWithAncestorWithLocRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResGrpParentWithAncestorWithLocCollection"/> class for mocking. </summary>
        protected ResGrpParentWithAncestorWithLocCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResGrpParentWithAncestorWithLocCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ResGrpParentWithAncestorWithLocCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resGrpParentWithAncestorWithLocClientDiagnostics = new ClientDiagnostics("MgmtListMethods", ResGrpParentWithAncestorWithLocResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResGrpParentWithAncestorWithLocResource.ResourceType, out string resGrpParentWithAncestorWithLocApiVersion);
            _resGrpParentWithAncestorWithLocRestClient = new ResGrpParentWithAncestorWithLocsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resGrpParentWithAncestorWithLocApiVersion);
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
        /// Create or update.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithLocs/{resGrpParentWithAncestorWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResGrpParentWithAncestorWithLocs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resGrpParentWithAncestorWithLocName"> Name. </param>
        /// <param name="data"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentWithAncestorWithLocName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ResGrpParentWithAncestorWithLocResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string resGrpParentWithAncestorWithLocName, ResGrpParentWithAncestorWithLocData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentWithAncestorWithLocName, nameof(resGrpParentWithAncestorWithLocName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _resGrpParentWithAncestorWithLocClientDiagnostics.CreateScope("ResGrpParentWithAncestorWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _resGrpParentWithAncestorWithLocRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, resGrpParentWithAncestorWithLocName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtListMethodsArmOperation<ResGrpParentWithAncestorWithLocResource>(Response.FromValue(new ResGrpParentWithAncestorWithLocResource(Client, response), response.GetRawResponse()));
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
        /// Create or update.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithLocs/{resGrpParentWithAncestorWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResGrpParentWithAncestorWithLocs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resGrpParentWithAncestorWithLocName"> Name. </param>
        /// <param name="data"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentWithAncestorWithLocName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ResGrpParentWithAncestorWithLocResource> CreateOrUpdate(WaitUntil waitUntil, string resGrpParentWithAncestorWithLocName, ResGrpParentWithAncestorWithLocData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentWithAncestorWithLocName, nameof(resGrpParentWithAncestorWithLocName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _resGrpParentWithAncestorWithLocClientDiagnostics.CreateScope("ResGrpParentWithAncestorWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _resGrpParentWithAncestorWithLocRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, resGrpParentWithAncestorWithLocName, data, cancellationToken);
                var operation = new MgmtListMethodsArmOperation<ResGrpParentWithAncestorWithLocResource>(Response.FromValue(new ResGrpParentWithAncestorWithLocResource(Client, response), response.GetRawResponse()));
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
        /// Retrieves information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithLocs/{resGrpParentWithAncestorWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResGrpParentWithAncestorWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resGrpParentWithAncestorWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is null. </exception>
        public virtual async Task<Response<ResGrpParentWithAncestorWithLocResource>> GetAsync(string resGrpParentWithAncestorWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentWithAncestorWithLocName, nameof(resGrpParentWithAncestorWithLocName));

            using var scope = _resGrpParentWithAncestorWithLocClientDiagnostics.CreateScope("ResGrpParentWithAncestorWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = await _resGrpParentWithAncestorWithLocRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resGrpParentWithAncestorWithLocName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResGrpParentWithAncestorWithLocResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithLocs/{resGrpParentWithAncestorWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResGrpParentWithAncestorWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resGrpParentWithAncestorWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is null. </exception>
        public virtual Response<ResGrpParentWithAncestorWithLocResource> Get(string resGrpParentWithAncestorWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentWithAncestorWithLocName, nameof(resGrpParentWithAncestorWithLocName));

            using var scope = _resGrpParentWithAncestorWithLocClientDiagnostics.CreateScope("ResGrpParentWithAncestorWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = _resGrpParentWithAncestorWithLocRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resGrpParentWithAncestorWithLocName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResGrpParentWithAncestorWithLocResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithLocs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResGrpParentWithAncestorWithLocs_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResGrpParentWithAncestorWithLocResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResGrpParentWithAncestorWithLocResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resGrpParentWithAncestorWithLocRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resGrpParentWithAncestorWithLocRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ResGrpParentWithAncestorWithLocResource(Client, ResGrpParentWithAncestorWithLocData.DeserializeResGrpParentWithAncestorWithLocData(e)), _resGrpParentWithAncestorWithLocClientDiagnostics, Pipeline, "ResGrpParentWithAncestorWithLocCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithLocs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResGrpParentWithAncestorWithLocs_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResGrpParentWithAncestorWithLocResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResGrpParentWithAncestorWithLocResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resGrpParentWithAncestorWithLocRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resGrpParentWithAncestorWithLocRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ResGrpParentWithAncestorWithLocResource(Client, ResGrpParentWithAncestorWithLocData.DeserializeResGrpParentWithAncestorWithLocData(e)), _resGrpParentWithAncestorWithLocClientDiagnostics, Pipeline, "ResGrpParentWithAncestorWithLocCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithLocs/{resGrpParentWithAncestorWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResGrpParentWithAncestorWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resGrpParentWithAncestorWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resGrpParentWithAncestorWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentWithAncestorWithLocName, nameof(resGrpParentWithAncestorWithLocName));

            using var scope = _resGrpParentWithAncestorWithLocClientDiagnostics.CreateScope("ResGrpParentWithAncestorWithLocCollection.Exists");
            scope.Start();
            try
            {
                var response = await _resGrpParentWithAncestorWithLocRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resGrpParentWithAncestorWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithLocs/{resGrpParentWithAncestorWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResGrpParentWithAncestorWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resGrpParentWithAncestorWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is null. </exception>
        public virtual Response<bool> Exists(string resGrpParentWithAncestorWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentWithAncestorWithLocName, nameof(resGrpParentWithAncestorWithLocName));

            using var scope = _resGrpParentWithAncestorWithLocClientDiagnostics.CreateScope("ResGrpParentWithAncestorWithLocCollection.Exists");
            scope.Start();
            try
            {
                var response = _resGrpParentWithAncestorWithLocRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resGrpParentWithAncestorWithLocName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithLocs/{resGrpParentWithAncestorWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResGrpParentWithAncestorWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resGrpParentWithAncestorWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is null. </exception>
        public virtual async Task<NullableResponse<ResGrpParentWithAncestorWithLocResource>> GetIfExistsAsync(string resGrpParentWithAncestorWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentWithAncestorWithLocName, nameof(resGrpParentWithAncestorWithLocName));

            using var scope = _resGrpParentWithAncestorWithLocClientDiagnostics.CreateScope("ResGrpParentWithAncestorWithLocCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _resGrpParentWithAncestorWithLocRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resGrpParentWithAncestorWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ResGrpParentWithAncestorWithLocResource>(response.GetRawResponse());
                return Response.FromValue(new ResGrpParentWithAncestorWithLocResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithLocs/{resGrpParentWithAncestorWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResGrpParentWithAncestorWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resGrpParentWithAncestorWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentWithAncestorWithLocName"/> is null. </exception>
        public virtual NullableResponse<ResGrpParentWithAncestorWithLocResource> GetIfExists(string resGrpParentWithAncestorWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentWithAncestorWithLocName, nameof(resGrpParentWithAncestorWithLocName));

            using var scope = _resGrpParentWithAncestorWithLocClientDiagnostics.CreateScope("ResGrpParentWithAncestorWithLocCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _resGrpParentWithAncestorWithLocRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resGrpParentWithAncestorWithLocName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ResGrpParentWithAncestorWithLocResource>(response.GetRawResponse());
                return Response.FromValue(new ResGrpParentWithAncestorWithLocResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResGrpParentWithAncestorWithLocResource> IEnumerable<ResGrpParentWithAncestorWithLocResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResGrpParentWithAncestorWithLocResource> IAsyncEnumerable<ResGrpParentWithAncestorWithLocResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
