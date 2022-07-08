// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The resource provisioning state. </summary>
    public readonly partial struct KnownDataCollectionRuleAssociationProvisioningState : IEquatable<KnownDataCollectionRuleAssociationProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KnownDataCollectionRuleAssociationProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KnownDataCollectionRuleAssociationProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";

        /// <summary> Creating. </summary>
        public static KnownDataCollectionRuleAssociationProvisioningState Creating { get; } = new KnownDataCollectionRuleAssociationProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static KnownDataCollectionRuleAssociationProvisioningState Updating { get; } = new KnownDataCollectionRuleAssociationProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static KnownDataCollectionRuleAssociationProvisioningState Deleting { get; } = new KnownDataCollectionRuleAssociationProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static KnownDataCollectionRuleAssociationProvisioningState Succeeded { get; } = new KnownDataCollectionRuleAssociationProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static KnownDataCollectionRuleAssociationProvisioningState Failed { get; } = new KnownDataCollectionRuleAssociationProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="KnownDataCollectionRuleAssociationProvisioningState"/> values are the same. </summary>
        public static bool operator ==(KnownDataCollectionRuleAssociationProvisioningState left, KnownDataCollectionRuleAssociationProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KnownDataCollectionRuleAssociationProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(KnownDataCollectionRuleAssociationProvisioningState left, KnownDataCollectionRuleAssociationProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KnownDataCollectionRuleAssociationProvisioningState"/>. </summary>
        public static implicit operator KnownDataCollectionRuleAssociationProvisioningState(string value) => new KnownDataCollectionRuleAssociationProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KnownDataCollectionRuleAssociationProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KnownDataCollectionRuleAssociationProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
