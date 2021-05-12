// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for IsRetryable.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IsRetryable
    {
        [EnumMember(Value = "Yes")]
        Yes,
        [EnumMember(Value = "No")]
        No
    }
    internal static class IsRetryableEnumExtension
    {
        internal static string ToSerializedValue(this IsRetryable? value)
        {
            return value == null ? null : ((IsRetryable)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this IsRetryable value)
        {
            switch( value )
            {
                case IsRetryable.Yes:
                    return "Yes";
                case IsRetryable.No:
                    return "No";
            }
            return null;
        }

        internal static IsRetryable? ParseIsRetryable(this string value)
        {
            switch( value )
            {
                case "Yes":
                    return IsRetryable.Yes;
                case "No":
                    return IsRetryable.No;
            }
            return null;
        }
    }
}
