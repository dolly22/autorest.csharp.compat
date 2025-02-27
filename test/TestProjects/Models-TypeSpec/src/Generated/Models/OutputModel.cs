// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace ModelsTypeSpec.Models
{
    /// <summary> Model used only as output. </summary>
    public partial class OutputModel
    {
        /// <summary> Initializes a new instance of OutputModel. </summary>
        /// <param name="requiredString"> Required string. </param>
        /// <param name="requiredInt"> Required int. </param>
        /// <param name="requiredModel"> Required model. </param>
        /// <param name="requiredList"> Required collection. </param>
        /// <param name="requiredModelRecord"> Required model record. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredString"/>, <paramref name="requiredModel"/>, <paramref name="requiredList"/> or <paramref name="requiredModelRecord"/> is null. </exception>
        internal OutputModel(string requiredString, int requiredInt, DerivedModel requiredModel, IEnumerable<CollectionItem> requiredList, IReadOnlyDictionary<string, RecordItem> requiredModelRecord)
        {
            Argument.AssertNotNull(requiredString, nameof(requiredString));
            Argument.AssertNotNull(requiredModel, nameof(requiredModel));
            Argument.AssertNotNull(requiredList, nameof(requiredList));
            Argument.AssertNotNull(requiredModelRecord, nameof(requiredModelRecord));

            RequiredString = requiredString;
            RequiredInt = requiredInt;
            RequiredModel = requiredModel;
            RequiredList = requiredList.ToList();
            RequiredModelRecord = requiredModelRecord;
            OptionalList = new ChangeTrackingList<CollectionItem>();
            OptionalNullableList = new ChangeTrackingList<CollectionItem>();
            OptionalRecord = new ChangeTrackingDictionary<string, RecordItem>();
            OptionalNullableRecord = new ChangeTrackingDictionary<string, RecordItem>();
        }

        /// <summary> Initializes a new instance of OutputModel. </summary>
        /// <param name="requiredString"> Required string. </param>
        /// <param name="requiredInt"> Required int. </param>
        /// <param name="requiredModel"> Required model. </param>
        /// <param name="requiredList"> Required collection. </param>
        /// <param name="requiredModelRecord"> Required model record. </param>
        /// <param name="optionalList"> Optional model collection. </param>
        /// <param name="optionalNullableList"> Optional model nullable collection. </param>
        /// <param name="optionalRecord"> Optional model record. </param>
        /// <param name="optionalNullableRecord"> Optional model nullable record. </param>
        internal OutputModel(string requiredString, int requiredInt, DerivedModel requiredModel, IReadOnlyList<CollectionItem> requiredList, IReadOnlyDictionary<string, RecordItem> requiredModelRecord, IReadOnlyList<CollectionItem> optionalList, IReadOnlyList<CollectionItem> optionalNullableList, IReadOnlyDictionary<string, RecordItem> optionalRecord, IReadOnlyDictionary<string, RecordItem> optionalNullableRecord)
        {
            RequiredString = requiredString;
            RequiredInt = requiredInt;
            RequiredModel = requiredModel;
            RequiredList = requiredList;
            RequiredModelRecord = requiredModelRecord;
            OptionalList = optionalList;
            OptionalNullableList = optionalNullableList;
            OptionalRecord = optionalRecord;
            OptionalNullableRecord = optionalNullableRecord;
        }

        /// <summary> Required string. </summary>
        public string RequiredString { get; }
        /// <summary> Required int. </summary>
        public int RequiredInt { get; }
        /// <summary> Required model. </summary>
        public DerivedModel RequiredModel { get; }
        /// <summary> Required collection. </summary>
        public IReadOnlyList<CollectionItem> RequiredList { get; }
        /// <summary> Required model record. </summary>
        public IReadOnlyDictionary<string, RecordItem> RequiredModelRecord { get; }
        /// <summary> Optional model collection. </summary>
        public IReadOnlyList<CollectionItem> OptionalList { get; }
        /// <summary> Optional model nullable collection. </summary>
        public IReadOnlyList<CollectionItem> OptionalNullableList { get; }
        /// <summary> Optional model record. </summary>
        public IReadOnlyDictionary<string, RecordItem> OptionalRecord { get; }
        /// <summary> Optional model nullable record. </summary>
        public IReadOnlyDictionary<string, RecordItem> OptionalNullableRecord { get; }
    }
}
