// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class ProximityPlacementGroupListResult
    {
        internal static ProximityPlacementGroupListResult DeserializeProximityPlacementGroupListResult(JsonElement element)
        {
            IReadOnlyList<ProximityPlacementGroupData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ProximityPlacementGroupData> array = new List<ProximityPlacementGroupData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProximityPlacementGroupData.DeserializeProximityPlacementGroupData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ProximityPlacementGroupListResult(value, nextLink.Value);
        }
    }
}
