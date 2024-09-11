// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Global Reach Connection status. </summary>
    public readonly partial struct GlobalReachConnectionStatus : IEquatable<GlobalReachConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GlobalReachConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GlobalReachConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ConnectedValue = "Connected";
        private const string ConnectingValue = "Connecting";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> is connected. </summary>
        public static GlobalReachConnectionStatus Connected { get; } = new GlobalReachConnectionStatus(ConnectedValue);
        /// <summary> is connecting. </summary>
        public static GlobalReachConnectionStatus Connecting { get; } = new GlobalReachConnectionStatus(ConnectingValue);
        /// <summary> is disconnected. </summary>
        public static GlobalReachConnectionStatus Disconnected { get; } = new GlobalReachConnectionStatus(DisconnectedValue);
        /// <summary> Determines if two <see cref="GlobalReachConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(GlobalReachConnectionStatus left, GlobalReachConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GlobalReachConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(GlobalReachConnectionStatus left, GlobalReachConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="GlobalReachConnectionStatus"/>. </summary>
        public static implicit operator GlobalReachConnectionStatus(string value) => new GlobalReachConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GlobalReachConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GlobalReachConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
