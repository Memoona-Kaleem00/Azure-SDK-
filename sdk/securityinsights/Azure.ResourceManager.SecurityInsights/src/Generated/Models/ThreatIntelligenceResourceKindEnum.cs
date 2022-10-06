// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The kind of the threat intelligence entity. </summary>
    internal readonly partial struct ThreatIntelligenceResourceKindEnum : IEquatable<ThreatIntelligenceResourceKindEnum>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceResourceKindEnum"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ThreatIntelligenceResourceKindEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IndicatorValue = "indicator";

        /// <summary> Entity represents threat intelligence indicator in the system. </summary>
        public static ThreatIntelligenceResourceKindEnum Indicator { get; } = new ThreatIntelligenceResourceKindEnum(IndicatorValue);
        /// <summary> Determines if two <see cref="ThreatIntelligenceResourceKindEnum"/> values are the same. </summary>
        public static bool operator ==(ThreatIntelligenceResourceKindEnum left, ThreatIntelligenceResourceKindEnum right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ThreatIntelligenceResourceKindEnum"/> values are not the same. </summary>
        public static bool operator !=(ThreatIntelligenceResourceKindEnum left, ThreatIntelligenceResourceKindEnum right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ThreatIntelligenceResourceKindEnum"/>. </summary>
        public static implicit operator ThreatIntelligenceResourceKindEnum(string value) => new ThreatIntelligenceResourceKindEnum(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ThreatIntelligenceResourceKindEnum other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ThreatIntelligenceResourceKindEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
