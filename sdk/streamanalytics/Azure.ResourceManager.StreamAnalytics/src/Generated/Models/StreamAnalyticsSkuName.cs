// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary>
    /// The name of the SKU. Required on PUT (CreateOrReplace) requests.
    /// Serialized Name: SkuName
    /// </summary>
    public readonly partial struct StreamAnalyticsSkuName : IEquatable<StreamAnalyticsSkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsSkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StreamAnalyticsSkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";

        /// <summary>
        /// Standard
        /// Serialized Name: SkuName.Standard
        /// </summary>
        public static StreamAnalyticsSkuName Standard { get; } = new StreamAnalyticsSkuName(StandardValue);
        /// <summary> Determines if two <see cref="StreamAnalyticsSkuName"/> values are the same. </summary>
        public static bool operator ==(StreamAnalyticsSkuName left, StreamAnalyticsSkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StreamAnalyticsSkuName"/> values are not the same. </summary>
        public static bool operator !=(StreamAnalyticsSkuName left, StreamAnalyticsSkuName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StreamAnalyticsSkuName"/>. </summary>
        public static implicit operator StreamAnalyticsSkuName(string value) => new StreamAnalyticsSkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StreamAnalyticsSkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StreamAnalyticsSkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
