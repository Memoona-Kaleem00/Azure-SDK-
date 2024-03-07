// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> The InternalFileDeletionStatus_object. </summary>
    internal readonly partial struct InternalFileDeletionStatusObject : IEquatable<InternalFileDeletionStatusObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InternalFileDeletionStatusObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InternalFileDeletionStatusObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FileValue = "file";

        /// <summary> file. </summary>
        public static InternalFileDeletionStatusObject File { get; } = new InternalFileDeletionStatusObject(FileValue);
        /// <summary> Determines if two <see cref="InternalFileDeletionStatusObject"/> values are the same. </summary>
        public static bool operator ==(InternalFileDeletionStatusObject left, InternalFileDeletionStatusObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InternalFileDeletionStatusObject"/> values are not the same. </summary>
        public static bool operator !=(InternalFileDeletionStatusObject left, InternalFileDeletionStatusObject right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InternalFileDeletionStatusObject"/>. </summary>
        public static implicit operator InternalFileDeletionStatusObject(string value) => new InternalFileDeletionStatusObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalFileDeletionStatusObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InternalFileDeletionStatusObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
