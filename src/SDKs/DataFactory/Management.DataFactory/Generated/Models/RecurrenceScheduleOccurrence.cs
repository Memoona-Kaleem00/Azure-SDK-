// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.2.22.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The recurrence schedule occurence.
    /// </summary>
    public partial class RecurrenceScheduleOccurrence
    {
        /// <summary>
        /// Initializes a new instance of the RecurrenceScheduleOccurrence
        /// class.
        /// </summary>
        public RecurrenceScheduleOccurrence()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecurrenceScheduleOccurrence
        /// class.
        /// </summary>
        /// <param name="day">The day of the week. Possible values include:
        /// 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday',
        /// 'Saturday'</param>
        /// <param name="occurrence">The occurrence.</param>
        public RecurrenceScheduleOccurrence(DayOfWeek? day = default(DayOfWeek?), int? occurrence = default(int?))
        {
            Day = day;
            Occurrence = occurrence;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the day of the week. Possible values include:
        /// 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday',
        /// 'Saturday'
        /// </summary>
        [JsonProperty(PropertyName = "day")]
        public DayOfWeek? Day { get; set; }

        /// <summary>
        /// Gets or sets the occurrence.
        /// </summary>
        [JsonProperty(PropertyName = "occurrence")]
        public int? Occurrence { get; set; }

    }
}
