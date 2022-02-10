// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties for updating a timer trigger.
    /// </summary>
    public partial class TimerTriggerUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the TimerTriggerUpdateParameters
        /// class.
        /// </summary>
        public TimerTriggerUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TimerTriggerUpdateParameters
        /// class.
        /// </summary>
        /// <param name="name">The name of the trigger.</param>
        /// <param name="schedule">The CRON expression for the task
        /// schedule</param>
        /// <param name="status">The current status of trigger. Possible values
        /// include: 'Disabled', 'Enabled'</param>
        public TimerTriggerUpdateParameters(string name, string schedule = default(string), string status = default(string))
        {
            Schedule = schedule;
            Status = status;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the CRON expression for the task schedule
        /// </summary>
        [JsonProperty(PropertyName = "schedule")]
        public string Schedule { get; set; }

        /// <summary>
        /// Gets or sets the current status of trigger. Possible values
        /// include: 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the name of the trigger.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
