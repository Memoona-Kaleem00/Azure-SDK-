// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiManagementDeletedServiceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceId))
            {
                writer.WritePropertyName("serviceId");
                writer.WriteStringValue(ServiceId);
            }
            if (Optional.IsDefined(ScheduledPurgeOn))
            {
                writer.WritePropertyName("scheduledPurgeDate");
                writer.WriteStringValue(ScheduledPurgeOn.Value, "O");
            }
            if (Optional.IsDefined(DeletedOn))
            {
                writer.WritePropertyName("deletionDate");
                writer.WriteStringValue(DeletedOn.Value, "O");
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApiManagementDeletedServiceData DeserializeApiManagementDeletedServiceData(JsonElement element)
        {
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> serviceId = default;
            Optional<DateTimeOffset> scheduledPurgeDate = default;
            Optional<DateTimeOffset> deletionDate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("serviceId"))
                        {
                            serviceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scheduledPurgeDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            scheduledPurgeDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("deletionDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deletionDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApiManagementDeletedServiceData(id, name, type, systemData.Value, Optional.ToNullable(location), serviceId.Value, Optional.ToNullable(scheduledPurgeDate), Optional.ToNullable(deletionDate));
        }
    }
}
