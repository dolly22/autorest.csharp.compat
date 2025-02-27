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
    /// <summary> The Polymorphism service client. </summary>
    public partial interface IPolymorphismClient
    {
        /// <summary> Get complex types that are polymorphic. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Task<Response<Fish>> GetValidAsync(CancellationToken cancellationToken = default);

        /// <summary> Get complex types that are polymorphic. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Fish> GetValid(CancellationToken cancellationToken = default);

        /// <summary> Put complex types that are polymorphic. </summary>
        /// <param name="complexBody">
        /// Please put a salmon that looks like this:
        /// {
        ///         &apos;fishtype&apos;:&apos;Salmon&apos;,
        ///         &apos;location&apos;:&apos;alaska&apos;,
        ///         &apos;iswild&apos;:true,
        ///         &apos;species&apos;:&apos;king&apos;,
        ///         &apos;length&apos;:1.0,
        ///         &apos;siblings&apos;:[
        ///           {
        ///             &apos;fishtype&apos;:&apos;Shark&apos;,
        ///             &apos;age&apos;:6,
        ///             &apos;birthday&apos;: &apos;2012-01-05T01:00:00Z&apos;,
        ///             &apos;length&apos;:20.0,
        ///             &apos;species&apos;:&apos;predator&apos;,
        ///           },
        ///           {
        ///             &apos;fishtype&apos;:&apos;Sawshark&apos;,
        ///             &apos;age&apos;:105,
        ///             &apos;birthday&apos;: &apos;1900-01-05T01:00:00Z&apos;,
        ///             &apos;length&apos;:10.0,
        ///             &apos;picture&apos;: new Buffer([255, 255, 255, 255, 254]).toString(&apos;base64&apos;),
        ///             &apos;species&apos;:&apos;dangerous&apos;,
        ///           },
        ///           {
        ///             &apos;fishtype&apos;: &apos;goblin&apos;,
        ///             &apos;age&apos;: 1,
        ///             &apos;birthday&apos;: &apos;2015-08-08T00:00:00Z&apos;,
        ///             &apos;length&apos;: 30.0,
        ///             &apos;species&apos;: &apos;scary&apos;,
        ///             &apos;jawsize&apos;: 5
        ///           }
        ///         ]
        ///       };
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Task<Response> PutValidAsync(Fish complexBody, CancellationToken cancellationToken = default);

        /// <summary> Put complex types that are polymorphic. </summary>
        /// <param name="complexBody">
        /// Please put a salmon that looks like this:
        /// {
        ///         &apos;fishtype&apos;:&apos;Salmon&apos;,
        ///         &apos;location&apos;:&apos;alaska&apos;,
        ///         &apos;iswild&apos;:true,
        ///         &apos;species&apos;:&apos;king&apos;,
        ///         &apos;length&apos;:1.0,
        ///         &apos;siblings&apos;:[
        ///           {
        ///             &apos;fishtype&apos;:&apos;Shark&apos;,
        ///             &apos;age&apos;:6,
        ///             &apos;birthday&apos;: &apos;2012-01-05T01:00:00Z&apos;,
        ///             &apos;length&apos;:20.0,
        ///             &apos;species&apos;:&apos;predator&apos;,
        ///           },
        ///           {
        ///             &apos;fishtype&apos;:&apos;Sawshark&apos;,
        ///             &apos;age&apos;:105,
        ///             &apos;birthday&apos;: &apos;1900-01-05T01:00:00Z&apos;,
        ///             &apos;length&apos;:10.0,
        ///             &apos;picture&apos;: new Buffer([255, 255, 255, 255, 254]).toString(&apos;base64&apos;),
        ///             &apos;species&apos;:&apos;dangerous&apos;,
        ///           },
        ///           {
        ///             &apos;fishtype&apos;: &apos;goblin&apos;,
        ///             &apos;age&apos;: 1,
        ///             &apos;birthday&apos;: &apos;2015-08-08T00:00:00Z&apos;,
        ///             &apos;length&apos;: 30.0,
        ///             &apos;species&apos;: &apos;scary&apos;,
        ///             &apos;jawsize&apos;: 5
        ///           }
        ///         ]
        ///       };
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutValid(Fish complexBody, CancellationToken cancellationToken = default);

        /// <summary> Get complex types that are polymorphic, JSON key contains a dot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Task<Response<DotFish>> GetDotSyntaxAsync(CancellationToken cancellationToken = default);

        /// <summary> Get complex types that are polymorphic, JSON key contains a dot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DotFish> GetDotSyntax(CancellationToken cancellationToken = default);

        /// <summary> Get complex object composing a polymorphic scalar property and array property with polymorphic element type, with discriminator specified. Deserialization must NOT fail and use the discriminator type specified on the wire. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Task<Response<DotFishMarket>> GetComposedWithDiscriminatorAsync(CancellationToken cancellationToken = default);

        /// <summary> Get complex object composing a polymorphic scalar property and array property with polymorphic element type, with discriminator specified. Deserialization must NOT fail and use the discriminator type specified on the wire. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DotFishMarket> GetComposedWithDiscriminator(CancellationToken cancellationToken = default);

        /// <summary> Get complex object composing a polymorphic scalar property and array property with polymorphic element type, without discriminator specified on wire. Deserialization must NOT fail and use the explicit type of the property. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Task<Response<DotFishMarket>> GetComposedWithoutDiscriminatorAsync(CancellationToken cancellationToken = default);

        /// <summary> Get complex object composing a polymorphic scalar property and array property with polymorphic element type, without discriminator specified on wire. Deserialization must NOT fail and use the explicit type of the property. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DotFishMarket> GetComposedWithoutDiscriminator(CancellationToken cancellationToken = default);

        /// <summary> Get complex types that are polymorphic, but not at the root of the hierarchy; also have additional properties. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Task<Response<Salmon>> GetComplicatedAsync(CancellationToken cancellationToken = default);

        /// <summary> Get complex types that are polymorphic, but not at the root of the hierarchy; also have additional properties. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Salmon> GetComplicated(CancellationToken cancellationToken = default);

        /// <summary> Put complex types that are polymorphic, but not at the root of the hierarchy; also have additional properties. </summary>
        /// <param name="complexBody"> The Salmon to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Task<Response> PutComplicatedAsync(Salmon complexBody, CancellationToken cancellationToken = default);

        /// <summary> Put complex types that are polymorphic, but not at the root of the hierarchy; also have additional properties. </summary>
        /// <param name="complexBody"> The Salmon to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutComplicated(Salmon complexBody, CancellationToken cancellationToken = default);

        /// <summary> Put complex types that are polymorphic, omitting the discriminator. </summary>
        /// <param name="complexBody"> The Salmon to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Task<Response<Salmon>> PutMissingDiscriminatorAsync(Salmon complexBody, CancellationToken cancellationToken = default);

        /// <summary> Put complex types that are polymorphic, omitting the discriminator. </summary>
        /// <param name="complexBody"> The Salmon to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Salmon> PutMissingDiscriminator(Salmon complexBody, CancellationToken cancellationToken = default);

        /// <summary> Put complex types that are polymorphic, attempting to omit required &apos;birthday&apos; field - the request should not be allowed from the client. </summary>
        /// <param name="complexBody">
        /// Please attempt put a sawshark that looks like this, the client should not allow this data to be sent:
        /// {
        ///     &quot;fishtype&quot;: &quot;sawshark&quot;,
        ///     &quot;species&quot;: &quot;snaggle toothed&quot;,
        ///     &quot;length&quot;: 18.5,
        ///     &quot;age&quot;: 2,
        ///     &quot;birthday&quot;: &quot;2013-06-01T01:00:00Z&quot;,
        ///     &quot;location&quot;: &quot;alaska&quot;,
        ///     &quot;picture&quot;: base64(FF FF FF FF FE),
        ///     &quot;siblings&quot;: [
        ///         {
        ///             &quot;fishtype&quot;: &quot;shark&quot;,
        ///             &quot;species&quot;: &quot;predator&quot;,
        ///             &quot;birthday&quot;: &quot;2012-01-05T01:00:00Z&quot;,
        ///             &quot;length&quot;: 20,
        ///             &quot;age&quot;: 6
        ///         },
        ///         {
        ///             &quot;fishtype&quot;: &quot;sawshark&quot;,
        ///             &quot;species&quot;: &quot;dangerous&quot;,
        ///             &quot;picture&quot;: base64(FF FF FF FF FE),
        ///             &quot;length&quot;: 10,
        ///             &quot;age&quot;: 105
        ///         }
        ///     ]
        /// }
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Task<Response> PutValidMissingRequiredAsync(Fish complexBody, CancellationToken cancellationToken = default);

        /// <summary> Put complex types that are polymorphic, attempting to omit required &apos;birthday&apos; field - the request should not be allowed from the client. </summary>
        /// <param name="complexBody">
        /// Please attempt put a sawshark that looks like this, the client should not allow this data to be sent:
        /// {
        ///     &quot;fishtype&quot;: &quot;sawshark&quot;,
        ///     &quot;species&quot;: &quot;snaggle toothed&quot;,
        ///     &quot;length&quot;: 18.5,
        ///     &quot;age&quot;: 2,
        ///     &quot;birthday&quot;: &quot;2013-06-01T01:00:00Z&quot;,
        ///     &quot;location&quot;: &quot;alaska&quot;,
        ///     &quot;picture&quot;: base64(FF FF FF FF FE),
        ///     &quot;siblings&quot;: [
        ///         {
        ///             &quot;fishtype&quot;: &quot;shark&quot;,
        ///             &quot;species&quot;: &quot;predator&quot;,
        ///             &quot;birthday&quot;: &quot;2012-01-05T01:00:00Z&quot;,
        ///             &quot;length&quot;: 20,
        ///             &quot;age&quot;: 6
        ///         },
        ///         {
        ///             &quot;fishtype&quot;: &quot;sawshark&quot;,
        ///             &quot;species&quot;: &quot;dangerous&quot;,
        ///             &quot;picture&quot;: base64(FF FF FF FF FE),
        ///             &quot;length&quot;: 10,
        ///             &quot;age&quot;: 105
        ///         }
        ///     ]
        /// }
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutValidMissingRequired(Fish complexBody, CancellationToken cancellationToken = default);
    }
}
