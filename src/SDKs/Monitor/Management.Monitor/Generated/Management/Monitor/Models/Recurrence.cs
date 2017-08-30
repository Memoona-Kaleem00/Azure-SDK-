// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Monitor.Management.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Monitor;
    using Microsoft.Azure.Management.Monitor.Management;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The repeating times at which this profile begins. This element is not
    /// used if the FixedDate element is used.
    /// </summary>
    public partial class Recurrence
    {
        /// <summary>
        /// Initializes a new instance of the Recurrence class.
        /// </summary>
        public Recurrence()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Recurrence class.
        /// </summary>
        /// <param name="frequency">the recurrence frequency. How often the
        /// schedule profile should take effect. This value must be Week,
        /// meaning each week will have the same set of profiles. Possible
        /// values include: 'None', 'Second', 'Minute', 'Hour', 'Day', 'Week',
        /// 'Month', 'Year'</param>
        /// <param name="schedule">the scheduling constraints for when the
        /// profile begins.</param>
        public Recurrence(RecurrenceFrequency frequency, RecurrentSchedule schedule)
        {
            Frequency = frequency;
            Schedule = schedule;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the recurrence frequency. How often the schedule
        /// profile should take effect. This value must be Week, meaning each
        /// week will have the same set of profiles. Possible values include:
        /// 'None', 'Second', 'Minute', 'Hour', 'Day', 'Week', 'Month', 'Year'
        /// </summary>
        [JsonProperty(PropertyName = "frequency")]
        public RecurrenceFrequency Frequency { get; set; }

        /// <summary>
        /// Gets or sets the scheduling constraints for when the profile
        /// begins.
        /// </summary>
        [JsonProperty(PropertyName = "schedule")]
        public RecurrentSchedule Schedule { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Schedule == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Schedule");
            }
            if (Schedule != null)
            {
                Schedule.Validate();
            }
        }
    }
}
