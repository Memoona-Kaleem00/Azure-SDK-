// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ServiceScalability.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServiceScalability
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "manual")]
        Manual,
        [EnumMember(Value = "automatic")]
        Automatic
    }
    internal static class ServiceScalabilityEnumExtension
    {
        internal static string ToSerializedValue(this ServiceScalability? value)
        {
            return value == null ? null : ((ServiceScalability)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ServiceScalability value)
        {
            switch( value )
            {
                case ServiceScalability.None:
                    return "none";
                case ServiceScalability.Manual:
                    return "manual";
                case ServiceScalability.Automatic:
                    return "automatic";
            }
            return null;
        }

        internal static ServiceScalability? ParseServiceScalability(this string value)
        {
            switch( value )
            {
                case "none":
                    return ServiceScalability.None;
                case "manual":
                    return ServiceScalability.Manual;
                case "automatic":
                    return ServiceScalability.Automatic;
            }
            return null;
        }
    }
}
