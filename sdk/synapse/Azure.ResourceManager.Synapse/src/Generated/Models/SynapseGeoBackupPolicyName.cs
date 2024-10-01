// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The SynapseGeoBackupPolicyName. </summary>
    public readonly partial struct SynapseGeoBackupPolicyName : IEquatable<SynapseGeoBackupPolicyName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SynapseGeoBackupPolicyName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SynapseGeoBackupPolicyName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";

        /// <summary> Default. </summary>
        public static SynapseGeoBackupPolicyName Default { get; } = new SynapseGeoBackupPolicyName(DefaultValue);
        /// <summary> Determines if two <see cref="SynapseGeoBackupPolicyName"/> values are the same. </summary>
        public static bool operator ==(SynapseGeoBackupPolicyName left, SynapseGeoBackupPolicyName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SynapseGeoBackupPolicyName"/> values are not the same. </summary>
        public static bool operator !=(SynapseGeoBackupPolicyName left, SynapseGeoBackupPolicyName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SynapseGeoBackupPolicyName"/>. </summary>
        public static implicit operator SynapseGeoBackupPolicyName(string value) => new SynapseGeoBackupPolicyName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SynapseGeoBackupPolicyName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SynapseGeoBackupPolicyName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
