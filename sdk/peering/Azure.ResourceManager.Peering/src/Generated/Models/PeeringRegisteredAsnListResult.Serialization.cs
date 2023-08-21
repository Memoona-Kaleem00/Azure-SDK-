// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Peering;

namespace Azure.ResourceManager.Peering.Models
{
    internal partial class PeeringRegisteredAsnListResult
    {
        internal static PeeringRegisteredAsnListResult DeserializePeeringRegisteredAsnListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<PeeringRegisteredAsnData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PeeringRegisteredAsnData> array = new List<PeeringRegisteredAsnData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PeeringRegisteredAsnData.DeserializePeeringRegisteredAsnData(item));
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
            return new PeeringRegisteredAsnListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
