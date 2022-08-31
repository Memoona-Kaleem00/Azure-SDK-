// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> It is used to set the encryption mode for node-node communication channel (when more than 2 self-hosted integration runtime nodes exist). </summary>
    public readonly partial struct IntegrationRuntimeInternalChannelEncryptionMode : IEquatable<IntegrationRuntimeInternalChannelEncryptionMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IntegrationRuntimeInternalChannelEncryptionMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IntegrationRuntimeInternalChannelEncryptionMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSetValue = "NotSet";
        private const string SslEncryptedValue = "SslEncrypted";
        private const string NotEncryptedValue = "NotEncrypted";

        /// <summary> NotSet. </summary>
        public static IntegrationRuntimeInternalChannelEncryptionMode NotSet { get; } = new IntegrationRuntimeInternalChannelEncryptionMode(NotSetValue);
        /// <summary> SslEncrypted. </summary>
        public static IntegrationRuntimeInternalChannelEncryptionMode SslEncrypted { get; } = new IntegrationRuntimeInternalChannelEncryptionMode(SslEncryptedValue);
        /// <summary> NotEncrypted. </summary>
        public static IntegrationRuntimeInternalChannelEncryptionMode NotEncrypted { get; } = new IntegrationRuntimeInternalChannelEncryptionMode(NotEncryptedValue);
        /// <summary> Determines if two <see cref="IntegrationRuntimeInternalChannelEncryptionMode"/> values are the same. </summary>
        public static bool operator ==(IntegrationRuntimeInternalChannelEncryptionMode left, IntegrationRuntimeInternalChannelEncryptionMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IntegrationRuntimeInternalChannelEncryptionMode"/> values are not the same. </summary>
        public static bool operator !=(IntegrationRuntimeInternalChannelEncryptionMode left, IntegrationRuntimeInternalChannelEncryptionMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IntegrationRuntimeInternalChannelEncryptionMode"/>. </summary>
        public static implicit operator IntegrationRuntimeInternalChannelEncryptionMode(string value) => new IntegrationRuntimeInternalChannelEncryptionMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IntegrationRuntimeInternalChannelEncryptionMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IntegrationRuntimeInternalChannelEncryptionMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
