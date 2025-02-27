// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace body_formdata_urlencoded.Models
{
    /// <summary> The PathsPvivzlFormsdataurlencodedPartialconstantbodyPostRequestbodyContentApplicationXWwwFormUrlencodedSchema. </summary>
    internal partial class PathsPvivzlFormsdataurlencodedPartialconstantbodyPostRequestbodyContentApplicationXWwwFormUrlencodedSchema
    {
        /// <summary> Initializes a new instance of PathsPvivzlFormsdataurlencodedPartialconstantbodyPostRequestbodyContentApplicationXWwwFormUrlencodedSchema. </summary>
        /// <param name="service"> Indicates the name of your Azure container registry. </param>
        /// <param name="aadAccessToken"> AAD access token, mandatory when grant_type is access_token_refresh_token or access_token. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="service"/> or <paramref name="aadAccessToken"/> is null. </exception>
        internal PathsPvivzlFormsdataurlencodedPartialconstantbodyPostRequestbodyContentApplicationXWwwFormUrlencodedSchema(string service, string aadAccessToken)
        {
            Argument.AssertNotNull(service, nameof(service));
            Argument.AssertNotNull(aadAccessToken, nameof(aadAccessToken));

            GrantType = PostContentSchemaGrantType.AccessToken;
            Service = service;
            AadAccessToken = aadAccessToken;
        }

        /// <summary> Constant part of a formdata body. </summary>
        public PostContentSchemaGrantType GrantType { get; }
        /// <summary> Indicates the name of your Azure container registry. </summary>
        public string Service { get; }
        /// <summary> AAD access token, mandatory when grant_type is access_token_refresh_token or access_token. </summary>
        public string AadAccessToken { get; }
    }
}
