// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtListMethods
{
    /// <summary>
    /// A Class representing a TenantTest along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="TenantTestResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetTenantTestResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource" /> using the GetTenantTest method.
    /// </summary>
    public partial class TenantTestResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TenantTestResource"/> instance. </summary>
        /// <param name="tenantTestName"> The tenantTestName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string tenantTestName)
        {
            var resourceId = $"/providers/Microsoft.Tenant/tenantTests/{tenantTestName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _tenantTestClientDiagnostics;
        private readonly TenantTestsRestOperations _tenantTestRestClient;
        private readonly TenantTestData _data;

        /// <summary> Initializes a new instance of the <see cref="TenantTestResource"/> class for mocking. </summary>
        protected TenantTestResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "TenantTestResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TenantTestResource(ArmClient client, TenantTestData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="TenantTestResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantTestResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantTestClientDiagnostics = new ClientDiagnostics("MgmtListMethods", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string tenantTestApiVersion);
            _tenantTestRestClient = new TenantTestsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tenantTestApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Tenant/tenantTests";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual TenantTestData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of TenantParentWithNonResChWithLocResources in the TenantTest. </summary>
        /// <returns> An object representing collection of TenantParentWithNonResChWithLocResources and their operations over a TenantParentWithNonResChWithLocResource. </returns>
        public virtual TenantParentWithNonResChWithLocCollection GetTenantParentWithNonResChWithLocs()
        {
            return GetCachedClient(client => new TenantParentWithNonResChWithLocCollection(client, Id));
        }

        /// <summary>
        /// Retrieves information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs/{tenantParentWithNonResChWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantParentWithNonResChWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithNonResChWithLocName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="tenantParentWithNonResChWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<TenantParentWithNonResChWithLocResource>> GetTenantParentWithNonResChWithLocAsync(string tenantParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            return await GetTenantParentWithNonResChWithLocs().GetAsync(tenantParentWithNonResChWithLocName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs/{tenantParentWithNonResChWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantParentWithNonResChWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithNonResChWithLocName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="tenantParentWithNonResChWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<TenantParentWithNonResChWithLocResource> GetTenantParentWithNonResChWithLoc(string tenantParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            return GetTenantParentWithNonResChWithLocs().Get(tenantParentWithNonResChWithLocName, cancellationToken);
        }

        /// <summary> Gets a collection of TenantParentWithNonResChResources in the TenantTest. </summary>
        /// <returns> An object representing collection of TenantParentWithNonResChResources and their operations over a TenantParentWithNonResChResource. </returns>
        public virtual TenantParentWithNonResChCollection GetTenantParentWithNonResChes()
        {
            return GetCachedClient(client => new TenantParentWithNonResChCollection(client, Id));
        }

        /// <summary>
        /// Retrieves information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChes/{tenantParentWithNonResChName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantParentWithNonResChes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithNonResChName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="tenantParentWithNonResChName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<TenantParentWithNonResChResource>> GetTenantParentWithNonResChAsync(string tenantParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            return await GetTenantParentWithNonResChes().GetAsync(tenantParentWithNonResChName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChes/{tenantParentWithNonResChName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantParentWithNonResChes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithNonResChName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="tenantParentWithNonResChName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<TenantParentWithNonResChResource> GetTenantParentWithNonResCh(string tenantParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            return GetTenantParentWithNonResChes().Get(tenantParentWithNonResChName, cancellationToken);
        }

        /// <summary> Gets a collection of TenantParentWithLocResources in the TenantTest. </summary>
        /// <returns> An object representing collection of TenantParentWithLocResources and their operations over a TenantParentWithLocResource. </returns>
        public virtual TenantParentWithLocCollection GetTenantParentWithLocs()
        {
            return GetCachedClient(client => new TenantParentWithLocCollection(client, Id));
        }

        /// <summary>
        /// Retrieves information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithLocs/{tenantParentWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantParentWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithLocName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="tenantParentWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<TenantParentWithLocResource>> GetTenantParentWithLocAsync(string tenantParentWithLocName, CancellationToken cancellationToken = default)
        {
            return await GetTenantParentWithLocs().GetAsync(tenantParentWithLocName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithLocs/{tenantParentWithLocName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantParentWithLocs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithLocName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="tenantParentWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<TenantParentWithLocResource> GetTenantParentWithLoc(string tenantParentWithLocName, CancellationToken cancellationToken = default)
        {
            return GetTenantParentWithLocs().Get(tenantParentWithLocName, cancellationToken);
        }

        /// <summary> Gets a collection of TenantParentResources in the TenantTest. </summary>
        /// <returns> An object representing collection of TenantParentResources and their operations over a TenantParentResource. </returns>
        public virtual TenantParentCollection GetTenantParents()
        {
            return GetCachedClient(client => new TenantParentCollection(client, Id));
        }

        /// <summary>
        /// Retrieves information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParents/{tenantParentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantParents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="tenantParentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<TenantParentResource>> GetTenantParentAsync(string tenantParentName, CancellationToken cancellationToken = default)
        {
            return await GetTenantParents().GetAsync(tenantParentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParents/{tenantParentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantParents_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="tenantParentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<TenantParentResource> GetTenantParent(string tenantParentName, CancellationToken cancellationToken = default)
        {
            return GetTenantParents().Get(tenantParentName, cancellationToken);
        }

        /// <summary>
        /// Gets a billing account by its ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Tenant/tenantTests/{tenantTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantTests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> May be used to expand the soldTo, invoice sections and billing profiles. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TenantTestResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _tenantTestClientDiagnostics.CreateScope("TenantTestResource.Get");
            scope.Start();
            try
            {
                var response = await _tenantTestRestClient.GetAsync(Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantTestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a billing account by its ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Tenant/tenantTests/{tenantTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantTests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> May be used to expand the soldTo, invoice sections and billing profiles. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TenantTestResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _tenantTestClientDiagnostics.CreateScope("TenantTestResource.Get");
            scope.Start();
            try
            {
                var response = _tenantTestRestClient.Get(Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantTestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates the properties of a billing account. Currently, displayName and address can be updated. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Tenant/tenantTests/{tenantTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantTests_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Request parameters that are provided to the update billing account operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<TenantTestResource>> UpdateAsync(WaitUntil waitUntil, TenantTestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _tenantTestClientDiagnostics.CreateScope("TenantTestResource.Update");
            scope.Start();
            try
            {
                var response = await _tenantTestRestClient.CreateAsync(Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtListMethodsArmOperation<TenantTestResource>(new TenantTestOperationSource(Client), _tenantTestClientDiagnostics, Pipeline, _tenantTestRestClient.CreateCreateRequest(Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Updates the properties of a billing account. Currently, displayName and address can be updated. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Tenant/tenantTests/{tenantTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantTests_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Request parameters that are provided to the update billing account operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<TenantTestResource> Update(WaitUntil waitUntil, TenantTestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _tenantTestClientDiagnostics.CreateScope("TenantTestResource.Update");
            scope.Start();
            try
            {
                var response = _tenantTestRestClient.Create(Id.Name, data, cancellationToken);
                var operation = new MgmtListMethodsArmOperation<TenantTestResource>(new TenantTestOperationSource(Client), _tenantTestClientDiagnostics, Pipeline, _tenantTestRestClient.CreateCreateRequest(Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Tenant/tenantTests/{tenantTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantTests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<TenantTestResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _tenantTestClientDiagnostics.CreateScope("TenantTestResource.AddTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues[key] = value;
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _tenantTestRestClient.GetAsync(Id.Name, null, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new TenantTestResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    current.Tags[key] = value;
                    var result = await UpdateAsync(WaitUntil.Completed, current, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Tenant/tenantTests/{tenantTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantTests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<TenantTestResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _tenantTestClientDiagnostics.CreateScope("TenantTestResource.AddTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues[key] = value;
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _tenantTestRestClient.Get(Id.Name, null, cancellationToken);
                    return Response.FromValue(new TenantTestResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    current.Tags[key] = value;
                    var result = Update(WaitUntil.Completed, current, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Tenant/tenantTests/{tenantTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantTests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<TenantTestResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _tenantTestClientDiagnostics.CreateScope("TenantTestResource.SetTags");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _tenantTestRestClient.GetAsync(Id.Name, null, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new TenantTestResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    current.Tags.ReplaceWith(tags);
                    var result = await UpdateAsync(WaitUntil.Completed, current, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Tenant/tenantTests/{tenantTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantTests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<TenantTestResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _tenantTestClientDiagnostics.CreateScope("TenantTestResource.SetTags");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _tenantTestRestClient.Get(Id.Name, null, cancellationToken);
                    return Response.FromValue(new TenantTestResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    current.Tags.ReplaceWith(tags);
                    var result = Update(WaitUntil.Completed, current, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Tenant/tenantTests/{tenantTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantTests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<TenantTestResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _tenantTestClientDiagnostics.CreateScope("TenantTestResource.RemoveTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.Remove(key);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _tenantTestRestClient.GetAsync(Id.Name, null, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new TenantTestResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    current.Tags.Remove(key);
                    var result = await UpdateAsync(WaitUntil.Completed, current, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Tenant/tenantTests/{tenantTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TenantTests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<TenantTestResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _tenantTestClientDiagnostics.CreateScope("TenantTestResource.RemoveTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.Remove(key);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _tenantTestRestClient.Get(Id.Name, null, cancellationToken);
                    return Response.FromValue(new TenantTestResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    current.Tags.Remove(key);
                    var result = Update(WaitUntil.Completed, current, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
