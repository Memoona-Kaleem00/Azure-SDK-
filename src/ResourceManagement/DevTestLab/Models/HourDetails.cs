// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLab.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLab;
    using Microsoft.Azure.Management.DevTestLab.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of an hourly schedule.
    /// </summary>
    public partial class HourDetails
    {
        /// <summary>
        /// Initializes a new instance of the HourDetails class.
        /// </summary>
        public HourDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HourDetails class.
        /// </summary>
        /// <param name="minute">Minutes of the hour the schedule will
        /// run.</param>
        public HourDetails(int? minute = default(int?))
        {
            Minute = minute;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets minutes of the hour the schedule will run.
        /// </summary>
        [JsonProperty(PropertyName = "minute")]
        public int? Minute { get; set; }

    }
}
