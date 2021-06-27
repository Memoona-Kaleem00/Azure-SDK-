// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Object tracker accuracy: low, medium, high. Higher accuracy leads to higher CPU consumption in average. </summary>
    public readonly partial struct ObjectTrackingAccuracy : IEquatable<ObjectTrackingAccuracy>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ObjectTrackingAccuracy"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ObjectTrackingAccuracy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LowValue = "low";
        private const string MediumValue = "medium";
        private const string HighValue = "high";

        /// <summary> Low accuracy. </summary>
        public static ObjectTrackingAccuracy Low { get; } = new ObjectTrackingAccuracy(LowValue);
        /// <summary> Medium accuracy. </summary>
        public static ObjectTrackingAccuracy Medium { get; } = new ObjectTrackingAccuracy(MediumValue);
        /// <summary> High accuracy. </summary>
        public static ObjectTrackingAccuracy High { get; } = new ObjectTrackingAccuracy(HighValue);
        /// <summary> Determines if two <see cref="ObjectTrackingAccuracy"/> values are the same. </summary>
        public static bool operator ==(ObjectTrackingAccuracy left, ObjectTrackingAccuracy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ObjectTrackingAccuracy"/> values are not the same. </summary>
        public static bool operator !=(ObjectTrackingAccuracy left, ObjectTrackingAccuracy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ObjectTrackingAccuracy"/>. </summary>
        public static implicit operator ObjectTrackingAccuracy(string value) => new ObjectTrackingAccuracy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ObjectTrackingAccuracy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ObjectTrackingAccuracy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
