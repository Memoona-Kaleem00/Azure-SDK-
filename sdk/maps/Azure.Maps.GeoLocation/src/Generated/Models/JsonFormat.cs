// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.GeoLocation
{
    /// <summary> The JsonFormat. </summary>
    internal readonly partial struct JsonFormat : IEquatable<JsonFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="JsonFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JsonFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string JsonValue = "json";

        /// <summary> [The JavaScript Object Notation Data Interchange Format](https://tools.ietf.org/html/rfc8259). </summary>
        public static JsonFormat Json { get; } = new JsonFormat(JsonValue);
        /// <summary> Determines if two <see cref="JsonFormat"/> values are the same. </summary>
        public static bool operator ==(JsonFormat left, JsonFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JsonFormat"/> values are not the same. </summary>
        public static bool operator !=(JsonFormat left, JsonFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JsonFormat"/>. </summary>
        public static implicit operator JsonFormat(string value) => new JsonFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JsonFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JsonFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
