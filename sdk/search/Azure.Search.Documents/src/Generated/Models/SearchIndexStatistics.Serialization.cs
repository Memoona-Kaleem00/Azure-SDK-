// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndexStatistics
    {
        internal static SearchIndexStatistics DeserializeSearchIndexStatistics(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long documentCount = default;
            long storageSize = default;
            long vectorIndexSize = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documentCount"u8))
                {
                    documentCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("storageSize"u8))
                {
                    storageSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("vectorIndexSize"u8))
                {
                    vectorIndexSize = property.Value.GetInt64();
                    continue;
                }
            }
            return new SearchIndexStatistics(documentCount, storageSize, vectorIndexSize);
        }
    }
}
