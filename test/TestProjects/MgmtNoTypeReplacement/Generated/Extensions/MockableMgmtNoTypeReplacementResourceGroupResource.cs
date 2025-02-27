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
using MgmtNoTypeReplacement;

namespace MgmtNoTypeReplacement.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableMgmtNoTypeReplacementResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableMgmtNoTypeReplacementResourceGroupResource"/> class for mocking. </summary>
        protected MockableMgmtNoTypeReplacementResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMgmtNoTypeReplacementResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMgmtNoTypeReplacementResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of NoTypeReplacementModel1Resources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of NoTypeReplacementModel1Resources and their operations over a NoTypeReplacementModel1Resource. </returns>
        public virtual NoTypeReplacementModel1Collection GetNoTypeReplacementModel1s()
        {
            return GetCachedClient(client => new NoTypeReplacementModel1Collection(client, Id));
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/noTypeReplacementModel1s/{noTypeReplacementModel1sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NoTypeReplacementModel1s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="noTypeReplacementModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel1SName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="noTypeReplacementModel1SName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NoTypeReplacementModel1Resource>> GetNoTypeReplacementModel1Async(string noTypeReplacementModel1SName, CancellationToken cancellationToken = default)
        {
            return await GetNoTypeReplacementModel1s().GetAsync(noTypeReplacementModel1SName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/noTypeReplacementModel1s/{noTypeReplacementModel1sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NoTypeReplacementModel1s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="noTypeReplacementModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel1SName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="noTypeReplacementModel1SName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NoTypeReplacementModel1Resource> GetNoTypeReplacementModel1(string noTypeReplacementModel1SName, CancellationToken cancellationToken = default)
        {
            return GetNoTypeReplacementModel1s().Get(noTypeReplacementModel1SName, cancellationToken);
        }

        /// <summary> Gets a collection of NoTypeReplacementModel2Resources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of NoTypeReplacementModel2Resources and their operations over a NoTypeReplacementModel2Resource. </returns>
        public virtual NoTypeReplacementModel2Collection GetNoTypeReplacementModel2s()
        {
            return GetCachedClient(client => new NoTypeReplacementModel2Collection(client, Id));
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/noTypeReplacementModel2s/{noTypeReplacementModel2sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NoTypeReplacementModel2s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="noTypeReplacementModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel2SName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="noTypeReplacementModel2SName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NoTypeReplacementModel2Resource>> GetNoTypeReplacementModel2Async(string noTypeReplacementModel2SName, CancellationToken cancellationToken = default)
        {
            return await GetNoTypeReplacementModel2s().GetAsync(noTypeReplacementModel2SName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/noTypeReplacementModel2s/{noTypeReplacementModel2sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NoTypeReplacementModel2s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="noTypeReplacementModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel2SName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="noTypeReplacementModel2SName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NoTypeReplacementModel2Resource> GetNoTypeReplacementModel2(string noTypeReplacementModel2SName, CancellationToken cancellationToken = default)
        {
            return GetNoTypeReplacementModel2s().Get(noTypeReplacementModel2SName, cancellationToken);
        }

        /// <summary> Gets a collection of NoTypeReplacementModel3Resources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of NoTypeReplacementModel3Resources and their operations over a NoTypeReplacementModel3Resource. </returns>
        public virtual NoTypeReplacementModel3Collection GetNoTypeReplacementModel3s()
        {
            return GetCachedClient(client => new NoTypeReplacementModel3Collection(client, Id));
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/noTypeReplacementModel3s/{noTypeReplacementModel3sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NoTypeReplacementModel3s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="noTypeReplacementModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel3SName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="noTypeReplacementModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<NoTypeReplacementModel3Resource>> GetNoTypeReplacementModel3Async(string noTypeReplacementModel3SName, CancellationToken cancellationToken = default)
        {
            return await GetNoTypeReplacementModel3s().GetAsync(noTypeReplacementModel3SName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/noTypeReplacementModel3s/{noTypeReplacementModel3sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NoTypeReplacementModel3s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="noTypeReplacementModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel3SName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="noTypeReplacementModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<NoTypeReplacementModel3Resource> GetNoTypeReplacementModel3(string noTypeReplacementModel3SName, CancellationToken cancellationToken = default)
        {
            return GetNoTypeReplacementModel3s().Get(noTypeReplacementModel3SName, cancellationToken);
        }
    }
}
