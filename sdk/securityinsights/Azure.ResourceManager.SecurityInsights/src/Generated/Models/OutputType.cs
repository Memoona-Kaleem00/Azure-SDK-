// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Insights Column type. </summary>
    public readonly partial struct OutputType : IEquatable<OutputType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OutputType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OutputType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NumberValue = "Number";
        private const string StringValue = "String";
        private const string DateValue = "Date";
        private const string EntityValue = "Entity";

        /// <summary> Number. </summary>
        public static OutputType Number { get; } = new OutputType(NumberValue);
        /// <summary> String. </summary>
        public static OutputType String { get; } = new OutputType(StringValue);
        /// <summary> Date. </summary>
        public static OutputType Date { get; } = new OutputType(DateValue);
        /// <summary> Entity. </summary>
        public static OutputType Entity { get; } = new OutputType(EntityValue);
        /// <summary> Determines if two <see cref="OutputType"/> values are the same. </summary>
        public static bool operator ==(OutputType left, OutputType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OutputType"/> values are not the same. </summary>
        public static bool operator !=(OutputType left, OutputType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OutputType"/>. </summary>
        public static implicit operator OutputType(string value) => new OutputType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OutputType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OutputType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
