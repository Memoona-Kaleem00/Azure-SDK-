// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class SyncGroupData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Interval))
            {
                writer.WritePropertyName("interval");
                writer.WriteNumberValue(Interval.Value);
            }
            if (Optional.IsDefined(ConflictResolutionPolicy))
            {
                writer.WritePropertyName("conflictResolutionPolicy");
                writer.WriteStringValue(ConflictResolutionPolicy.Value.ToString());
            }
            if (Optional.IsDefined(SyncDatabaseId))
            {
                writer.WritePropertyName("syncDatabaseId");
                writer.WriteStringValue(SyncDatabaseId);
            }
            if (Optional.IsDefined(HubDatabaseUserName))
            {
                writer.WritePropertyName("hubDatabaseUserName");
                writer.WriteStringValue(HubDatabaseUserName);
            }
            if (Optional.IsDefined(HubDatabasePassword))
            {
                writer.WritePropertyName("hubDatabasePassword");
                writer.WriteStringValue(HubDatabasePassword);
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema");
                writer.WriteObjectValue(Schema);
            }
            if (Optional.IsDefined(EnableConflictLogging))
            {
                writer.WritePropertyName("enableConflictLogging");
                writer.WriteBooleanValue(EnableConflictLogging.Value);
            }
            if (Optional.IsDefined(ConflictLoggingRetentionInDays))
            {
                writer.WritePropertyName("conflictLoggingRetentionInDays");
                writer.WriteNumberValue(ConflictLoggingRetentionInDays.Value);
            }
            if (Optional.IsDefined(UsePrivateLinkConnection))
            {
                writer.WritePropertyName("usePrivateLinkConnection");
                writer.WriteBooleanValue(UsePrivateLinkConnection.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SyncGroupData DeserializeSyncGroupData(JsonElement element)
        {
            Optional<SqlSku> sku = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<int> interval = default;
            Optional<DateTimeOffset> lastSyncTime = default;
            Optional<SyncConflictResolutionPolicy> conflictResolutionPolicy = default;
            Optional<string> syncDatabaseId = default;
            Optional<string> hubDatabaseUserName = default;
            Optional<string> hubDatabasePassword = default;
            Optional<SyncGroupState> syncState = default;
            Optional<SyncGroupSchema> schema = default;
            Optional<bool> enableConflictLogging = default;
            Optional<int> conflictLoggingRetentionInDays = default;
            Optional<bool> usePrivateLinkConnection = default;
            Optional<string> privateEndpointName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = SqlSku.DeserializeSqlSku(property.Value);
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
                    type = (ResourceType)property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
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
                        if (property0.NameEquals("interval"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            interval = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("lastSyncTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastSyncTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("conflictResolutionPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            conflictResolutionPolicy = new SyncConflictResolutionPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("syncDatabaseId"))
                        {
                            syncDatabaseId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hubDatabaseUserName"))
                        {
                            hubDatabaseUserName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hubDatabasePassword"))
                        {
                            hubDatabasePassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("syncState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            syncState = new SyncGroupState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("schema"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            schema = SyncGroupSchema.DeserializeSyncGroupSchema(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enableConflictLogging"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableConflictLogging = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("conflictLoggingRetentionInDays"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            conflictLoggingRetentionInDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("usePrivateLinkConnection"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            usePrivateLinkConnection = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointName"))
                        {
                            privateEndpointName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SyncGroupData(id, name, type, systemData, sku.Value, Optional.ToNullable(interval), Optional.ToNullable(lastSyncTime), Optional.ToNullable(conflictResolutionPolicy), syncDatabaseId.Value, hubDatabaseUserName.Value, hubDatabasePassword.Value, Optional.ToNullable(syncState), schema.Value, Optional.ToNullable(enableConflictLogging), Optional.ToNullable(conflictLoggingRetentionInDays), Optional.ToNullable(usePrivateLinkConnection), privateEndpointName.Value);
        }
    }
}
