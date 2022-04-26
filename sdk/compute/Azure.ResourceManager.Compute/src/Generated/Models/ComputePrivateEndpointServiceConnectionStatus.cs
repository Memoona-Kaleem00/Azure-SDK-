// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The private endpoint connection status. </summary>
    public readonly partial struct ComputePrivateEndpointServiceConnectionStatus : IEquatable<ComputePrivateEndpointServiceConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ComputePrivateEndpointServiceConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ComputePrivateEndpointServiceConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";

        /// <summary> Pending. </summary>
        public static ComputePrivateEndpointServiceConnectionStatus Pending { get; } = new ComputePrivateEndpointServiceConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static ComputePrivateEndpointServiceConnectionStatus Approved { get; } = new ComputePrivateEndpointServiceConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static ComputePrivateEndpointServiceConnectionStatus Rejected { get; } = new ComputePrivateEndpointServiceConnectionStatus(RejectedValue);
        /// <summary> Determines if two <see cref="ComputePrivateEndpointServiceConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(ComputePrivateEndpointServiceConnectionStatus left, ComputePrivateEndpointServiceConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ComputePrivateEndpointServiceConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(ComputePrivateEndpointServiceConnectionStatus left, ComputePrivateEndpointServiceConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ComputePrivateEndpointServiceConnectionStatus"/>. </summary>
        public static implicit operator ComputePrivateEndpointServiceConnectionStatus(string value) => new ComputePrivateEndpointServiceConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComputePrivateEndpointServiceConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ComputePrivateEndpointServiceConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
