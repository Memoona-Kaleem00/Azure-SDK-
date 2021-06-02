// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Resources
{
    /// <summary> The attributes of the token that the alias path is referring to. </summary>
    public readonly partial struct AliasPathAttributes : IEquatable<AliasPathAttributes>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AliasPathAttributes"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AliasPathAttributes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string ModifiableValue = "Modifiable";

        /// <summary> The token that the alias path is referring to has no attributes. </summary>
        public static AliasPathAttributes None { get; } = new AliasPathAttributes(NoneValue);
        /// <summary> The token that the alias path is referring to is modifiable by policies with &apos;modify&apos; effect. </summary>
        public static AliasPathAttributes Modifiable { get; } = new AliasPathAttributes(ModifiableValue);
        /// <summary> Determines if two <see cref="AliasPathAttributes"/> values are the same. </summary>
        public static bool operator ==(AliasPathAttributes left, AliasPathAttributes right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AliasPathAttributes"/> values are not the same. </summary>
        public static bool operator !=(AliasPathAttributes left, AliasPathAttributes right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AliasPathAttributes"/>. </summary>
        public static implicit operator AliasPathAttributes(string value) => new AliasPathAttributes(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AliasPathAttributes other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AliasPathAttributes other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
