// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The SkuName. </summary>
    public readonly partial struct SkuName : IEquatable<SkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FreeValue = "Free";
        private const string SharedValue = "Shared";
        private const string BasicValue = "Basic";
        private const string StandardValue = "Standard";
        private const string PremiumValue = "Premium";
        private const string DynamicValue = "Dynamic";
        private const string IsolatedValue = "Isolated";
        private const string IsolatedV2Value = "IsolatedV2";
        private const string PremiumV2Value = "PremiumV2";
        private const string PremiumV3Value = "PremiumV3";
        private const string PremiumContainerValue = "PremiumContainer";
        private const string ElasticPremiumValue = "ElasticPremium";
        private const string ElasticIsolatedValue = "ElasticIsolated";

        /// <summary> Free. </summary>
        public static SkuName Free { get; } = new SkuName(FreeValue);
        /// <summary> Shared. </summary>
        public static SkuName Shared { get; } = new SkuName(SharedValue);
        /// <summary> Basic. </summary>
        public static SkuName Basic { get; } = new SkuName(BasicValue);
        /// <summary> Standard. </summary>
        public static SkuName Standard { get; } = new SkuName(StandardValue);
        /// <summary> Premium. </summary>
        public static SkuName Premium { get; } = new SkuName(PremiumValue);
        /// <summary> Dynamic. </summary>
        public static SkuName Dynamic { get; } = new SkuName(DynamicValue);
        /// <summary> Isolated. </summary>
        public static SkuName Isolated { get; } = new SkuName(IsolatedValue);
        /// <summary> IsolatedV2. </summary>
        public static SkuName IsolatedV2 { get; } = new SkuName(IsolatedV2Value);
        /// <summary> PremiumV2. </summary>
        public static SkuName PremiumV2 { get; } = new SkuName(PremiumV2Value);
        /// <summary> PremiumV3. </summary>
        public static SkuName PremiumV3 { get; } = new SkuName(PremiumV3Value);
        /// <summary> PremiumContainer. </summary>
        public static SkuName PremiumContainer { get; } = new SkuName(PremiumContainerValue);
        /// <summary> ElasticPremium. </summary>
        public static SkuName ElasticPremium { get; } = new SkuName(ElasticPremiumValue);
        /// <summary> ElasticIsolated. </summary>
        public static SkuName ElasticIsolated { get; } = new SkuName(ElasticIsolatedValue);
        /// <summary> Determines if two <see cref="SkuName"/> values are the same. </summary>
        public static bool operator ==(SkuName left, SkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SkuName"/> values are not the same. </summary>
        public static bool operator !=(SkuName left, SkuName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SkuName"/>. </summary>
        public static implicit operator SkuName(string value) => new SkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
