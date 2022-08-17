// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using Azure.Core;

namespace Azure.Maps.Geolocation.Models
{
    /// <summary> The object containing the country/region information. </summary>
    [CodeGenModel("CountryRegion")]
    internal partial class CountryRegion
    {
        /// <summary> Initializes a new instance of CountryRegion. </summary>
        internal CountryRegion()
        {
        }

        /// <summary> Initializes a new instance of CountryRegion. </summary>
        /// <param name="isoCode"> The IP Address&apos;s 2-character code [(ISO 3166-1)](https://www.iso.org/iso-3166-country-codes.html) of the country or region. Please note, IP address in ranges reserved for special purpose will return Null for country/region. </param>
        internal CountryRegion(string isoCode)
        {
            IsoCode = isoCode;
        }

        /// <summary> The IP Address&apos;s 2-character code [(ISO 3166-1)](https://www.iso.org/iso-3166-country-codes.html) of the country or region. Please note, IP address in ranges reserved for special purpose will return Null for country/region. </summary>
        public string IsoCode { get; }
    }
}
