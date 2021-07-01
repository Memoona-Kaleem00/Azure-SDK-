// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class ServiceSpecification
    {
        internal static ServiceSpecification DeserializeServiceSpecification(JsonElement element)
        {
            Optional<IReadOnlyList<LogSpecification>> logSpecifications = default;
            Optional<IReadOnlyList<MetricSpecification>> metricSpecifications = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logSpecifications"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LogSpecification> array = new List<LogSpecification>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LogSpecification.DeserializeLogSpecification(item));
                    }
                    logSpecifications = array;
                    continue;
                }
                if (property.NameEquals("metricSpecifications"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MetricSpecification> array = new List<MetricSpecification>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricSpecification.DeserializeMetricSpecification(item));
                    }
                    metricSpecifications = array;
                    continue;
                }
            }
            return new ServiceSpecification(Optional.ToList(logSpecifications), Optional.ToList(metricSpecifications));
        }
    }
}
