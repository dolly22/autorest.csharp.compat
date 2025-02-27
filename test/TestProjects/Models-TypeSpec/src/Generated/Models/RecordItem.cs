// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace ModelsTypeSpec.Models
{
    /// <summary> Record item model. </summary>
    public partial class RecordItem : DerivedModel
    {
        /// <summary> Initializes a new instance of RecordItem. </summary>
        /// <param name="requiredList"> Required collection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredList"/> is null. </exception>
        public RecordItem(IEnumerable<CollectionItem> requiredList) : base(requiredList)
        {
            Argument.AssertNotNull(requiredList, nameof(requiredList));
        }

        /// <summary> Initializes a new instance of RecordItem. </summary>
        /// <param name="requiredList"> Required collection. </param>
        internal RecordItem(IList<CollectionItem> requiredList) : base(requiredList)
        {
        }
    }
}
