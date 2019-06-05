// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ScaleDirection.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ScaleDirection
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Increase")]
        Increase,
        [EnumMember(Value = "Decrease")]
        Decrease
    }
    internal static class ScaleDirectionEnumExtension
    {
        internal static string ToSerializedValue(this ScaleDirection? value)
        {
            return value == null ? null : ((ScaleDirection)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ScaleDirection value)
        {
            switch( value )
            {
                case ScaleDirection.None:
                    return "None";
                case ScaleDirection.Increase:
                    return "Increase";
                case ScaleDirection.Decrease:
                    return "Decrease";
            }
            return null;
        }

        internal static ScaleDirection? ParseScaleDirection(this string value)
        {
            switch( value )
            {
                case "None":
                    return ScaleDirection.None;
                case "Increase":
                    return ScaleDirection.Increase;
                case "Decrease":
                    return ScaleDirection.Decrease;
            }
            return null;
        }
    }
}
