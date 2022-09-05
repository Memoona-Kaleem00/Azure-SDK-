// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Protocol this rule will use when forwarding traffic to backends. </summary>
    public readonly partial struct FrontDoorForwardingProtocol : IEquatable<FrontDoorForwardingProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FrontDoorForwardingProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FrontDoorForwardingProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HttpOnlyValue = "HttpOnly";
        private const string HttpsOnlyValue = "HttpsOnly";
        private const string MatchRequestValue = "MatchRequest";

        /// <summary> HttpOnly. </summary>
        public static FrontDoorForwardingProtocol HttpOnly { get; } = new FrontDoorForwardingProtocol(HttpOnlyValue);
        /// <summary> HttpsOnly. </summary>
        public static FrontDoorForwardingProtocol HttpsOnly { get; } = new FrontDoorForwardingProtocol(HttpsOnlyValue);
        /// <summary> MatchRequest. </summary>
        public static FrontDoorForwardingProtocol MatchRequest { get; } = new FrontDoorForwardingProtocol(MatchRequestValue);
        /// <summary> Determines if two <see cref="FrontDoorForwardingProtocol"/> values are the same. </summary>
        public static bool operator ==(FrontDoorForwardingProtocol left, FrontDoorForwardingProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FrontDoorForwardingProtocol"/> values are not the same. </summary>
        public static bool operator !=(FrontDoorForwardingProtocol left, FrontDoorForwardingProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FrontDoorForwardingProtocol"/>. </summary>
        public static implicit operator FrontDoorForwardingProtocol(string value) => new FrontDoorForwardingProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FrontDoorForwardingProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FrontDoorForwardingProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
