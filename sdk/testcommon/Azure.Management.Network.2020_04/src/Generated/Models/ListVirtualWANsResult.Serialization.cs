// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ListVirtualWANsResult
    {
        internal static ListVirtualWANsResult DeserializeListVirtualWANsResult(JsonElement element)
        {
            Optional<IReadOnlyList<VirtualWAN>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VirtualWAN> array = new List<VirtualWAN>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualWAN.DeserializeVirtualWAN(item));
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
            return new ListVirtualWANsResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
