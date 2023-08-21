// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    internal partial class NewRelicObservabilityMonitoredResourceListResult
    {
        internal static NewRelicObservabilityMonitoredResourceListResult DeserializeNewRelicObservabilityMonitoredResourceListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<NewRelicResourceMonitorResult> value = default;
            Core.Optional<Uri> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<NewRelicResourceMonitorResult> array = new List<NewRelicResourceMonitorResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NewRelicResourceMonitorResult.DeserializeNewRelicResourceMonitorResult(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLink = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new NewRelicObservabilityMonitoredResourceListResult(value, nextLink.Value);
        }
    }
}
