// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Maintenance window options.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class MaintenanceWindowOptions : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the MaintenanceWindowOptions class.
        /// </summary>
        public MaintenanceWindowOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MaintenanceWindowOptions class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="isEnabled">Whether maintenance windows are enabled for
        /// the database.</param>
        /// <param name="maintenanceWindowCycles">Available maintenance cycles
        /// e.g. {Saturday, 0, 48*60}, {Wednesday, 0, 24*60}.</param>
        /// <param name="minDurationInMinutes">Minimum duration of maintenance
        /// window.</param>
        /// <param name="defaultDurationInMinutes">Default duration for
        /// maintenance window.</param>
        /// <param name="minCycles">Minimum number of maintenance windows
        /// cycles to be set on the database.</param>
        /// <param name="timeGranularityInMinutes">Time granularity in minutes
        /// for maintenance windows.</param>
        /// <param name="allowMultipleMaintenanceWindowsPerCycle">Whether we
        /// allow multiple maintenance windows per cycle.</param>
        public MaintenanceWindowOptions(string id = default(string), string name = default(string), string type = default(string), bool? isEnabled = default(bool?), IList<MaintenanceWindowTimeRange> maintenanceWindowCycles = default(IList<MaintenanceWindowTimeRange>), int? minDurationInMinutes = default(int?), int? defaultDurationInMinutes = default(int?), int? minCycles = default(int?), int? timeGranularityInMinutes = default(int?), bool? allowMultipleMaintenanceWindowsPerCycle = default(bool?))
            : base(id, name, type)
        {
            IsEnabled = isEnabled;
            MaintenanceWindowCycles = maintenanceWindowCycles;
            MinDurationInMinutes = minDurationInMinutes;
            DefaultDurationInMinutes = defaultDurationInMinutes;
            MinCycles = minCycles;
            TimeGranularityInMinutes = timeGranularityInMinutes;
            AllowMultipleMaintenanceWindowsPerCycle = allowMultipleMaintenanceWindowsPerCycle;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether maintenance windows are enabled for the
        /// database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isEnabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets available maintenance cycles e.g. {Saturday, 0,
        /// 48*60}, {Wednesday, 0, 24*60}.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maintenanceWindowCycles")]
        public IList<MaintenanceWindowTimeRange> MaintenanceWindowCycles { get; set; }

        /// <summary>
        /// Gets or sets minimum duration of maintenance window.
        /// </summary>
        [JsonProperty(PropertyName = "properties.minDurationInMinutes")]
        public int? MinDurationInMinutes { get; set; }

        /// <summary>
        /// Gets or sets default duration for maintenance window.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultDurationInMinutes")]
        public int? DefaultDurationInMinutes { get; set; }

        /// <summary>
        /// Gets or sets minimum number of maintenance windows cycles to be set
        /// on the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.minCycles")]
        public int? MinCycles { get; set; }

        /// <summary>
        /// Gets or sets time granularity in minutes for maintenance windows.
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeGranularityInMinutes")]
        public int? TimeGranularityInMinutes { get; set; }

        /// <summary>
        /// Gets or sets whether we allow multiple maintenance windows per
        /// cycle.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowMultipleMaintenanceWindowsPerCycle")]
        public bool? AllowMultipleMaintenanceWindowsPerCycle { get; set; }

    }
}
