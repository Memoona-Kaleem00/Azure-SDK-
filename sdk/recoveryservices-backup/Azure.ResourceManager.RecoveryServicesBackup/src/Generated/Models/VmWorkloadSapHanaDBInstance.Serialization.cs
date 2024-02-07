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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class VmWorkloadSapHanaDBInstance : IUtf8JsonSerializable, IJsonModel<VmWorkloadSapHanaDBInstance>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VmWorkloadSapHanaDBInstance>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VmWorkloadSapHanaDBInstance>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadSapHanaDBInstance>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmWorkloadSapHanaDBInstance)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ParentName))
            {
                writer.WritePropertyName("parentName"u8);
                writer.WriteStringValue(ParentName);
            }
            if (Optional.IsDefined(ParentUniqueName))
            {
                writer.WritePropertyName("parentUniqueName"u8);
                writer.WriteStringValue(ParentUniqueName);
            }
            if (Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            if (Optional.IsDefined(IsAutoProtectable))
            {
                writer.WritePropertyName("isAutoProtectable"u8);
                writer.WriteBooleanValue(IsAutoProtectable.Value);
            }
            if (Optional.IsDefined(IsAutoProtected))
            {
                writer.WritePropertyName("isAutoProtected"u8);
                writer.WriteBooleanValue(IsAutoProtected.Value);
            }
            if (Optional.IsDefined(SubInquiredItemCount))
            {
                writer.WritePropertyName("subinquireditemcount"u8);
                writer.WriteNumberValue(SubInquiredItemCount.Value);
            }
            if (Optional.IsDefined(SubProtectableItemCount))
            {
                writer.WritePropertyName("subprotectableitemcount"u8);
                writer.WriteNumberValue(SubProtectableItemCount.Value);
            }
            if (Optional.IsDefined(PreBackupValidation))
            {
                writer.WritePropertyName("prebackupvalidation"u8);
                writer.WriteObjectValue(PreBackupValidation);
            }
            if (Optional.IsDefined(IsProtectable))
            {
                writer.WritePropertyName("isProtectable"u8);
                writer.WriteBooleanValue(IsProtectable.Value);
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType);
            }
            if (Optional.IsDefined(WorkloadType))
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType);
            }
            writer.WritePropertyName("protectableItemType"u8);
            writer.WriteStringValue(ProtectableItemType);
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState.Value.ToString());
            }
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

        VmWorkloadSapHanaDBInstance IJsonModel<VmWorkloadSapHanaDBInstance>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadSapHanaDBInstance>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmWorkloadSapHanaDBInstance)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVmWorkloadSapHanaDBInstance(document.RootElement, options);
        }

        internal static VmWorkloadSapHanaDBInstance DeserializeVmWorkloadSapHanaDBInstance(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> parentName = default;
            Optional<string> parentUniqueName = default;
            Optional<string> serverName = default;
            Optional<bool> isAutoProtectable = default;
            Optional<bool> isAutoProtected = default;
            Optional<int> subinquireditemcount = default;
            Optional<int> subprotectableitemcount = default;
            Optional<PreBackupValidation> prebackupvalidation = default;
            Optional<bool> isProtectable = default;
            Optional<string> backupManagementType = default;
            Optional<string> workloadType = default;
            string protectableItemType = default;
            Optional<string> friendlyName = default;
            Optional<BackupProtectionStatus> protectionState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parentName"u8))
                {
                    parentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parentUniqueName"u8))
                {
                    parentUniqueName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverName"u8))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAutoProtectable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoProtectable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isAutoProtected"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoProtected = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subinquireditemcount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subinquireditemcount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("subprotectableitemcount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subprotectableitemcount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("prebackupvalidation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prebackupvalidation = PreBackupValidation.DeserializePreBackupValidation(property.Value);
                    continue;
                }
                if (property.NameEquals("isProtectable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isProtectable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    backupManagementType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadType"u8))
                {
                    workloadType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectableItemType"u8))
                {
                    protectableItemType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionState = new BackupProtectionStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VmWorkloadSapHanaDBInstance(backupManagementType.Value, workloadType.Value, protectableItemType, friendlyName.Value, Optional.ToNullable(protectionState), serializedAdditionalRawData, parentName.Value, parentUniqueName.Value, serverName.Value, Optional.ToNullable(isAutoProtectable), Optional.ToNullable(isAutoProtected), Optional.ToNullable(subinquireditemcount), Optional.ToNullable(subprotectableitemcount), prebackupvalidation.Value, Optional.ToNullable(isProtectable));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ParentName))
            {
                builder.Append("  parentName:");
                if (ParentName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ParentName}'''");
                }
                else
                {
                    builder.AppendLine($" '{ParentName}'");
                }
            }

            if (Optional.IsDefined(ParentUniqueName))
            {
                builder.Append("  parentUniqueName:");
                if (ParentUniqueName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ParentUniqueName}'''");
                }
                else
                {
                    builder.AppendLine($" '{ParentUniqueName}'");
                }
            }

            if (Optional.IsDefined(ServerName))
            {
                builder.Append("  serverName:");
                if (ServerName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ServerName}'''");
                }
                else
                {
                    builder.AppendLine($" '{ServerName}'");
                }
            }

            if (Optional.IsDefined(IsAutoProtectable))
            {
                builder.Append("  isAutoProtectable:");
                var boolValue = IsAutoProtectable.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(IsAutoProtected))
            {
                builder.Append("  isAutoProtected:");
                var boolValue = IsAutoProtected.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(SubInquiredItemCount))
            {
                builder.Append("  subinquireditemcount:");
                builder.AppendLine($" {SubInquiredItemCount.Value}");
            }

            if (Optional.IsDefined(SubProtectableItemCount))
            {
                builder.Append("  subprotectableitemcount:");
                builder.AppendLine($" {SubProtectableItemCount.Value}");
            }

            if (Optional.IsDefined(PreBackupValidation))
            {
                builder.Append("  prebackupvalidation:");
                AppendChildObject(builder, PreBackupValidation, options, 2, false);
            }

            if (Optional.IsDefined(IsProtectable))
            {
                builder.Append("  isProtectable:");
                var boolValue = IsProtectable.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(BackupManagementType))
            {
                builder.Append("  backupManagementType:");
                if (BackupManagementType.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{BackupManagementType}'''");
                }
                else
                {
                    builder.AppendLine($" '{BackupManagementType}'");
                }
            }

            if (Optional.IsDefined(WorkloadType))
            {
                builder.Append("  workloadType:");
                if (WorkloadType.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{WorkloadType}'''");
                }
                else
                {
                    builder.AppendLine($" '{WorkloadType}'");
                }
            }

            if (Optional.IsDefined(ProtectableItemType))
            {
                builder.Append("  protectableItemType:");
                if (ProtectableItemType.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ProtectableItemType}'''");
                }
                else
                {
                    builder.AppendLine($" '{ProtectableItemType}'");
                }
            }

            if (Optional.IsDefined(FriendlyName))
            {
                builder.Append("  friendlyName:");
                if (FriendlyName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{FriendlyName}'''");
                }
                else
                {
                    builder.AppendLine($" '{FriendlyName}'");
                }
            }

            if (Optional.IsDefined(ProtectionState))
            {
                builder.Append("  protectionState:");
                builder.AppendLine($" '{ProtectionState.Value.ToString()}'");
            }

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

        BinaryData IPersistableModel<VmWorkloadSapHanaDBInstance>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadSapHanaDBInstance>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(VmWorkloadSapHanaDBInstance)} does not support '{options.Format}' format.");
            }
        }

        VmWorkloadSapHanaDBInstance IPersistableModel<VmWorkloadSapHanaDBInstance>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadSapHanaDBInstance>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVmWorkloadSapHanaDBInstance(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(VmWorkloadSapHanaDBInstance)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VmWorkloadSapHanaDBInstance>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
