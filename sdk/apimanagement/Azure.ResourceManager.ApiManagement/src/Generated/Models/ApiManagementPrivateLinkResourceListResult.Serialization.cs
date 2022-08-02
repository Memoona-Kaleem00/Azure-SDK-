// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal partial class ApiManagementPrivateLinkResourceListResult
    {
        internal static ApiManagementPrivateLinkResourceListResult DeserializeApiManagementPrivateLinkResourceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ApiManagementPrivateLinkData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ApiManagementPrivateLinkData> array = new List<ApiManagementPrivateLinkData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiManagementPrivateLinkData.DeserializeApiManagementPrivateLinkData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ApiManagementPrivateLinkResourceListResult(Optional.ToList(value));
        }
    }
}
