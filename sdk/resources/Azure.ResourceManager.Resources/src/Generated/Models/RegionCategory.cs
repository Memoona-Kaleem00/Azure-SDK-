// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Resources
{
    /// <summary> The category of the region. </summary>
    internal readonly partial struct RegionCategory : IEquatable<RegionCategory>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="RegionCategory"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RegionCategory(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RecommendedValue = "Recommended";
        private const string ExtendedValue = "Extended";
        private const string OtherValue = "Other";

        /// <summary> Recommended. </summary>
        public static RegionCategory Recommended { get; } = new RegionCategory(RecommendedValue);
        /// <summary> Extended. </summary>
        public static RegionCategory Extended { get; } = new RegionCategory(ExtendedValue);
        /// <summary> Other. </summary>
        public static RegionCategory Other { get; } = new RegionCategory(OtherValue);
        /// <summary> Determines if two <see cref="RegionCategory"/> values are the same. </summary>
        public static bool operator ==(RegionCategory left, RegionCategory right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RegionCategory"/> values are not the same. </summary>
        public static bool operator !=(RegionCategory left, RegionCategory right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RegionCategory"/>. </summary>
        public static implicit operator RegionCategory(string value) => new RegionCategory(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RegionCategory other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RegionCategory other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
