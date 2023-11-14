// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    public partial class TrainingDocumentInfo
    {
        internal static TrainingDocumentInfo DeserializeTrainingDocumentInfo(JsonElement element)
        {
            string documentName = default;
            int pages = default;
            IReadOnlyList<ErrorInformation> errors = default;
            TrainStatus status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documentName"u8))
                {
                    documentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pages"u8))
                {
                    pages = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    List<ErrorInformation> array = new List<ErrorInformation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ErrorInformation.DeserializeErrorInformation(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString().ToTrainStatus();
                    continue;
                }
            }
            return new TrainingDocumentInfo(documentName, pages, errors, status);
        }
    }
}
