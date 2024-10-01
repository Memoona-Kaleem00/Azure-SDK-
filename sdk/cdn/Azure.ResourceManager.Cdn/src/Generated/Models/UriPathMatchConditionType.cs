// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The UriPathMatchConditionType. </summary>
    public readonly partial struct UriPathMatchConditionType : IEquatable<UriPathMatchConditionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UriPathMatchConditionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UriPathMatchConditionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UriPathMatchConditionValue = "DeliveryRuleUrlPathMatchConditionParameters";

        /// <summary> DeliveryRuleUrlPathMatchConditionParameters. </summary>
        public static UriPathMatchConditionType UriPathMatchCondition { get; } = new UriPathMatchConditionType(UriPathMatchConditionValue);
        /// <summary> Determines if two <see cref="UriPathMatchConditionType"/> values are the same. </summary>
        public static bool operator ==(UriPathMatchConditionType left, UriPathMatchConditionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UriPathMatchConditionType"/> values are not the same. </summary>
        public static bool operator !=(UriPathMatchConditionType left, UriPathMatchConditionType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="UriPathMatchConditionType"/>. </summary>
        public static implicit operator UriPathMatchConditionType(string value) => new UriPathMatchConditionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UriPathMatchConditionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UriPathMatchConditionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
