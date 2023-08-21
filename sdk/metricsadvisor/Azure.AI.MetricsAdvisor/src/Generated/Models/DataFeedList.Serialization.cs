// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class DataFeedList
    {
        internal static DataFeedList DeserializeDataFeedList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> nextLink = default;
            Core.Optional<IReadOnlyList<DataFeedDetail>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataFeedDetail> array = new List<DataFeedDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFeedDetail.DeserializeDataFeedDetail(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new DataFeedList(nextLink.Value, Core.Optional.ToList(value));
        }
    }
}
