// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class MetricEnrichedSeriesData
    {
        internal static MetricEnrichedSeriesData DeserializeMetricEnrichedSeriesData(JsonElement element)
        {
            SeriesIdentity series = default;
            IReadOnlyList<DateTimeOffset> timestampList = default;
            IReadOnlyList<double> valueList = default;
            IReadOnlyList<bool?> isAnomalyList = default;
            IReadOnlyList<int?> periodList = default;
            IReadOnlyList<double?> expectedValueList = default;
            IReadOnlyList<double?> lowerBoundaryList = default;
            IReadOnlyList<double?> upperBoundaryList = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("series"))
                {
                    series = SeriesIdentity.DeserializeSeriesIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("timestampList"))
                {
                    List<DateTimeOffset> array = new List<DateTimeOffset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDateTimeOffset("O"));
                    }
                    timestampList = array;
                    continue;
                }
                if (property.NameEquals("valueList"))
                {
                    List<double> array = new List<double>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDouble());
                    }
                    valueList = array;
                    continue;
                }
                if (property.NameEquals("isAnomalyList"))
                {
                    List<bool?> array = new List<bool?>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetBoolean());
                        }
                    }
                    isAnomalyList = array;
                    continue;
                }
                if (property.NameEquals("periodList"))
                {
                    List<int?> array = new List<int?>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetInt32());
                        }
                    }
                    periodList = array;
                    continue;
                }
                if (property.NameEquals("expectedValueList"))
                {
                    List<double?> array = new List<double?>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetDouble());
                        }
                    }
                    expectedValueList = array;
                    continue;
                }
                if (property.NameEquals("lowerBoundaryList"))
                {
                    List<double?> array = new List<double?>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetDouble());
                        }
                    }
                    lowerBoundaryList = array;
                    continue;
                }
                if (property.NameEquals("upperBoundaryList"))
                {
                    List<double?> array = new List<double?>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetDouble());
                        }
                    }
                    upperBoundaryList = array;
                    continue;
                }
            }
            return new MetricEnrichedSeriesData(series, timestampList, valueList, isAnomalyList, periodList, expectedValueList, lowerBoundaryList, upperBoundaryList);
        }
    }
}
