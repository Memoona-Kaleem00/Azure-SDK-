// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> The type of an entity resolution. </summary>
    public readonly partial struct ResolutionKind : IEquatable<ResolutionKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResolutionKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResolutionKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DictionaryNormalizedValueValue = "DictionaryNormalizedValue";

        /// <summary> Dictionary normalized entities. </summary>
        public static ResolutionKind DictionaryNormalizedValue { get; } = new ResolutionKind(DictionaryNormalizedValueValue);
        /// <summary> Determines if two <see cref="ResolutionKind"/> values are the same. </summary>
        public static bool operator ==(ResolutionKind left, ResolutionKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResolutionKind"/> values are not the same. </summary>
        public static bool operator !=(ResolutionKind left, ResolutionKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResolutionKind"/>. </summary>
        public static implicit operator ResolutionKind(string value) => new ResolutionKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResolutionKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResolutionKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
