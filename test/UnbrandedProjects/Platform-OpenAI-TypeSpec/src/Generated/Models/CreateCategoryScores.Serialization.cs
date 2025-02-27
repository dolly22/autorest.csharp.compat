// <auto-generated/>

#nullable disable

using System.Net.ClientModel.Core;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class CreateCategoryScores
    {
        internal static CreateCategoryScores DeserializeCreateCategoryScores(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double hate = default;
            double hateThreatening = default;
            double harassment = default;
            double harassmentThreatening = default;
            double selfHarm = default;
            double selfHarmIntent = default;
            double selfHarmInstructive = default;
            double sexual = default;
            double sexualMinors = default;
            double violence = default;
            double violenceGraphic = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hate"u8))
                {
                    hate = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("hate/threatening"u8))
                {
                    hateThreatening = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("harassment"u8))
                {
                    harassment = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("harassment/threatening"u8))
                {
                    harassmentThreatening = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("self-harm"u8))
                {
                    selfHarm = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("self-harm/intent"u8))
                {
                    selfHarmIntent = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("self-harm/instructive"u8))
                {
                    selfHarmInstructive = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("sexual"u8))
                {
                    sexual = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("sexual/minors"u8))
                {
                    sexualMinors = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("violence"u8))
                {
                    violence = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("violence/graphic"u8))
                {
                    violenceGraphic = property.Value.GetDouble();
                    continue;
                }
            }
            return new CreateCategoryScores(hate, hateThreatening, harassment, harassmentThreatening, selfHarm, selfHarmIntent, selfHarmInstructive, sexual, sexualMinors, violence, violenceGraphic);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static CreateCategoryScores FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCreateCategoryScores(document.RootElement);
        }
    }
}
