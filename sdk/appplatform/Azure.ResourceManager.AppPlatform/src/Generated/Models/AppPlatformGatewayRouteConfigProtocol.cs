// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Protocol of routed Azure Spring Apps applications. </summary>
    public readonly partial struct AppPlatformGatewayRouteConfigProtocol : IEquatable<AppPlatformGatewayRouteConfigProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppPlatformGatewayRouteConfigProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppPlatformGatewayRouteConfigProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HttpValue = "HTTP";
        private const string HttpsValue = "HTTPS";

        /// <summary> HTTP. </summary>
        public static AppPlatformGatewayRouteConfigProtocol Http { get; } = new AppPlatformGatewayRouteConfigProtocol(HttpValue);
        /// <summary> HTTPS. </summary>
        public static AppPlatformGatewayRouteConfigProtocol Https { get; } = new AppPlatformGatewayRouteConfigProtocol(HttpsValue);
        /// <summary> Determines if two <see cref="AppPlatformGatewayRouteConfigProtocol"/> values are the same. </summary>
        public static bool operator ==(AppPlatformGatewayRouteConfigProtocol left, AppPlatformGatewayRouteConfigProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppPlatformGatewayRouteConfigProtocol"/> values are not the same. </summary>
        public static bool operator !=(AppPlatformGatewayRouteConfigProtocol left, AppPlatformGatewayRouteConfigProtocol right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AppPlatformGatewayRouteConfigProtocol"/>. </summary>
        public static implicit operator AppPlatformGatewayRouteConfigProtocol(string value) => new AppPlatformGatewayRouteConfigProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppPlatformGatewayRouteConfigProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppPlatformGatewayRouteConfigProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
