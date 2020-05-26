// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndexerStatus
    {
        internal static SearchIndexerStatus DeserializeSearchIndexerStatus(JsonElement element)
        {
            IndexerStatus status = default;
            IndexerExecutionResult lastResult = default;
            IReadOnlyList<IndexerExecutionResult> executionHistory = default;
            SearchIndexerLimits limits = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString().ToIndexerStatus();
                    continue;
                }
                if (property.NameEquals("lastResult"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastResult = IndexerExecutionResult.DeserializeIndexerExecutionResult(property.Value);
                    continue;
                }
                if (property.NameEquals("executionHistory"))
                {
                    List<IndexerExecutionResult> array = new List<IndexerExecutionResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(IndexerExecutionResult.DeserializeIndexerExecutionResult(item));
                        }
                    }
                    executionHistory = array;
                    continue;
                }
                if (property.NameEquals("limits"))
                {
                    limits = SearchIndexerLimits.DeserializeSearchIndexerLimits(property.Value);
                    continue;
                }
            }
            return new SearchIndexerStatus(status, lastResult, executionHistory, limits);
        }
    }
}
