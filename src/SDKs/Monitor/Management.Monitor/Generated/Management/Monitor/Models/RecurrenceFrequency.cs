// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Monitor.Management.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Monitor;
    using Microsoft.Azure.Monitor.Management;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for RecurrenceFrequency.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecurrenceFrequency
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Second")]
        Second,
        [EnumMember(Value = "Minute")]
        Minute,
        [EnumMember(Value = "Hour")]
        Hour,
        [EnumMember(Value = "Day")]
        Day,
        [EnumMember(Value = "Week")]
        Week,
        [EnumMember(Value = "Month")]
        Month,
        [EnumMember(Value = "Year")]
        Year
    }
}
