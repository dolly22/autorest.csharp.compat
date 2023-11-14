// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using SubscriptionExtensions;

namespace SubscriptionExtensions.Models
{
    internal partial class ToasterListResult
    {
        internal static ToasterListResult DeserializeToasterListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ToasterData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ToasterData> array = new List<ToasterData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ToasterData.DeserializeToasterData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ToasterListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
