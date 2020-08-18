// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ExpressRoutePortsLocationListResult
    {
        internal static ExpressRoutePortsLocationListResult DeserializeExpressRoutePortsLocationListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ExpressRoutePortsLocation>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ExpressRoutePortsLocation> array = new List<ExpressRoutePortsLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExpressRoutePortsLocation.DeserializeExpressRoutePortsLocation(item));
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
            return new ExpressRoutePortsLocationListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
