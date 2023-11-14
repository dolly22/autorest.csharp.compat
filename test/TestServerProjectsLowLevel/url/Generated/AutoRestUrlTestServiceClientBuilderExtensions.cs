// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core.Extensions;
using url_LowLevel;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="PathsClient"/>, <see cref="QueriesClient"/>, <see cref="PathItemsClient"/> to client builder. </summary>
    public static partial class AutoRestUrlTestServiceClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="PathsClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        public static IAzureClientBuilder<PathsClient, AutoRestUrlTestServiceClientOptions> AddPathsClient<TBuilder>(this TBuilder builder, AzureKeyCredential credential, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<PathsClient, AutoRestUrlTestServiceClientOptions>((options) => new PathsClient(credential, endpoint, options));
        }

        /// <summary> Registers a <see cref="QueriesClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        public static IAzureClientBuilder<QueriesClient, AutoRestUrlTestServiceClientOptions> AddQueriesClient<TBuilder>(this TBuilder builder, AzureKeyCredential credential, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<QueriesClient, AutoRestUrlTestServiceClientOptions>((options) => new QueriesClient(credential, endpoint, options));
        }

        /// <summary> Registers a <see cref="PathItemsClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="globalStringPath"> A string value &apos;globalItemStringPath&apos; that appears in the path. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="globalStringQuery"> should contain value null. </param>
        public static IAzureClientBuilder<PathItemsClient, AutoRestUrlTestServiceClientOptions> AddPathItemsClient<TBuilder>(this TBuilder builder, string globalStringPath, AzureKeyCredential credential, Uri endpoint, string globalStringQuery)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<PathItemsClient, AutoRestUrlTestServiceClientOptions>((options) => new PathItemsClient(globalStringPath, credential, endpoint, globalStringQuery, options));
        }

        /// <summary> Registers a <see cref="PathsClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<PathsClient, AutoRestUrlTestServiceClientOptions> AddPathsClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<PathsClient, AutoRestUrlTestServiceClientOptions>(configuration);
        }
        /// <summary> Registers a <see cref="QueriesClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<QueriesClient, AutoRestUrlTestServiceClientOptions> AddQueriesClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<QueriesClient, AutoRestUrlTestServiceClientOptions>(configuration);
        }
        /// <summary> Registers a <see cref="PathItemsClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<PathItemsClient, AutoRestUrlTestServiceClientOptions> AddPathItemsClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<PathItemsClient, AutoRestUrlTestServiceClientOptions>(configuration);
        }
    }
}
