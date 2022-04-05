// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    /// <summary> Indicates the current status of event support for the resource. </summary>
    public readonly partial struct ServiceEventState : IEquatable<ServiceEventState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ServiceEventState"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceEventState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";
        private const string UpdatingValue = "Updating";

        /// <summary> Disabled. </summary>
        public static ServiceEventState Disabled { get; } = new ServiceEventState(DisabledValue);
        /// <summary> Enabled. </summary>
        public static ServiceEventState Enabled { get; } = new ServiceEventState(EnabledValue);
        /// <summary> Updating. </summary>
        public static ServiceEventState Updating { get; } = new ServiceEventState(UpdatingValue);
        /// <summary> Determines if two <see cref="ServiceEventState"/> values are the same. </summary>
        public static bool operator ==(ServiceEventState left, ServiceEventState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceEventState"/> values are not the same. </summary>
        public static bool operator !=(ServiceEventState left, ServiceEventState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServiceEventState"/>. </summary>
        public static implicit operator ServiceEventState(string value) => new ServiceEventState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceEventState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceEventState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
