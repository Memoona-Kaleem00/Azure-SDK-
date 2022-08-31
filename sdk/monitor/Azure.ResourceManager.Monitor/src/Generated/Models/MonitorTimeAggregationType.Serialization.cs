// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Monitor.Models
{
    internal static partial class MonitorTimeAggregationTypeExtensions
    {
        public static string ToSerialString(this MonitorTimeAggregationType value) => value switch
        {
            MonitorTimeAggregationType.Average => "Average",
            MonitorTimeAggregationType.Minimum => "Minimum",
            MonitorTimeAggregationType.Maximum => "Maximum",
            MonitorTimeAggregationType.Total => "Total",
            MonitorTimeAggregationType.Count => "Count",
            MonitorTimeAggregationType.Last => "Last",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MonitorTimeAggregationType value.")
        };

        public static MonitorTimeAggregationType ToMonitorTimeAggregationType(this string value)
        {
            if (string.Equals(value, "Average", StringComparison.InvariantCultureIgnoreCase)) return MonitorTimeAggregationType.Average;
            if (string.Equals(value, "Minimum", StringComparison.InvariantCultureIgnoreCase)) return MonitorTimeAggregationType.Minimum;
            if (string.Equals(value, "Maximum", StringComparison.InvariantCultureIgnoreCase)) return MonitorTimeAggregationType.Maximum;
            if (string.Equals(value, "Total", StringComparison.InvariantCultureIgnoreCase)) return MonitorTimeAggregationType.Total;
            if (string.Equals(value, "Count", StringComparison.InvariantCultureIgnoreCase)) return MonitorTimeAggregationType.Count;
            if (string.Equals(value, "Last", StringComparison.InvariantCultureIgnoreCase)) return MonitorTimeAggregationType.Last;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MonitorTimeAggregationType value.");
        }
    }
}
