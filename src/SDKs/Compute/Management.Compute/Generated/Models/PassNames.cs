// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for PassNames.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PassNames
    {
        [EnumMember(Value = "OobeSystem")]
        OobeSystem
    }
    internal static class PassNamesEnumExtension
    {
        internal static string ToSerializedValue(this PassNames? value)  =>
            value == null ? null : ((PassNames)value).ToSerializedValue();

        internal static string ToSerializedValue(this PassNames value)
        {
            switch( value )
            {
                case PassNames.OobeSystem:
                    return "OobeSystem";
            }
            return null;
        }

        internal static PassNames? ParsePassNames(this string value)
        {
            switch( value )
            {
                case "OobeSystem":
                    return PassNames.OobeSystem;
            }
            return null;
        }
    }
}
