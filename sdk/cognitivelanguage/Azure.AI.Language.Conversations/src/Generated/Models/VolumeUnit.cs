// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> The Volume Unit of measurement. </summary>
    public readonly partial struct VolumeUnit : IEquatable<VolumeUnit>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VolumeUnit"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VolumeUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnspecifiedValue = "Unspecified";
        private const string CubicMeterValue = "CubicMeter";
        private const string CubicCentimeterValue = "CubicCentimeter";
        private const string CubicMillimeterValue = "CubicMillimeter";
        private const string HectoliterValue = "Hectoliter";
        private const string DecaliterValue = "Decaliter";
        private const string LiterValue = "Liter";
        private const string CentiliterValue = "Centiliter";
        private const string MilliliterValue = "Milliliter";
        private const string CubicYardValue = "CubicYard";
        private const string CubicInchValue = "CubicInch";
        private const string CubicFootValue = "CubicFoot";
        private const string CubicMileValue = "CubicMile";
        private const string FluidOunceValue = "FluidOunce";
        private const string TeaspoonValue = "Teaspoon";
        private const string TablespoonValue = "Tablespoon";
        private const string PintValue = "Pint";
        private const string QuartValue = "Quart";
        private const string CupValue = "Cup";
        private const string GillValue = "Gill";
        private const string PinchValue = "Pinch";
        private const string FluidDramValue = "FluidDram";
        private const string BarrelValue = "Barrel";
        private const string MinimValue = "Minim";
        private const string CordValue = "Cord";
        private const string PeckValue = "Peck";
        private const string BushelValue = "Bushel";
        private const string HogsheadValue = "Hogshead";

        /// <summary> Unspecified volume unit. </summary>
        public static VolumeUnit Unspecified { get; } = new VolumeUnit(UnspecifiedValue);
        /// <summary> Volume unit in cubic meters. </summary>
        public static VolumeUnit CubicMeter { get; } = new VolumeUnit(CubicMeterValue);
        /// <summary> Volume unit in cubic centimeters. </summary>
        public static VolumeUnit CubicCentimeter { get; } = new VolumeUnit(CubicCentimeterValue);
        /// <summary> Volume unit in cubic millimeters. </summary>
        public static VolumeUnit CubicMillimeter { get; } = new VolumeUnit(CubicMillimeterValue);
        /// <summary> Volume unit in hectoliters. </summary>
        public static VolumeUnit Hectoliter { get; } = new VolumeUnit(HectoliterValue);
        /// <summary> Volume unit in decaliters. </summary>
        public static VolumeUnit Decaliter { get; } = new VolumeUnit(DecaliterValue);
        /// <summary> Volume unit in liters. </summary>
        public static VolumeUnit Liter { get; } = new VolumeUnit(LiterValue);
        /// <summary> Volume unit in centiliters. </summary>
        public static VolumeUnit Centiliter { get; } = new VolumeUnit(CentiliterValue);
        /// <summary> Volume unit in milliliters. </summary>
        public static VolumeUnit Milliliter { get; } = new VolumeUnit(MilliliterValue);
        /// <summary> Volume unit in cubic yards. </summary>
        public static VolumeUnit CubicYard { get; } = new VolumeUnit(CubicYardValue);
        /// <summary> Volume unit in cubic inches. </summary>
        public static VolumeUnit CubicInch { get; } = new VolumeUnit(CubicInchValue);
        /// <summary> Volume unit in cubic feet. </summary>
        public static VolumeUnit CubicFoot { get; } = new VolumeUnit(CubicFootValue);
        /// <summary> Volume unit in cubic miles. </summary>
        public static VolumeUnit CubicMile { get; } = new VolumeUnit(CubicMileValue);
        /// <summary> Volume unit in fluid ounces. </summary>
        public static VolumeUnit FluidOunce { get; } = new VolumeUnit(FluidOunceValue);
        /// <summary> Volume unit in teaspoons. </summary>
        public static VolumeUnit Teaspoon { get; } = new VolumeUnit(TeaspoonValue);
        /// <summary> Volume unit in tablespoons. </summary>
        public static VolumeUnit Tablespoon { get; } = new VolumeUnit(TablespoonValue);
        /// <summary> Volume unit in pints. </summary>
        public static VolumeUnit Pint { get; } = new VolumeUnit(PintValue);
        /// <summary> Volume unit in quarts. </summary>
        public static VolumeUnit Quart { get; } = new VolumeUnit(QuartValue);
        /// <summary> Volume unit in cups. </summary>
        public static VolumeUnit Cup { get; } = new VolumeUnit(CupValue);
        /// <summary> Volume unit in gills. </summary>
        public static VolumeUnit Gill { get; } = new VolumeUnit(GillValue);
        /// <summary> Volume unit in pinches. </summary>
        public static VolumeUnit Pinch { get; } = new VolumeUnit(PinchValue);
        /// <summary> Volume unit in fluid drams. </summary>
        public static VolumeUnit FluidDram { get; } = new VolumeUnit(FluidDramValue);
        /// <summary> Volume unit in barrels. </summary>
        public static VolumeUnit Barrel { get; } = new VolumeUnit(BarrelValue);
        /// <summary> Volume unit in minims. </summary>
        public static VolumeUnit Minim { get; } = new VolumeUnit(MinimValue);
        /// <summary> Volume unit in cords. </summary>
        public static VolumeUnit Cord { get; } = new VolumeUnit(CordValue);
        /// <summary> Volume unit in pecks. </summary>
        public static VolumeUnit Peck { get; } = new VolumeUnit(PeckValue);
        /// <summary> Volume unit in bushels. </summary>
        public static VolumeUnit Bushel { get; } = new VolumeUnit(BushelValue);
        /// <summary> Volume unit in hogsheads. </summary>
        public static VolumeUnit Hogshead { get; } = new VolumeUnit(HogsheadValue);
        /// <summary> Determines if two <see cref="VolumeUnit"/> values are the same. </summary>
        public static bool operator ==(VolumeUnit left, VolumeUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VolumeUnit"/> values are not the same. </summary>
        public static bool operator !=(VolumeUnit left, VolumeUnit right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VolumeUnit"/>. </summary>
        public static implicit operator VolumeUnit(string value) => new VolumeUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VolumeUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VolumeUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
