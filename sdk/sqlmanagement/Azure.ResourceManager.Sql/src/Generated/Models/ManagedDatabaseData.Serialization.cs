// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedDatabaseData : IUtf8JsonSerializable, IJsonModel<ManagedDatabaseData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedDatabaseData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedDatabaseData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedDatabaseData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedDatabaseData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Collation))
            {
                writer.WritePropertyName("collation"u8);
                writer.WriteStringValue(Collation);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(EarliestRestorePoint))
            {
                writer.WritePropertyName("earliestRestorePoint"u8);
                writer.WriteStringValue(EarliestRestorePoint.Value, "O");
            }
            if (Optional.IsDefined(RestorePointInTime))
            {
                writer.WritePropertyName("restorePointInTime"u8);
                writer.WriteStringValue(RestorePointInTime.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(DefaultSecondaryLocation))
            {
                writer.WritePropertyName("defaultSecondaryLocation"u8);
                writer.WriteStringValue(DefaultSecondaryLocation.Value);
            }
            if (Optional.IsDefined(CatalogCollation))
            {
                writer.WritePropertyName("catalogCollation"u8);
                writer.WriteStringValue(CatalogCollation.Value.ToString());
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            if (Optional.IsDefined(StorageContainerUri))
            {
                writer.WritePropertyName("storageContainerUri"u8);
                writer.WriteStringValue(StorageContainerUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SourceDatabaseId))
            {
                writer.WritePropertyName("sourceDatabaseId"u8);
                writer.WriteStringValue(SourceDatabaseId);
            }
            if (Optional.IsDefined(CrossSubscriptionSourceDatabaseId))
            {
                writer.WritePropertyName("crossSubscriptionSourceDatabaseId"u8);
                writer.WriteStringValue(CrossSubscriptionSourceDatabaseId);
            }
            if (Optional.IsDefined(RestorableDroppedDatabaseId))
            {
                writer.WritePropertyName("restorableDroppedDatabaseId"u8);
                writer.WriteStringValue(RestorableDroppedDatabaseId);
            }
            if (Optional.IsDefined(CrossSubscriptionRestorableDroppedDatabaseId))
            {
                writer.WritePropertyName("crossSubscriptionRestorableDroppedDatabaseId"u8);
                writer.WriteStringValue(CrossSubscriptionRestorableDroppedDatabaseId);
            }
            if (Optional.IsDefined(StorageContainerIdentity))
            {
                writer.WritePropertyName("storageContainerIdentity"u8);
                writer.WriteStringValue(StorageContainerIdentity);
            }
            if (Optional.IsDefined(StorageContainerSasToken))
            {
                writer.WritePropertyName("storageContainerSasToken"u8);
                writer.WriteStringValue(StorageContainerSasToken);
            }
            if (options.Format != "W" && Optional.IsDefined(FailoverGroupId))
            {
                writer.WritePropertyName("failoverGroupId"u8);
                writer.WriteStringValue(FailoverGroupId);
            }
            if (Optional.IsDefined(RecoverableDatabaseId))
            {
                writer.WritePropertyName("recoverableDatabaseId"u8);
                writer.WriteStringValue(RecoverableDatabaseId);
            }
            if (Optional.IsDefined(LongTermRetentionBackupResourceId))
            {
                writer.WritePropertyName("longTermRetentionBackupResourceId"u8);
                writer.WriteStringValue(LongTermRetentionBackupResourceId);
            }
            if (Optional.IsDefined(AllowAutoCompleteRestore))
            {
                writer.WritePropertyName("autoCompleteRestore"u8);
                writer.WriteBooleanValue(AllowAutoCompleteRestore.Value);
            }
            if (Optional.IsDefined(LastBackupName))
            {
                writer.WritePropertyName("lastBackupName"u8);
                writer.WriteStringValue(LastBackupName);
            }
            if (Optional.IsDefined(CrossSubscriptionTargetManagedInstanceId))
            {
                writer.WritePropertyName("crossSubscriptionTargetManagedInstanceId"u8);
                writer.WriteStringValue(CrossSubscriptionTargetManagedInstanceId);
            }
            if (Optional.IsDefined(IsLedgerOn))
            {
                writer.WritePropertyName("isLedgerOn"u8);
                writer.WriteBooleanValue(IsLedgerOn.Value);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ManagedDatabaseData IJsonModel<ManagedDatabaseData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedDatabaseData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedDatabaseData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedDatabaseData(document.RootElement, options);
        }

        internal static ManagedDatabaseData DeserializeManagedDatabaseData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> collation = default;
            Optional<ManagedDatabaseStatus> status = default;
            Optional<DateTimeOffset> creationDate = default;
            Optional<DateTimeOffset> earliestRestorePoint = default;
            Optional<DateTimeOffset> restorePointInTime = default;
            Optional<AzureLocation> defaultSecondaryLocation = default;
            Optional<CatalogCollationType> catalogCollation = default;
            Optional<ManagedDatabaseCreateMode> createMode = default;
            Optional<Uri> storageContainerUri = default;
            Optional<ResourceIdentifier> sourceDatabaseId = default;
            Optional<ResourceIdentifier> crossSubscriptionSourceDatabaseId = default;
            Optional<ResourceIdentifier> restorableDroppedDatabaseId = default;
            Optional<ResourceIdentifier> crossSubscriptionRestorableDroppedDatabaseId = default;
            Optional<string> storageContainerIdentity = default;
            Optional<string> storageContainerSasToken = default;
            Optional<ResourceIdentifier> failoverGroupId = default;
            Optional<ResourceIdentifier> recoverableDatabaseId = default;
            Optional<ResourceIdentifier> longTermRetentionBackupResourceId = default;
            Optional<bool> autoCompleteRestore = default;
            Optional<string> lastBackupName = default;
            Optional<ResourceIdentifier> crossSubscriptionTargetManagedInstanceId = default;
            Optional<bool> isLedgerOn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("collation"u8))
                        {
                            collation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new ManagedDatabaseStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("creationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("earliestRestorePoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            earliestRestorePoint = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("restorePointInTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restorePointInTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("defaultSecondaryLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultSecondaryLocation = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("catalogCollation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            catalogCollation = new CatalogCollationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("createMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createMode = new ManagedDatabaseCreateMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("storageContainerUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageContainerUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sourceDatabaseId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceDatabaseId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("crossSubscriptionSourceDatabaseId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            crossSubscriptionSourceDatabaseId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("restorableDroppedDatabaseId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restorableDroppedDatabaseId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("crossSubscriptionRestorableDroppedDatabaseId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            crossSubscriptionRestorableDroppedDatabaseId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("storageContainerIdentity"u8))
                        {
                            storageContainerIdentity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageContainerSasToken"u8))
                        {
                            storageContainerSasToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("failoverGroupId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            failoverGroupId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("recoverableDatabaseId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recoverableDatabaseId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("longTermRetentionBackupResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            longTermRetentionBackupResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("autoCompleteRestore"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoCompleteRestore = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("lastBackupName"u8))
                        {
                            lastBackupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("crossSubscriptionTargetManagedInstanceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            crossSubscriptionTargetManagedInstanceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isLedgerOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isLedgerOn = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedDatabaseData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, collation.Value, Optional.ToNullable(status), Optional.ToNullable(creationDate), Optional.ToNullable(earliestRestorePoint), Optional.ToNullable(restorePointInTime), Optional.ToNullable(defaultSecondaryLocation), Optional.ToNullable(catalogCollation), Optional.ToNullable(createMode), storageContainerUri.Value, sourceDatabaseId.Value, crossSubscriptionSourceDatabaseId.Value, restorableDroppedDatabaseId.Value, crossSubscriptionRestorableDroppedDatabaseId.Value, storageContainerIdentity.Value, storageContainerSasToken.Value, failoverGroupId.Value, recoverableDatabaseId.Value, longTermRetentionBackupResourceId.Value, Optional.ToNullable(autoCompleteRestore), lastBackupName.Value, crossSubscriptionTargetManagedInstanceId.Value, Optional.ToNullable(isLedgerOn), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                if (Name.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Name}'''");
                }
                else
                {
                    builder.AppendLine($" '{Name}'");
                }
            }

            if (Optional.IsDefined(Location))
            {
                builder.Append("  location:");
                builder.AppendLine($" '{Location.ToString()}'");
            }

            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags.Any())
                {
                    builder.Append("  tags:");
                    builder.AppendLine(" {");
                    foreach (var item in Tags)
                    {
                        builder.Append($"    {item.Key}:");
                        if (item.Value == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        if (item.Value.Contains(Environment.NewLine))
                        {
                            builder.AppendLine(" '''");
                            builder.AppendLine($"{item.Value}'''");
                        }
                        else
                        {
                            builder.AppendLine($" '{item.Value}'");
                        }
                    }
                    builder.AppendLine("  }");
                }
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsDefined(Collation))
            {
                builder.Append("    collation:");
                if (Collation.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Collation}'''");
                }
                else
                {
                    builder.AppendLine($" '{Collation}'");
                }
            }

            if (Optional.IsDefined(Status))
            {
                builder.Append("    status:");
                builder.AppendLine($" '{Status.Value.ToString()}'");
            }

            if (Optional.IsDefined(CreatedOn))
            {
                builder.Append("    creationDate:");
                var formattedDateTimeString = TypeFormatters.ToString(CreatedOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(EarliestRestorePoint))
            {
                builder.Append("    earliestRestorePoint:");
                var formattedDateTimeString = TypeFormatters.ToString(EarliestRestorePoint.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(RestorePointInTime))
            {
                builder.Append("    restorePointInTime:");
                var formattedDateTimeString = TypeFormatters.ToString(RestorePointInTime.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(DefaultSecondaryLocation))
            {
                builder.Append("    defaultSecondaryLocation:");
                builder.AppendLine($" '{DefaultSecondaryLocation.Value.ToString()}'");
            }

            if (Optional.IsDefined(CatalogCollation))
            {
                builder.Append("    catalogCollation:");
                builder.AppendLine($" '{CatalogCollation.Value.ToString()}'");
            }

            if (Optional.IsDefined(CreateMode))
            {
                builder.Append("    createMode:");
                builder.AppendLine($" '{CreateMode.Value.ToString()}'");
            }

            if (Optional.IsDefined(StorageContainerUri))
            {
                builder.Append("    storageContainerUri:");
                builder.AppendLine($" '{StorageContainerUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(SourceDatabaseId))
            {
                builder.Append("    sourceDatabaseId:");
                builder.AppendLine($" '{SourceDatabaseId.ToString()}'");
            }

            if (Optional.IsDefined(CrossSubscriptionSourceDatabaseId))
            {
                builder.Append("    crossSubscriptionSourceDatabaseId:");
                builder.AppendLine($" '{CrossSubscriptionSourceDatabaseId.ToString()}'");
            }

            if (Optional.IsDefined(RestorableDroppedDatabaseId))
            {
                builder.Append("    restorableDroppedDatabaseId:");
                builder.AppendLine($" '{RestorableDroppedDatabaseId.ToString()}'");
            }

            if (Optional.IsDefined(CrossSubscriptionRestorableDroppedDatabaseId))
            {
                builder.Append("    crossSubscriptionRestorableDroppedDatabaseId:");
                builder.AppendLine($" '{CrossSubscriptionRestorableDroppedDatabaseId.ToString()}'");
            }

            if (Optional.IsDefined(StorageContainerIdentity))
            {
                builder.Append("    storageContainerIdentity:");
                if (StorageContainerIdentity.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{StorageContainerIdentity}'''");
                }
                else
                {
                    builder.AppendLine($" '{StorageContainerIdentity}'");
                }
            }

            if (Optional.IsDefined(StorageContainerSasToken))
            {
                builder.Append("    storageContainerSasToken:");
                if (StorageContainerSasToken.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{StorageContainerSasToken}'''");
                }
                else
                {
                    builder.AppendLine($" '{StorageContainerSasToken}'");
                }
            }

            if (Optional.IsDefined(FailoverGroupId))
            {
                builder.Append("    failoverGroupId:");
                builder.AppendLine($" '{FailoverGroupId.ToString()}'");
            }

            if (Optional.IsDefined(RecoverableDatabaseId))
            {
                builder.Append("    recoverableDatabaseId:");
                builder.AppendLine($" '{RecoverableDatabaseId.ToString()}'");
            }

            if (Optional.IsDefined(LongTermRetentionBackupResourceId))
            {
                builder.Append("    longTermRetentionBackupResourceId:");
                builder.AppendLine($" '{LongTermRetentionBackupResourceId.ToString()}'");
            }

            if (Optional.IsDefined(AllowAutoCompleteRestore))
            {
                builder.Append("    autoCompleteRestore:");
                var boolValue = AllowAutoCompleteRestore.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(LastBackupName))
            {
                builder.Append("    lastBackupName:");
                if (LastBackupName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{LastBackupName}'''");
                }
                else
                {
                    builder.AppendLine($" '{LastBackupName}'");
                }
            }

            if (Optional.IsDefined(CrossSubscriptionTargetManagedInstanceId))
            {
                builder.Append("    crossSubscriptionTargetManagedInstanceId:");
                builder.AppendLine($" '{CrossSubscriptionTargetManagedInstanceId.ToString()}'");
            }

            if (Optional.IsDefined(IsLedgerOn))
            {
                builder.Append("    isLedgerOn:");
                var boolValue = IsLedgerOn.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            bool inMultilineString = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (inMultilineString)
                {
                    if (line.Contains("'''"))
                    {
                        inMultilineString = false;
                    }
                    stringBuilder.AppendLine(line);
                    continue;
                }
                if (line.Contains("'''"))
                {
                    inMultilineString = true;
                    stringBuilder.AppendLine($"{indent}{line}");
                    continue;
                }
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<ManagedDatabaseData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedDatabaseData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedDatabaseData)} does not support '{options.Format}' format.");
            }
        }

        ManagedDatabaseData IPersistableModel<ManagedDatabaseData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedDatabaseData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedDatabaseData(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ManagedDatabaseData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedDatabaseData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
