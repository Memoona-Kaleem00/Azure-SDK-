// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> The state of monitoring. </summary>
    public readonly partial struct NewRelicMonitoringStatus : IEquatable<NewRelicMonitoringStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NewRelicMonitoringStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NewRelicMonitoringStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InProgressValue = "InProgress";
        private const string ActiveValue = "Active";
        private const string FailedValue = "Failed";
        private const string DeletingValue = "Deleting";

        /// <summary> InProgress. </summary>
        public static NewRelicMonitoringStatus InProgress { get; } = new NewRelicMonitoringStatus(InProgressValue);
        /// <summary> Active. </summary>
        public static NewRelicMonitoringStatus Active { get; } = new NewRelicMonitoringStatus(ActiveValue);
        /// <summary> Failed. </summary>
        public static NewRelicMonitoringStatus Failed { get; } = new NewRelicMonitoringStatus(FailedValue);
        /// <summary> Deleting. </summary>
        public static NewRelicMonitoringStatus Deleting { get; } = new NewRelicMonitoringStatus(DeletingValue);
        /// <summary> Determines if two <see cref="NewRelicMonitoringStatus"/> values are the same. </summary>
        public static bool operator ==(NewRelicMonitoringStatus left, NewRelicMonitoringStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NewRelicMonitoringStatus"/> values are not the same. </summary>
        public static bool operator !=(NewRelicMonitoringStatus left, NewRelicMonitoringStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NewRelicMonitoringStatus"/>. </summary>
        public static implicit operator NewRelicMonitoringStatus(string value) => new NewRelicMonitoringStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NewRelicMonitoringStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NewRelicMonitoringStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
