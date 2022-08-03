// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary>
    /// Value may be JobStartTime, CustomTime, or LastOutputEventTime to indicate whether the starting point of the output event stream should start whenever the job is started, start at a custom user time stamp specified via the outputStartTime property, or start from the last event output time.
    /// Serialized Name: OutputStartMode
    /// </summary>
    public readonly partial struct OutputStartMode : IEquatable<OutputStartMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OutputStartMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OutputStartMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string JobStartTimeValue = "JobStartTime";
        private const string CustomTimeValue = "CustomTime";
        private const string LastOutputEventTimeValue = "LastOutputEventTime";

        /// <summary>
        /// JobStartTime
        /// Serialized Name: OutputStartMode.JobStartTime
        /// </summary>
        public static OutputStartMode JobStartTime { get; } = new OutputStartMode(JobStartTimeValue);
        /// <summary>
        /// CustomTime
        /// Serialized Name: OutputStartMode.CustomTime
        /// </summary>
        public static OutputStartMode CustomTime { get; } = new OutputStartMode(CustomTimeValue);
        /// <summary>
        /// LastOutputEventTime
        /// Serialized Name: OutputStartMode.LastOutputEventTime
        /// </summary>
        public static OutputStartMode LastOutputEventTime { get; } = new OutputStartMode(LastOutputEventTimeValue);
        /// <summary> Determines if two <see cref="OutputStartMode"/> values are the same. </summary>
        public static bool operator ==(OutputStartMode left, OutputStartMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OutputStartMode"/> values are not the same. </summary>
        public static bool operator !=(OutputStartMode left, OutputStartMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OutputStartMode"/>. </summary>
        public static implicit operator OutputStartMode(string value) => new OutputStartMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OutputStartMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OutputStartMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
