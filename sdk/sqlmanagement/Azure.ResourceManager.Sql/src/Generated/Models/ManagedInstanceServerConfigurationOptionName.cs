// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The ManagedInstanceServerConfigurationOptionName. </summary>
    public readonly partial struct ManagedInstanceServerConfigurationOptionName : IEquatable<ManagedInstanceServerConfigurationOptionName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceServerConfigurationOptionName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedInstanceServerConfigurationOptionName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowPolybaseExportValue = "allowPolybaseExport";

        /// <summary> allowPolybaseExport. </summary>
        public static ManagedInstanceServerConfigurationOptionName AllowPolybaseExport { get; } = new ManagedInstanceServerConfigurationOptionName(AllowPolybaseExportValue);
        /// <summary> Determines if two <see cref="ManagedInstanceServerConfigurationOptionName"/> values are the same. </summary>
        public static bool operator ==(ManagedInstanceServerConfigurationOptionName left, ManagedInstanceServerConfigurationOptionName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedInstanceServerConfigurationOptionName"/> values are not the same. </summary>
        public static bool operator !=(ManagedInstanceServerConfigurationOptionName left, ManagedInstanceServerConfigurationOptionName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ManagedInstanceServerConfigurationOptionName"/>. </summary>
        public static implicit operator ManagedInstanceServerConfigurationOptionName(string value) => new ManagedInstanceServerConfigurationOptionName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedInstanceServerConfigurationOptionName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedInstanceServerConfigurationOptionName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
