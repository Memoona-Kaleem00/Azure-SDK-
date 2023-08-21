// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class AzureReachabilityReportItem
    {
        internal static AzureReachabilityReportItem DeserializeAzureReachabilityReportItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> provider = default;
            Core.Optional<AzureLocation> azureLocation = default;
            Core.Optional<IReadOnlyList<AzureReachabilityReportLatencyInfo>> latencies = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provider"u8))
                {
                    provider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("latencies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureReachabilityReportLatencyInfo> array = new List<AzureReachabilityReportLatencyInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureReachabilityReportLatencyInfo.DeserializeAzureReachabilityReportLatencyInfo(item));
                    }
                    latencies = array;
                    continue;
                }
            }
            return new AzureReachabilityReportItem(provider.Value, Core.Optional.ToNullable(azureLocation), Core.Optional.ToList(latencies));
        }
    }
}
