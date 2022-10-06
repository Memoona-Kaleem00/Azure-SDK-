// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class StorageCacheUsage
    {
        internal static StorageCacheUsage DeserializeStorageCacheUsage(JsonElement element)
        {
            Optional<int> limit = default;
            Optional<string> unit = default;
            Optional<int> currentValue = default;
            Optional<StorageCacheUsageName> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("limit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    limit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currentValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    currentValue = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    name = StorageCacheUsageName.DeserializeStorageCacheUsageName(property.Value);
                    continue;
                }
            }
            return new StorageCacheUsage(Optional.ToNullable(limit), unit.Value, Optional.ToNullable(currentValue), name.Value);
        }
    }
}
