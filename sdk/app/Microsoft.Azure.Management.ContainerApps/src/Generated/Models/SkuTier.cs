// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerApps.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SkuTier.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SkuTier
    {
        [EnumMember(Value = "Free")]
        Free,
        [EnumMember(Value = "Basic")]
        Basic,
        [EnumMember(Value = "Standard")]
        Standard,
        [EnumMember(Value = "Premium")]
        Premium
    }
    internal static class SkuTierEnumExtension
    {
        internal static string ToSerializedValue(this SkuTier? value)
        {
            return value == null ? null : ((SkuTier)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SkuTier value)
        {
            switch( value )
            {
                case SkuTier.Free:
                    return "Free";
                case SkuTier.Basic:
                    return "Basic";
                case SkuTier.Standard:
                    return "Standard";
                case SkuTier.Premium:
                    return "Premium";
            }
            return null;
        }

        internal static SkuTier? ParseSkuTier(this string value)
        {
            switch( value )
            {
                case "Free":
                    return SkuTier.Free;
                case "Basic":
                    return SkuTier.Basic;
                case "Standard":
                    return SkuTier.Standard;
                case "Premium":
                    return SkuTier.Premium;
            }
            return null;
        }
    }
}
