// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
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
                    case "AzureFileShare": return FileShareProtectableItem.DeserializeFileShareProtectableItem(element, options);
                    case "AzureVmWorkloadProtectableItem": return VmWorkloadProtectableItem.DeserializeVmWorkloadProtectableItem(element, options);
                    case "HanaHSRContainer": return VmWorkloadSapHanaHsrProtectableItem.DeserializeVmWorkloadSapHanaHsrProtectableItem(element, options);
                    case "IaaSVMProtectableItem": return IaasVmProtectableItem.DeserializeIaasVmProtectableItem(element, options);
                    case "Microsoft.ClassicCompute/virtualMachines": return IaasClassicComputeVmProtectableItem.DeserializeIaasClassicComputeVmProtectableItem(element, options);
                    case "Microsoft.Compute/virtualMachines": return IaasComputeVmProtectableItem.DeserializeIaasComputeVmProtectableItem(element, options);
                    case "SAPAseSystem": return VmWorkloadSapAseSystemProtectableItem.DeserializeVmWorkloadSapAseSystemProtectableItem(element, options);
                    case "SAPHanaDBInstance": return VmWorkloadSapHanaDBInstance.DeserializeVmWorkloadSapHanaDBInstance(element, options);
                    case "SAPHanaDatabase": return VmWorkloadSapHanaDatabaseProtectableItem.DeserializeVmWorkloadSapHanaDatabaseProtectableItem(element, options);
                    case "SAPHanaSystem": return VmWorkloadSapHanaSystemProtectableItem.DeserializeVmWorkloadSapHanaSystemProtectableItem(element, options);
                    case "SQLAvailabilityGroupContainer": return VmWorkloadSqlAvailabilityGroupProtectableItem.DeserializeVmWorkloadSqlAvailabilityGroupProtectableItem(element, options);
                    case "SQLDataBase": return VmWorkloadSqlDatabaseProtectableItem.DeserializeVmWorkloadSqlDatabaseProtectableItem(element, options);
                    case "SQLInstance": return VmWorkloadSqlInstanceProtectableItem.DeserializeVmWorkloadSqlInstanceProtectableItem(element, options);
                }
            }
            return UnknownWorkloadProtectableItem.DeserializeUnknownWorkloadProtectableItem(element, options);
        }

        BinaryData IPersistableModel<WorkloadProtectableItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadProtectableItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
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
                default:
                    throw new FormatException($"The model {nameof(WorkloadProtectableItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkloadProtectableItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
