// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DisableProtectionReason.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DisableProtectionReason
    {
        [EnumMember(Value = "NotSpecified")]
        NotSpecified,
        [EnumMember(Value = "MigrationComplete")]
        MigrationComplete
    }
    internal static class DisableProtectionReasonEnumExtension
    {
        internal static string ToSerializedValue(this DisableProtectionReason? value)
        {
            return value == null ? null : ((DisableProtectionReason)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DisableProtectionReason value)
        {
            switch( value )
            {
                case DisableProtectionReason.NotSpecified:
                    return "NotSpecified";
                case DisableProtectionReason.MigrationComplete:
                    return "MigrationComplete";
            }
            return null;
        }

        internal static DisableProtectionReason? ParseDisableProtectionReason(this string value)
        {
            switch( value )
            {
                case "NotSpecified":
                    return DisableProtectionReason.NotSpecified;
                case "MigrationComplete":
                    return DisableProtectionReason.MigrationComplete;
            }
            return null;
        }
    }
}
