// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> For schedules like: 'recur every month on the first Monday' or 'recur every 3 months on last Friday'. </summary>
    public partial class ContainerServiceMaintenanceRelativeMonthlySchedule
    {
        /// <summary> Initializes a new instance of <see cref="ContainerServiceMaintenanceRelativeMonthlySchedule"/>. </summary>
        /// <param name="intervalMonths"> Specifies the number of months between each set of occurrences. </param>
        /// <param name="weekIndex"> Specifies on which instance of the allowed days specified in daysOfWeek the maintenance occurs. </param>
        /// <param name="dayOfWeek"> Specifies on which day of the week the maintenance occurs. </param>
        public ContainerServiceMaintenanceRelativeMonthlySchedule(int intervalMonths, ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex weekIndex, ContainerServiceWeekDay dayOfWeek)
        {
            IntervalMonths = intervalMonths;
            WeekIndex = weekIndex;
            DayOfWeek = dayOfWeek;
        }

        /// <summary> Specifies the number of months between each set of occurrences. </summary>
        public int IntervalMonths { get; set; }
        /// <summary> Specifies on which instance of the allowed days specified in daysOfWeek the maintenance occurs. </summary>
        public ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex WeekIndex { get; set; }
        /// <summary> Specifies on which day of the week the maintenance occurs. </summary>
        public ContainerServiceWeekDay DayOfWeek { get; set; }
    }
}
