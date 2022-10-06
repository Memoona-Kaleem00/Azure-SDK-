// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    public partial class SkuDetailsForExistingResource
    {
        internal static SkuDetailsForExistingResource DeserializeSkuDetailsForExistingResource(JsonElement element)
        {
            Optional<string> resourceType = default;
            Optional<CapacitySku> sku = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = CapacitySku.DeserializeCapacitySku(property.Value);
                    continue;
                }
            }
            return new SkuDetailsForExistingResource(resourceType.Value, sku.Value);
        }
    }
}
