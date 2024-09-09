// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MongoCluster.Models
{
    /// <summary> The current provisioning state. </summary>
    public readonly partial struct MongoClusterPrivateEndpointConnectionProvisioningState : IEquatable<MongoClusterPrivateEndpointConnectionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MongoClusterPrivateEndpointConnectionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MongoClusterPrivateEndpointConnectionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";

        /// <summary> Connection has been provisioned. </summary>
        public static MongoClusterPrivateEndpointConnectionProvisioningState Succeeded { get; } = new MongoClusterPrivateEndpointConnectionProvisioningState(SucceededValue);
        /// <summary> Connection is being created. </summary>
        public static MongoClusterPrivateEndpointConnectionProvisioningState Creating { get; } = new MongoClusterPrivateEndpointConnectionProvisioningState(CreatingValue);
        /// <summary> Connection is being deleted. </summary>
        public static MongoClusterPrivateEndpointConnectionProvisioningState Deleting { get; } = new MongoClusterPrivateEndpointConnectionProvisioningState(DeletingValue);
        /// <summary> Connection provisioning has failed. </summary>
        public static MongoClusterPrivateEndpointConnectionProvisioningState Failed { get; } = new MongoClusterPrivateEndpointConnectionProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="MongoClusterPrivateEndpointConnectionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(MongoClusterPrivateEndpointConnectionProvisioningState left, MongoClusterPrivateEndpointConnectionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MongoClusterPrivateEndpointConnectionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(MongoClusterPrivateEndpointConnectionProvisioningState left, MongoClusterPrivateEndpointConnectionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MongoClusterPrivateEndpointConnectionProvisioningState"/>. </summary>
        public static implicit operator MongoClusterPrivateEndpointConnectionProvisioningState(string value) => new MongoClusterPrivateEndpointConnectionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MongoClusterPrivateEndpointConnectionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MongoClusterPrivateEndpointConnectionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
