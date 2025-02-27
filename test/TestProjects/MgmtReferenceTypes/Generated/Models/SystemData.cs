// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Fake.Models
{
    /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
    [PropertyReferenceType]
    public partial class SystemData
    {
        /// <summary> Initializes a new instance of SystemData. </summary>
        [InitializationConstructor]
        public SystemData()
        {
        }

        /// <summary> Initializes a new instance of SystemData. </summary>
        /// <param name="createdBy"> The identity that created the resource. </param>
        /// <param name="createdByType"> The type of identity that created the resource. </param>
        /// <param name="createdOn"> The timestamp of resource creation (UTC). </param>
        /// <param name="lastModifiedBy"> The identity that last modified the resource. </param>
        /// <param name="lastModifiedByType"> The type of identity that last modified the resource. </param>
        /// <param name="lastModifiedOn"> The timestamp of resource last modification (UTC). </param>
        [SerializationConstructor]
        internal SystemData(string createdBy, CreatedByType? createdByType, DateTimeOffset? createdOn, string lastModifiedBy, CreatedByType? lastModifiedByType, DateTimeOffset? lastModifiedOn)
        {
            CreatedBy = createdBy;
            CreatedByType = createdByType;
            CreatedOn = createdOn;
            LastModifiedBy = lastModifiedBy;
            LastModifiedByType = lastModifiedByType;
            LastModifiedOn = lastModifiedOn;
        }

        /// <summary> The identity that created the resource. </summary>
        public string CreatedBy { get; set; }
        /// <summary> The type of identity that created the resource. </summary>
        public CreatedByType? CreatedByType { get; set; }
        /// <summary> The timestamp of resource creation (UTC). </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> The identity that last modified the resource. </summary>
        public string LastModifiedBy { get; set; }
        /// <summary> The type of identity that last modified the resource. </summary>
        public CreatedByType? LastModifiedByType { get; set; }
        /// <summary> The timestamp of resource last modification (UTC). </summary>
        public DateTimeOffset? LastModifiedOn { get; set; }
    }
}
