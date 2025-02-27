// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Models
{
    /// <summary> Enum for model in CreateChatCompletionRequest. </summary>
    public readonly partial struct CreateChatCompletionRequestModel : IEquatable<CreateChatCompletionRequestModel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CreateChatCompletionRequestModel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CreateChatCompletionRequestModel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Gpt4Value = "gpt4";
        private const string Gpt40314Value = "gpt-4-0314";
        private const string Gpt40613Value = "gpt-4-0613";
        private const string Gpt432kValue = "gpt-4-32k";
        private const string Gpt432k0314Value = "gpt-4-32k-0314";
        private const string Gpt432k0613Value = "gpt-4-32k-0613";
        private const string Gpt35TurboValue = "gpt-3.5-turbo";
        private const string Gpt35Turbo16kValue = "gpt-3.5-turbo-16k";
        private const string Gpt35Turbo0301Value = "gpt-3.5-turbo-0301";
        private const string Gpt35Turbo0613Value = "gpt-3.5-turbo-0613";
        private const string Gpt35Turbo16k0613Value = "gpt-3.5-turbo-16k-0613";

        /// <summary> gpt4. </summary>
        public static CreateChatCompletionRequestModel Gpt4 { get; } = new CreateChatCompletionRequestModel(Gpt4Value);
        /// <summary> gpt-4-0314. </summary>
        public static CreateChatCompletionRequestModel Gpt40314 { get; } = new CreateChatCompletionRequestModel(Gpt40314Value);
        /// <summary> gpt-4-0613. </summary>
        public static CreateChatCompletionRequestModel Gpt40613 { get; } = new CreateChatCompletionRequestModel(Gpt40613Value);
        /// <summary> gpt-4-32k. </summary>
        public static CreateChatCompletionRequestModel Gpt432k { get; } = new CreateChatCompletionRequestModel(Gpt432kValue);
        /// <summary> gpt-4-32k-0314. </summary>
        public static CreateChatCompletionRequestModel Gpt432k0314 { get; } = new CreateChatCompletionRequestModel(Gpt432k0314Value);
        /// <summary> gpt-4-32k-0613. </summary>
        public static CreateChatCompletionRequestModel Gpt432k0613 { get; } = new CreateChatCompletionRequestModel(Gpt432k0613Value);
        /// <summary> gpt-3.5-turbo. </summary>
        public static CreateChatCompletionRequestModel Gpt35Turbo { get; } = new CreateChatCompletionRequestModel(Gpt35TurboValue);
        /// <summary> gpt-3.5-turbo-16k. </summary>
        public static CreateChatCompletionRequestModel Gpt35Turbo16k { get; } = new CreateChatCompletionRequestModel(Gpt35Turbo16kValue);
        /// <summary> gpt-3.5-turbo-0301. </summary>
        public static CreateChatCompletionRequestModel Gpt35Turbo0301 { get; } = new CreateChatCompletionRequestModel(Gpt35Turbo0301Value);
        /// <summary> gpt-3.5-turbo-0613. </summary>
        public static CreateChatCompletionRequestModel Gpt35Turbo0613 { get; } = new CreateChatCompletionRequestModel(Gpt35Turbo0613Value);
        /// <summary> gpt-3.5-turbo-16k-0613. </summary>
        public static CreateChatCompletionRequestModel Gpt35Turbo16k0613 { get; } = new CreateChatCompletionRequestModel(Gpt35Turbo16k0613Value);
        /// <summary> Determines if two <see cref="CreateChatCompletionRequestModel"/> values are the same. </summary>
        public static bool operator ==(CreateChatCompletionRequestModel left, CreateChatCompletionRequestModel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CreateChatCompletionRequestModel"/> values are not the same. </summary>
        public static bool operator !=(CreateChatCompletionRequestModel left, CreateChatCompletionRequestModel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CreateChatCompletionRequestModel"/>. </summary>
        public static implicit operator CreateChatCompletionRequestModel(string value) => new CreateChatCompletionRequestModel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CreateChatCompletionRequestModel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CreateChatCompletionRequestModel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
