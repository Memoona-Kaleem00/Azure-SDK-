// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Proactive diagnostic collection consent flag. </summary>
    public readonly partial struct ProactiveDiagnosticsConsent : IEquatable<ProactiveDiagnosticsConsent>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProactiveDiagnosticsConsent"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProactiveDiagnosticsConsent(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static ProactiveDiagnosticsConsent Enabled { get; } = new ProactiveDiagnosticsConsent(EnabledValue);
        /// <summary> Disabled. </summary>
        public static ProactiveDiagnosticsConsent Disabled { get; } = new ProactiveDiagnosticsConsent(DisabledValue);
        /// <summary> Determines if two <see cref="ProactiveDiagnosticsConsent"/> values are the same. </summary>
        public static bool operator ==(ProactiveDiagnosticsConsent left, ProactiveDiagnosticsConsent right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProactiveDiagnosticsConsent"/> values are not the same. </summary>
        public static bool operator !=(ProactiveDiagnosticsConsent left, ProactiveDiagnosticsConsent right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ProactiveDiagnosticsConsent"/>. </summary>
        public static implicit operator ProactiveDiagnosticsConsent(string value) => new ProactiveDiagnosticsConsent(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProactiveDiagnosticsConsent other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProactiveDiagnosticsConsent other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
