// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstanceVersionCapability
    {
        internal static ManagedInstanceVersionCapability DeserializeManagedInstanceVersionCapability(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IReadOnlyList<ManagedInstanceEditionCapability>> supportedEditions = default;
            Optional<IReadOnlyList<InstancePoolEditionCapability>> supportedInstancePoolEditions = default;
            Optional<SqlCapabilityStatus> status = default;
            Optional<string> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedEditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedInstanceEditionCapability> array = new List<ManagedInstanceEditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedInstanceEditionCapability.DeserializeManagedInstanceEditionCapability(item));
                    }
                    supportedEditions = array;
                    continue;
                }
                if (property.NameEquals("supportedInstancePoolEditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InstancePoolEditionCapability> array = new List<InstancePoolEditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InstancePoolEditionCapability.DeserializeInstancePoolEditionCapability(item));
                    }
                    supportedInstancePoolEditions = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToSqlCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
            }
            return new ManagedInstanceVersionCapability(name.Value, Optional.ToList(supportedEditions), Optional.ToList(supportedInstancePoolEditions), Optional.ToNullable(status), reason.Value);
        }
    }
}
