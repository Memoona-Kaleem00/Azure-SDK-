// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The Enum16. </summary>
    public readonly partial struct Enum16 : IEquatable<Enum16>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Enum16"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum16(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WindowsValue = "Windows";
        private const string LinuxValue = "Linux";
        private const string AllValue = "All";

        /// <summary> Windows. </summary>
        public static Enum16 Windows { get; } = new Enum16(WindowsValue);
        /// <summary> Linux. </summary>
        public static Enum16 Linux { get; } = new Enum16(LinuxValue);
        /// <summary> All. </summary>
        public static Enum16 All { get; } = new Enum16(AllValue);
        /// <summary> Determines if two <see cref="Enum16"/> values are the same. </summary>
        public static bool operator ==(Enum16 left, Enum16 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum16"/> values are not the same. </summary>
        public static bool operator !=(Enum16 left, Enum16 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum16"/>. </summary>
        public static implicit operator Enum16(string value) => new Enum16(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum16 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum16 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
