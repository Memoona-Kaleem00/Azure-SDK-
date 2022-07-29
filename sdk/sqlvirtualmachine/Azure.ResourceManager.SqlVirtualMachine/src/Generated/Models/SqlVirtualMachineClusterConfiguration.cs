// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Cluster type. </summary>
    public readonly partial struct SqlVirtualMachineClusterConfiguration : IEquatable<SqlVirtualMachineClusterConfiguration>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlVirtualMachineClusterConfiguration"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlVirtualMachineClusterConfiguration(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DomainfulValue = "Domainful";

        /// <summary> Domainful. </summary>
        public static SqlVirtualMachineClusterConfiguration Domainful { get; } = new SqlVirtualMachineClusterConfiguration(DomainfulValue);
        /// <summary> Determines if two <see cref="SqlVirtualMachineClusterConfiguration"/> values are the same. </summary>
        public static bool operator ==(SqlVirtualMachineClusterConfiguration left, SqlVirtualMachineClusterConfiguration right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlVirtualMachineClusterConfiguration"/> values are not the same. </summary>
        public static bool operator !=(SqlVirtualMachineClusterConfiguration left, SqlVirtualMachineClusterConfiguration right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SqlVirtualMachineClusterConfiguration"/>. </summary>
        public static implicit operator SqlVirtualMachineClusterConfiguration(string value) => new SqlVirtualMachineClusterConfiguration(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlVirtualMachineClusterConfiguration other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlVirtualMachineClusterConfiguration other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
