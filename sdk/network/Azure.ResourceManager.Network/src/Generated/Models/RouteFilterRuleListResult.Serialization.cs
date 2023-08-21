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
    internal partial class RouteFilterRuleListResult
    {
        internal static RouteFilterRuleListResult DeserializeRouteFilterRuleListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<RouteFilterRuleData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouteFilterRuleData> array = new List<RouteFilterRuleData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteFilterRuleData.DeserializeRouteFilterRuleData(item));
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
            return new RouteFilterRuleListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
