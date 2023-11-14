// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace PetStore.Models
{
    public partial class Shark
    {
        internal static Shark DeserializeShark(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string bite = default;
            string kind = default;
            int size = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bite"u8))
                {
                    bite = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    size = property.Value.GetInt32();
                    continue;
                }
            }
            return new Shark(kind, size, bite);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new Shark FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeShark(document.RootElement);
        }
    }
}
