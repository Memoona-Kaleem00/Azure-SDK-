// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Metric Trigger Evaluation Type. </summary>
    public readonly partial struct MetricTriggerType : IEquatable<MetricTriggerType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MetricTriggerType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MetricTriggerType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ConsecutiveValue = "Consecutive";
        private const string TotalValue = "Total";

        /// <summary> Consecutive. </summary>
        public static MetricTriggerType Consecutive { get; } = new MetricTriggerType(ConsecutiveValue);
        /// <summary> Total. </summary>
        public static MetricTriggerType Total { get; } = new MetricTriggerType(TotalValue);
        /// <summary> Determines if two <see cref="MetricTriggerType"/> values are the same. </summary>
        public static bool operator ==(MetricTriggerType left, MetricTriggerType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MetricTriggerType"/> values are not the same. </summary>
        public static bool operator !=(MetricTriggerType left, MetricTriggerType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MetricTriggerType"/>. </summary>
        public static implicit operator MetricTriggerType(string value) => new MetricTriggerType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MetricTriggerType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MetricTriggerType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
