// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel.Core;
using System.Net.ClientModel.Internal;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class CreateCompletionResponse
    {
        internal static CreateCompletionResponse DeserializeCreateCompletionResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string @object = default;
            DateTimeOffset created = default;
            string model = default;
            IReadOnlyList<CreateCompletionResponseChoice> choices = default;
            OptionalProperty<CompletionUsage> usage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("object"u8))
                {
                    @object = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("created"u8))
                {
                    created = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("choices"u8))
                {
                    List<CreateCompletionResponseChoice> array = new List<CreateCompletionResponseChoice>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CreateCompletionResponseChoice.DeserializeCreateCompletionResponseChoice(item));
                    }
                    choices = array;
                    continue;
                }
                if (property.NameEquals("usage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usage = CompletionUsage.DeserializeCompletionUsage(property.Value);
                    continue;
                }
            }
            return new CreateCompletionResponse(id, @object, created, model, choices, usage.Value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static CreateCompletionResponse FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCreateCompletionResponse(document.RootElement);
        }
    }
}
