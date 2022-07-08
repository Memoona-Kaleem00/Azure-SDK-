// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ComputeResourceSkuZoneDetails
    {
        internal static ComputeResourceSkuZoneDetails DeserializeComputeResourceSkuZoneDetails(JsonElement element)
        {
            Optional<IReadOnlyList<string>> name = default;
            Optional<IReadOnlyList<ResourceSkuCapabilities>> capabilities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    name = array;
                    continue;
                }
                if (property.NameEquals("capabilities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResourceSkuCapabilities> array = new List<ResourceSkuCapabilities>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceSkuCapabilities.DeserializeResourceSkuCapabilities(item));
                    }
                    capabilities = array;
                    continue;
                }
            }
            return new ComputeResourceSkuZoneDetails(Optional.ToList(name), Optional.ToList(capabilities));
        }
    }
}
