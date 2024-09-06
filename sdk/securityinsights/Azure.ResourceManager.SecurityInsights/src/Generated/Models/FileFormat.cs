// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The format of the file. </summary>
    public readonly partial struct FileFormat : IEquatable<FileFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FileFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FileFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CSVValue = "CSV";
        private const string JsonValue = "JSON";
        private const string UnspecifiedValue = "Unspecified";

        /// <summary> A CSV file. </summary>
        public static FileFormat CSV { get; } = new FileFormat(CSVValue);
        /// <summary> A JSON file. </summary>
        public static FileFormat Json { get; } = new FileFormat(JsonValue);
        /// <summary> A file of other format. </summary>
        public static FileFormat Unspecified { get; } = new FileFormat(UnspecifiedValue);
        /// <summary> Determines if two <see cref="FileFormat"/> values are the same. </summary>
        public static bool operator ==(FileFormat left, FileFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FileFormat"/> values are not the same. </summary>
        public static bool operator !=(FileFormat left, FileFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FileFormat"/>. </summary>
        public static implicit operator FileFormat(string value) => new FileFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FileFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FileFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
