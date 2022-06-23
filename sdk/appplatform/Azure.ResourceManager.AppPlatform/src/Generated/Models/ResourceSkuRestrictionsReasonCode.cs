// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Gets the reason for restriction. Possible values include: &apos;QuotaId&apos;, &apos;NotAvailableForSubscription&apos;. </summary>
    public readonly partial struct ResourceSkuRestrictionsReasonCode : IEquatable<ResourceSkuRestrictionsReasonCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceSkuRestrictionsReasonCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceSkuRestrictionsReasonCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string QuotaIdValue = "QuotaId";
        private const string NotAvailableForSubscriptionValue = "NotAvailableForSubscription";

        /// <summary> QuotaId. </summary>
        public static ResourceSkuRestrictionsReasonCode QuotaId { get; } = new ResourceSkuRestrictionsReasonCode(QuotaIdValue);
        /// <summary> NotAvailableForSubscription. </summary>
        public static ResourceSkuRestrictionsReasonCode NotAvailableForSubscription { get; } = new ResourceSkuRestrictionsReasonCode(NotAvailableForSubscriptionValue);
        /// <summary> Determines if two <see cref="ResourceSkuRestrictionsReasonCode"/> values are the same. </summary>
        public static bool operator ==(ResourceSkuRestrictionsReasonCode left, ResourceSkuRestrictionsReasonCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceSkuRestrictionsReasonCode"/> values are not the same. </summary>
        public static bool operator !=(ResourceSkuRestrictionsReasonCode left, ResourceSkuRestrictionsReasonCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResourceSkuRestrictionsReasonCode"/>. </summary>
        public static implicit operator ResourceSkuRestrictionsReasonCode(string value) => new ResourceSkuRestrictionsReasonCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceSkuRestrictionsReasonCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceSkuRestrictionsReasonCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
