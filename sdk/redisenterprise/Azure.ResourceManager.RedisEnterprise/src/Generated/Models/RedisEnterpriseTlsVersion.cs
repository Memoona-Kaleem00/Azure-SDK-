// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> The minimum TLS version for the cluster to support, e.g. &apos;1.2&apos;. </summary>
    public readonly partial struct RedisEnterpriseTlsVersion : IEquatable<RedisEnterpriseTlsVersion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseTlsVersion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RedisEnterpriseTlsVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Tls1_0Value = "1.0";
        private const string Tls1_1Value = "1.1";
        private const string Tls1_2Value = "1.2";
        /// <summary> Determines if two <see cref="RedisEnterpriseTlsVersion"/> values are the same. </summary>
        public static bool operator ==(RedisEnterpriseTlsVersion left, RedisEnterpriseTlsVersion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RedisEnterpriseTlsVersion"/> values are not the same. </summary>
        public static bool operator !=(RedisEnterpriseTlsVersion left, RedisEnterpriseTlsVersion right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RedisEnterpriseTlsVersion"/>. </summary>
        public static implicit operator RedisEnterpriseTlsVersion(string value) => new RedisEnterpriseTlsVersion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RedisEnterpriseTlsVersion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RedisEnterpriseTlsVersion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
