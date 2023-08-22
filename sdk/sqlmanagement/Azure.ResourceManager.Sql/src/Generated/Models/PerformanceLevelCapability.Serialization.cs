// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class PerformanceLevelCapability
    {
        internal static PerformanceLevelCapability DeserializePerformanceLevelCapability(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<double> value = default;
            Optional<PerformanceLevelUnit> unit = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unit = new PerformanceLevelUnit(property.Value.GetString());
                    continue;
                }
            }
            return new PerformanceLevelCapability(Optional.ToNullable(value), Optional.ToNullable(unit));
        }
    }
}
