// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ShareLink.Models
{
    /// <summary> Reflects the deletion recovery level currently in effect for storage accounts in the current vault. If it contains &apos;Purgeable&apos; the storage account can be permanently deleted by a privileged user; otherwise, only the system can purge the storage account, at the end of the retention interval. </summary>
    public readonly partial struct DeletionRecoveryLevel : IEquatable<DeletionRecoveryLevel>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DeletionRecoveryLevel"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeletionRecoveryLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PurgeableValue = "Purgeable";
        private const string RecoverablePurgeableValue = "Recoverable+Purgeable";
        private const string RecoverableValue = "Recoverable";
        private const string RecoverableProtectedSubscriptionValue = "Recoverable+ProtectedSubscription";
        private const string CustomizedRecoverablePurgeableValue = "CustomizedRecoverable+Purgeable";
        private const string CustomizedRecoverableValue = "CustomizedRecoverable";
        private const string CustomizedRecoverableProtectedSubscriptionValue = "CustomizedRecoverable+ProtectedSubscription";

        /// <summary> Denotes a vault state in which deletion is an irreversible operation, without the possibility for recovery. This level corresponds to no protection being available against a Delete operation; the data is irretrievably lost upon accepting a Delete operation at the entity level or higher (vault, resource group, subscription etc.). </summary>
        public static DeletionRecoveryLevel Purgeable { get; } = new DeletionRecoveryLevel(PurgeableValue);
        /// <summary> Denotes a vault state in which deletion is recoverable, and which also permits immediate and permanent deletion (i.e. purge). This level guarantees the recoverability of the deleted entity during the retention interval (90 days), unless a Purge operation is requested, or the subscription is cancelled. System wil permanently delete it after 90 days, if not recovered. </summary>
        public static DeletionRecoveryLevel RecoverablePurgeable { get; } = new DeletionRecoveryLevel(RecoverablePurgeableValue);
        /// <summary> Denotes a vault state in which deletion is recoverable without the possibility for immediate and permanent deletion (i.e. purge). This level guarantees the recoverability of the deleted entity during the retention interval(90 days) and while the subscription is still available. System wil permanently delete it after 90 days, if not recovered. </summary>
        public static DeletionRecoveryLevel Recoverable { get; } = new DeletionRecoveryLevel(RecoverableValue);
        /// <summary> Denotes a vault and subscription state in which deletion is recoverable within retention interval (90 days), immediate and permanent deletion (i.e. purge) is not permitted, and in which the subscription itself  cannot be permanently canceled. System wil permanently delete it after 90 days, if not recovered. </summary>
        public static DeletionRecoveryLevel RecoverableProtectedSubscription { get; } = new DeletionRecoveryLevel(RecoverableProtectedSubscriptionValue);
        /// <summary> Denotes a vault state in which deletion is recoverable, and which also permits immediate and permanent deletion (i.e. purge when 7&lt;= SoftDeleteRetentionInDays &lt; 90). This level guarantees the recoverability of the deleted entity during the retention interval, unless a Purge operation is requested, or the subscription is cancelled. </summary>
        public static DeletionRecoveryLevel CustomizedRecoverablePurgeable { get; } = new DeletionRecoveryLevel(CustomizedRecoverablePurgeableValue);
        /// <summary> Denotes a vault state in which deletion is recoverable without the possibility for immediate and permanent deletion (i.e. purge when 7&lt;= SoftDeleteRetentionInDays &lt; 90).This level guarantees the recoverability of the deleted entity during the retention interval and while the subscription is still available. </summary>
        public static DeletionRecoveryLevel CustomizedRecoverable { get; } = new DeletionRecoveryLevel(CustomizedRecoverableValue);
        /// <summary> Denotes a vault and subscription state in which deletion is recoverable, immediate and permanent deletion (i.e. purge) is not permitted, and in which the subscription itself cannot be permanently canceled when 7&lt;= SoftDeleteRetentionInDays &lt; 90. This level guarantees the recoverability of the deleted entity during the retention interval, and also reflects the fact that the subscription itself cannot be cancelled. </summary>
        public static DeletionRecoveryLevel CustomizedRecoverableProtectedSubscription { get; } = new DeletionRecoveryLevel(CustomizedRecoverableProtectedSubscriptionValue);
        /// <summary> Determines if two <see cref="DeletionRecoveryLevel"/> values are the same. </summary>
        public static bool operator ==(DeletionRecoveryLevel left, DeletionRecoveryLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeletionRecoveryLevel"/> values are not the same. </summary>
        public static bool operator !=(DeletionRecoveryLevel left, DeletionRecoveryLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DeletionRecoveryLevel"/>. </summary>
        public static implicit operator DeletionRecoveryLevel(string value) => new DeletionRecoveryLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeletionRecoveryLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeletionRecoveryLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
