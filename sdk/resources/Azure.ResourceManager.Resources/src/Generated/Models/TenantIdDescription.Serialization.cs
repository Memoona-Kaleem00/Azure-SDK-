// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class TenantIdDescription
    {
        internal static TenantIdDescription DeserializeTenantIdDescription(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> tenantId = default;
            Optional<TenantCategory> tenantCategory = default;
            Optional<string> country = default;
            Optional<string> countryCode = default;
            Optional<string> displayName = default;
            Optional<IReadOnlyList<string>> domains = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"))
                {
                    tenantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantCategory"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tenantCategory = property.Value.GetString().ToTenantCategory();
                    continue;
                }
                if (property.NameEquals("country"))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("countryCode"))
                {
                    countryCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domains"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    domains = array;
                    continue;
                }
            }
            return new TenantIdDescription(id.Value, tenantId.Value, Optional.ToNullable(tenantCategory), country.Value, countryCode.Value, displayName.Value, Optional.ToList(domains));
        }
    }
}
