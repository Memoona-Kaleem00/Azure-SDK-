// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for RestorePointTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RestorePointTypes
    {
        [EnumMember(Value = "DISCRETE")]
        DISCRETE,
        [EnumMember(Value = "CONTINUOUS")]
        CONTINUOUS
    }
}
