// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Orbital;

namespace Azure.ResourceManager.Orbital.Models
{
    internal partial class AvailableGroundStationListResult
    {
        internal static AvailableGroundStationListResult DeserializeAvailableGroundStationListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<AvailableGroundStationData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AvailableGroundStationData> array = new List<AvailableGroundStationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailableGroundStationData.DeserializeAvailableGroundStationData(item));
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
            return new AvailableGroundStationListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
