// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The type of the VM. </summary>
    public readonly partial struct VMTier : IEquatable<VMTier>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="VMTier"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VMTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";
        private const string LowPriorityValue = "LowPriority";
        private const string SpotValue = "Spot";

        /// <summary> Standard. </summary>
        public static VMTier Standard { get; } = new VMTier(StandardValue);
        /// <summary> LowPriority. </summary>
        public static VMTier LowPriority { get; } = new VMTier(LowPriorityValue);
        /// <summary> Spot. </summary>
        public static VMTier Spot { get; } = new VMTier(SpotValue);
        /// <summary> Determines if two <see cref="VMTier"/> values are the same. </summary>
        public static bool operator ==(VMTier left, VMTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VMTier"/> values are not the same. </summary>
        public static bool operator !=(VMTier left, VMTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VMTier"/>. </summary>
        public static implicit operator VMTier(string value) => new VMTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VMTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VMTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
