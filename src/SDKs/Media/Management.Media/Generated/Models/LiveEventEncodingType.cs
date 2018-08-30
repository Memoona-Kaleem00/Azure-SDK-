// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for LiveEventEncodingType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LiveEventEncodingType
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Basic")]
        Basic
    }
    internal static class LiveEventEncodingTypeEnumExtension
    {
        internal static string ToSerializedValue(this LiveEventEncodingType? value)
        {
            return value == null ? null : ((LiveEventEncodingType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this LiveEventEncodingType value)
        {
            switch( value )
            {
                case LiveEventEncodingType.None:
                    return "None";
                case LiveEventEncodingType.Basic:
                    return "Basic";
            }
            return null;
        }

        internal static LiveEventEncodingType? ParseLiveEventEncodingType(this string value)
        {
            switch( value )
            {
                case "None":
                    return LiveEventEncodingType.None;
                case "Basic":
                    return LiveEventEncodingType.Basic;
            }
            return null;
        }
    }
}
