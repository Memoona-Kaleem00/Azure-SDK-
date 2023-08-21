// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class MonitorResponse
    {
        internal static MonitorResponse DeserializeMonitorResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<int> cost = default;
            string timespan = default;
            Core.Optional<TimeSpan> interval = default;
            Core.Optional<string> @namespace = default;
            Core.Optional<string> resourceregion = default;
            IReadOnlyList<MonitorMetric> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cost = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timespan"u8))
                {
                    timespan = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("interval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interval = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceregion"u8))
                {
                    resourceregion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    List<MonitorMetric> array = new List<MonitorMetric>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorMetric.DeserializeMonitorMetric(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new MonitorResponse(Core.Optional.ToNullable(cost), timespan, Core.Optional.ToNullable(interval), @namespace.Value, resourceregion.Value, value);
        }
    }
}
