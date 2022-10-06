// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagementPartner.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagementPartner
{
    public partial class PartnerResponseData
    {
        internal static PartnerResponseData DeserializePartnerResponseData(JsonElement element)
        {
            Optional<int> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> partnerId = default;
            Optional<string> partnerName = default;
            Optional<Guid> tenantId = default;
            Optional<string> objectId = default;
            Optional<int> version = default;
            Optional<DateTimeOffset> updatedTime = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<ManagementPartnerState> state = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("partnerId"))
                        {
                            partnerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerName"))
                        {
                            partnerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tenantId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("objectId"))
                        {
                            objectId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            version = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("updatedTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            updatedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("createdTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("state"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            state = new ManagementPartnerState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PartnerResponseData(id, name, type, systemData.Value, Optional.ToNullable(etag), partnerId.Value, partnerName.Value, Optional.ToNullable(tenantId), objectId.Value, Optional.ToNullable(version), Optional.ToNullable(updatedTime), Optional.ToNullable(createdTime), Optional.ToNullable(state));
        }
    }
}
