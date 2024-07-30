// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The library management action. </summary>
    public readonly partial struct LibraryManagementAction : IEquatable<LibraryManagementAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LibraryManagementAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LibraryManagementAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InstallValue = "Install";
        private const string UninstallValue = "Uninstall";

        /// <summary> Install. </summary>
        public static LibraryManagementAction Install { get; } = new LibraryManagementAction(InstallValue);
        /// <summary> Uninstall. </summary>
        public static LibraryManagementAction Uninstall { get; } = new LibraryManagementAction(UninstallValue);
        /// <summary> Determines if two <see cref="LibraryManagementAction"/> values are the same. </summary>
        public static bool operator ==(LibraryManagementAction left, LibraryManagementAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LibraryManagementAction"/> values are not the same. </summary>
        public static bool operator !=(LibraryManagementAction left, LibraryManagementAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LibraryManagementAction"/>. </summary>
        public static implicit operator LibraryManagementAction(string value) => new LibraryManagementAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LibraryManagementAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LibraryManagementAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
