// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Text
{
    /// <summary> PII domains. </summary>
    public readonly partial struct PiiDomain : IEquatable<PiiDomain>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PiiDomain"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PiiDomain(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PhiValue = "phi";
        private const string NoneValue = "none";

        /// <summary> Indicates that entities in the Personal Health Information domain should be redacted. </summary>
        public static PiiDomain Phi { get; } = new PiiDomain(PhiValue);
        /// <summary> Indicates that no domain is specified. </summary>
        public static PiiDomain None { get; } = new PiiDomain(NoneValue);
        /// <summary> Determines if two <see cref="PiiDomain"/> values are the same. </summary>
        public static bool operator ==(PiiDomain left, PiiDomain right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PiiDomain"/> values are not the same. </summary>
        public static bool operator !=(PiiDomain left, PiiDomain right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PiiDomain"/>. </summary>
        public static implicit operator PiiDomain(string value) => new PiiDomain(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PiiDomain other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PiiDomain other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
