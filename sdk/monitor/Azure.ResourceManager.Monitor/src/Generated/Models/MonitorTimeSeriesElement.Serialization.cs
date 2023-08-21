// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorTimeSeriesElement
    {
        internal static MonitorTimeSeriesElement DeserializeMonitorTimeSeriesElement(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<MonitorMetadataValue>> metadatavalues = default;
            Core.Optional<IReadOnlyList<MonitorMetricValue>> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metadatavalues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorMetadataValue> array = new List<MonitorMetadataValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorMetadataValue.DeserializeMonitorMetadataValue(item));
                    }
                    metadatavalues = array;
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorMetricValue> array = new List<MonitorMetricValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorMetricValue.DeserializeMonitorMetricValue(item));
                    }
                    data = array;
                    continue;
                }
            }
            return new MonitorTimeSeriesElement(Core.Optional.ToList(metadatavalues), Core.Optional.ToList(data));
        }
    }
}
