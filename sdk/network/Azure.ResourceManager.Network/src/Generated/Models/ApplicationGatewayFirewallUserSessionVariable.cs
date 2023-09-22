// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> User Session clause variable. </summary>
    public readonly partial struct ApplicationGatewayFirewallUserSessionVariable : IEquatable<ApplicationGatewayFirewallUserSessionVariable>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayFirewallUserSessionVariable"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationGatewayFirewallUserSessionVariable(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ClientAddrValue = "ClientAddr";
        private const string GeoLocationValue = "GeoLocation";
        private const string NoneValue = "None";

        /// <summary> ClientAddr. </summary>
        public static ApplicationGatewayFirewallUserSessionVariable ClientAddr { get; } = new ApplicationGatewayFirewallUserSessionVariable(ClientAddrValue);
        /// <summary> GeoLocation. </summary>
        public static ApplicationGatewayFirewallUserSessionVariable GeoLocation { get; } = new ApplicationGatewayFirewallUserSessionVariable(GeoLocationValue);
        /// <summary> None. </summary>
        public static ApplicationGatewayFirewallUserSessionVariable None { get; } = new ApplicationGatewayFirewallUserSessionVariable(NoneValue);
        /// <summary> Determines if two <see cref="ApplicationGatewayFirewallUserSessionVariable"/> values are the same. </summary>
        public static bool operator ==(ApplicationGatewayFirewallUserSessionVariable left, ApplicationGatewayFirewallUserSessionVariable right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationGatewayFirewallUserSessionVariable"/> values are not the same. </summary>
        public static bool operator !=(ApplicationGatewayFirewallUserSessionVariable left, ApplicationGatewayFirewallUserSessionVariable right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationGatewayFirewallUserSessionVariable"/>. </summary>
        public static implicit operator ApplicationGatewayFirewallUserSessionVariable(string value) => new ApplicationGatewayFirewallUserSessionVariable(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationGatewayFirewallUserSessionVariable other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationGatewayFirewallUserSessionVariable other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
