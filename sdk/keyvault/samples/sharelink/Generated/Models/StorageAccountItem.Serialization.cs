// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Storage.Models
{
    public partial class StorageAccountItem
    {
        internal static StorageAccountItem DeserializeStorageAccountItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string resourceId = default;
            StorageAccountAttributes attributes = default;
            IReadOnlyDictionary<string, string> tags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("attributes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attributes = StorageAccountAttributes.DeserializeStorageAccountAttributes(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
            }
            return new StorageAccountItem(id, resourceId, attributes, tags ?? new ChangeTrackingDictionary<string, string>());
        }
    }
}
