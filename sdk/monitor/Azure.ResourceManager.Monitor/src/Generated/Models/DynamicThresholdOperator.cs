// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The operator used to compare the metric value against the threshold. </summary>
    public readonly partial struct DynamicThresholdOperator : IEquatable<DynamicThresholdOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DynamicThresholdOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DynamicThresholdOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GreaterThanValue = "GreaterThan";
        private const string LessThanValue = "LessThan";
        private const string GreaterOrLessThanValue = "GreaterOrLessThan";

        /// <summary> GreaterThan. </summary>
        public static DynamicThresholdOperator GreaterThan { get; } = new DynamicThresholdOperator(GreaterThanValue);
        /// <summary> LessThan. </summary>
        public static DynamicThresholdOperator LessThan { get; } = new DynamicThresholdOperator(LessThanValue);
        /// <summary> GreaterOrLessThan. </summary>
        public static DynamicThresholdOperator GreaterOrLessThan { get; } = new DynamicThresholdOperator(GreaterOrLessThanValue);
        /// <summary> Determines if two <see cref="DynamicThresholdOperator"/> values are the same. </summary>
        public static bool operator ==(DynamicThresholdOperator left, DynamicThresholdOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DynamicThresholdOperator"/> values are not the same. </summary>
        public static bool operator !=(DynamicThresholdOperator left, DynamicThresholdOperator right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DynamicThresholdOperator"/>. </summary>
        public static implicit operator DynamicThresholdOperator(string value) => new DynamicThresholdOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DynamicThresholdOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DynamicThresholdOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
