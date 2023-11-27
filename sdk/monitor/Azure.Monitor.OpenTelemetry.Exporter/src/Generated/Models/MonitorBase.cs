// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    /// <summary> Data struct to contain only C section with custom fields. </summary>
    internal partial class MonitorBase
    {
        /// <summary> Initializes a new instance of <see cref="MonitorBase"/>. </summary>
        public MonitorBase()
        {
        }

        /// <summary> Name of item (B section) if any. If telemetry data is derived straight from this, this should be null. </summary>
        public string BaseType { get; set; }
        /// <summary> The data payload for the telemetry request. </summary>
        public MonitorDomain BaseData { get; set; }
    }
}
