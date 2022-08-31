// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> the operation associated with the notification and its value must be &quot;scale&quot;. </summary>
    public readonly partial struct MonitorOperationType : IEquatable<MonitorOperationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MonitorOperationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MonitorOperationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ScaleValue = "Scale";

        /// <summary> Scale. </summary>
        public static MonitorOperationType Scale { get; } = new MonitorOperationType(ScaleValue);
        /// <summary> Determines if two <see cref="MonitorOperationType"/> values are the same. </summary>
        public static bool operator ==(MonitorOperationType left, MonitorOperationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MonitorOperationType"/> values are not the same. </summary>
        public static bool operator !=(MonitorOperationType left, MonitorOperationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MonitorOperationType"/>. </summary>
        public static implicit operator MonitorOperationType(string value) => new MonitorOperationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MonitorOperationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MonitorOperationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
