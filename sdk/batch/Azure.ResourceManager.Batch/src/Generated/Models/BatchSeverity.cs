// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Severity of the issue. </summary>
    public readonly partial struct BatchSeverity : IEquatable<BatchSeverity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BatchSeverity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BatchSeverity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WarningValue = "Warning";
        private const string ErrorValue = "Error";

        /// <summary> Warning. </summary>
        public static BatchSeverity Warning { get; } = new BatchSeverity(WarningValue);
        /// <summary> Error. </summary>
        public static BatchSeverity Error { get; } = new BatchSeverity(ErrorValue);
        /// <summary> Determines if two <see cref="BatchSeverity"/> values are the same. </summary>
        public static bool operator ==(BatchSeverity left, BatchSeverity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BatchSeverity"/> values are not the same. </summary>
        public static bool operator !=(BatchSeverity left, BatchSeverity right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BatchSeverity"/>. </summary>
        public static implicit operator BatchSeverity(string value) => new BatchSeverity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BatchSeverity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BatchSeverity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
