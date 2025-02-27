// <auto-generated/>

#nullable disable

using System;

namespace OpenAI.Models
{
    /// <summary> The CreateHyperparameters. </summary>
    public partial class CreateHyperparameters
    {
        /// <summary> Initializes a new instance of CreateHyperparameters. </summary>
        public CreateHyperparameters()
        {
        }

        /// <summary> Initializes a new instance of CreateHyperparameters. </summary>
        /// <param name="nEpochs">
        /// The number of epochs to train the model for. An epoch refers to one full cycle through the
        /// training dataset.
        /// </param>
        internal CreateHyperparameters(BinaryData nEpochs)
        {
            NEpochs = nEpochs;
        }

        /// <summary>
        /// The number of epochs to train the model for. An epoch refers to one full cycle through the
        /// training dataset.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData NEpochs { get; set; }
    }
}
