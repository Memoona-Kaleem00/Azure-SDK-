// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    /// <summary> The status of the operation being performed. </summary>
    public readonly partial struct OperationResultStatus : IEquatable<OperationResultStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="OperationResultStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperationResultStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CanceledValue = "Canceled";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string RequestedValue = "Requested";
        private const string RunningValue = "Running";

        /// <summary> Canceled. </summary>
        public static OperationResultStatus Canceled { get; } = new OperationResultStatus(CanceledValue);
        /// <summary> Succeeded. </summary>
        public static OperationResultStatus Succeeded { get; } = new OperationResultStatus(SucceededValue);
        /// <summary> Failed. </summary>
        public static OperationResultStatus Failed { get; } = new OperationResultStatus(FailedValue);
        /// <summary> Requested. </summary>
        public static OperationResultStatus Requested { get; } = new OperationResultStatus(RequestedValue);
        /// <summary> Running. </summary>
        public static OperationResultStatus Running { get; } = new OperationResultStatus(RunningValue);
        /// <summary> Determines if two <see cref="OperationResultStatus"/> values are the same. </summary>
        public static bool operator ==(OperationResultStatus left, OperationResultStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperationResultStatus"/> values are not the same. </summary>
        public static bool operator !=(OperationResultStatus left, OperationResultStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OperationResultStatus"/>. </summary>
        public static implicit operator OperationResultStatus(string value) => new OperationResultStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperationResultStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperationResultStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
