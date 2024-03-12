// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Search.Models
{
    public partial class ReverseSearchAddressBatchResult
    {
        internal static ReverseSearchAddressBatchResult DeserializeReverseSearchAddressBatchResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ReverseSearchAddressBatchItem> batchItems = default;
            BatchResultSummary summary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("batchItems"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReverseSearchAddressBatchItem> array = new List<ReverseSearchAddressBatchItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReverseSearchAddressBatchItem.DeserializeReverseSearchAddressBatchItem(item));
                    }
                    batchItems = array;
                    continue;
                }
                if (property.NameEquals("summary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    summary = BatchResultSummary.DeserializeBatchResultSummary(property.Value);
                    continue;
                }
            }
            return new ReverseSearchAddressBatchResult(summary, batchItems ?? new ChangeTrackingList<ReverseSearchAddressBatchItem>());
        }
    }
}
