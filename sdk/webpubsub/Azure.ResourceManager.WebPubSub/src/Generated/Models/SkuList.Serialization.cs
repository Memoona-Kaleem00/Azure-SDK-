// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    public partial class SkuList
    {
        internal static SkuList DeserializeSkuList(JsonElement element)
        {
            Optional<IReadOnlyList<Sku>> value = default;
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
                    List<Sku> array = new List<Sku>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Sku.DeserializeSku(item));
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
            return new SkuList(Optional.ToList(value), nextLink.Value);
        }
    }
}
