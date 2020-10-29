// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    public partial class HealthcareEntity
    {
        internal static HealthcareEntity DeserializeHealthcareEntity(JsonElement element)
        {
            bool isNegated = default;
            Optional<IReadOnlyList<HealthcareEntityLink>> links = default;
            string text = default;
            string category = default;
            Optional<string> subcategory = default;
            int offset = default;
            int length = default;
            double confidenceScore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isNegated"))
                {
                    isNegated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("links"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<HealthcareEntityLink> array = new List<HealthcareEntityLink>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareEntityLink.DeserializeHealthcareEntityLink(item));
                    }
                    links = array;
                    continue;
                }
                if (property.NameEquals("text"))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subcategory"))
                {
                    subcategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offset"))
                {
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("confidenceScore"))
                {
                    confidenceScore = property.Value.GetDouble();
                    continue;
                }
            }
            return new HealthcareEntity(text, category, subcategory.Value, offset, length, confidenceScore, isNegated, Optional.ToList(links));
        }
    }
}
