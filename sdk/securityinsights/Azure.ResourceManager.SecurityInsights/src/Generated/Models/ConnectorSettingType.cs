// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The kind of the setting. </summary>
    public readonly partial struct ConnectorSettingType : IEquatable<ConnectorSettingType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConnectorSettingType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectorSettingType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CopyableLabelValue = "CopyableLabel";
        private const string InstructionStepsGroupValue = "InstructionStepsGroup";
        private const string InfoMessageValue = "InfoMessage";

        /// <summary> CopyableLabel. </summary>
        public static ConnectorSettingType CopyableLabel { get; } = new ConnectorSettingType(CopyableLabelValue);
        /// <summary> InstructionStepsGroup. </summary>
        public static ConnectorSettingType InstructionStepsGroup { get; } = new ConnectorSettingType(InstructionStepsGroupValue);
        /// <summary> InfoMessage. </summary>
        public static ConnectorSettingType InfoMessage { get; } = new ConnectorSettingType(InfoMessageValue);
        /// <summary> Determines if two <see cref="ConnectorSettingType"/> values are the same. </summary>
        public static bool operator ==(ConnectorSettingType left, ConnectorSettingType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectorSettingType"/> values are not the same. </summary>
        public static bool operator !=(ConnectorSettingType left, ConnectorSettingType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ConnectorSettingType"/>. </summary>
        public static implicit operator ConnectorSettingType(string value) => new ConnectorSettingType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectorSettingType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectorSettingType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
