// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Automation key name. </summary>
    public readonly partial struct AutomationKeyName : IEquatable<AutomationKeyName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AutomationKeyName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AutomationKeyName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrimaryValue = "Primary";
        private const string SecondaryValue = "Secondary";

        /// <summary> Primary. </summary>
        public static AutomationKeyName Primary { get; } = new AutomationKeyName(PrimaryValue);
        /// <summary> Secondary. </summary>
        public static AutomationKeyName Secondary { get; } = new AutomationKeyName(SecondaryValue);
        /// <summary> Determines if two <see cref="AutomationKeyName"/> values are the same. </summary>
        public static bool operator ==(AutomationKeyName left, AutomationKeyName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AutomationKeyName"/> values are not the same. </summary>
        public static bool operator !=(AutomationKeyName left, AutomationKeyName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AutomationKeyName"/>. </summary>
        public static implicit operator AutomationKeyName(string value) => new AutomationKeyName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AutomationKeyName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AutomationKeyName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
