// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Type of the delivery attribute or header name. </summary>
    internal readonly partial struct DeliveryAttributeMappingType : IEquatable<DeliveryAttributeMappingType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeliveryAttributeMappingType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeliveryAttributeMappingType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StaticValue = "Static";
        private const string DynamicValue = "Dynamic";

        /// <summary> Static. </summary>
        public static DeliveryAttributeMappingType Static { get; } = new DeliveryAttributeMappingType(StaticValue);
        /// <summary> Dynamic. </summary>
        public static DeliveryAttributeMappingType Dynamic { get; } = new DeliveryAttributeMappingType(DynamicValue);
        /// <summary> Determines if two <see cref="DeliveryAttributeMappingType"/> values are the same. </summary>
        public static bool operator ==(DeliveryAttributeMappingType left, DeliveryAttributeMappingType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeliveryAttributeMappingType"/> values are not the same. </summary>
        public static bool operator !=(DeliveryAttributeMappingType left, DeliveryAttributeMappingType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DeliveryAttributeMappingType"/>. </summary>
        public static implicit operator DeliveryAttributeMappingType(string value) => new DeliveryAttributeMappingType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeliveryAttributeMappingType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeliveryAttributeMappingType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
