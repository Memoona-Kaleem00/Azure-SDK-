// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The operating system type. The default is Linux. </summary>
    public readonly partial struct ContainerServiceOSType : IEquatable<ContainerServiceOSType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerServiceOSType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerServiceOSType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LinuxValue = "Linux";
        private const string WindowsValue = "Windows";

        /// <summary> Use Linux. </summary>
        public static ContainerServiceOSType Linux { get; } = new ContainerServiceOSType(LinuxValue);
        /// <summary> Use Windows. </summary>
        public static ContainerServiceOSType Windows { get; } = new ContainerServiceOSType(WindowsValue);
        /// <summary> Determines if two <see cref="ContainerServiceOSType"/> values are the same. </summary>
        public static bool operator ==(ContainerServiceOSType left, ContainerServiceOSType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerServiceOSType"/> values are not the same. </summary>
        public static bool operator !=(ContainerServiceOSType left, ContainerServiceOSType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ContainerServiceOSType"/>. </summary>
        public static implicit operator ContainerServiceOSType(string value) => new ContainerServiceOSType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerServiceOSType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerServiceOSType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
