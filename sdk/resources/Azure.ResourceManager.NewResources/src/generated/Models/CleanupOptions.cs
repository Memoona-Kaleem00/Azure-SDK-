// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NewResources
{
    /// <summary> The clean up preference when the script execution gets in a terminal state. Default setting is &apos;Always&apos;. </summary>
    public readonly partial struct CleanupOptions : IEquatable<CleanupOptions>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="CleanupOptions"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CleanupOptions(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AlwaysValue = "Always";
        private const string OnSuccessValue = "OnSuccess";
        private const string OnExpirationValue = "OnExpiration";

        /// <summary> Always. </summary>
        public static CleanupOptions Always { get; } = new CleanupOptions(AlwaysValue);
        /// <summary> OnSuccess. </summary>
        public static CleanupOptions OnSuccess { get; } = new CleanupOptions(OnSuccessValue);
        /// <summary> OnExpiration. </summary>
        public static CleanupOptions OnExpiration { get; } = new CleanupOptions(OnExpirationValue);
        /// <summary> Determines if two <see cref="CleanupOptions"/> values are the same. </summary>
        public static bool operator ==(CleanupOptions left, CleanupOptions right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CleanupOptions"/> values are not the same. </summary>
        public static bool operator !=(CleanupOptions left, CleanupOptions right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CleanupOptions"/>. </summary>
        public static implicit operator CleanupOptions(string value) => new CleanupOptions(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CleanupOptions other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CleanupOptions other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
