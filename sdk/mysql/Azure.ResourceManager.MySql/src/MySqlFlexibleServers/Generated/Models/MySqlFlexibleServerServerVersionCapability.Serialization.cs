// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerServerVersionCapability
    {
        internal static MySqlFlexibleServerServerVersionCapability DeserializeMySqlFlexibleServerServerVersionCapability(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            Core.Optional<IReadOnlyList<MySqlFlexibleServerSkuCapability>> supportedSkus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedSkus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MySqlFlexibleServerSkuCapability> array = new List<MySqlFlexibleServerSkuCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MySqlFlexibleServerSkuCapability.DeserializeMySqlFlexibleServerSkuCapability(item));
                    }
                    supportedSkus = array;
                    continue;
                }
            }
            return new MySqlFlexibleServerServerVersionCapability(name.Value, Core.Optional.ToList(supportedSkus));
        }
    }
}
