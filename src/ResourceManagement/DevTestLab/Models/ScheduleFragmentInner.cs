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
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A schedule.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ScheduleFragmentInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the ScheduleFragmentInner class.
        /// </summary>
        public ScheduleFragmentInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScheduleFragmentInner class.
        /// </summary>
        /// <param name="status">The status of the schedule (i.e. Enabled,
        /// Disabled). Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="taskType">The task type of the schedule (e.g.
        /// LabVmsShutdownTask, LabVmAutoStart).</param>
        /// <param name="weeklyRecurrence">If the schedule will occur only some
        /// days of the week, specify the weekly recurrence.</param>
        /// <param name="dailyRecurrence">If the schedule will occur once each
        /// day of the week, specify the daily recurrence.</param>
        /// <param name="hourlyRecurrence">If the schedule will occur multiple
        /// times a day, specify the hourly recurrence.</param>
        /// <param name="timeZoneId">The time zone ID (e.g. Pacific Standard
        /// time).</param>
        /// <param name="notificationSettings">Notification settings.</param>
        /// <param name="targetResourceId">The resource ID to which the
        /// schedule belongs</param>
        /// <param name="provisioningState">The provisioning status of the
        /// resource.</param>
        /// <param name="uniqueIdentifier">The unique immutable identifier of a
        /// resource (Guid).</param>
        public ScheduleFragmentInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string status = default(string), string taskType = default(string), WeekDetailsFragment weeklyRecurrence = default(WeekDetailsFragment), DayDetailsFragment dailyRecurrence = default(DayDetailsFragment), HourDetailsFragment hourlyRecurrence = default(HourDetailsFragment), string timeZoneId = default(string), NotificationSettingsFragment notificationSettings = default(NotificationSettingsFragment), string targetResourceId = default(string), string provisioningState = default(string), string uniqueIdentifier = default(string))
            : base(location, id, name, type, tags)
        {
            Status = status;
            TaskType = taskType;
            WeeklyRecurrence = weeklyRecurrence;
            DailyRecurrence = dailyRecurrence;
            HourlyRecurrence = hourlyRecurrence;
            TimeZoneId = timeZoneId;
            NotificationSettings = notificationSettings;
            TargetResourceId = targetResourceId;
            ProvisioningState = provisioningState;
            UniqueIdentifier = uniqueIdentifier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the status of the schedule (i.e. Enabled, Disabled).
        /// Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the task type of the schedule (e.g.
        /// LabVmsShutdownTask, LabVmAutoStart).
        /// </summary>
        [JsonProperty(PropertyName = "properties.taskType")]
        public string TaskType { get; set; }

        /// <summary>
        /// Gets or sets if the schedule will occur only some days of the week,
        /// specify the weekly recurrence.
        /// </summary>
        [JsonProperty(PropertyName = "properties.weeklyRecurrence")]
        public WeekDetailsFragment WeeklyRecurrence { get; set; }

        /// <summary>
        /// Gets or sets if the schedule will occur once each day of the week,
        /// specify the daily recurrence.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dailyRecurrence")]
        public DayDetailsFragment DailyRecurrence { get; set; }

        /// <summary>
        /// Gets or sets if the schedule will occur multiple times a day,
        /// specify the hourly recurrence.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hourlyRecurrence")]
        public HourDetailsFragment HourlyRecurrence { get; set; }

        /// <summary>
        /// Gets or sets the time zone ID (e.g. Pacific Standard time).
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeZoneId")]
        public string TimeZoneId { get; set; }

        /// <summary>
        /// Gets or sets notification settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.notificationSettings")]
        public NotificationSettingsFragment NotificationSettings { get; set; }

        /// <summary>
        /// Gets or sets the resource ID to which the schedule belongs
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetResourceId")]
        public string TargetResourceId { get; set; }

        /// <summary>
        /// Gets or sets the provisioning status of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the unique immutable identifier of a resource (Guid).
        /// </summary>
        [JsonProperty(PropertyName = "properties.uniqueIdentifier")]
        public string UniqueIdentifier { get; set; }

    }
}
