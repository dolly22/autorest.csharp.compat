// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using body_complex.Models;

namespace body_complex
{
    /// <summary> The Polymorphicrecursive service client. </summary>
    public partial class PolymorphicrecursiveClient : IPolymorphicrecursiveClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PolymorphicrecursiveRestClient RestClient { get; }

        /// <summary> Initializes a new instance of PolymorphicrecursiveClient for mocking. </summary>
        protected PolymorphicrecursiveClient()
        {
        }

        /// <summary> Initializes a new instance of PolymorphicrecursiveClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal PolymorphicrecursiveClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new PolymorphicrecursiveRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get complex types that are polymorphic and have recursive references. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Fish>> GetValidAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphicrecursiveClient.GetValid");
            scope.Start();
            try
            {
                return await RestClient.GetValidAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types that are polymorphic and have recursive references. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Fish> GetValid(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphicrecursiveClient.GetValid");
            scope.Start();
            try
            {
                return RestClient.GetValid(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic and have recursive references. </summary>
        /// <param name="complexBody">
        /// Please put a salmon that looks like this:
        /// {
        ///     "fishtype": "salmon",
        ///     "species": "king",
        ///     "length": 1,
        ///     "age": 1,
        ///     "location": "alaska",
        ///     "iswild": true,
        ///     "siblings": [
        ///         {
        ///             "fishtype": "shark",
        ///             "species": "predator",
        ///             "length": 20,
        ///             "age": 6,
        ///             "siblings": [
        ///                 {
        ///                     "fishtype": "salmon",
        ///                     "species": "coho",
        ///                     "length": 2,
        ///                     "age": 2,
        ///                     "location": "atlantic",
        ///                     "iswild": true,
        ///                     "siblings": [
        ///                         {
        ///                             "fishtype": "shark",
        ///                             "species": "predator",
        ///                             "length": 20,
        ///                             "age": 6
        ///                         },
        ///                         {
        ///                             "fishtype": "sawshark",
        ///                             "species": "dangerous",
        ///                             "length": 10,
        ///                             "age": 105
        ///                         }
        ///                     ]
        ///                 },
        ///                 {
        ///                     "fishtype": "sawshark",
        ///                     "species": "dangerous",
        ///                     "length": 10,
        ///                     "age": 105
        ///                 }
        ///             ]
        ///         },
        ///         {
        ///             "fishtype": "sawshark",
        ///             "species": "dangerous",
        ///             "length": 10,
        ///             "age": 105
        ///         }
        ///     ]
        /// }
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutValidAsync(Fish complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphicrecursiveClient.PutValid");
            scope.Start();
            try
            {
                return await RestClient.PutValidAsync(complexBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic and have recursive references. </summary>
        /// <param name="complexBody">
        /// Please put a salmon that looks like this:
        /// {
        ///     "fishtype": "salmon",
        ///     "species": "king",
        ///     "length": 1,
        ///     "age": 1,
        ///     "location": "alaska",
        ///     "iswild": true,
        ///     "siblings": [
        ///         {
        ///             "fishtype": "shark",
        ///             "species": "predator",
        ///             "length": 20,
        ///             "age": 6,
        ///             "siblings": [
        ///                 {
        ///                     "fishtype": "salmon",
        ///                     "species": "coho",
        ///                     "length": 2,
        ///                     "age": 2,
        ///                     "location": "atlantic",
        ///                     "iswild": true,
        ///                     "siblings": [
        ///                         {
        ///                             "fishtype": "shark",
        ///                             "species": "predator",
        ///                             "length": 20,
        ///                             "age": 6
        ///                         },
        ///                         {
        ///                             "fishtype": "sawshark",
        ///                             "species": "dangerous",
        ///                             "length": 10,
        ///                             "age": 105
        ///                         }
        ///                     ]
        ///                 },
        ///                 {
        ///                     "fishtype": "sawshark",
        ///                     "species": "dangerous",
        ///                     "length": 10,
        ///                     "age": 105
        ///                 }
        ///             ]
        ///         },
        ///         {
        ///             "fishtype": "sawshark",
        ///             "species": "dangerous",
        ///             "length": 10,
        ///             "age": 105
        ///         }
        ///     ]
        /// }
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutValid(Fish complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphicrecursiveClient.PutValid");
            scope.Start();
            try
            {
                return RestClient.PutValid(complexBody, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
