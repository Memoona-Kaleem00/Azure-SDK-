// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> Indicates whether this solution is the recommended. </summary>
    public readonly partial struct IsRecommendSolution : IEquatable<IsRecommendSolution>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IsRecommendSolution"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IsRecommendSolution(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "true";
        private const string FalseValue = "false";

        /// <summary> This solution is the recommended. </summary>
        public static IsRecommendSolution True { get; } = new IsRecommendSolution(TrueValue);
        /// <summary> This solution is not the recommended. </summary>
        public static IsRecommendSolution False { get; } = new IsRecommendSolution(FalseValue);
        /// <summary> Determines if two <see cref="IsRecommendSolution"/> values are the same. </summary>
        public static bool operator ==(IsRecommendSolution left, IsRecommendSolution right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IsRecommendSolution"/> values are not the same. </summary>
        public static bool operator !=(IsRecommendSolution left, IsRecommendSolution right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IsRecommendSolution"/>. </summary>
        public static implicit operator IsRecommendSolution(string value) => new IsRecommendSolution(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IsRecommendSolution other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IsRecommendSolution other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
