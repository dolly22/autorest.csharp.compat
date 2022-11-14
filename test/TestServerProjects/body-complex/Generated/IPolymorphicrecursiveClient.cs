// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using body_complex.Models;

namespace body_complex
{
    /// <summary> The Polymorphicrecursive service client. </summary>
    public partial interface IPolymorphicrecursiveClient
    {
        /// <summary> Get complex types that are polymorphic and have recursive references. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Task<Response<Fish>> GetValidAsync(CancellationToken cancellationToken = default);

        /// <summary> Get complex types that are polymorphic and have recursive references. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Fish> GetValid(CancellationToken cancellationToken = default);

        /// <summary> Put complex types that are polymorphic and have recursive references. </summary>
        /// <param name="complexBody">
        /// Please put a salmon that looks like this:
        /// {
        ///     &quot;fishtype&quot;: &quot;salmon&quot;,
        ///     &quot;species&quot;: &quot;king&quot;,
        ///     &quot;length&quot;: 1,
        ///     &quot;age&quot;: 1,
        ///     &quot;location&quot;: &quot;alaska&quot;,
        ///     &quot;iswild&quot;: true,
        ///     &quot;siblings&quot;: [
        ///         {
        ///             &quot;fishtype&quot;: &quot;shark&quot;,
        ///             &quot;species&quot;: &quot;predator&quot;,
        ///             &quot;length&quot;: 20,
        ///             &quot;age&quot;: 6,
        ///             &quot;siblings&quot;: [
        ///                 {
        ///                     &quot;fishtype&quot;: &quot;salmon&quot;,
        ///                     &quot;species&quot;: &quot;coho&quot;,
        ///                     &quot;length&quot;: 2,
        ///                     &quot;age&quot;: 2,
        ///                     &quot;location&quot;: &quot;atlantic&quot;,
        ///                     &quot;iswild&quot;: true,
        ///                     &quot;siblings&quot;: [
        ///                         {
        ///                             &quot;fishtype&quot;: &quot;shark&quot;,
        ///                             &quot;species&quot;: &quot;predator&quot;,
        ///                             &quot;length&quot;: 20,
        ///                             &quot;age&quot;: 6
        ///                         },
        ///                         {
        ///                             &quot;fishtype&quot;: &quot;sawshark&quot;,
        ///                             &quot;species&quot;: &quot;dangerous&quot;,
        ///                             &quot;length&quot;: 10,
        ///                             &quot;age&quot;: 105
        ///                         }
        ///                     ]
        ///                 },
        ///                 {
        ///                     &quot;fishtype&quot;: &quot;sawshark&quot;,
        ///                     &quot;species&quot;: &quot;dangerous&quot;,
        ///                     &quot;length&quot;: 10,
        ///                     &quot;age&quot;: 105
        ///                 }
        ///             ]
        ///         },
        ///         {
        ///             &quot;fishtype&quot;: &quot;sawshark&quot;,
        ///             &quot;species&quot;: &quot;dangerous&quot;,
        ///             &quot;length&quot;: 10,
        ///             &quot;age&quot;: 105
        ///         }
        ///     ]
        /// }
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Task<Response> PutValidAsync(Fish complexBody, CancellationToken cancellationToken = default);

        /// <summary> Put complex types that are polymorphic and have recursive references. </summary>
        /// <param name="complexBody">
        /// Please put a salmon that looks like this:
        /// {
        ///     &quot;fishtype&quot;: &quot;salmon&quot;,
        ///     &quot;species&quot;: &quot;king&quot;,
        ///     &quot;length&quot;: 1,
        ///     &quot;age&quot;: 1,
        ///     &quot;location&quot;: &quot;alaska&quot;,
        ///     &quot;iswild&quot;: true,
        ///     &quot;siblings&quot;: [
        ///         {
        ///             &quot;fishtype&quot;: &quot;shark&quot;,
        ///             &quot;species&quot;: &quot;predator&quot;,
        ///             &quot;length&quot;: 20,
        ///             &quot;age&quot;: 6,
        ///             &quot;siblings&quot;: [
        ///                 {
        ///                     &quot;fishtype&quot;: &quot;salmon&quot;,
        ///                     &quot;species&quot;: &quot;coho&quot;,
        ///                     &quot;length&quot;: 2,
        ///                     &quot;age&quot;: 2,
        ///                     &quot;location&quot;: &quot;atlantic&quot;,
        ///                     &quot;iswild&quot;: true,
        ///                     &quot;siblings&quot;: [
        ///                         {
        ///                             &quot;fishtype&quot;: &quot;shark&quot;,
        ///                             &quot;species&quot;: &quot;predator&quot;,
        ///                             &quot;length&quot;: 20,
        ///                             &quot;age&quot;: 6
        ///                         },
        ///                         {
        ///                             &quot;fishtype&quot;: &quot;sawshark&quot;,
        ///                             &quot;species&quot;: &quot;dangerous&quot;,
        ///                             &quot;length&quot;: 10,
        ///                             &quot;age&quot;: 105
        ///                         }
        ///                     ]
        ///                 },
        ///                 {
        ///                     &quot;fishtype&quot;: &quot;sawshark&quot;,
        ///                     &quot;species&quot;: &quot;dangerous&quot;,
        ///                     &quot;length&quot;: 10,
        ///                     &quot;age&quot;: 105
        ///                 }
        ///             ]
        ///         },
        ///         {
        ///             &quot;fishtype&quot;: &quot;sawshark&quot;,
        ///             &quot;species&quot;: &quot;dangerous&quot;,
        ///             &quot;length&quot;: 10,
        ///             &quot;age&quot;: 105
        ///         }
        ///     ]
        /// }
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutValid(Fish complexBody, CancellationToken cancellationToken = default);
    }
}
