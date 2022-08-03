// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary>
    /// Determines whether blob blocks are either committed automatically or appended.
    /// Serialized Name: BlobWriteMode
    /// </summary>
    public readonly partial struct BlobWriteMode : IEquatable<BlobWriteMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BlobWriteMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BlobWriteMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AppendValue = "Append";
        private const string OnceValue = "Once";

        /// <summary>
        /// Append
        /// Serialized Name: BlobWriteMode.Append
        /// </summary>
        public static BlobWriteMode Append { get; } = new BlobWriteMode(AppendValue);
        /// <summary>
        /// Once
        /// Serialized Name: BlobWriteMode.Once
        /// </summary>
        public static BlobWriteMode Once { get; } = new BlobWriteMode(OnceValue);
        /// <summary> Determines if two <see cref="BlobWriteMode"/> values are the same. </summary>
        public static bool operator ==(BlobWriteMode left, BlobWriteMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BlobWriteMode"/> values are not the same. </summary>
        public static bool operator !=(BlobWriteMode left, BlobWriteMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BlobWriteMode"/>. </summary>
        public static implicit operator BlobWriteMode(string value) => new BlobWriteMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BlobWriteMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BlobWriteMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
