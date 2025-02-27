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
using Azure.ResourceManager;

namespace MgmtPartialResource
{
    /// <summary>
    /// A class extending from the VirtualMachineResource in MgmtPartialResource along with the instance operations that can be performed on it.
    /// You can only construct a <see cref="VirtualMachineMgmtPartialResource" /> from a <see cref="ResourceIdentifier" /> with a resource type of Microsoft.Compute/virtualMachines.
    /// </summary>
    public partial class VirtualMachineMgmtPartialResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="VirtualMachineMgmtPartialResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="vmName"> The vmName. </param>
        internal static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vmName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}";
            return new ResourceIdentifier(resourceId);
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineMgmtPartialResource"/> class for mocking. </summary>
        protected VirtualMachineMgmtPartialResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineMgmtPartialResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VirtualMachineMgmtPartialResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/virtualMachines";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of ConfigurationProfileAssignmentResources in the VirtualMachineMgmtPartialResource. </summary>
        /// <returns> An object representing collection of ConfigurationProfileAssignmentResources and their operations over a ConfigurationProfileAssignmentResource. </returns>
        public virtual ConfigurationProfileAssignmentCollection GetConfigurationProfileAssignments()
        {
            return GetCachedClient(client => new ConfigurationProfileAssignmentCollection(client, Id));
        }

        /// <summary>
        /// Get information about a configuration profile assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ConfigurationProfileAssignmentResource>> GetConfigurationProfileAssignmentAsync(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            return await GetConfigurationProfileAssignments().GetAsync(configurationProfileAssignmentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get information about a configuration profile assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ConfigurationProfileAssignmentResource> GetConfigurationProfileAssignment(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            return GetConfigurationProfileAssignments().Get(configurationProfileAssignmentName, cancellationToken);
        }
    }
}
