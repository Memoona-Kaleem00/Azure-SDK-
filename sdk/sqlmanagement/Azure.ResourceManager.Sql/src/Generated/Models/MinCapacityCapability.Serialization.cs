// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class MinCapacityCapability
    {
        internal static MinCapacityCapability DeserializeMinCapacityCapability(JsonElement element)
        {
            Optional<double> value = default;
            Optional<CapabilityStatus> status = default;
            Optional<string> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    value = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = property.Value.GetString().ToCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"))
                {
                    reason = property.Value.GetString();
                    continue;
                }
            }
            return new MinCapacityCapability(Optional.ToNullable(value), Optional.ToNullable(status), reason.Value);
        }
    }
}
