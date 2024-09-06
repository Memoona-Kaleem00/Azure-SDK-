// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Identifies the type of tax calculation used for the invoice. The field is applicable only to invoices with special tax calculation logic. </summary>
    public readonly partial struct SpecialTaxationType : IEquatable<SpecialTaxationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SpecialTaxationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SpecialTaxationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SubtotalLevelValue = "SubtotalLevel";
        private const string InvoiceLevelValue = "InvoiceLevel";

        /// <summary> SubtotalLevel. </summary>
        public static SpecialTaxationType SubtotalLevel { get; } = new SpecialTaxationType(SubtotalLevelValue);
        /// <summary> InvoiceLevel. </summary>
        public static SpecialTaxationType InvoiceLevel { get; } = new SpecialTaxationType(InvoiceLevelValue);
        /// <summary> Determines if two <see cref="SpecialTaxationType"/> values are the same. </summary>
        public static bool operator ==(SpecialTaxationType left, SpecialTaxationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SpecialTaxationType"/> values are not the same. </summary>
        public static bool operator !=(SpecialTaxationType left, SpecialTaxationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SpecialTaxationType"/>. </summary>
        public static implicit operator SpecialTaxationType(string value) => new SpecialTaxationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SpecialTaxationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SpecialTaxationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
