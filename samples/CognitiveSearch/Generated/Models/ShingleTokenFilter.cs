// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace CognitiveSearch.Models
{
    /// <summary> Creates combinations of tokens as a single token. This token filter is implemented using Apache Lucene. </summary>
    public partial class ShingleTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of ShingleTokenFilter. </summary>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ShingleTokenFilter(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            OdataType = "#Microsoft.Azure.Search.ShingleTokenFilter";
        }

        /// <summary> Initializes a new instance of ShingleTokenFilter. </summary>
        /// <param name="odataType"> Identifies the concrete type of the token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="maxShingleSize"> The maximum shingle size. Default and minimum value is 2. </param>
        /// <param name="minShingleSize"> The minimum shingle size. Default and minimum value is 2. Must be less than the value of maxShingleSize. </param>
        /// <param name="outputUnigrams"> A value indicating whether the output stream will contain the input tokens (unigrams) as well as shingles. Default is true. </param>
        /// <param name="outputUnigramsIfNoShingles"> A value indicating whether to output unigrams for those times when no shingles are available. This property takes precedence when outputUnigrams is set to false. Default is false. </param>
        /// <param name="tokenSeparator"> The string to use when joining adjacent tokens to form a shingle. Default is a single space (" "). </param>
        /// <param name="filterToken"> The string to insert for each position at which there is no token. Default is an underscore ("_"). </param>
        internal ShingleTokenFilter(string odataType, string name, int? maxShingleSize, int? minShingleSize, bool? outputUnigrams, bool? outputUnigramsIfNoShingles, string tokenSeparator, string filterToken) : base(odataType, name)
        {
            MaxShingleSize = maxShingleSize;
            MinShingleSize = minShingleSize;
            OutputUnigrams = outputUnigrams;
            OutputUnigramsIfNoShingles = outputUnigramsIfNoShingles;
            TokenSeparator = tokenSeparator;
            FilterToken = filterToken;
            OdataType = odataType ?? "#Microsoft.Azure.Search.ShingleTokenFilter";
        }

        /// <summary> The maximum shingle size. Default and minimum value is 2. </summary>
        public int? MaxShingleSize { get; set; }
        /// <summary> The minimum shingle size. Default and minimum value is 2. Must be less than the value of maxShingleSize. </summary>
        public int? MinShingleSize { get; set; }
        /// <summary> A value indicating whether the output stream will contain the input tokens (unigrams) as well as shingles. Default is true. </summary>
        public bool? OutputUnigrams { get; set; }
        /// <summary> A value indicating whether to output unigrams for those times when no shingles are available. This property takes precedence when outputUnigrams is set to false. Default is false. </summary>
        public bool? OutputUnigramsIfNoShingles { get; set; }
        /// <summary> The string to use when joining adjacent tokens to form a shingle. Default is a single space (" "). </summary>
        public string TokenSeparator { get; set; }
        /// <summary> The string to insert for each position at which there is no token. Default is an underscore ("_"). </summary>
        public string FilterToken { get; set; }
    }
}
