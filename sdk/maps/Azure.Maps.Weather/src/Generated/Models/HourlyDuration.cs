// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using System.Globalization;

namespace Azure.Maps.Weather.Models
{
    /// <summary> The HourlyDuration. </summary>
    public readonly partial struct HourlyDuration : IEquatable<HourlyDuration>
    {
        private readonly int _value;

        /// <summary> Initializes a new instance of <see cref="HourlyDuration"/>. </summary>
        public HourlyDuration(int value)
        {
            _value = value;
        }

        private const int OneHourValue = 1;
        private const int TwelveHoursValue = 12;
        private const int TwentyFourHoursValue = 24;
        private const int FortyEightHoursValue = 48;
        private const int SeventyTwoHoursValue = 72;
        private const int NinetySixHoursValue = 96;

        /// <summary> 1 Hours. </summary>
        public static HourlyDuration OneHour { get; } = new HourlyDuration(OneHourValue);
        /// <summary> 12 Hours. </summary>
        public static HourlyDuration TwelveHours { get; } = new HourlyDuration(TwelveHoursValue);
        /// <summary> 24 Hours. </summary>
        public static HourlyDuration TwentyFourHours { get; } = new HourlyDuration(TwentyFourHoursValue);
        /// <summary> 48 Hours. </summary>
        public static HourlyDuration FortyEightHours { get; } = new HourlyDuration(FortyEightHoursValue);
        /// <summary> 72 Hours. </summary>
        public static HourlyDuration SeventyTwoHours { get; } = new HourlyDuration(SeventyTwoHoursValue);
        /// <summary> 96 Hours. </summary>
        public static HourlyDuration NinetySixHours { get; } = new HourlyDuration(NinetySixHoursValue);

        internal int ToSerialInt32() => _value;

        /// <summary> Determines if two <see cref="HourlyDuration"/> values are the same. </summary>
        public static bool operator ==(HourlyDuration left, HourlyDuration right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HourlyDuration"/> values are not the same. </summary>
        public static bool operator !=(HourlyDuration left, HourlyDuration right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HourlyDuration"/>. </summary>
        public static implicit operator HourlyDuration(int value) => new HourlyDuration(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HourlyDuration other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HourlyDuration other) => Equals(_value, other._value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value.GetHashCode();
        /// <inheritdoc />
        public override string ToString() => _value.ToString(CultureInfo.InvariantCulture);
    }
}
