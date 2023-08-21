// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class NetworkCloudNetworkInterface
    {
        internal static NetworkCloudNetworkInterface DeserializeNetworkCloudNetworkInterface(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> address = default;
            Core.Optional<DeviceConnectionType> deviceConnectionType = default;
            Core.Optional<string> model = default;
            Core.Optional<long> physicalSlot = default;
            Core.Optional<long> portCount = default;
            Core.Optional<long> portSpeed = default;
            Core.Optional<string> vendor = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("address"u8))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceConnectionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceConnectionType = new DeviceConnectionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("physicalSlot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    physicalSlot = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("portCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    portCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("portSpeed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    portSpeed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("vendor"u8))
                {
                    vendor = property.Value.GetString();
                    continue;
                }
            }
            return new NetworkCloudNetworkInterface(address.Value, Core.Optional.ToNullable(deviceConnectionType), model.Value, Core.Optional.ToNullable(physicalSlot), Core.Optional.ToNullable(portCount), Core.Optional.ToNullable(portSpeed), vendor.Value);
        }
    }
}
