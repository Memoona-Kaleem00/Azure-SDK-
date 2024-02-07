// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    [PersistableModelProxy(typeof(UnknownWorkloadProtectableItem))]
    public partial class WorkloadProtectableItem : IUtf8JsonSerializable, IJsonModel<WorkloadProtectableItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkloadProtectableItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WorkloadProtectableItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadProtectableItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadProtectableItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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

        WorkloadProtectableItem IJsonModel<WorkloadProtectableItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadProtectableItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadProtectableItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadProtectableItem(document.RootElement, options);
        }

        internal static WorkloadProtectableItem DeserializeWorkloadProtectableItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("protectableItemType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureFileShare": return FileShareProtectableItem.DeserializeFileShareProtectableItem(element);
                    case "AzureVmWorkloadProtectableItem": return VmWorkloadProtectableItem.DeserializeVmWorkloadProtectableItem(element);
                    case "HanaHSRContainer": return VmWorkloadSapHanaHsrProtectableItem.DeserializeVmWorkloadSapHanaHsrProtectableItem(element);
                    case "IaaSVMProtectableItem": return IaasVmProtectableItem.DeserializeIaasVmProtectableItem(element);
                    case "Microsoft.ClassicCompute/virtualMachines": return IaasClassicComputeVmProtectableItem.DeserializeIaasClassicComputeVmProtectableItem(element);
                    case "Microsoft.Compute/virtualMachines": return IaasComputeVmProtectableItem.DeserializeIaasComputeVmProtectableItem(element);
                    case "SAPAseSystem": return VmWorkloadSapAseSystemProtectableItem.DeserializeVmWorkloadSapAseSystemProtectableItem(element);
                    case "SAPHanaDBInstance": return VmWorkloadSapHanaDBInstance.DeserializeVmWorkloadSapHanaDBInstance(element);
                    case "SAPHanaDatabase": return VmWorkloadSapHanaDatabaseProtectableItem.DeserializeVmWorkloadSapHanaDatabaseProtectableItem(element);
                    case "SAPHanaSystem": return VmWorkloadSapHanaSystemProtectableItem.DeserializeVmWorkloadSapHanaSystemProtectableItem(element);
                    case "SQLAvailabilityGroupContainer": return VmWorkloadSqlAvailabilityGroupProtectableItem.DeserializeVmWorkloadSqlAvailabilityGroupProtectableItem(element);
                    case "SQLDataBase": return VmWorkloadSqlDatabaseProtectableItem.DeserializeVmWorkloadSqlDatabaseProtectableItem(element);
                    case "SQLInstance": return VmWorkloadSqlInstanceProtectableItem.DeserializeVmWorkloadSqlInstanceProtectableItem(element);
                }
            }
            return UnknownWorkloadProtectableItem.DeserializeUnknownWorkloadProtectableItem(element);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

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

        BinaryData IPersistableModel<WorkloadProtectableItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadProtectableItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(WorkloadProtectableItem)} does not support '{options.Format}' format.");
            }
        }

        WorkloadProtectableItem IPersistableModel<WorkloadProtectableItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadProtectableItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkloadProtectableItem(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(WorkloadProtectableItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkloadProtectableItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
