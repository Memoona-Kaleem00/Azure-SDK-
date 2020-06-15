// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Spark.Models
{
    /// <summary> The SparkStatementLanguageType. </summary>
    public readonly partial struct SparkStatementLanguageType : IEquatable<SparkStatementLanguageType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SparkStatementLanguageType"/> values are the same. </summary>
        public SparkStatementLanguageType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SparkValue = "spark";
        private const string PysparkValue = "pyspark";
        private const string DotnetsparkValue = "dotnetspark";
        private const string SqlValue = "sql";

        /// <summary> spark. </summary>
        public static SparkStatementLanguageType Spark { get; } = new SparkStatementLanguageType(SparkValue);
        /// <summary> pyspark. </summary>
        public static SparkStatementLanguageType Pyspark { get; } = new SparkStatementLanguageType(PysparkValue);
        /// <summary> dotnetspark. </summary>
        public static SparkStatementLanguageType Dotnetspark { get; } = new SparkStatementLanguageType(DotnetsparkValue);
        /// <summary> sql. </summary>
        public static SparkStatementLanguageType Sql { get; } = new SparkStatementLanguageType(SqlValue);
        /// <summary> Determines if two <see cref="SparkStatementLanguageType"/> values are the same. </summary>
        public static bool operator ==(SparkStatementLanguageType left, SparkStatementLanguageType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SparkStatementLanguageType"/> values are not the same. </summary>
        public static bool operator !=(SparkStatementLanguageType left, SparkStatementLanguageType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SparkStatementLanguageType"/>. </summary>
        public static implicit operator SparkStatementLanguageType(string value) => new SparkStatementLanguageType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SparkStatementLanguageType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SparkStatementLanguageType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
