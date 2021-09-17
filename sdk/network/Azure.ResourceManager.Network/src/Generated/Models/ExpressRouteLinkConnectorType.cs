// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Physical fiber port type. </summary>
    public readonly partial struct ExpressRouteLinkConnectorType : IEquatable<ExpressRouteLinkConnectorType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExpressRouteLinkConnectorType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExpressRouteLinkConnectorType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LCValue = "LC";
        private const string SCValue = "SC";

        /// <summary> LC. </summary>
        public static ExpressRouteLinkConnectorType LC { get; } = new ExpressRouteLinkConnectorType(LCValue);
        /// <summary> SC. </summary>
        public static ExpressRouteLinkConnectorType SC { get; } = new ExpressRouteLinkConnectorType(SCValue);
        /// <summary> Determines if two <see cref="ExpressRouteLinkConnectorType"/> values are the same. </summary>
        public static bool operator ==(ExpressRouteLinkConnectorType left, ExpressRouteLinkConnectorType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExpressRouteLinkConnectorType"/> values are not the same. </summary>
        public static bool operator !=(ExpressRouteLinkConnectorType left, ExpressRouteLinkConnectorType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ExpressRouteLinkConnectorType"/>. </summary>
        public static implicit operator ExpressRouteLinkConnectorType(string value) => new ExpressRouteLinkConnectorType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExpressRouteLinkConnectorType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExpressRouteLinkConnectorType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
