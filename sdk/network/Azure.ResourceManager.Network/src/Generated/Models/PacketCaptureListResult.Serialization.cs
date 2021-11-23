// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class PacketCaptureListResult
    {
        internal static PacketCaptureListResult DeserializePacketCaptureListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PacketCaptureData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PacketCaptureData> array = new List<PacketCaptureData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PacketCaptureData.DeserializePacketCaptureData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new PacketCaptureListResult(Optional.ToList(value));
        }
    }
}
