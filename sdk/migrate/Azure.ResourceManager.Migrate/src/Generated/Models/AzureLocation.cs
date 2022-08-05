// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Target Azure location for which the machines should be assessed. These enums are the same as used by Compute API. </summary>
    public readonly partial struct AzureLocation : IEquatable<AzureLocation>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AzureLocation"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AzureLocation(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string EastAsiaValue = "EastAsia";
        private const string SoutheastAsiaValue = "SoutheastAsia";
        private const string AustraliaEastValue = "AustraliaEast";
        private const string AustraliaSoutheastValue = "AustraliaSoutheast";
        private const string BrazilSouthValue = "BrazilSouth";
        private const string CanadaCentralValue = "CanadaCentral";
        private const string CanadaEastValue = "CanadaEast";
        private const string WestEuropeValue = "WestEurope";
        private const string NorthEuropeValue = "NorthEurope";
        private const string CentralIndiaValue = "CentralIndia";
        private const string SouthIndiaValue = "SouthIndia";
        private const string WestIndiaValue = "WestIndia";
        private const string JapanEastValue = "JapanEast";
        private const string JapanWestValue = "JapanWest";
        private const string KoreaCentralValue = "KoreaCentral";
        private const string KoreaSouthValue = "KoreaSouth";
        private const string UkWestValue = "UkWest";
        private const string UkSouthValue = "UkSouth";
        private const string NorthCentralUsValue = "NorthCentralUs";
        private const string EastUsValue = "EastUs";
        private const string WestUs2Value = "WestUs2";
        private const string SouthCentralUsValue = "SouthCentralUs";
        private const string CentralUsValue = "CentralUs";
        private const string EastUs2Value = "EastUs2";
        private const string WestUsValue = "WestUs";
        private const string WestCentralUsValue = "WestCentralUs";
        private const string GermanyCentralValue = "GermanyCentral";
        private const string GermanyNortheastValue = "GermanyNortheast";
        private const string ChinaNorthValue = "ChinaNorth";
        private const string ChinaEastValue = "ChinaEast";
        private const string USGovArizonaValue = "USGovArizona";
        private const string USGovTexasValue = "USGovTexas";
        private const string USGovIowaValue = "USGovIowa";
        private const string USGovVirginiaValue = "USGovVirginia";
        private const string USDoDCentralValue = "USDoDCentral";
        private const string USDoDEastValue = "USDoDEast";

        /// <summary> Unknown. </summary>
        public static AzureLocation Unknown { get; } = new AzureLocation(UnknownValue);
        /// <summary> EastAsia. </summary>
        public static AzureLocation EastAsia { get; } = new AzureLocation(EastAsiaValue);
        /// <summary> SoutheastAsia. </summary>
        public static AzureLocation SoutheastAsia { get; } = new AzureLocation(SoutheastAsiaValue);
        /// <summary> AustraliaEast. </summary>
        public static AzureLocation AustraliaEast { get; } = new AzureLocation(AustraliaEastValue);
        /// <summary> AustraliaSoutheast. </summary>
        public static AzureLocation AustraliaSoutheast { get; } = new AzureLocation(AustraliaSoutheastValue);
        /// <summary> BrazilSouth. </summary>
        public static AzureLocation BrazilSouth { get; } = new AzureLocation(BrazilSouthValue);
        /// <summary> CanadaCentral. </summary>
        public static AzureLocation CanadaCentral { get; } = new AzureLocation(CanadaCentralValue);
        /// <summary> CanadaEast. </summary>
        public static AzureLocation CanadaEast { get; } = new AzureLocation(CanadaEastValue);
        /// <summary> WestEurope. </summary>
        public static AzureLocation WestEurope { get; } = new AzureLocation(WestEuropeValue);
        /// <summary> NorthEurope. </summary>
        public static AzureLocation NorthEurope { get; } = new AzureLocation(NorthEuropeValue);
        /// <summary> CentralIndia. </summary>
        public static AzureLocation CentralIndia { get; } = new AzureLocation(CentralIndiaValue);
        /// <summary> SouthIndia. </summary>
        public static AzureLocation SouthIndia { get; } = new AzureLocation(SouthIndiaValue);
        /// <summary> WestIndia. </summary>
        public static AzureLocation WestIndia { get; } = new AzureLocation(WestIndiaValue);
        /// <summary> JapanEast. </summary>
        public static AzureLocation JapanEast { get; } = new AzureLocation(JapanEastValue);
        /// <summary> JapanWest. </summary>
        public static AzureLocation JapanWest { get; } = new AzureLocation(JapanWestValue);
        /// <summary> KoreaCentral. </summary>
        public static AzureLocation KoreaCentral { get; } = new AzureLocation(KoreaCentralValue);
        /// <summary> KoreaSouth. </summary>
        public static AzureLocation KoreaSouth { get; } = new AzureLocation(KoreaSouthValue);
        /// <summary> UkWest. </summary>
        public static AzureLocation UkWest { get; } = new AzureLocation(UkWestValue);
        /// <summary> UkSouth. </summary>
        public static AzureLocation UkSouth { get; } = new AzureLocation(UkSouthValue);
        /// <summary> NorthCentralUs. </summary>
        public static AzureLocation NorthCentralUs { get; } = new AzureLocation(NorthCentralUsValue);
        /// <summary> EastUs. </summary>
        public static AzureLocation EastUs { get; } = new AzureLocation(EastUsValue);
        /// <summary> WestUs2. </summary>
        public static AzureLocation WestUs2 { get; } = new AzureLocation(WestUs2Value);
        /// <summary> SouthCentralUs. </summary>
        public static AzureLocation SouthCentralUs { get; } = new AzureLocation(SouthCentralUsValue);
        /// <summary> CentralUs. </summary>
        public static AzureLocation CentralUs { get; } = new AzureLocation(CentralUsValue);
        /// <summary> EastUs2. </summary>
        public static AzureLocation EastUs2 { get; } = new AzureLocation(EastUs2Value);
        /// <summary> WestUs. </summary>
        public static AzureLocation WestUs { get; } = new AzureLocation(WestUsValue);
        /// <summary> WestCentralUs. </summary>
        public static AzureLocation WestCentralUs { get; } = new AzureLocation(WestCentralUsValue);
        /// <summary> GermanyCentral. </summary>
        public static AzureLocation GermanyCentral { get; } = new AzureLocation(GermanyCentralValue);
        /// <summary> GermanyNortheast. </summary>
        public static AzureLocation GermanyNortheast { get; } = new AzureLocation(GermanyNortheastValue);
        /// <summary> ChinaNorth. </summary>
        public static AzureLocation ChinaNorth { get; } = new AzureLocation(ChinaNorthValue);
        /// <summary> ChinaEast. </summary>
        public static AzureLocation ChinaEast { get; } = new AzureLocation(ChinaEastValue);
        /// <summary> USGovArizona. </summary>
        public static AzureLocation USGovArizona { get; } = new AzureLocation(USGovArizonaValue);
        /// <summary> USGovTexas. </summary>
        public static AzureLocation USGovTexas { get; } = new AzureLocation(USGovTexasValue);
        /// <summary> USGovIowa. </summary>
        public static AzureLocation USGovIowa { get; } = new AzureLocation(USGovIowaValue);
        /// <summary> USGovVirginia. </summary>
        public static AzureLocation USGovVirginia { get; } = new AzureLocation(USGovVirginiaValue);
        /// <summary> USDoDCentral. </summary>
        public static AzureLocation USDoDCentral { get; } = new AzureLocation(USDoDCentralValue);
        /// <summary> USDoDEast. </summary>
        public static AzureLocation USDoDEast { get; } = new AzureLocation(USDoDEastValue);
        /// <summary> Determines if two <see cref="AzureLocation"/> values are the same. </summary>
        public static bool operator ==(AzureLocation left, AzureLocation right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AzureLocation"/> values are not the same. </summary>
        public static bool operator !=(AzureLocation left, AzureLocation right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AzureLocation"/>. </summary>
        public static implicit operator AzureLocation(string value) => new AzureLocation(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AzureLocation other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AzureLocation other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
