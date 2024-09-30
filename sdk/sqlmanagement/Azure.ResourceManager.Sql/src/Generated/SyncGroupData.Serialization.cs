// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class SyncGroupData : IUtf8JsonSerializable, IJsonModel<SyncGroupData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SyncGroupData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SyncGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncGroupData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Interval))
            {
                writer.WritePropertyName("interval"u8);
                writer.WriteNumberValue(Interval.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LastSyncOn))
            {
                writer.WritePropertyName("lastSyncTime"u8);
                writer.WriteStringValue(LastSyncOn.Value, "O");
            }
            if (Optional.IsDefined(ConflictResolutionPolicy))
            {
                writer.WritePropertyName("conflictResolutionPolicy"u8);
                writer.WriteStringValue(ConflictResolutionPolicy.Value.ToString());
            }
            if (Optional.IsDefined(SyncDatabaseId))
            {
                writer.WritePropertyName("syncDatabaseId"u8);
                writer.WriteStringValue(SyncDatabaseId);
            }
            if (Optional.IsDefined(HubDatabaseUserName))
            {
                writer.WritePropertyName("hubDatabaseUserName"u8);
                writer.WriteStringValue(HubDatabaseUserName);
            }
            if (Optional.IsDefined(HubDatabasePassword))
            {
                writer.WritePropertyName("hubDatabasePassword"u8);
                writer.WriteStringValue(HubDatabasePassword);
            }
            if (options.Format != "W" && Optional.IsDefined(SyncState))
            {
                writer.WritePropertyName("syncState"u8);
                writer.WriteStringValue(SyncState.Value.ToString());
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema"u8);
                writer.WriteObjectValue(Schema, options);
            }
            if (Optional.IsDefined(IsConflictLoggingEnabled))
            {
                writer.WritePropertyName("enableConflictLogging"u8);
                writer.WriteBooleanValue(IsConflictLoggingEnabled.Value);
            }
            if (Optional.IsDefined(ConflictLoggingRetentionInDays))
            {
                writer.WritePropertyName("conflictLoggingRetentionInDays"u8);
                writer.WriteNumberValue(ConflictLoggingRetentionInDays.Value);
            }
            if (Optional.IsDefined(UsePrivateLinkConnection))
            {
                writer.WritePropertyName("usePrivateLinkConnection"u8);
                writer.WriteBooleanValue(UsePrivateLinkConnection.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PrivateEndpointName))
            {
                writer.WritePropertyName("privateEndpointName"u8);
                writer.WriteStringValue(PrivateEndpointName);
            }
            writer.WriteEndObject();
        }

        SyncGroupData IJsonModel<SyncGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncGroupData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncGroupData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSyncGroupData(document.RootElement, options);
        }

        internal static SyncGroupData DeserializeSyncGroupData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SqlSku sku = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            int? interval = default;
            DateTimeOffset? lastSyncTime = default;
            SyncConflictResolutionPolicy? conflictResolutionPolicy = default;
            ResourceIdentifier syncDatabaseId = default;
            string hubDatabaseUserName = default;
            string hubDatabasePassword = default;
            SyncGroupState? syncState = default;
            SyncGroupSchema schema = default;
            bool? enableConflictLogging = default;
            int? conflictLoggingRetentionInDays = default;
            bool? usePrivateLinkConnection = default;
            string privateEndpointName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = SqlSku.DeserializeSqlSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("interval"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            interval = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("lastSyncTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastSyncTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("conflictResolutionPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            conflictResolutionPolicy = new SyncConflictResolutionPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("syncDatabaseId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            syncDatabaseId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hubDatabaseUserName"u8))
                        {
                            hubDatabaseUserName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hubDatabasePassword"u8))
                        {
                            hubDatabasePassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("syncState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            syncState = new SyncGroupState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("schema"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            schema = SyncGroupSchema.DeserializeSyncGroupSchema(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("enableConflictLogging"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableConflictLogging = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("conflictLoggingRetentionInDays"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            conflictLoggingRetentionInDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("usePrivateLinkConnection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usePrivateLinkConnection = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointName"u8))
                        {
                            privateEndpointName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SyncGroupData(
                id,
                name,
                type,
                systemData,
                sku,
                interval,
                lastSyncTime,
                conflictResolutionPolicy,
                syncDatabaseId,
                hubDatabaseUserName,
                hubDatabasePassword,
                syncState,
                schema,
                enableConflictLogging,
                conflictLoggingRetentionInDays,
                usePrivateLinkConnection,
                privateEndpointName,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Sku), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sku: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Sku))
                {
                    builder.Append("  sku: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Sku, options, 2, false, "  sku: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Interval), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    interval: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Interval))
                {
                    builder.Append("    interval: ");
                    builder.AppendLine($"{Interval.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastSyncOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    lastSyncTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastSyncOn))
                {
                    builder.Append("    lastSyncTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastSyncOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConflictResolutionPolicy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    conflictResolutionPolicy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConflictResolutionPolicy))
                {
                    builder.Append("    conflictResolutionPolicy: ");
                    builder.AppendLine($"'{ConflictResolutionPolicy.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SyncDatabaseId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    syncDatabaseId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SyncDatabaseId))
                {
                    builder.Append("    syncDatabaseId: ");
                    builder.AppendLine($"'{SyncDatabaseId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HubDatabaseUserName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    hubDatabaseUserName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HubDatabaseUserName))
                {
                    builder.Append("    hubDatabaseUserName: ");
                    if (HubDatabaseUserName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{HubDatabaseUserName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{HubDatabaseUserName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HubDatabasePassword), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    hubDatabasePassword: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HubDatabasePassword))
                {
                    builder.Append("    hubDatabasePassword: ");
                    if (HubDatabasePassword.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{HubDatabasePassword}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{HubDatabasePassword}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SyncState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    syncState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SyncState))
                {
                    builder.Append("    syncState: ");
                    builder.AppendLine($"'{SyncState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Schema), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    schema: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Schema))
                {
                    builder.Append("    schema: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Schema, options, 4, false, "    schema: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsConflictLoggingEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    enableConflictLogging: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsConflictLoggingEnabled))
                {
                    builder.Append("    enableConflictLogging: ");
                    var boolValue = IsConflictLoggingEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConflictLoggingRetentionInDays), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    conflictLoggingRetentionInDays: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConflictLoggingRetentionInDays))
                {
                    builder.Append("    conflictLoggingRetentionInDays: ");
                    builder.AppendLine($"{ConflictLoggingRetentionInDays.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UsePrivateLinkConnection), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    usePrivateLinkConnection: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UsePrivateLinkConnection))
                {
                    builder.Append("    usePrivateLinkConnection: ");
                    var boolValue = UsePrivateLinkConnection.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrivateEndpointName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    privateEndpointName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PrivateEndpointName))
                {
                    builder.Append("    privateEndpointName: ");
                    if (PrivateEndpointName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PrivateEndpointName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PrivateEndpointName}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SyncGroupData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SyncGroupData)} does not support writing '{options.Format}' format.");
            }
        }

        SyncGroupData IPersistableModel<SyncGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncGroupData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSyncGroupData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SyncGroupData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SyncGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
