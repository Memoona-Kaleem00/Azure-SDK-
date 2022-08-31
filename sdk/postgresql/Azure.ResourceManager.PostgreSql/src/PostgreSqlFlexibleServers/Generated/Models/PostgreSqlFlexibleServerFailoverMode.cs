// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Failover mode. </summary>
    public readonly partial struct PostgreSqlFlexibleServerFailoverMode : IEquatable<PostgreSqlFlexibleServerFailoverMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerFailoverMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlFlexibleServerFailoverMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PlannedFailoverValue = "PlannedFailover";
        private const string ForcedFailoverValue = "ForcedFailover";
        private const string PlannedSwitchoverValue = "PlannedSwitchover";
        private const string ForcedSwitchoverValue = "ForcedSwitchover";

        /// <summary> PlannedFailover. </summary>
        public static PostgreSqlFlexibleServerFailoverMode PlannedFailover { get; } = new PostgreSqlFlexibleServerFailoverMode(PlannedFailoverValue);
        /// <summary> ForcedFailover. </summary>
        public static PostgreSqlFlexibleServerFailoverMode ForcedFailover { get; } = new PostgreSqlFlexibleServerFailoverMode(ForcedFailoverValue);
        /// <summary> PlannedSwitchover. </summary>
        public static PostgreSqlFlexibleServerFailoverMode PlannedSwitchover { get; } = new PostgreSqlFlexibleServerFailoverMode(PlannedSwitchoverValue);
        /// <summary> ForcedSwitchover. </summary>
        public static PostgreSqlFlexibleServerFailoverMode ForcedSwitchover { get; } = new PostgreSqlFlexibleServerFailoverMode(ForcedSwitchoverValue);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerFailoverMode"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlFlexibleServerFailoverMode left, PostgreSqlFlexibleServerFailoverMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlFlexibleServerFailoverMode"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlFlexibleServerFailoverMode left, PostgreSqlFlexibleServerFailoverMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PostgreSqlFlexibleServerFailoverMode"/>. </summary>
        public static implicit operator PostgreSqlFlexibleServerFailoverMode(string value) => new PostgreSqlFlexibleServerFailoverMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlFlexibleServerFailoverMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlFlexibleServerFailoverMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
