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
    [PersistableModelProxy(typeof(UnknownJob))]
    public partial class BackupGenericJob : IUtf8JsonSerializable, IJsonModel<BackupGenericJob>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupGenericJob>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupGenericJob>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupGenericJob)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EntityFriendlyName))
            {
                writer.WritePropertyName("entityFriendlyName"u8);
                writer.WriteStringValue(EntityFriendlyName);
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (Optional.IsDefined(Operation))
            {
                writer.WritePropertyName("operation"u8);
                writer.WriteStringValue(Operation);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(ActivityId))
            {
                writer.WritePropertyName("activityId"u8);
                writer.WriteStringValue(ActivityId);
            }
            writer.WritePropertyName("jobType"u8);
            writer.WriteStringValue(JobType);
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

        BackupGenericJob IJsonModel<BackupGenericJob>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupGenericJob)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupGenericJob(document.RootElement, options);
        }

        internal static BackupGenericJob DeserializeBackupGenericJob(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("jobType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureIaaSVMJob": return IaasVmBackupJob.DeserializeIaasVmBackupJob(element, options);
                    case "AzureIaaSVMJobV2": return IaasVmBackupJobV2.DeserializeIaasVmBackupJobV2(element, options);
                    case "AzureStorageJob": return StorageBackupJob.DeserializeStorageBackupJob(element, options);
                    case "AzureWorkloadJob": return WorkloadBackupJob.DeserializeWorkloadBackupJob(element, options);
                    case "DpmJob": return DpmBackupJob.DeserializeDpmBackupJob(element, options);
                    case "MabJob": return MabBackupJob.DeserializeMabBackupJob(element, options);
                    case "VaultJob": return VaultBackupJob.DeserializeVaultBackupJob(element, options);
                }
            }
            return UnknownJob.DeserializeUnknownJob(element, options);
        }

        BinaryData IPersistableModel<BackupGenericJob>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupGenericJob)} does not support '{options.Format}' format.");
            }
        }

        BackupGenericJob IPersistableModel<BackupGenericJob>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupGenericJob(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupGenericJob)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupGenericJob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
