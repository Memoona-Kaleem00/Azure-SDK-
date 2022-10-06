// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Datadog.Models
{
    internal partial class DatadogAgreementResourceListResponse
    {
        internal static DatadogAgreementResourceListResponse DeserializeDatadogAgreementResourceListResponse(JsonElement element)
        {
            Optional<IReadOnlyList<DatadogAgreementResource>> value = default;
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
                    List<DatadogAgreementResource> array = new List<DatadogAgreementResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatadogAgreementResource.DeserializeDatadogAgreementResource(item));
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
            return new DatadogAgreementResourceListResponse(Optional.ToList(value), nextLink.Value);
        }
    }
}
