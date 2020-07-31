// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The list of HTTP methods supported by a AzureFunctionActivity. </summary>
    public readonly partial struct AzureFunctionActivityMethod : IEquatable<AzureFunctionActivityMethod>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AzureFunctionActivityMethod"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AzureFunctionActivityMethod(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GETValue = "GET";
        private const string PostValue = "POST";
        private const string PUTValue = "PUT";
        private const string DeleteValue = "DELETE";
        private const string OptionsValue = "OPTIONS";
        private const string HeadValue = "HEAD";
        private const string TraceValue = "TRACE";

        /// <summary> GET. </summary>
        public static AzureFunctionActivityMethod GET { get; } = new AzureFunctionActivityMethod(GETValue);
        /// <summary> POST. </summary>
        public static AzureFunctionActivityMethod Post { get; } = new AzureFunctionActivityMethod(PostValue);
        /// <summary> PUT. </summary>
        public static AzureFunctionActivityMethod PUT { get; } = new AzureFunctionActivityMethod(PUTValue);
        /// <summary> DELETE. </summary>
        public static AzureFunctionActivityMethod Delete { get; } = new AzureFunctionActivityMethod(DeleteValue);
        /// <summary> OPTIONS. </summary>
        public static AzureFunctionActivityMethod Options { get; } = new AzureFunctionActivityMethod(OptionsValue);
        /// <summary> HEAD. </summary>
        public static AzureFunctionActivityMethod Head { get; } = new AzureFunctionActivityMethod(HeadValue);
        /// <summary> TRACE. </summary>
        public static AzureFunctionActivityMethod Trace { get; } = new AzureFunctionActivityMethod(TraceValue);
        /// <summary> Determines if two <see cref="AzureFunctionActivityMethod"/> values are the same. </summary>
        public static bool operator ==(AzureFunctionActivityMethod left, AzureFunctionActivityMethod right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AzureFunctionActivityMethod"/> values are not the same. </summary>
        public static bool operator !=(AzureFunctionActivityMethod left, AzureFunctionActivityMethod right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AzureFunctionActivityMethod"/>. </summary>
        public static implicit operator AzureFunctionActivityMethod(string value) => new AzureFunctionActivityMethod(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AzureFunctionActivityMethod other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AzureFunctionActivityMethod other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
