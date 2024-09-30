// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The SyncGroupLogType. </summary>
    public readonly partial struct SyncGroupLogType : IEquatable<SyncGroupLogType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SyncGroupLogType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SyncGroupLogType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllValue = "All";
        private const string ErrorValue = "Error";
        private const string WarningValue = "Warning";
        private const string SuccessValue = "Success";

        /// <summary> All. </summary>
        public static SyncGroupLogType All { get; } = new SyncGroupLogType(AllValue);
        /// <summary> Error. </summary>
        public static SyncGroupLogType Error { get; } = new SyncGroupLogType(ErrorValue);
        /// <summary> Warning. </summary>
        public static SyncGroupLogType Warning { get; } = new SyncGroupLogType(WarningValue);
        /// <summary> Success. </summary>
        public static SyncGroupLogType Success { get; } = new SyncGroupLogType(SuccessValue);
        /// <summary> Determines if two <see cref="SyncGroupLogType"/> values are the same. </summary>
        public static bool operator ==(SyncGroupLogType left, SyncGroupLogType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SyncGroupLogType"/> values are not the same. </summary>
        public static bool operator !=(SyncGroupLogType left, SyncGroupLogType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SyncGroupLogType"/>. </summary>
        public static implicit operator SyncGroupLogType(string value) => new SyncGroupLogType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SyncGroupLogType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SyncGroupLogType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
