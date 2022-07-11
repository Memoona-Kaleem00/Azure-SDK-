// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// The trigger type of the function
    /// Serialized Name: TriggerTypes
    /// </summary>
    public readonly partial struct TriggerType : IEquatable<TriggerType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TriggerType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TriggerType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HttpTriggerValue = "HttpTrigger";
        private const string UnknownValue = "Unknown";

        /// <summary>
        /// HttpTrigger
        /// Serialized Name: TriggerTypes.HttpTrigger
        /// </summary>
        public static TriggerType HttpTrigger { get; } = new TriggerType(HttpTriggerValue);
        /// <summary>
        /// Unknown
        /// Serialized Name: TriggerTypes.Unknown
        /// </summary>
        public static TriggerType Unknown { get; } = new TriggerType(UnknownValue);
        /// <summary> Determines if two <see cref="TriggerType"/> values are the same. </summary>
        public static bool operator ==(TriggerType left, TriggerType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TriggerType"/> values are not the same. </summary>
        public static bool operator !=(TriggerType left, TriggerType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TriggerType"/>. </summary>
        public static implicit operator TriggerType(string value) => new TriggerType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TriggerType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TriggerType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
