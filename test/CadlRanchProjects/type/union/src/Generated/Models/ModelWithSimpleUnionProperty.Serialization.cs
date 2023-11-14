// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace _Type.Union.Models
{
    public partial class ModelWithSimpleUnionProperty : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("simpleUnion"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SimpleUnion);
#else
            using (JsonDocument document = JsonDocument.Parse(SimpleUnion))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
