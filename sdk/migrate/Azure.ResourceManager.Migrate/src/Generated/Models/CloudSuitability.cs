// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Whether this disk is suitable for Azure. </summary>
    public readonly partial struct CloudSuitability : IEquatable<CloudSuitability>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CloudSuitability"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CloudSuitability(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string NotSuitableValue = "NotSuitable";
        private const string SuitableValue = "Suitable";
        private const string ConditionallySuitableValue = "ConditionallySuitable";
        private const string ReadinessUnknownValue = "ReadinessUnknown";

        /// <summary> Unknown. </summary>
        public static CloudSuitability Unknown { get; } = new CloudSuitability(UnknownValue);
        /// <summary> NotSuitable. </summary>
        public static CloudSuitability NotSuitable { get; } = new CloudSuitability(NotSuitableValue);
        /// <summary> Suitable. </summary>
        public static CloudSuitability Suitable { get; } = new CloudSuitability(SuitableValue);
        /// <summary> ConditionallySuitable. </summary>
        public static CloudSuitability ConditionallySuitable { get; } = new CloudSuitability(ConditionallySuitableValue);
        /// <summary> ReadinessUnknown. </summary>
        public static CloudSuitability ReadinessUnknown { get; } = new CloudSuitability(ReadinessUnknownValue);
        /// <summary> Determines if two <see cref="CloudSuitability"/> values are the same. </summary>
        public static bool operator ==(CloudSuitability left, CloudSuitability right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CloudSuitability"/> values are not the same. </summary>
        public static bool operator !=(CloudSuitability left, CloudSuitability right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CloudSuitability"/>. </summary>
        public static implicit operator CloudSuitability(string value) => new CloudSuitability(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CloudSuitability other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CloudSuitability other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
