// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Fabric.Models
{
    /// <summary> The FabricSkuTier. </summary>
    public readonly partial struct FabricSkuTier : IEquatable<FabricSkuTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FabricSkuTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FabricSkuTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FabricValue = "Fabric";

        /// <summary> Fabric. </summary>
        public static FabricSkuTier Fabric { get; } = new FabricSkuTier(FabricValue);
        /// <summary> Determines if two <see cref="FabricSkuTier"/> values are the same. </summary>
        public static bool operator ==(FabricSkuTier left, FabricSkuTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FabricSkuTier"/> values are not the same. </summary>
        public static bool operator !=(FabricSkuTier left, FabricSkuTier right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="FabricSkuTier"/>. </summary>
        public static implicit operator FabricSkuTier(string value) => new FabricSkuTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FabricSkuTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FabricSkuTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
