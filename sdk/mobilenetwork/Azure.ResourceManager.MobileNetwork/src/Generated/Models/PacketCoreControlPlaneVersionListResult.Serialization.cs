// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    internal partial class PacketCoreControlPlaneVersionListResult
    {
        internal static PacketCoreControlPlaneVersionListResult DeserializePacketCoreControlPlaneVersionListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<PacketCoreControlPlaneVersionData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PacketCoreControlPlaneVersionData> array = new List<PacketCoreControlPlaneVersionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PacketCoreControlPlaneVersionData.DeserializePacketCoreControlPlaneVersionData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PacketCoreControlPlaneVersionListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
