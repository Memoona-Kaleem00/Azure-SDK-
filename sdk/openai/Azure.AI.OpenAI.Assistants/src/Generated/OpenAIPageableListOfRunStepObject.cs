// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> The OpenAIPageableListOfRunStep_object. </summary>
    internal readonly partial struct OpenAIPageableListOfRunStepObject : IEquatable<OpenAIPageableListOfRunStepObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OpenAIPageableListOfRunStepObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OpenAIPageableListOfRunStepObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ListValue = "list";

        /// <summary> list. </summary>
        public static OpenAIPageableListOfRunStepObject List { get; } = new OpenAIPageableListOfRunStepObject(ListValue);
        /// <summary> Determines if two <see cref="OpenAIPageableListOfRunStepObject"/> values are the same. </summary>
        public static bool operator ==(OpenAIPageableListOfRunStepObject left, OpenAIPageableListOfRunStepObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OpenAIPageableListOfRunStepObject"/> values are not the same. </summary>
        public static bool operator !=(OpenAIPageableListOfRunStepObject left, OpenAIPageableListOfRunStepObject right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OpenAIPageableListOfRunStepObject"/>. </summary>
        public static implicit operator OpenAIPageableListOfRunStepObject(string value) => new OpenAIPageableListOfRunStepObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OpenAIPageableListOfRunStepObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OpenAIPageableListOfRunStepObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
