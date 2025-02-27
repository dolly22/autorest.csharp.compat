// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using MgmtSupersetInheritance;
using MgmtSupersetInheritance.Models;

namespace MgmtSupersetInheritance.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableMgmtSupersetInheritanceResourceGroupResource : ArmResource
    {
        private ClientDiagnostics _supersetModel2sClientDiagnostics;
        private SupersetModel2SRestOperations _supersetModel2sRestClient;
        private ClientDiagnostics _supersetModel3sClientDiagnostics;
        private SupersetModel3SRestOperations _supersetModel3sRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableMgmtSupersetInheritanceResourceGroupResource"/> class for mocking. </summary>
        protected MockableMgmtSupersetInheritanceResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMgmtSupersetInheritanceResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMgmtSupersetInheritanceResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics SupersetModel2sClientDiagnostics => _supersetModel2sClientDiagnostics ??= new ClientDiagnostics("MgmtSupersetInheritance", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private SupersetModel2SRestOperations SupersetModel2sRestClient => _supersetModel2sRestClient ??= new SupersetModel2SRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics SupersetModel3sClientDiagnostics => _supersetModel3sClientDiagnostics ??= new ClientDiagnostics("MgmtSupersetInheritance", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private SupersetModel3SRestOperations SupersetModel3sRestClient => _supersetModel3sRestClient ??= new SupersetModel3SRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of SupersetModel1Resources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of SupersetModel1Resources and their operations over a SupersetModel1Resource. </returns>
        public virtual SupersetModel1Collection GetSupersetModel1s()
        {
            return GetCachedClient(client => new SupersetModel1Collection(client, Id));
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel1s/{supersetModel1sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel1s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel1SName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel1SName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SupersetModel1Resource>> GetSupersetModel1Async(string supersetModel1SName, CancellationToken cancellationToken = default)
        {
            return await GetSupersetModel1s().GetAsync(supersetModel1SName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel1s/{supersetModel1sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel1s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel1SName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel1SName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SupersetModel1Resource> GetSupersetModel1(string supersetModel1SName, CancellationToken cancellationToken = default)
        {
            return GetSupersetModel1s().Get(supersetModel1SName, cancellationToken);
        }

        /// <summary> Gets a collection of SupersetModel4Resources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of SupersetModel4Resources and their operations over a SupersetModel4Resource. </returns>
        public virtual SupersetModel4Collection GetSupersetModel4s()
        {
            return GetCachedClient(client => new SupersetModel4Collection(client, Id));
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel4s/{supersetModel4sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel4s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel4SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel4SName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel4SName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SupersetModel4Resource>> GetSupersetModel4Async(string supersetModel4SName, CancellationToken cancellationToken = default)
        {
            return await GetSupersetModel4s().GetAsync(supersetModel4SName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel4s/{supersetModel4sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel4s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel4SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel4SName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel4SName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SupersetModel4Resource> GetSupersetModel4(string supersetModel4SName, CancellationToken cancellationToken = default)
        {
            return GetSupersetModel4s().Get(supersetModel4SName, cancellationToken);
        }

        /// <summary> Gets a collection of SupersetModel6Resources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of SupersetModel6Resources and their operations over a SupersetModel6Resource. </returns>
        public virtual SupersetModel6Collection GetSupersetModel6s()
        {
            return GetCachedClient(client => new SupersetModel6Collection(client, Id));
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel6s/{supersetModel6sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel6s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel6SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel6SName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel6SName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SupersetModel6Resource>> GetSupersetModel6Async(string supersetModel6SName, CancellationToken cancellationToken = default)
        {
            return await GetSupersetModel6s().GetAsync(supersetModel6SName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel6s/{supersetModel6sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel6s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel6SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel6SName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel6SName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SupersetModel6Resource> GetSupersetModel6(string supersetModel6SName, CancellationToken cancellationToken = default)
        {
            return GetSupersetModel6s().Get(supersetModel6SName, cancellationToken);
        }

        /// <summary> Gets a collection of SupersetModel7Resources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of SupersetModel7Resources and their operations over a SupersetModel7Resource. </returns>
        public virtual SupersetModel7Collection GetSupersetModel7s()
        {
            return GetCachedClient(client => new SupersetModel7Collection(client, Id));
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel7s/{supersetModel7sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel7s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel7SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel7SName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel7SName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SupersetModel7Resource>> GetSupersetModel7Async(string supersetModel7SName, CancellationToken cancellationToken = default)
        {
            return await GetSupersetModel7s().GetAsync(supersetModel7SName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel7s/{supersetModel7sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel7s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel7SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel7SName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel7SName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SupersetModel7Resource> GetSupersetModel7(string supersetModel7SName, CancellationToken cancellationToken = default)
        {
            return GetSupersetModel7s().Get(supersetModel7SName, cancellationToken);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel2s/{supersetModel2sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel2s_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel2SName"> The String to use. </param>
        /// <param name="supersetModel2"> The SupersetModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel2SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel2SName"/> or <paramref name="supersetModel2"/> is null. </exception>
        public virtual async Task<Response<SupersetModel2>> PutSupersetModel2Async(string supersetModel2SName, SupersetModel2 supersetModel2, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel2SName, nameof(supersetModel2SName));
            Argument.AssertNotNull(supersetModel2, nameof(supersetModel2));

            using var scope = SupersetModel2sClientDiagnostics.CreateScope("MockableMgmtSupersetInheritanceResourceGroupResource.PutSupersetModel2");
            scope.Start();
            try
            {
                var response = await SupersetModel2sRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, supersetModel2SName, supersetModel2, cancellationToken).ConfigureAwait(false);
                return response;
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel2s/{supersetModel2sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel2s_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel2SName"> The String to use. </param>
        /// <param name="supersetModel2"> The SupersetModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel2SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel2SName"/> or <paramref name="supersetModel2"/> is null. </exception>
        public virtual Response<SupersetModel2> PutSupersetModel2(string supersetModel2SName, SupersetModel2 supersetModel2, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel2SName, nameof(supersetModel2SName));
            Argument.AssertNotNull(supersetModel2, nameof(supersetModel2));

            using var scope = SupersetModel2sClientDiagnostics.CreateScope("MockableMgmtSupersetInheritanceResourceGroupResource.PutSupersetModel2");
            scope.Start();
            try
            {
                var response = SupersetModel2sRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, supersetModel2SName, supersetModel2, cancellationToken);
                return response;
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel2s/{supersetModel2sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel2s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel2SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel2SName"/> is null. </exception>
        public virtual async Task<Response<SupersetModel2>> GetSupersetModel2Async(string supersetModel2SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel2SName, nameof(supersetModel2SName));

            using var scope = SupersetModel2sClientDiagnostics.CreateScope("MockableMgmtSupersetInheritanceResourceGroupResource.GetSupersetModel2");
            scope.Start();
            try
            {
                var response = await SupersetModel2sRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, supersetModel2SName, cancellationToken).ConfigureAwait(false);
                return response;
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel2s/{supersetModel2sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel2s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel2SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel2SName"/> is null. </exception>
        public virtual Response<SupersetModel2> GetSupersetModel2(string supersetModel2SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel2SName, nameof(supersetModel2SName));

            using var scope = SupersetModel2sClientDiagnostics.CreateScope("MockableMgmtSupersetInheritanceResourceGroupResource.GetSupersetModel2");
            scope.Start();
            try
            {
                var response = SupersetModel2sRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, supersetModel2SName, cancellationToken);
                return response;
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel3s/{supersetModel3sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel3s_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel3SName"> The String to use. </param>
        /// <param name="supersetModel3"> The SupersetModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel3SName"/> or <paramref name="supersetModel3"/> is null. </exception>
        public virtual async Task<Response<SupersetModel3>> PutSupersetModel3Async(string supersetModel3SName, SupersetModel3 supersetModel3, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel3SName, nameof(supersetModel3SName));
            Argument.AssertNotNull(supersetModel3, nameof(supersetModel3));

            using var scope = SupersetModel3sClientDiagnostics.CreateScope("MockableMgmtSupersetInheritanceResourceGroupResource.PutSupersetModel3");
            scope.Start();
            try
            {
                var response = await SupersetModel3sRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, supersetModel3SName, supersetModel3, cancellationToken).ConfigureAwait(false);
                return response;
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel3s/{supersetModel3sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel3s_Put</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel3SName"> The String to use. </param>
        /// <param name="supersetModel3"> The SupersetModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel3SName"/> or <paramref name="supersetModel3"/> is null. </exception>
        public virtual Response<SupersetModel3> PutSupersetModel3(string supersetModel3SName, SupersetModel3 supersetModel3, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel3SName, nameof(supersetModel3SName));
            Argument.AssertNotNull(supersetModel3, nameof(supersetModel3));

            using var scope = SupersetModel3sClientDiagnostics.CreateScope("MockableMgmtSupersetInheritanceResourceGroupResource.PutSupersetModel3");
            scope.Start();
            try
            {
                var response = SupersetModel3sRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, supersetModel3SName, supersetModel3, cancellationToken);
                return response;
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel3s/{supersetModel3sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel3s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel3SName"/> is null. </exception>
        public virtual async Task<Response<SupersetModel3>> GetSupersetModel3Async(string supersetModel3SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel3SName, nameof(supersetModel3SName));

            using var scope = SupersetModel3sClientDiagnostics.CreateScope("MockableMgmtSupersetInheritanceResourceGroupResource.GetSupersetModel3");
            scope.Start();
            try
            {
                var response = await SupersetModel3sRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, supersetModel3SName, cancellationToken).ConfigureAwait(false);
                return response;
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel3s/{supersetModel3sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupersetModel3s_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="supersetModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="supersetModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel3SName"/> is null. </exception>
        public virtual Response<SupersetModel3> GetSupersetModel3(string supersetModel3SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(supersetModel3SName, nameof(supersetModel3SName));

            using var scope = SupersetModel3sClientDiagnostics.CreateScope("MockableMgmtSupersetInheritanceResourceGroupResource.GetSupersetModel3");
            scope.Start();
            try
            {
                var response = SupersetModel3sRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, supersetModel3SName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
