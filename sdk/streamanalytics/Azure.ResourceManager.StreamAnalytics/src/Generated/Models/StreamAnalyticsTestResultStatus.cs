// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary>
    /// The status of the test input or output request.
    /// Serialized Name: TestDatasourceResultStatus
    /// </summary>
    public readonly partial struct StreamAnalyticsTestResultStatus : IEquatable<StreamAnalyticsTestResultStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsTestResultStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StreamAnalyticsTestResultStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TestSucceededValue = "TestSucceeded";
        private const string TestFailedValue = "TestFailed";

        /// <summary>
        /// The test datasource operation succeeded.
        /// Serialized Name: TestDatasourceResultStatus.TestSucceeded
        /// </summary>
        public static StreamAnalyticsTestResultStatus TestSucceeded { get; } = new StreamAnalyticsTestResultStatus(TestSucceededValue);
        /// <summary>
        /// The test datasource operation failed.
        /// Serialized Name: TestDatasourceResultStatus.TestFailed
        /// </summary>
        public static StreamAnalyticsTestResultStatus TestFailed { get; } = new StreamAnalyticsTestResultStatus(TestFailedValue);
        /// <summary> Determines if two <see cref="StreamAnalyticsTestResultStatus"/> values are the same. </summary>
        public static bool operator ==(StreamAnalyticsTestResultStatus left, StreamAnalyticsTestResultStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StreamAnalyticsTestResultStatus"/> values are not the same. </summary>
        public static bool operator !=(StreamAnalyticsTestResultStatus left, StreamAnalyticsTestResultStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StreamAnalyticsTestResultStatus"/>. </summary>
        public static implicit operator StreamAnalyticsTestResultStatus(string value) => new StreamAnalyticsTestResultStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StreamAnalyticsTestResultStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StreamAnalyticsTestResultStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
