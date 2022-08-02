// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    internal static partial class CognitiveServicesSkuRestrictionsTypeExtensions
    {
        public static string ToSerialString(this CognitiveServicesSkuRestrictionsType value) => value switch
        {
            CognitiveServicesSkuRestrictionsType.Location => "Location",
            CognitiveServicesSkuRestrictionsType.Zone => "Zone",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CognitiveServicesSkuRestrictionsType value.")
        };

        public static CognitiveServicesSkuRestrictionsType ToCognitiveServicesSkuRestrictionsType(this string value)
        {
            if (string.Equals(value, "Location", StringComparison.InvariantCultureIgnoreCase)) return CognitiveServicesSkuRestrictionsType.Location;
            if (string.Equals(value, "Zone", StringComparison.InvariantCultureIgnoreCase)) return CognitiveServicesSkuRestrictionsType.Zone;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CognitiveServicesSkuRestrictionsType value.");
        }
    }
}
