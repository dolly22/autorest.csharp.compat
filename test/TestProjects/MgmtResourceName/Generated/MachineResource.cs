// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtResourceName
{
    /// <summary>
    /// A Class representing a Machine along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="MachineResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetMachineResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetMachine method.
    /// </summary>
    public partial class MachineResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MachineResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="machineName"> The machineName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string machineName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/machines/{machineName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _machineClientDiagnostics;
        private readonly MachinesRestOperations _machineRestClient;
        private readonly MachineData _data;

        /// <summary> Initializes a new instance of the <see cref="MachineResource"/> class for mocking. </summary>
        protected MachineResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MachineResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MachineResource(ArmClient client, MachineData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MachineResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MachineResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineClientDiagnostics = new ClientDiagnostics("MgmtResourceName", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string machineApiVersion);
            _machineRestClient = new MachinesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/machines";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MachineData Data
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

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/machines/{machineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Machines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MachineResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _machineClientDiagnostics.CreateScope("MachineResource.Get");
            scope.Start();
            try
            {
                var response = await _machineRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/machines/{machineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Machines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MachineResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _machineClientDiagnostics.CreateScope("MachineResource.Get");
            scope.Start();
            try
            {
                var response = _machineRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/machines/{machineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Machines_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The Machine to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineResource>> UpdateAsync(WaitUntil waitUntil, MachineData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineClientDiagnostics.CreateScope("MachineResource.Update");
            scope.Start();
            try
            {
                var response = await _machineRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtResourceNameArmOperation<MachineResource>(Response.FromValue(new MachineResource(Client, response), response.GetRawResponse()));
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/machines/{machineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Machines_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The Machine to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineResource> Update(WaitUntil waitUntil, MachineData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineClientDiagnostics.CreateScope("MachineResource.Update");
            scope.Start();
            try
            {
                var response = _machineRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, data, cancellationToken);
                var operation = new MgmtResourceNameArmOperation<MachineResource>(Response.FromValue(new MachineResource(Client, response), response.GetRawResponse()));
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
    }
}
