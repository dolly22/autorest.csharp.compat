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

namespace Azure.ResourceManager.Sample
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualMachineScaleSetVirtualMachineExtensionResource" /> and their operations.
    /// Each <see cref="VirtualMachineScaleSetVirtualMachineExtensionResource" /> in the collection will belong to the same instance of <see cref="VirtualMachineScaleSetVmResource" />.
    /// To get a <see cref="VirtualMachineScaleSetVirtualMachineExtensionCollection" /> instance call the GetVirtualMachineScaleSetVirtualMachineExtensions method from an instance of <see cref="VirtualMachineScaleSetVmResource" />.
    /// </summary>
    public partial class VirtualMachineScaleSetVirtualMachineExtensionCollection : ArmCollection, IEnumerable<VirtualMachineScaleSetVirtualMachineExtensionResource>, IAsyncEnumerable<VirtualMachineScaleSetVirtualMachineExtensionResource>
    {
        private readonly ClientDiagnostics _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics;
        private readonly VirtualMachineScaleSetVMExtensionsRestOperations _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetVirtualMachineExtensionCollection"/> class for mocking. </summary>
        protected VirtualMachineScaleSetVirtualMachineExtensionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetVirtualMachineExtensionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualMachineScaleSetVirtualMachineExtensionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sample", VirtualMachineScaleSetVirtualMachineExtensionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualMachineScaleSetVirtualMachineExtensionResource.ResourceType, out string virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsApiVersion);
            _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsRestClient = new VirtualMachineScaleSetVMExtensionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualMachineScaleSetVmResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualMachineScaleSetVmResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update the VMSS VM extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMExtensions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="data"> Parameters supplied to the Create Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualMachineScaleSetVirtualMachineExtensionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vmExtensionName, VirtualMachineExtensionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vmExtensionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SampleArmOperation<VirtualMachineScaleSetVirtualMachineExtensionResource>(new VirtualMachineScaleSetVirtualMachineExtensionOperationSource(Client), _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics, Pipeline, _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vmExtensionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to create or update the VMSS VM extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMExtensions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="data"> Parameters supplied to the Create Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VirtualMachineScaleSetVirtualMachineExtensionResource> CreateOrUpdate(WaitUntil waitUntil, string vmExtensionName, VirtualMachineExtensionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineExtensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vmExtensionName, data, cancellationToken);
                var operation = new SampleArmOperation<VirtualMachineScaleSetVirtualMachineExtensionResource>(new VirtualMachineScaleSetVirtualMachineExtensionOperationSource(Client), _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics, Pipeline, _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vmExtensionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to get the VMSS VM extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMExtensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> is null. </exception>
        public virtual async Task<Response<VirtualMachineScaleSetVirtualMachineExtensionResource>> GetAsync(string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));

            using var scope = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vmExtensionName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVirtualMachineExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the VMSS VM extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMExtensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSetVirtualMachineExtensionResource> Get(string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));

            using var scope = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineExtensionCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vmExtensionName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVirtualMachineExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get all extensions of an instance in Virtual Machine Scaleset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMExtensions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineScaleSetVirtualMachineExtensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineScaleSetVirtualMachineExtensionResource> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new VirtualMachineScaleSetVirtualMachineExtensionResource(Client, VirtualMachineExtensionData.DeserializeVirtualMachineExtensionData(e)), _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics, Pipeline, "VirtualMachineScaleSetVirtualMachineExtensionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// The operation to get all extensions of an instance in Virtual Machine Scaleset.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMExtensions_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineScaleSetVirtualMachineExtensionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineScaleSetVirtualMachineExtensionResource> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new VirtualMachineScaleSetVirtualMachineExtensionResource(Client, VirtualMachineExtensionData.DeserializeVirtualMachineExtensionData(e)), _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics, Pipeline, "VirtualMachineScaleSetVirtualMachineExtensionCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMExtensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));

            using var scope = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vmExtensionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMExtensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> is null. </exception>
        public virtual Response<bool> Exists(string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));

            using var scope = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineExtensionCollection.Exists");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vmExtensionName, expand, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMExtensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> is null. </exception>
        public virtual async Task<NullableResponse<VirtualMachineScaleSetVirtualMachineExtensionResource>> GetIfExistsAsync(string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));

            using var scope = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineExtensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vmExtensionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VirtualMachineScaleSetVirtualMachineExtensionResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVirtualMachineExtensionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMExtensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vmExtensionName"> The name of the virtual machine extension. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmExtensionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmExtensionName"/> is null. </exception>
        public virtual NullableResponse<VirtualMachineScaleSetVirtualMachineExtensionResource> GetIfExists(string vmExtensionName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmExtensionName, nameof(vmExtensionName));

            using var scope = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVirtualMachineExtensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVirtualMachineExtensionVirtualMachineScaleSetVmExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, vmExtensionName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VirtualMachineScaleSetVirtualMachineExtensionResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVirtualMachineExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualMachineScaleSetVirtualMachineExtensionResource> IEnumerable<VirtualMachineScaleSetVirtualMachineExtensionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualMachineScaleSetVirtualMachineExtensionResource> IAsyncEnumerable<VirtualMachineScaleSetVirtualMachineExtensionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
