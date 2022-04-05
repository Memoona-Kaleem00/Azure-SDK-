// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    /// <summary> Controls how resources are versioned on the FHIR service. </summary>
    public readonly partial struct FhirResourceVersionPolicy : IEquatable<FhirResourceVersionPolicy>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="FhirResourceVersionPolicy"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FhirResourceVersionPolicy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoVersionValue = "no-version";
        private const string VersionedValue = "versioned";
        private const string VersionedUpdateValue = "versioned-update";

        /// <summary> no-version. </summary>
        public static FhirResourceVersionPolicy NoVersion { get; } = new FhirResourceVersionPolicy(NoVersionValue);
        /// <summary> versioned. </summary>
        public static FhirResourceVersionPolicy Versioned { get; } = new FhirResourceVersionPolicy(VersionedValue);
        /// <summary> versioned-update. </summary>
        public static FhirResourceVersionPolicy VersionedUpdate { get; } = new FhirResourceVersionPolicy(VersionedUpdateValue);
        /// <summary> Determines if two <see cref="FhirResourceVersionPolicy"/> values are the same. </summary>
        public static bool operator ==(FhirResourceVersionPolicy left, FhirResourceVersionPolicy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FhirResourceVersionPolicy"/> values are not the same. </summary>
        public static bool operator !=(FhirResourceVersionPolicy left, FhirResourceVersionPolicy right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FhirResourceVersionPolicy"/>. </summary>
        public static implicit operator FhirResourceVersionPolicy(string value) => new FhirResourceVersionPolicy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FhirResourceVersionPolicy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FhirResourceVersionPolicy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
