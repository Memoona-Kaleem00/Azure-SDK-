// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExpressRoutePortListResult
    {
        internal static ExpressRoutePortListResult DeserializeExpressRoutePortListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ExpressRoutePort>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ExpressRoutePort> array = new List<ExpressRoutePort>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExpressRoutePort.DeserializeExpressRoutePort(item));
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
            return new ExpressRoutePortListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
