// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class LabelingJobResourceArmPaginatedResult
    {
        internal static LabelingJobResourceArmPaginatedResult DeserializeLabelingJobResourceArmPaginatedResult(JsonElement element)
        {
            Optional<IReadOnlyList<LabelingJobResource>> value = default;
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
                    List<LabelingJobResource> array = new List<LabelingJobResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LabelingJobResource.DeserializeLabelingJobResource(item));
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
            return new LabelingJobResourceArmPaginatedResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
