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
                    case "AzureIaaSVMJob": return IaasVmBackupJob.DeserializeIaasVmBackupJob(element);
                    case "AzureIaaSVMJobV2": return IaasVmBackupJobV2.DeserializeIaasVmBackupJobV2(element);
                    case "AzureStorageJob": return StorageBackupJob.DeserializeStorageBackupJob(element);
                    case "AzureWorkloadJob": return WorkloadBackupJob.DeserializeWorkloadBackupJob(element);
                    case "DpmJob": return DpmBackupJob.DeserializeDpmBackupJob(element);
                    case "MabJob": return MabBackupJob.DeserializeMabBackupJob(element);
                    case "VaultJob": return VaultBackupJob.DeserializeVaultBackupJob(element);
                }
            }
            return UnknownJob.DeserializeUnknownJob(element);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(EntityFriendlyName))
            {
                builder.Append("  entityFriendlyName:");
                if (EntityFriendlyName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{EntityFriendlyName}'''");
                }
                else
                {
                    builder.AppendLine($" '{EntityFriendlyName}'");
                }
            }

            if (Optional.IsDefined(BackupManagementType))
            {
                builder.Append("  backupManagementType:");
                builder.AppendLine($" '{BackupManagementType.Value.ToString()}'");
            }

            if (Optional.IsDefined(Operation))
            {
                builder.Append("  operation:");
                if (Operation.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Operation}'''");
                }
                else
                {
                    builder.AppendLine($" '{Operation}'");
                }
            }

            if (Optional.IsDefined(Status))
            {
                builder.Append("  status:");
                if (Status.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Status}'''");
                }
                else
                {
                    builder.AppendLine($" '{Status}'");
                }
            }

            if (Optional.IsDefined(StartOn))
            {
                builder.Append("  startTime:");
                var formattedDateTimeString = TypeFormatters.ToString(StartOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(EndOn))
            {
                builder.Append("  endTime:");
                var formattedDateTimeString = TypeFormatters.ToString(EndOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(ActivityId))
            {
                builder.Append("  activityId:");
                if (ActivityId.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ActivityId}'''");
                }
                else
                {
                    builder.AppendLine($" '{ActivityId}'");
                }
            }

            if (Optional.IsDefined(JobType))
            {
                builder.Append("  jobType:");
                if (JobType.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{JobType}'''");
                }
                else
                {
                    builder.AppendLine($" '{JobType}'");
                }
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

        BinaryData IPersistableModel<BackupGenericJob>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
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
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(BackupGenericJob)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupGenericJob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
