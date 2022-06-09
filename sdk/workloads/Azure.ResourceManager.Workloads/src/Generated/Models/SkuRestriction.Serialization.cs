// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SkuRestriction
    {
        internal static SkuRestriction DeserializeSkuRestriction(JsonElement element)
        {
            Optional<SkuRestrictionType> type = default;
            Optional<IReadOnlyList<string>> values = default;
            Optional<RestrictionInfo> restrictionInfo = default;
            Optional<SkuRestrictionReasonCode> reasonCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new SkuRestrictionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("values"))
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
                    values = array;
                    continue;
                }
                if (property.NameEquals("restrictionInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    restrictionInfo = RestrictionInfo.DeserializeRestrictionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("reasonCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    reasonCode = new SkuRestrictionReasonCode(property.Value.GetString());
                    continue;
                }
            }
            return new SkuRestriction(Optional.ToNullable(type), Optional.ToList(values), restrictionInfo.Value, Optional.ToNullable(reasonCode));
        }
    }
}
