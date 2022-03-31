// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The RequestSchemeMatchConditionParametersTypeName. </summary>
    public readonly partial struct RequestSchemeMatchConditionParametersTypeName : IEquatable<RequestSchemeMatchConditionParametersTypeName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RequestSchemeMatchConditionParametersTypeName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RequestSchemeMatchConditionParametersTypeName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeliveryRuleRequestSchemeConditionParametersValue = "DeliveryRuleRequestSchemeConditionParameters";

        /// <summary> DeliveryRuleRequestSchemeConditionParameters. </summary>
        public static RequestSchemeMatchConditionParametersTypeName DeliveryRuleRequestSchemeConditionParameters { get; } = new RequestSchemeMatchConditionParametersTypeName(DeliveryRuleRequestSchemeConditionParametersValue);
        /// <summary> Determines if two <see cref="RequestSchemeMatchConditionParametersTypeName"/> values are the same. </summary>
        public static bool operator ==(RequestSchemeMatchConditionParametersTypeName left, RequestSchemeMatchConditionParametersTypeName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RequestSchemeMatchConditionParametersTypeName"/> values are not the same. </summary>
        public static bool operator !=(RequestSchemeMatchConditionParametersTypeName left, RequestSchemeMatchConditionParametersTypeName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RequestSchemeMatchConditionParametersTypeName"/>. </summary>
        public static implicit operator RequestSchemeMatchConditionParametersTypeName(string value) => new RequestSchemeMatchConditionParametersTypeName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RequestSchemeMatchConditionParametersTypeName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RequestSchemeMatchConditionParametersTypeName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
