// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.ContentSafety
{
    /// <summary> The AnalyzeTextOutputType. </summary>
    public readonly partial struct AnalyzeTextOutputType : IEquatable<AnalyzeTextOutputType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AnalyzeTextOutputType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AnalyzeTextOutputType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FourSeverityLevelsValue = "FourSeverityLevels";
        private const string EightSeverityLevelsValue = "EightSeverityLevels";

        /// <summary> FourSeverityLevels. </summary>
        public static AnalyzeTextOutputType FourSeverityLevels { get; } = new AnalyzeTextOutputType(FourSeverityLevelsValue);
        /// <summary> EightSeverityLevels. </summary>
        public static AnalyzeTextOutputType EightSeverityLevels { get; } = new AnalyzeTextOutputType(EightSeverityLevelsValue);
        /// <summary> Determines if two <see cref="AnalyzeTextOutputType"/> values are the same. </summary>
        public static bool operator ==(AnalyzeTextOutputType left, AnalyzeTextOutputType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AnalyzeTextOutputType"/> values are not the same. </summary>
        public static bool operator !=(AnalyzeTextOutputType left, AnalyzeTextOutputType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AnalyzeTextOutputType"/>. </summary>
        public static implicit operator AnalyzeTextOutputType(string value) => new AnalyzeTextOutputType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AnalyzeTextOutputType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AnalyzeTextOutputType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
