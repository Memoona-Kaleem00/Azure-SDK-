// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary>
    /// The reason for the restriction.
    /// Serialized Name: RestrictionReasonCode
    /// </summary>
    public readonly partial struct RestrictionReasonCode : IEquatable<RestrictionReasonCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RestrictionReasonCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RestrictionReasonCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string QuotaIdValue = "QuotaId";
        private const string NotAvailableForSubscriptionValue = "NotAvailableForSubscription";

        /// <summary>
        /// QuotaId
        /// Serialized Name: RestrictionReasonCode.QuotaId
        /// </summary>
        public static RestrictionReasonCode QuotaId { get; } = new RestrictionReasonCode(QuotaIdValue);
        /// <summary>
        /// NotAvailableForSubscription
        /// Serialized Name: RestrictionReasonCode.NotAvailableForSubscription
        /// </summary>
        public static RestrictionReasonCode NotAvailableForSubscription { get; } = new RestrictionReasonCode(NotAvailableForSubscriptionValue);
        /// <summary> Determines if two <see cref="RestrictionReasonCode"/> values are the same. </summary>
        public static bool operator ==(RestrictionReasonCode left, RestrictionReasonCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RestrictionReasonCode"/> values are not the same. </summary>
        public static bool operator !=(RestrictionReasonCode left, RestrictionReasonCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RestrictionReasonCode"/>. </summary>
        public static implicit operator RestrictionReasonCode(string value) => new RestrictionReasonCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RestrictionReasonCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RestrictionReasonCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
