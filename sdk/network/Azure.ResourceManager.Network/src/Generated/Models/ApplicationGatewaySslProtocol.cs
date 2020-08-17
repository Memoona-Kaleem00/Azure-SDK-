// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Ssl protocol enums. </summary>
    public readonly partial struct ApplicationGatewaySslProtocol : IEquatable<ApplicationGatewaySslProtocol>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ApplicationGatewaySslProtocol"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationGatewaySslProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TLSv10Value = "TLSv1_0";
        private const string TLSv11Value = "TLSv1_1";
        private const string TLSv12Value = "TLSv1_2";

        /// <summary> TLSv1_0. </summary>
        public static ApplicationGatewaySslProtocol TLSv10 { get; } = new ApplicationGatewaySslProtocol(TLSv10Value);
        /// <summary> TLSv1_1. </summary>
        public static ApplicationGatewaySslProtocol TLSv11 { get; } = new ApplicationGatewaySslProtocol(TLSv11Value);
        /// <summary> TLSv1_2. </summary>
        public static ApplicationGatewaySslProtocol TLSv12 { get; } = new ApplicationGatewaySslProtocol(TLSv12Value);
        /// <summary> Determines if two <see cref="ApplicationGatewaySslProtocol"/> values are the same. </summary>
        public static bool operator ==(ApplicationGatewaySslProtocol left, ApplicationGatewaySslProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationGatewaySslProtocol"/> values are not the same. </summary>
        public static bool operator !=(ApplicationGatewaySslProtocol left, ApplicationGatewaySslProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationGatewaySslProtocol"/>. </summary>
        public static implicit operator ApplicationGatewaySslProtocol(string value) => new ApplicationGatewaySslProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationGatewaySslProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationGatewaySslProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
