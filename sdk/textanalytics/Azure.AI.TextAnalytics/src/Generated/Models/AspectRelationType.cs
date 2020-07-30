// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The type related to the aspect. </summary>
    public readonly partial struct AspectRelationType : IEquatable<AspectRelationType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AspectRelationType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AspectRelationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OpinionValue = "opinion";
        private const string AspectValue = "aspect";

        /// <summary> opinion. </summary>
        public static AspectRelationType Opinion { get; } = new AspectRelationType(OpinionValue);
        /// <summary> aspect. </summary>
        public static AspectRelationType Aspect { get; } = new AspectRelationType(AspectValue);
        /// <summary> Determines if two <see cref="AspectRelationType"/> values are the same. </summary>
        public static bool operator ==(AspectRelationType left, AspectRelationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AspectRelationType"/> values are not the same. </summary>
        public static bool operator !=(AspectRelationType left, AspectRelationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AspectRelationType"/>. </summary>
        public static implicit operator AspectRelationType(string value) => new AspectRelationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AspectRelationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AspectRelationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
