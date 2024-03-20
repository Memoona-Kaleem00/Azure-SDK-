// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> The MySqlFlexibleServerBackupType. </summary>
    public readonly partial struct MySqlFlexibleServerBackupType : IEquatable<MySqlFlexibleServerBackupType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerBackupType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MySqlFlexibleServerBackupType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FullValue = "FULL";

        /// <summary> FULL. </summary>
        public static MySqlFlexibleServerBackupType Full { get; } = new MySqlFlexibleServerBackupType(FullValue);
        /// <summary> Determines if two <see cref="MySqlFlexibleServerBackupType"/> values are the same. </summary>
        public static bool operator ==(MySqlFlexibleServerBackupType left, MySqlFlexibleServerBackupType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MySqlFlexibleServerBackupType"/> values are not the same. </summary>
        public static bool operator !=(MySqlFlexibleServerBackupType left, MySqlFlexibleServerBackupType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MySqlFlexibleServerBackupType"/>. </summary>
        public static implicit operator MySqlFlexibleServerBackupType(string value) => new MySqlFlexibleServerBackupType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MySqlFlexibleServerBackupType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MySqlFlexibleServerBackupType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
