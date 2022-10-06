// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.LabServices.Models
{
    internal static partial class LabServicesSkuTierExtensions
    {
        public static string ToSerialString(this LabServicesSkuTier value) => value switch
        {
            LabServicesSkuTier.Free => "Free",
            LabServicesSkuTier.Basic => "Basic",
            LabServicesSkuTier.Standard => "Standard",
            LabServicesSkuTier.Premium => "Premium",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown LabServicesSkuTier value.")
        };

        public static LabServicesSkuTier ToLabServicesSkuTier(this string value)
        {
            if (string.Equals(value, "Free", StringComparison.InvariantCultureIgnoreCase)) return LabServicesSkuTier.Free;
            if (string.Equals(value, "Basic", StringComparison.InvariantCultureIgnoreCase)) return LabServicesSkuTier.Basic;
            if (string.Equals(value, "Standard", StringComparison.InvariantCultureIgnoreCase)) return LabServicesSkuTier.Standard;
            if (string.Equals(value, "Premium", StringComparison.InvariantCultureIgnoreCase)) return LabServicesSkuTier.Premium;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown LabServicesSkuTier value.");
        }
    }
}
