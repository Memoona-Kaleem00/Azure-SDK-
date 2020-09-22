// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ForwardProxyConvention.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ForwardProxyConvention
    {
        [EnumMember(Value = "NoProxy")]
        NoProxy,
        [EnumMember(Value = "Standard")]
        Standard,
        [EnumMember(Value = "Custom")]
        Custom
    }
    internal static class ForwardProxyConventionEnumExtension
    {
        internal static string ToSerializedValue(this ForwardProxyConvention? value)
        {
            return value == null ? null : ((ForwardProxyConvention)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ForwardProxyConvention value)
        {
            switch( value )
            {
                case ForwardProxyConvention.NoProxy:
                    return "NoProxy";
                case ForwardProxyConvention.Standard:
                    return "Standard";
                case ForwardProxyConvention.Custom:
                    return "Custom";
            }
            return null;
        }

        internal static ForwardProxyConvention? ParseForwardProxyConvention(this string value)
        {
            switch( value )
            {
                case "NoProxy":
                    return ForwardProxyConvention.NoProxy;
                case "Standard":
                    return ForwardProxyConvention.Standard;
                case "Custom":
                    return ForwardProxyConvention.Custom;
            }
            return null;
        }
    }
}
