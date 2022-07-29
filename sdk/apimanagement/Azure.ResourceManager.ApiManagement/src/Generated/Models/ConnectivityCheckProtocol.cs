// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The request&apos;s protocol. Specific protocol configuration can be available based on this selection. The specified destination address must be coherent with this value. </summary>
    public readonly partial struct ConnectivityCheckProtocol : IEquatable<ConnectivityCheckProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConnectivityCheckProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectivityCheckProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TcpValue = "TCP";
        private const string HttpValue = "HTTP";
        private const string HttpsValue = "HTTPS";

        /// <summary> TCP. </summary>
        public static ConnectivityCheckProtocol Tcp { get; } = new ConnectivityCheckProtocol(TcpValue);
        /// <summary> HTTP. </summary>
        public static ConnectivityCheckProtocol Http { get; } = new ConnectivityCheckProtocol(HttpValue);
        /// <summary> HTTPS. </summary>
        public static ConnectivityCheckProtocol Https { get; } = new ConnectivityCheckProtocol(HttpsValue);
        /// <summary> Determines if two <see cref="ConnectivityCheckProtocol"/> values are the same. </summary>
        public static bool operator ==(ConnectivityCheckProtocol left, ConnectivityCheckProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectivityCheckProtocol"/> values are not the same. </summary>
        public static bool operator !=(ConnectivityCheckProtocol left, ConnectivityCheckProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConnectivityCheckProtocol"/>. </summary>
        public static implicit operator ConnectivityCheckProtocol(string value) => new ConnectivityCheckProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectivityCheckProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectivityCheckProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
