// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Gets or sets the resync state. </summary>
    public readonly partial struct VMwareToAzureMigrateResyncState : IEquatable<VMwareToAzureMigrateResyncState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VMwareToAzureMigrateResyncState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VMwareToAzureMigrateResyncState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string PreparedForResynchronizationValue = "PreparedForResynchronization";
        private const string StartedResynchronizationValue = "StartedResynchronization";

        /// <summary> None. </summary>
        public static VMwareToAzureMigrateResyncState None { get; } = new VMwareToAzureMigrateResyncState(NoneValue);
        /// <summary> PreparedForResynchronization. </summary>
        public static VMwareToAzureMigrateResyncState PreparedForResynchronization { get; } = new VMwareToAzureMigrateResyncState(PreparedForResynchronizationValue);
        /// <summary> StartedResynchronization. </summary>
        public static VMwareToAzureMigrateResyncState StartedResynchronization { get; } = new VMwareToAzureMigrateResyncState(StartedResynchronizationValue);
        /// <summary> Determines if two <see cref="VMwareToAzureMigrateResyncState"/> values are the same. </summary>
        public static bool operator ==(VMwareToAzureMigrateResyncState left, VMwareToAzureMigrateResyncState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VMwareToAzureMigrateResyncState"/> values are not the same. </summary>
        public static bool operator !=(VMwareToAzureMigrateResyncState left, VMwareToAzureMigrateResyncState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VMwareToAzureMigrateResyncState"/>. </summary>
        public static implicit operator VMwareToAzureMigrateResyncState(string value) => new VMwareToAzureMigrateResyncState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VMwareToAzureMigrateResyncState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VMwareToAzureMigrateResyncState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
