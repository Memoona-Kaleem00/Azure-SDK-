// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class ResourceSkuLocationInfo
    {
        internal static ResourceSkuLocationInfo DeserializeResourceSkuLocationInfo(JsonElement element)
        {
            string location = default;
            IReadOnlyList<string> zones = default;
            IReadOnlyList<ResourceSkuZoneDetails> zoneDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zones"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("zoneDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceSkuZoneDetails> array = new List<ResourceSkuZoneDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ResourceSkuZoneDetails.DeserializeResourceSkuZoneDetails(item));
                        }
                    }
                    zoneDetails = array;
                    continue;
                }
            }
            return new ResourceSkuLocationInfo(location, zones, zoneDetails);
        }
    }
}
