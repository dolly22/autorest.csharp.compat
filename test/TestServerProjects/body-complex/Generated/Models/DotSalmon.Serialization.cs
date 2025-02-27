// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace body_complex.Models
{
    public partial class DotSalmon
    {
        internal static DotSalmon DeserializeDotSalmon(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> location = default;
            Optional<bool> iswild = default;
            string fishType = default;
            Optional<string> species = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iswild"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    iswild = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("fish.type"u8))
                {
                    fishType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("species"u8))
                {
                    species = property.Value.GetString();
                    continue;
                }
            }
            return new DotSalmon(fishType, species.Value, location.Value, Optional.ToNullable(iswild));
        }
    }
}
