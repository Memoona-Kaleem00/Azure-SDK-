// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PrivateLinkServiceListResult
    {
        internal static PrivateLinkServiceListResult DeserializePrivateLinkServiceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PrivateLinkService>> value = default;
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
                    List<PrivateLinkService> array = new List<PrivateLinkService>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateLinkService.DeserializePrivateLinkService(item));
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
            return new PrivateLinkServiceListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
