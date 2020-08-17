// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Access to be allowed or denied. </summary>
    public readonly partial struct Access : IEquatable<Access>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Access"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Access(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";
        private const string DenyValue = "Deny";

        /// <summary> Allow. </summary>
        public static Access Allow { get; } = new Access(AllowValue);
        /// <summary> Deny. </summary>
        public static Access Deny { get; } = new Access(DenyValue);
        /// <summary> Determines if two <see cref="Access"/> values are the same. </summary>
        public static bool operator ==(Access left, Access right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Access"/> values are not the same. </summary>
        public static bool operator !=(Access left, Access right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Access"/>. </summary>
        public static implicit operator Access(string value) => new Access(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Access other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Access other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
