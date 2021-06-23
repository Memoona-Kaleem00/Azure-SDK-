// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Current availability stage of the product. Availability stage. </summary>
    public readonly partial struct AvailabilityStage : IEquatable<AvailabilityStage>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AvailabilityStage"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AvailabilityStage(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvailableValue = "Available";
        private const string ComingSoonValue = "ComingSoon";
        private const string PreviewValue = "Preview";
        private const string DeprecatedValue = "Deprecated";
        private const string SignupValue = "Signup";
        private const string UnavailableValue = "Unavailable";

        /// <summary> Product is available. </summary>
        public static AvailabilityStage Available { get; } = new AvailabilityStage(AvailableValue);
        /// <summary> Product is coming soon. </summary>
        public static AvailabilityStage ComingSoon { get; } = new AvailabilityStage(ComingSoonValue);
        /// <summary> Product is in preview. </summary>
        public static AvailabilityStage Preview { get; } = new AvailabilityStage(PreviewValue);
        /// <summary> Product is deprecated. </summary>
        public static AvailabilityStage Deprecated { get; } = new AvailabilityStage(DeprecatedValue);
        /// <summary> Product is available only on signup. </summary>
        public static AvailabilityStage Signup { get; } = new AvailabilityStage(SignupValue);
        /// <summary> Product is not available. </summary>
        public static AvailabilityStage Unavailable { get; } = new AvailabilityStage(UnavailableValue);
        /// <summary> Determines if two <see cref="AvailabilityStage"/> values are the same. </summary>
        public static bool operator ==(AvailabilityStage left, AvailabilityStage right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AvailabilityStage"/> values are not the same. </summary>
        public static bool operator !=(AvailabilityStage left, AvailabilityStage right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AvailabilityStage"/>. </summary>
        public static implicit operator AvailabilityStage(string value) => new AvailabilityStage(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AvailabilityStage other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AvailabilityStage other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
