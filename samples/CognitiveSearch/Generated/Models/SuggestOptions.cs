// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace CognitiveSearch.Models
{
    /// <summary> Parameter group. </summary>
    public partial class SuggestOptions
    {
        /// <summary> Initializes a new instance of SuggestOptions. </summary>
        public SuggestOptions()
        {
            OrderBy = new ChangeTrackingList<string>();
            SearchFields = new ChangeTrackingList<string>();
            Select = new ChangeTrackingList<string>();
        }

        /// <summary> An OData expression that filters the documents considered for suggestions. </summary>
        public string Filter { get; set; }
        /// <summary> A value indicating whether to use fuzzy matching for the suggestions query. Default is false. When set to true, the query will find terms even if there's a substituted or missing character in the search text. While this provides a better experience in some scenarios, it comes at a performance cost as fuzzy suggestions queries are slower and consume more resources. </summary>
        public bool? UseFuzzyMatching { get; set; }
        /// <summary> A string tag that is appended to hit highlights. Must be set with highlightPreTag. If omitted, hit highlighting of suggestions is disabled. </summary>
        public string HighlightPostTag { get; set; }
        /// <summary> A string tag that is prepended to hit highlights. Must be set with highlightPostTag. If omitted, hit highlighting of suggestions is disabled. </summary>
        public string HighlightPreTag { get; set; }
        /// <summary> A number between 0 and 100 indicating the percentage of the index that must be covered by a suggestions query in order for the query to be reported as a success. This parameter can be useful for ensuring search availability even for services with only one replica. The default is 80. </summary>
        public double? MinimumCoverage { get; set; }
        /// <summary> The list of OData $orderby expressions by which to sort the results. Each expression can be either a field name or a call to either the geo.distance() or the search.score() functions. Each expression can be followed by asc to indicate ascending, or desc to indicate descending. The default is ascending order. Ties will be broken by the match scores of documents. If no $orderby is specified, the default sort order is descending by document match score. There can be at most 32 $orderby clauses. </summary>
        public IList<string> OrderBy { get; }
        /// <summary> The list of field names to search for the specified search text. Target fields must be included in the specified suggester. </summary>
        public IList<string> SearchFields { get; }
        /// <summary> The list of fields to retrieve. If unspecified, only the key field will be included in the results. </summary>
        public IList<string> Select { get; }
        /// <summary> The number of suggestions to retrieve. The value must be a number between 1 and 100. The default is 5. </summary>
        public int? Top { get; set; }
    }
}
