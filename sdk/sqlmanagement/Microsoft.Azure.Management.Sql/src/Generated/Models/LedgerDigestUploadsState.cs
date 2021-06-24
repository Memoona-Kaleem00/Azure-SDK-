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
    /// Defines values for LedgerDigestUploadsState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LedgerDigestUploadsState
    {
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "Disabled")]
        Disabled
    }
    internal static class LedgerDigestUploadsStateEnumExtension
    {
        internal static string ToSerializedValue(this LedgerDigestUploadsState? value)
        {
            return value == null ? null : ((LedgerDigestUploadsState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this LedgerDigestUploadsState value)
        {
            switch( value )
            {
                case LedgerDigestUploadsState.Enabled:
                    return "Enabled";
                case LedgerDigestUploadsState.Disabled:
                    return "Disabled";
            }
            return null;
        }

        internal static LedgerDigestUploadsState? ParseLedgerDigestUploadsState(this string value)
        {
            switch( value )
            {
                case "Enabled":
                    return LedgerDigestUploadsState.Enabled;
                case "Disabled":
                    return LedgerDigestUploadsState.Disabled;
            }
            return null;
        }
    }
}
