// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The indicator of whether the control plane will be impacted during the upgrade. </summary>
    public readonly partial struct ControlImpact : IEquatable<ControlImpact>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ControlImpact"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ControlImpact(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "True";
        private const string FalseValue = "False";

        /// <summary> True. </summary>
        public static ControlImpact True { get; } = new ControlImpact(TrueValue);
        /// <summary> False. </summary>
        public static ControlImpact False { get; } = new ControlImpact(FalseValue);
        /// <summary> Determines if two <see cref="ControlImpact"/> values are the same. </summary>
        public static bool operator ==(ControlImpact left, ControlImpact right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ControlImpact"/> values are not the same. </summary>
        public static bool operator !=(ControlImpact left, ControlImpact right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ControlImpact"/>. </summary>
        public static implicit operator ControlImpact(string value) => new ControlImpact(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ControlImpact other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ControlImpact other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
