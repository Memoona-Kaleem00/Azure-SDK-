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
    /// Defines values for ManagedServiceIdentityType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ManagedServiceIdentityType
    {
        [EnumMember(Value = "SystemAssigned")]
        SystemAssigned,
        [EnumMember(Value = "UserAssigned")]
        UserAssigned,
        [EnumMember(Value = "SystemAssigned, UserAssigned")]
        SystemAssignedUserAssigned,
        [EnumMember(Value = "None")]
        None
    }
    internal static class ManagedServiceIdentityTypeEnumExtension
    {
        internal static string ToSerializedValue(this ManagedServiceIdentityType? value)
        {
            return value == null ? null : ((ManagedServiceIdentityType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ManagedServiceIdentityType value)
        {
            switch( value )
            {
                case ManagedServiceIdentityType.SystemAssigned:
                    return "SystemAssigned";
                case ManagedServiceIdentityType.UserAssigned:
                    return "UserAssigned";
                case ManagedServiceIdentityType.SystemAssignedUserAssigned:
                    return "SystemAssigned, UserAssigned";
                case ManagedServiceIdentityType.None:
                    return "None";
            }
            return null;
        }

        internal static ManagedServiceIdentityType? ParseManagedServiceIdentityType(this string value)
        {
            switch( value )
            {
                case "SystemAssigned":
                    return ManagedServiceIdentityType.SystemAssigned;
                case "UserAssigned":
                    return ManagedServiceIdentityType.UserAssigned;
                case "SystemAssigned, UserAssigned":
                    return ManagedServiceIdentityType.SystemAssignedUserAssigned;
                case "None":
                    return ManagedServiceIdentityType.None;
            }
            return null;
        }
    }
}
