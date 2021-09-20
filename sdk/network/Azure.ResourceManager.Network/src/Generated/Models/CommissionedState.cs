// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The commissioned state of the Custom IP Prefix. </summary>
    public readonly partial struct CommissionedState : IEquatable<CommissionedState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CommissionedState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CommissionedState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ProvisioningValue = "Provisioning";
        private const string ProvisionedValue = "Provisioned";
        private const string CommissioningValue = "Commissioning";
        private const string CommissionedValue = "Commissioned";
        private const string DecommissioningValue = "Decommissioning";
        private const string DeprovisioningValue = "Deprovisioning";

        /// <summary> Provisioning. </summary>
        public static CommissionedState Provisioning { get; } = new CommissionedState(ProvisioningValue);
        /// <summary> Provisioned. </summary>
        public static CommissionedState Provisioned { get; } = new CommissionedState(ProvisionedValue);
        /// <summary> Commissioning. </summary>
        public static CommissionedState Commissioning { get; } = new CommissionedState(CommissioningValue);
        /// <summary> Commissioned. </summary>
        public static CommissionedState Commissioned { get; } = new CommissionedState(CommissionedValue);
        /// <summary> Decommissioning. </summary>
        public static CommissionedState Decommissioning { get; } = new CommissionedState(DecommissioningValue);
        /// <summary> Deprovisioning. </summary>
        public static CommissionedState Deprovisioning { get; } = new CommissionedState(DeprovisioningValue);
        /// <summary> Determines if two <see cref="CommissionedState"/> values are the same. </summary>
        public static bool operator ==(CommissionedState left, CommissionedState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CommissionedState"/> values are not the same. </summary>
        public static bool operator !=(CommissionedState left, CommissionedState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CommissionedState"/>. </summary>
        public static implicit operator CommissionedState(string value) => new CommissionedState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CommissionedState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CommissionedState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
