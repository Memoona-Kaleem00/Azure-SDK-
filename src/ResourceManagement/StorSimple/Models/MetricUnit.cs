// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StorSimple;
    using Microsoft.Azure.Management.StorSimple.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for MetricUnit.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MetricUnit
    {
        [EnumMember(Value = "Bytes")]
        Bytes,
        [EnumMember(Value = "BytesPerSecond")]
        BytesPerSecond,
        [EnumMember(Value = "Count")]
        Count,
        [EnumMember(Value = "CountPerSecond")]
        CountPerSecond,
        [EnumMember(Value = "Percent")]
        Percent,
        [EnumMember(Value = "Seconds")]
        Seconds
    }
    internal static class MetricUnitEnumExtension
    {
        internal static string ToSerializedValue(this MetricUnit? value)
        {
            return value == null ? null : ((MetricUnit)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this MetricUnit value)
        {
            switch( value )
            {
                case MetricUnit.Bytes:
                    return "Bytes";
                case MetricUnit.BytesPerSecond:
                    return "BytesPerSecond";
                case MetricUnit.Count:
                    return "Count";
                case MetricUnit.CountPerSecond:
                    return "CountPerSecond";
                case MetricUnit.Percent:
                    return "Percent";
                case MetricUnit.Seconds:
                    return "Seconds";
            }
            return null;
        }

        internal static MetricUnit? ParseMetricUnit(this string value)
        {
            switch( value )
            {
                case "Bytes":
                    return MetricUnit.Bytes;
                case "BytesPerSecond":
                    return MetricUnit.BytesPerSecond;
                case "Count":
                    return MetricUnit.Count;
                case "CountPerSecond":
                    return MetricUnit.CountPerSecond;
                case "Percent":
                    return MetricUnit.Percent;
                case "Seconds":
                    return MetricUnit.Seconds;
            }
            return null;
        }
    }
}
