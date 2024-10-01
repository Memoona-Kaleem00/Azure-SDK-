// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary>
    /// Specifies the mode of VM Guest Patching to IaaS virtual machine or virtual
    /// machines associated to virtual machine scale set with OrchestrationMode as
    /// Flexible.
    /// </summary>
    public readonly partial struct ComputeFleetLinuxVmGuestPatchMode : IEquatable<ComputeFleetLinuxVmGuestPatchMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ComputeFleetLinuxVmGuestPatchMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ComputeFleetLinuxVmGuestPatchMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ImageDefaultValue = "ImageDefault";
        private const string AutomaticByPlatformValue = "AutomaticByPlatform";

        /// <summary> The virtual machine's default patching configuration is used. </summary>
        public static ComputeFleetLinuxVmGuestPatchMode ImageDefault { get; } = new ComputeFleetLinuxVmGuestPatchMode(ImageDefaultValue);
        /// <summary> The virtual machine will be automatically updated by the platform. The property provisionVMAgent must be true. </summary>
        public static ComputeFleetLinuxVmGuestPatchMode AutomaticByPlatform { get; } = new ComputeFleetLinuxVmGuestPatchMode(AutomaticByPlatformValue);
        /// <summary> Determines if two <see cref="ComputeFleetLinuxVmGuestPatchMode"/> values are the same. </summary>
        public static bool operator ==(ComputeFleetLinuxVmGuestPatchMode left, ComputeFleetLinuxVmGuestPatchMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ComputeFleetLinuxVmGuestPatchMode"/> values are not the same. </summary>
        public static bool operator !=(ComputeFleetLinuxVmGuestPatchMode left, ComputeFleetLinuxVmGuestPatchMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ComputeFleetLinuxVmGuestPatchMode"/>. </summary>
        public static implicit operator ComputeFleetLinuxVmGuestPatchMode(string value) => new ComputeFleetLinuxVmGuestPatchMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComputeFleetLinuxVmGuestPatchMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ComputeFleetLinuxVmGuestPatchMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
