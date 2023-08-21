// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class DataCollectionEndpointResourceListResult
    {
        internal static DataCollectionEndpointResourceListResult DeserializeDataCollectionEndpointResourceListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DataCollectionEndpointData> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<DataCollectionEndpointData> array = new List<DataCollectionEndpointData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataCollectionEndpointData.DeserializeDataCollectionEndpointData(item));
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
            return new DataCollectionEndpointResourceListResult(value, nextLink.Value);
        }
    }
}
