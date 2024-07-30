// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> State of the deployment stack. </summary>
    public readonly partial struct DeploymentStackProvisioningState : IEquatable<DeploymentStackProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeploymentStackProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeploymentStackProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "creating";
        private const string ValidatingValue = "validating";
        private const string WaitingValue = "waiting";
        private const string DeployingValue = "deploying";
        private const string CancelingValue = "canceling";
        private const string UpdatingDenyAssignmentsValue = "updatingDenyAssignments";
        private const string DeletingResourcesValue = "deletingResources";
        private const string SucceededValue = "succeeded";
        private const string FailedValue = "failed";
        private const string CanceledValue = "canceled";
        private const string DeletingValue = "deleting";

        /// <summary> creating. </summary>
        public static DeploymentStackProvisioningState Creating { get; } = new DeploymentStackProvisioningState(CreatingValue);
        /// <summary> validating. </summary>
        public static DeploymentStackProvisioningState Validating { get; } = new DeploymentStackProvisioningState(ValidatingValue);
        /// <summary> waiting. </summary>
        public static DeploymentStackProvisioningState Waiting { get; } = new DeploymentStackProvisioningState(WaitingValue);
        /// <summary> deploying. </summary>
        public static DeploymentStackProvisioningState Deploying { get; } = new DeploymentStackProvisioningState(DeployingValue);
        /// <summary> canceling. </summary>
        public static DeploymentStackProvisioningState Canceling { get; } = new DeploymentStackProvisioningState(CancelingValue);
        /// <summary> updatingDenyAssignments. </summary>
        public static DeploymentStackProvisioningState UpdatingDenyAssignments { get; } = new DeploymentStackProvisioningState(UpdatingDenyAssignmentsValue);
        /// <summary> deletingResources. </summary>
        public static DeploymentStackProvisioningState DeletingResources { get; } = new DeploymentStackProvisioningState(DeletingResourcesValue);
        /// <summary> succeeded. </summary>
        public static DeploymentStackProvisioningState Succeeded { get; } = new DeploymentStackProvisioningState(SucceededValue);
        /// <summary> failed. </summary>
        public static DeploymentStackProvisioningState Failed { get; } = new DeploymentStackProvisioningState(FailedValue);
        /// <summary> canceled. </summary>
        public static DeploymentStackProvisioningState Canceled { get; } = new DeploymentStackProvisioningState(CanceledValue);
        /// <summary> deleting. </summary>
        public static DeploymentStackProvisioningState Deleting { get; } = new DeploymentStackProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="DeploymentStackProvisioningState"/> values are the same. </summary>
        public static bool operator ==(DeploymentStackProvisioningState left, DeploymentStackProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeploymentStackProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(DeploymentStackProvisioningState left, DeploymentStackProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DeploymentStackProvisioningState"/>. </summary>
        public static implicit operator DeploymentStackProvisioningState(string value) => new DeploymentStackProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeploymentStackProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeploymentStackProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
