// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    internal partial class SearchGetSchemaResponse
    {
        internal static SearchGetSchemaResponse DeserializeSearchGetSchemaResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<SearchMetadata> metadata = default;
            Core.Optional<IReadOnlyList<OperationalInsightsSearchSchemaValue>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = SearchMetadata.DeserializeSearchMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OperationalInsightsSearchSchemaValue> array = new List<OperationalInsightsSearchSchemaValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OperationalInsightsSearchSchemaValue.DeserializeOperationalInsightsSearchSchemaValue(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SearchGetSchemaResponse(metadata.Value, Core.Optional.ToList(value));
        }
    }
}
