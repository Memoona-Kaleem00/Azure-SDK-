// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectivityInformation
    {
        internal static ConnectivityInformation DeserializeConnectivityInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<ConnectivityHopInfo>> hops = default;
            Core.Optional<NetworkConnectionStatus> connectionStatus = default;
            Core.Optional<int> avgLatencyInMs = default;
            Core.Optional<int> minLatencyInMs = default;
            Core.Optional<int> maxLatencyInMs = default;
            Core.Optional<int> probesSent = default;
            Core.Optional<int> probesFailed = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hops"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectivityHopInfo> array = new List<ConnectivityHopInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectivityHopInfo.DeserializeConnectivityHopInfo(item));
                    }
                    hops = array;
                    continue;
                }
                if (property.NameEquals("connectionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionStatus = new NetworkConnectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("avgLatencyInMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    avgLatencyInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minLatencyInMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minLatencyInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxLatencyInMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxLatencyInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("probesSent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    probesSent = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("probesFailed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    probesFailed = property.Value.GetInt32();
                    continue;
                }
            }
            return new ConnectivityInformation(Core.Optional.ToList(hops), Core.Optional.ToNullable(connectionStatus), Core.Optional.ToNullable(avgLatencyInMs), Core.Optional.ToNullable(minLatencyInMs), Core.Optional.ToNullable(maxLatencyInMs), Core.Optional.ToNullable(probesSent), Core.Optional.ToNullable(probesFailed));
        }
    }
}
