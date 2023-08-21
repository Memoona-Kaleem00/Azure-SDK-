// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    public partial class MetricAvailability
    {
        internal static MetricAvailability DeserializeMetricAvailability(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<TimeSpan> timeGrain = default;
            Core.Optional<TimeSpan> retention = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeGrain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeGrain = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("retention"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retention = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new MetricAvailability(Core.Optional.ToNullable(timeGrain), Core.Optional.ToNullable(retention));
        }
    }
}
