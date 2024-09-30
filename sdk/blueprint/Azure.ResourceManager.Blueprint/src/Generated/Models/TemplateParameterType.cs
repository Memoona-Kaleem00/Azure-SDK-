// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Blueprint.Models
{
    /// <summary> Allowed data types for Resource Manager template parameters. </summary>
    public readonly partial struct TemplateParameterType : IEquatable<TemplateParameterType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TemplateParameterType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TemplateParameterType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StringValue = "string";
        private const string ArrayValue = "array";
        private const string BoolValue = "bool";
        private const string IntValue = "int";
        private const string ObjectValue = "object";
        private const string SecureObjectValue = "secureObject";
        private const string SecureStringValue = "secureString";

        /// <summary> string. </summary>
        public static TemplateParameterType String { get; } = new TemplateParameterType(StringValue);
        /// <summary> array. </summary>
        public static TemplateParameterType Array { get; } = new TemplateParameterType(ArrayValue);
        /// <summary> bool. </summary>
        public static TemplateParameterType Bool { get; } = new TemplateParameterType(BoolValue);
        /// <summary> int. </summary>
        public static TemplateParameterType Int { get; } = new TemplateParameterType(IntValue);
        /// <summary> object. </summary>
        public static TemplateParameterType Object { get; } = new TemplateParameterType(ObjectValue);
        /// <summary> secureObject. </summary>
        public static TemplateParameterType SecureObject { get; } = new TemplateParameterType(SecureObjectValue);
        /// <summary> secureString. </summary>
        public static TemplateParameterType SecureString { get; } = new TemplateParameterType(SecureStringValue);
        /// <summary> Determines if two <see cref="TemplateParameterType"/> values are the same. </summary>
        public static bool operator ==(TemplateParameterType left, TemplateParameterType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TemplateParameterType"/> values are not the same. </summary>
        public static bool operator !=(TemplateParameterType left, TemplateParameterType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TemplateParameterType"/>. </summary>
        public static implicit operator TemplateParameterType(string value) => new TemplateParameterType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TemplateParameterType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TemplateParameterType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
