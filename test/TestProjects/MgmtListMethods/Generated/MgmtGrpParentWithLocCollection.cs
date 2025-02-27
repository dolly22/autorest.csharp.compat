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
using Azure.ResourceManager.ManagementGroups;

namespace MgmtListMethods
{
    /// <summary>
    /// A class representing a collection of <see cref="MgmtGrpParentWithLocResource" /> and their operations.
    /// Each <see cref="MgmtGrpParentWithLocResource" /> in the collection will belong to the same instance of <see cref="ManagementGroupResource" />.
    /// To get a <see cref="MgmtGrpParentWithLocCollection" /> instance call the GetMgmtGrpParentWithLocs method from an instance of <see cref="ManagementGroupResource" />.
    /// </summary>
    public partial class MgmtGrpParentWithLocCollection : ArmCollection, IEnumerable<MgmtGrpParentWithLocResource>, IAsyncEnumerable<MgmtGrpParentWithLocResource>
    {
        private readonly ClientDiagnostics _mgmtGrpParentWithLocClientDiagnostics;
        private readonly MgmtGrpParentWithLocsRestOperations _mgmtGrpParentWithLocRestClient;

        /// <summary> Initializes a new instance of the <see cref="MgmtGrpParentWithLocCollection"/> class for mocking. </summary>
        protected MgmtGrpParentWithLocCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MgmtGrpParentWithLocCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MgmtGrpParentWithLocCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mgmtGrpParentWithLocClientDiagnostics = new ClientDiagnostics("MgmtListMethods", MgmtGrpParentWithLocResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MgmtGrpParentWithLocResource.ResourceType, out string mgmtGrpParentWithLocApiVersion);
            _mgmtGrpParentWithLocRestClient = new MgmtGrpParentWithLocsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mgmtGrpParentWithLocApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagementGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagementGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithLocs/{mgmtGrpParentWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MgmtGrpParentWithLocs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="mgmtGrpParentWithLocName"> Name. </param>
        /// <param name="data"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mgmtGrpParentWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithLocName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MgmtGrpParentWithLocResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string mgmtGrpParentWithLocName, MgmtGrpParentWithLocData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mgmtGrpParentWithLocName, nameof(mgmtGrpParentWithLocName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mgmtGrpParentWithLocClientDiagnostics.CreateScope("MgmtGrpParentWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mgmtGrpParentWithLocRestClient.CreateOrUpdateAsync(Id.Name, mgmtGrpParentWithLocName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtListMethodsArmOperation<MgmtGrpParentWithLocResource>(Response.FromValue(new MgmtGrpParentWithLocResource(Client, response), response.GetRawResponse()));
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
        /// <description>/providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithLocs/{mgmtGrpParentWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MgmtGrpParentWithLocs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="mgmtGrpParentWithLocName"> Name. </param>
        /// <param name="data"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mgmtGrpParentWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithLocName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MgmtGrpParentWithLocResource> CreateOrUpdate(WaitUntil waitUntil, string mgmtGrpParentWithLocName, MgmtGrpParentWithLocData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mgmtGrpParentWithLocName, nameof(mgmtGrpParentWithLocName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mgmtGrpParentWithLocClientDiagnostics.CreateScope("MgmtGrpParentWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mgmtGrpParentWithLocRestClient.CreateOrUpdate(Id.Name, mgmtGrpParentWithLocName, data, cancellationToken);
                var operation = new MgmtListMethodsArmOperation<MgmtGrpParentWithLocResource>(Response.FromValue(new MgmtGrpParentWithLocResource(Client, response), response.GetRawResponse()));
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
        /// <description>/providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithLocs/{mgmtGrpParentWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MgmtGrpParentWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mgmtGrpParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mgmtGrpParentWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithLocName"/> is null. </exception>
        public virtual async Task<Response<MgmtGrpParentWithLocResource>> GetAsync(string mgmtGrpParentWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mgmtGrpParentWithLocName, nameof(mgmtGrpParentWithLocName));

            using var scope = _mgmtGrpParentWithLocClientDiagnostics.CreateScope("MgmtGrpParentWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = await _mgmtGrpParentWithLocRestClient.GetAsync(Id.Name, mgmtGrpParentWithLocName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MgmtGrpParentWithLocResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithLocs/{mgmtGrpParentWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MgmtGrpParentWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mgmtGrpParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mgmtGrpParentWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithLocName"/> is null. </exception>
        public virtual Response<MgmtGrpParentWithLocResource> Get(string mgmtGrpParentWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mgmtGrpParentWithLocName, nameof(mgmtGrpParentWithLocName));

            using var scope = _mgmtGrpParentWithLocClientDiagnostics.CreateScope("MgmtGrpParentWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = _mgmtGrpParentWithLocRestClient.Get(Id.Name, mgmtGrpParentWithLocName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MgmtGrpParentWithLocResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithLocs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MgmtGrpParentWithLocs_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MgmtGrpParentWithLocResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MgmtGrpParentWithLocResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mgmtGrpParentWithLocRestClient.CreateListRequest(Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mgmtGrpParentWithLocRestClient.CreateListNextPageRequest(nextLink, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MgmtGrpParentWithLocResource(Client, MgmtGrpParentWithLocData.DeserializeMgmtGrpParentWithLocData(e)), _mgmtGrpParentWithLocClientDiagnostics, Pipeline, "MgmtGrpParentWithLocCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithLocs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MgmtGrpParentWithLocs_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MgmtGrpParentWithLocResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MgmtGrpParentWithLocResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mgmtGrpParentWithLocRestClient.CreateListRequest(Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mgmtGrpParentWithLocRestClient.CreateListNextPageRequest(nextLink, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MgmtGrpParentWithLocResource(Client, MgmtGrpParentWithLocData.DeserializeMgmtGrpParentWithLocData(e)), _mgmtGrpParentWithLocClientDiagnostics, Pipeline, "MgmtGrpParentWithLocCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithLocs/{mgmtGrpParentWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MgmtGrpParentWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mgmtGrpParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mgmtGrpParentWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithLocName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string mgmtGrpParentWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mgmtGrpParentWithLocName, nameof(mgmtGrpParentWithLocName));

            using var scope = _mgmtGrpParentWithLocClientDiagnostics.CreateScope("MgmtGrpParentWithLocCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mgmtGrpParentWithLocRestClient.GetAsync(Id.Name, mgmtGrpParentWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithLocs/{mgmtGrpParentWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MgmtGrpParentWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mgmtGrpParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mgmtGrpParentWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithLocName"/> is null. </exception>
        public virtual Response<bool> Exists(string mgmtGrpParentWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mgmtGrpParentWithLocName, nameof(mgmtGrpParentWithLocName));

            using var scope = _mgmtGrpParentWithLocClientDiagnostics.CreateScope("MgmtGrpParentWithLocCollection.Exists");
            scope.Start();
            try
            {
                var response = _mgmtGrpParentWithLocRestClient.Get(Id.Name, mgmtGrpParentWithLocName, cancellationToken: cancellationToken);
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
        /// <description>/providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithLocs/{mgmtGrpParentWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MgmtGrpParentWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mgmtGrpParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mgmtGrpParentWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithLocName"/> is null. </exception>
        public virtual async Task<NullableResponse<MgmtGrpParentWithLocResource>> GetIfExistsAsync(string mgmtGrpParentWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mgmtGrpParentWithLocName, nameof(mgmtGrpParentWithLocName));

            using var scope = _mgmtGrpParentWithLocClientDiagnostics.CreateScope("MgmtGrpParentWithLocCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _mgmtGrpParentWithLocRestClient.GetAsync(Id.Name, mgmtGrpParentWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MgmtGrpParentWithLocResource>(response.GetRawResponse());
                return Response.FromValue(new MgmtGrpParentWithLocResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithLocs/{mgmtGrpParentWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MgmtGrpParentWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mgmtGrpParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mgmtGrpParentWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGrpParentWithLocName"/> is null. </exception>
        public virtual NullableResponse<MgmtGrpParentWithLocResource> GetIfExists(string mgmtGrpParentWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mgmtGrpParentWithLocName, nameof(mgmtGrpParentWithLocName));

            using var scope = _mgmtGrpParentWithLocClientDiagnostics.CreateScope("MgmtGrpParentWithLocCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mgmtGrpParentWithLocRestClient.Get(Id.Name, mgmtGrpParentWithLocName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MgmtGrpParentWithLocResource>(response.GetRawResponse());
                return Response.FromValue(new MgmtGrpParentWithLocResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MgmtGrpParentWithLocResource> IEnumerable<MgmtGrpParentWithLocResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MgmtGrpParentWithLocResource> IAsyncEnumerable<MgmtGrpParentWithLocResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
