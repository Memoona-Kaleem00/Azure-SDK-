// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Type of a managed network Outbound Rule of a machine learning workspace. </summary>
    public readonly partial struct OutboundRuleStatus : IEquatable<OutboundRuleStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OutboundRuleStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OutboundRuleStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InactiveValue = "Inactive";
        private const string ActiveValue = "Active";

        /// <summary> Inactive. </summary>
        public static OutboundRuleStatus Inactive { get; } = new OutboundRuleStatus(InactiveValue);
        /// <summary> Active. </summary>
        public static OutboundRuleStatus Active { get; } = new OutboundRuleStatus(ActiveValue);
        /// <summary> Determines if two <see cref="OutboundRuleStatus"/> values are the same. </summary>
        public static bool operator ==(OutboundRuleStatus left, OutboundRuleStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OutboundRuleStatus"/> values are not the same. </summary>
        public static bool operator !=(OutboundRuleStatus left, OutboundRuleStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OutboundRuleStatus"/>. </summary>
        public static implicit operator OutboundRuleStatus(string value) => new OutboundRuleStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OutboundRuleStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OutboundRuleStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
