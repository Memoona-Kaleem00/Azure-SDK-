// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Schedules applicable to a virtual machine. The schedules may have been
    /// defined on a VM or on lab level.
    /// </summary>
    [JsonTransformation]
    public partial class ApplicableSchedule : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicableSchedule class.
        /// </summary>
        public ApplicableSchedule() { }

        /// <summary>
        /// Initializes a new instance of the ApplicableSchedule class.
        /// </summary>
        public ApplicableSchedule(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Schedule labVmsShutdown = default(Schedule), Schedule labVmsStartup = default(Schedule))
            : base(id, name, type, location, tags)
        {
            LabVmsShutdown = labVmsShutdown;
            LabVmsStartup = labVmsStartup;
        }

        /// <summary>
        /// The auto-shutdown schedule, if one has been set at the lab or lab
        /// resource level.
        /// </summary>
        [JsonProperty(PropertyName = "properties.labVmsShutdown")]
        public Schedule LabVmsShutdown { get; set; }

        /// <summary>
        /// The auto-startup schedule, if one has been set at the lab or lab
        /// resource level.
        /// </summary>
        [JsonProperty(PropertyName = "properties.labVmsStartup")]
        public Schedule LabVmsStartup { get; set; }

    }
}
