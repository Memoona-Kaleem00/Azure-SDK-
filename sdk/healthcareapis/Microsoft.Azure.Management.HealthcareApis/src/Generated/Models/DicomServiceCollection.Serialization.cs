// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    public partial class DicomServiceCollection
    {
        internal static DicomServiceCollection DeserializeDicomServiceCollection(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<DicomService>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DicomService> array = new List<DicomService>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DicomService.DeserializeDicomService(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new DicomServiceCollection(nextLink.Value, Optional.ToList(value));
        }
    }
}
