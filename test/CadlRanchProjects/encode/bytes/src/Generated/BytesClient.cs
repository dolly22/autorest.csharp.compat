// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Encode.Bytes
{
    // Data plane generated client.
    /// <summary> The Bytes service client. </summary>
    public partial class BytesClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of BytesClient. </summary>
        public BytesClient() : this(new Uri("http://localhost:3000"), new BytesClientOptions())
        {
        }

        /// <summary> Initializes a new instance of BytesClient. </summary>
        /// <param name="endpoint"> TestServer endpoint. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public BytesClient(Uri endpoint, BytesClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new BytesClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <summary> Initializes a new instance of Query. </summary>
        /// <param name="apiVersion"> The String to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual Query GetQueryClient(string apiVersion = "1.0.0")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new Query(ClientDiagnostics, _pipeline, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of Property. </summary>
        /// <param name="apiVersion"> The String to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual Property GetPropertyClient(string apiVersion = "1.0.0")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new Property(ClientDiagnostics, _pipeline, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of Header. </summary>
        /// <param name="apiVersion"> The String to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual Header GetHeaderClient(string apiVersion = "1.0.0")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new Header(ClientDiagnostics, _pipeline, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of RequestBody. </summary>
        /// <param name="apiVersion"> The String to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual RequestBody GetRequestBodyClient(string apiVersion = "1.0.0")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new RequestBody(ClientDiagnostics, _pipeline, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of ResponseBody. </summary>
        /// <param name="apiVersion"> The String to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual ResponseBody GetResponseBodyClient(string apiVersion = "1.0.0")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new ResponseBody(ClientDiagnostics, _pipeline, _endpoint, apiVersion);
        }
    }
}
