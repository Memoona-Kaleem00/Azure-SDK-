// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Gets or sets the stream type. </summary>
    public readonly partial struct JobStreamType : IEquatable<JobStreamType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="JobStreamType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public JobStreamType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ProgressValue = "Progress";
        private const string OutputValue = "Output";
        private const string WarningValue = "Warning";
        private const string ErrorValue = "Error";
        private const string DebugValue = "Debug";
        private const string VerboseValue = "Verbose";
        private const string AnyValue = "Any";

        /// <summary> Progress. </summary>
        public static JobStreamType Progress { get; } = new JobStreamType(ProgressValue);
        /// <summary> Output. </summary>
        public static JobStreamType Output { get; } = new JobStreamType(OutputValue);
        /// <summary> Warning. </summary>
        public static JobStreamType Warning { get; } = new JobStreamType(WarningValue);
        /// <summary> Error. </summary>
        public static JobStreamType Error { get; } = new JobStreamType(ErrorValue);
        /// <summary> Debug. </summary>
        public static JobStreamType Debug { get; } = new JobStreamType(DebugValue);
        /// <summary> Verbose. </summary>
        public static JobStreamType Verbose { get; } = new JobStreamType(VerboseValue);
        /// <summary> Any. </summary>
        public static JobStreamType Any { get; } = new JobStreamType(AnyValue);
        /// <summary> Determines if two <see cref="JobStreamType"/> values are the same. </summary>
        public static bool operator ==(JobStreamType left, JobStreamType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobStreamType"/> values are not the same. </summary>
        public static bool operator !=(JobStreamType left, JobStreamType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobStreamType"/>. </summary>
        public static implicit operator JobStreamType(string value) => new JobStreamType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobStreamType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobStreamType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
