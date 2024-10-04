// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.ContentSafety
{
    /// <summary> The AnalyzeImageOutputType. </summary>
    public readonly partial struct AnalyzeImageOutputType : IEquatable<AnalyzeImageOutputType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AnalyzeImageOutputType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AnalyzeImageOutputType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FourSeverityLevelsValue = "FourSeverityLevels";

        /// <summary> FourSeverityLevels. </summary>
        public static AnalyzeImageOutputType FourSeverityLevels { get; } = new AnalyzeImageOutputType(FourSeverityLevelsValue);
        /// <summary> Determines if two <see cref="AnalyzeImageOutputType"/> values are the same. </summary>
        public static bool operator ==(AnalyzeImageOutputType left, AnalyzeImageOutputType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AnalyzeImageOutputType"/> values are not the same. </summary>
        public static bool operator !=(AnalyzeImageOutputType left, AnalyzeImageOutputType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AnalyzeImageOutputType"/>. </summary>
        public static implicit operator AnalyzeImageOutputType(string value) => new AnalyzeImageOutputType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AnalyzeImageOutputType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AnalyzeImageOutputType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
