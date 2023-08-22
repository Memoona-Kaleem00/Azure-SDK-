// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class ManagedInstanceQueryStatistics
    {
        internal static ManagedInstanceQueryStatistics DeserializeManagedInstanceQueryStatistics(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<QueryStatistics>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QueryStatistics> array = new List<QueryStatistics>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueryStatistics.DeserializeQueryStatistics(item));
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
            return new ManagedInstanceQueryStatistics(Optional.ToList(value), nextLink.Value);
        }
    }
}
