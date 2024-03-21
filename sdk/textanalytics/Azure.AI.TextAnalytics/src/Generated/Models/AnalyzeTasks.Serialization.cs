// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class AnalyzeTasks
    {
        internal static AnalyzeTasks DeserializeAnalyzeTasks(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int completed = default;
            int failed = default;
            int inProgress = default;
            int total = default;
            IReadOnlyList<AnalyzeTextLROResult> items = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("completed"u8))
                {
                    completed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failed"u8))
                {
                    failed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("inProgress"u8))
                {
                    inProgress = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("total"u8))
                {
                    total = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("items"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AnalyzeTextLROResult> array = new List<AnalyzeTextLROResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnalyzeTextLROResult.DeserializeAnalyzeTextLROResult(item));
                    }
                    items = array;
                    continue;
                }
            }
            return new AnalyzeTasks(completed, failed, inProgress, total, items ?? new ChangeTrackingList<AnalyzeTextLROResult>());
        }
    }
}
