// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class UsagesListResult
    {
        internal static UsagesListResult DeserializeUsagesListResult(JsonElement element)
        {
            Optional<IReadOnlyList<Usage>> value = default;
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
                    List<Usage> array = new List<Usage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Usage.DeserializeUsage(item));
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
            return new UsagesListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
