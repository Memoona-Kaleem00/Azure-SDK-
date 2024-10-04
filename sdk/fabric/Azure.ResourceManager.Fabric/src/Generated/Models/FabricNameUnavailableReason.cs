// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Fabric.Models
{
    /// <summary> The FabricNameUnavailableReason. </summary>
    public readonly partial struct FabricNameUnavailableReason : IEquatable<FabricNameUnavailableReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FabricNameUnavailableReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FabricNameUnavailableReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string AlreadyExistsValue = "AlreadyExists";

        /// <summary> Invalid. </summary>
        public static FabricNameUnavailableReason Invalid { get; } = new FabricNameUnavailableReason(InvalidValue);
        /// <summary> AlreadyExists. </summary>
        public static FabricNameUnavailableReason AlreadyExists { get; } = new FabricNameUnavailableReason(AlreadyExistsValue);
        /// <summary> Determines if two <see cref="FabricNameUnavailableReason"/> values are the same. </summary>
        public static bool operator ==(FabricNameUnavailableReason left, FabricNameUnavailableReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FabricNameUnavailableReason"/> values are not the same. </summary>
        public static bool operator !=(FabricNameUnavailableReason left, FabricNameUnavailableReason right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="FabricNameUnavailableReason"/>. </summary>
        public static implicit operator FabricNameUnavailableReason(string value) => new FabricNameUnavailableReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FabricNameUnavailableReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FabricNameUnavailableReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
