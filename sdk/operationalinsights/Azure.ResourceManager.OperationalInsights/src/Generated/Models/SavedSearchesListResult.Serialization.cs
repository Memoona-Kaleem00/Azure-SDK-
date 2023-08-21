// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.OperationalInsights;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    internal partial class SavedSearchesListResult
    {
        internal static SavedSearchesListResult DeserializeSavedSearchesListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<OperationalInsightsSavedSearchData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OperationalInsightsSavedSearchData> array = new List<OperationalInsightsSavedSearchData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OperationalInsightsSavedSearchData.DeserializeOperationalInsightsSavedSearchData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SavedSearchesListResult(Core.Optional.ToList(value));
        }
    }
}
