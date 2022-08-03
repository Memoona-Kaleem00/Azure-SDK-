// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary>
    /// The status of the sample input request.
    /// Serialized Name: SampleInputResultStatus
    /// </summary>
    public readonly partial struct SampleInputResultStatus : IEquatable<SampleInputResultStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SampleInputResultStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SampleInputResultStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReadAllEventsInRangeValue = "ReadAllEventsInRange";
        private const string NoEventsFoundInRangeValue = "NoEventsFoundInRange";
        private const string ErrorConnectingToInputValue = "ErrorConnectingToInput";

        /// <summary>
        /// The sample input operation successfully read all the events in the range.
        /// Serialized Name: SampleInputResultStatus.ReadAllEventsInRange
        /// </summary>
        public static SampleInputResultStatus ReadAllEventsInRange { get; } = new SampleInputResultStatus(ReadAllEventsInRangeValue);
        /// <summary>
        /// The sample input operation found no events in the range.
        /// Serialized Name: SampleInputResultStatus.NoEventsFoundInRange
        /// </summary>
        public static SampleInputResultStatus NoEventsFoundInRange { get; } = new SampleInputResultStatus(NoEventsFoundInRangeValue);
        /// <summary>
        /// The sample input operation failed to connect to the input.
        /// Serialized Name: SampleInputResultStatus.ErrorConnectingToInput
        /// </summary>
        public static SampleInputResultStatus ErrorConnectingToInput { get; } = new SampleInputResultStatus(ErrorConnectingToInputValue);
        /// <summary> Determines if two <see cref="SampleInputResultStatus"/> values are the same. </summary>
        public static bool operator ==(SampleInputResultStatus left, SampleInputResultStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SampleInputResultStatus"/> values are not the same. </summary>
        public static bool operator !=(SampleInputResultStatus left, SampleInputResultStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SampleInputResultStatus"/>. </summary>
        public static implicit operator SampleInputResultStatus(string value) => new SampleInputResultStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SampleInputResultStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SampleInputResultStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
