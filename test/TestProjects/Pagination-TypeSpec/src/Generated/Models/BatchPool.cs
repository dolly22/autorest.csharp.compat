// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Pagination.Models
{
    /// <summary> A Pool in the Azure Batch service. </summary>
    public partial class BatchPool
    {
        /// <summary> Initializes a new instance of BatchPool. </summary>
        internal BatchPool()
        {
        }

        /// <summary> Initializes a new instance of BatchPool. </summary>
        /// <param name="id"> A string that uniquely identifies the Pool within the Account. The ID can contain any combination of alphanumeric characters including hyphens and underscores, and cannot contain more than 64 characters. The ID is case-preserving and case-insensitive (that is, you may not have two IDs within an Account that differ only by case). </param>
        /// <param name="displayName"> The display name for the Pool. The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024. </param>
        /// <param name="url"> The URL of the Pool. </param>
        internal BatchPool(string id, string displayName, string url)
        {
            Id = id;
            DisplayName = displayName;
            Url = url;
        }

        /// <summary> A string that uniquely identifies the Pool within the Account. The ID can contain any combination of alphanumeric characters including hyphens and underscores, and cannot contain more than 64 characters. The ID is case-preserving and case-insensitive (that is, you may not have two IDs within an Account that differ only by case). </summary>
        public string Id { get; }
        /// <summary> The display name for the Pool. The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024. </summary>
        public string DisplayName { get; }
        /// <summary> The URL of the Pool. </summary>
        public string Url { get; }
    }
}
