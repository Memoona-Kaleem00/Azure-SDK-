// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ExpressRouteCircuitPeeringListResult
    {
        internal static ExpressRouteCircuitPeeringListResult DeserializeExpressRouteCircuitPeeringListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ExpressRouteCircuitPeering>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ExpressRouteCircuitPeering> array = new List<ExpressRouteCircuitPeering>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExpressRouteCircuitPeering.DeserializeExpressRouteCircuitPeering(item));
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
            return new ExpressRouteCircuitPeeringListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
