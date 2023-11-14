// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using custom_baseUrl_paging.Models;

namespace custom_baseUrl_paging
{
    /// <summary> The Paging service client. </summary>
    public partial class PagingClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PagingRestClient RestClient { get; }

        /// <summary> Initializes a new instance of PagingClient for mocking. </summary>
        protected PagingClient()
        {
        }

        /// <summary> Initializes a new instance of PagingClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="host"> A string value that is used as a global part of the parameterized host. The default value is "host". </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="host"/> is null. </exception>
        internal PagingClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host)
        {
            RestClient = new PagingRestClient(clientDiagnostics, pipeline, host);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL and expect to concat after host. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual AsyncPageable<Product> GetPagesPartialUrlAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateGetPagesPartialUrlRequest(accountName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateGetPagesPartialUrlNextPageRequest(nextLink, accountName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, Product.DeserializeProduct, _clientDiagnostics, _pipeline, "PagingClient.GetPagesPartialUrl", "values", "nextLink", cancellationToken);
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL and expect to concat after host. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Pageable<Product> GetPagesPartialUrl(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateGetPagesPartialUrlRequest(accountName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateGetPagesPartialUrlNextPageRequest(nextLink, accountName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, Product.DeserializeProduct, _clientDiagnostics, _pipeline, "PagingClient.GetPagesPartialUrl", "values", "nextLink", cancellationToken);
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL with next operation. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual AsyncPageable<Product> GetPagesPartialUrlOperationAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateGetPagesPartialUrlOperationRequest(accountName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateGetPagesPartialUrlOperationNextRequest(accountName, nextLink);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, Product.DeserializeProduct, _clientDiagnostics, _pipeline, "PagingClient.GetPagesPartialUrlOperation", "values", "nextLink", cancellationToken);
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL with next operation. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Pageable<Product> GetPagesPartialUrlOperation(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));

            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateGetPagesPartialUrlOperationRequest(accountName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateGetPagesPartialUrlOperationNextRequest(accountName, nextLink);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, Product.DeserializeProduct, _clientDiagnostics, _pipeline, "PagingClient.GetPagesPartialUrlOperation", "values", "nextLink", cancellationToken);
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="nextLink"/> is null. </exception>
        public virtual AsyncPageable<Product> GetPagesPartialUrlOperationNextAsync(string accountName, string nextLink, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateGetPagesPartialUrlOperationNextRequest(accountName, nextLink);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateGetPagesPartialUrlOperationNextRequest(accountName, nextLink);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, Product.DeserializeProduct, _clientDiagnostics, _pipeline, "PagingClient.GetPagesPartialUrlOperationNext", "values", "nextLink", cancellationToken);
        }

        /// <summary> A paging operation that combines custom url, paging and partial URL. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="nextLink"/> is null. </exception>
        public virtual Pageable<Product> GetPagesPartialUrlOperationNext(string accountName, string nextLink, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateGetPagesPartialUrlOperationNextRequest(accountName, nextLink);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateGetPagesPartialUrlOperationNextRequest(accountName, nextLink);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, Product.DeserializeProduct, _clientDiagnostics, _pipeline, "PagingClient.GetPagesPartialUrlOperationNext", "values", "nextLink", cancellationToken);
        }
    }
}
