// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class RoutingPreference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RoutingChoice))
            {
                writer.WritePropertyName("routingChoice"u8);
                writer.WriteStringValue(RoutingChoice.Value.ToString());
            }
            if (Optional.IsDefined(PublishMicrosoftEndpoints))
            {
                writer.WritePropertyName("publishMicrosoftEndpoints"u8);
                writer.WriteBooleanValue(PublishMicrosoftEndpoints.Value);
            }
            if (Optional.IsDefined(PublishInternetEndpoints))
            {
                writer.WritePropertyName("publishInternetEndpoints"u8);
                writer.WriteBooleanValue(PublishInternetEndpoints.Value);
            }
            writer.WriteEndObject();
        }

        internal static RoutingPreference DeserializeRoutingPreference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RoutingChoice> routingChoice = default;
            Optional<bool> publishMicrosoftEndpoints = default;
            Optional<bool> publishInternetEndpoints = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routingChoice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routingChoice = new RoutingChoice(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publishMicrosoftEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publishMicrosoftEndpoints = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("publishInternetEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publishInternetEndpoints = property.Value.GetBoolean();
                    continue;
                }
            }
            return new RoutingPreference(Optional.ToNullable(routingChoice), Optional.ToNullable(publishMicrosoftEndpoints), Optional.ToNullable(publishInternetEndpoints));
        }
    }
}
