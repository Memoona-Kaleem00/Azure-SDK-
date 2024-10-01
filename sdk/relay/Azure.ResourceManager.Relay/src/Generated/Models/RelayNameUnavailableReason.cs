// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Relay.Models
{
    /// <summary> Specifies the reason for the unavailability of the service. </summary>
    public readonly partial struct RelayNameUnavailableReason : IEquatable<RelayNameUnavailableReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RelayNameUnavailableReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RelayNameUnavailableReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string InvalidNameValue = "InvalidName";
        private const string SubscriptionIsDisabledValue = "SubscriptionIsDisabled";
        private const string NameInUseValue = "NameInUse";
        private const string NameInLockdownValue = "NameInLockdown";
        private const string TooManyNamespaceInCurrentSubscriptionValue = "TooManyNamespaceInCurrentSubscription";

        /// <summary> None. </summary>
        public static RelayNameUnavailableReason None { get; } = new RelayNameUnavailableReason(NoneValue);
        /// <summary> InvalidName. </summary>
        public static RelayNameUnavailableReason InvalidName { get; } = new RelayNameUnavailableReason(InvalidNameValue);
        /// <summary> SubscriptionIsDisabled. </summary>
        public static RelayNameUnavailableReason SubscriptionIsDisabled { get; } = new RelayNameUnavailableReason(SubscriptionIsDisabledValue);
        /// <summary> NameInUse. </summary>
        public static RelayNameUnavailableReason NameInUse { get; } = new RelayNameUnavailableReason(NameInUseValue);
        /// <summary> NameInLockdown. </summary>
        public static RelayNameUnavailableReason NameInLockdown { get; } = new RelayNameUnavailableReason(NameInLockdownValue);
        /// <summary> TooManyNamespaceInCurrentSubscription. </summary>
        public static RelayNameUnavailableReason TooManyNamespaceInCurrentSubscription { get; } = new RelayNameUnavailableReason(TooManyNamespaceInCurrentSubscriptionValue);
        /// <summary> Determines if two <see cref="RelayNameUnavailableReason"/> values are the same. </summary>
        public static bool operator ==(RelayNameUnavailableReason left, RelayNameUnavailableReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RelayNameUnavailableReason"/> values are not the same. </summary>
        public static bool operator !=(RelayNameUnavailableReason left, RelayNameUnavailableReason right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RelayNameUnavailableReason"/>. </summary>
        public static implicit operator RelayNameUnavailableReason(string value) => new RelayNameUnavailableReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RelayNameUnavailableReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RelayNameUnavailableReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
