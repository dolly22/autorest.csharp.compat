// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace additionalProperties.Models
{
    /// <summary> The PetAPString. </summary>
    public partial class PetAPString
    {
        /// <summary> Initializes a new instance of PetAPString. </summary>
        /// <param name="id"></param>
        public PetAPString(int id)
        {
            Id = id;
            AdditionalProperties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of PetAPString. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal PetAPString(int id, string name, bool? status, IDictionary<string, string> additionalProperties)
        {
            Id = id;
            Name = name;
            Status = status;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Gets or sets the id. </summary>
        public int Id { get; set; }
        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Gets the status. </summary>
        public bool? Status { get; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, string> AdditionalProperties { get; }
    }
}
