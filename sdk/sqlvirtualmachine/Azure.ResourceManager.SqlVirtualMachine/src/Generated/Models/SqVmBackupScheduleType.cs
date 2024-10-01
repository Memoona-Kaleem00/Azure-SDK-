// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Backup schedule type. </summary>
    public readonly partial struct SqVmBackupScheduleType : IEquatable<SqVmBackupScheduleType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqVmBackupScheduleType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqVmBackupScheduleType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ManualValue = "Manual";
        private const string AutomatedValue = "Automated";

        /// <summary> Manual. </summary>
        public static SqVmBackupScheduleType Manual { get; } = new SqVmBackupScheduleType(ManualValue);
        /// <summary> Automated. </summary>
        public static SqVmBackupScheduleType Automated { get; } = new SqVmBackupScheduleType(AutomatedValue);
        /// <summary> Determines if two <see cref="SqVmBackupScheduleType"/> values are the same. </summary>
        public static bool operator ==(SqVmBackupScheduleType left, SqVmBackupScheduleType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqVmBackupScheduleType"/> values are not the same. </summary>
        public static bool operator !=(SqVmBackupScheduleType left, SqVmBackupScheduleType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SqVmBackupScheduleType"/>. </summary>
        public static implicit operator SqVmBackupScheduleType(string value) => new SqVmBackupScheduleType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqVmBackupScheduleType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqVmBackupScheduleType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
