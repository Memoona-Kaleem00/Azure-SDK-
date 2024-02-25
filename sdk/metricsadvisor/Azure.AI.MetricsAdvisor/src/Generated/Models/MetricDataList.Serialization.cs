// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class MetricDataList
    {
        internal static MetricDataList DeserializeMetricDataList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<MetricSeriesData> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricSeriesData> array = new List<MetricSeriesData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricSeriesData.DeserializeMetricSeriesData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new MetricDataList(value ?? new ChangeTrackingList<MetricSeriesData>());
        }
    }
}
