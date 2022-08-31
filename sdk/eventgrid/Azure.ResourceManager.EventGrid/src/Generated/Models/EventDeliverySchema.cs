// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The event delivery schema for the event subscription. </summary>
    public readonly partial struct EventDeliverySchema : IEquatable<EventDeliverySchema>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventDeliverySchema"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventDeliverySchema(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EventGridSchemaValue = "EventGridSchema";
        private const string CustomInputSchemaValue = "CustomInputSchema";
        private const string CloudEventSchemaV10Value = "CloudEventSchemaV1_0";

        /// <summary> EventGridSchema. </summary>
        public static EventDeliverySchema EventGridSchema { get; } = new EventDeliverySchema(EventGridSchemaValue);
        /// <summary> CustomInputSchema. </summary>
        public static EventDeliverySchema CustomInputSchema { get; } = new EventDeliverySchema(CustomInputSchemaValue);
        /// <summary> CloudEventSchemaV1_0. </summary>
        public static EventDeliverySchema CloudEventSchemaV10 { get; } = new EventDeliverySchema(CloudEventSchemaV10Value);
        /// <summary> Determines if two <see cref="EventDeliverySchema"/> values are the same. </summary>
        public static bool operator ==(EventDeliverySchema left, EventDeliverySchema right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventDeliverySchema"/> values are not the same. </summary>
        public static bool operator !=(EventDeliverySchema left, EventDeliverySchema right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EventDeliverySchema"/>. </summary>
        public static implicit operator EventDeliverySchema(string value) => new EventDeliverySchema(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventDeliverySchema other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventDeliverySchema other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
