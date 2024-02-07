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
    public partial class SqlAvailabilityGroupWorkloadProtectionContainer : IUtf8JsonSerializable, IJsonModel<SqlAvailabilityGroupWorkloadProtectionContainer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlAvailabilityGroupWorkloadProtectionContainer>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlAvailabilityGroupWorkloadProtectionContainer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAvailabilityGroupWorkloadProtectionContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlAvailabilityGroupWorkloadProtectionContainer)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedTime"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(ExtendedInfo))
            {
                writer.WritePropertyName("extendedInfo"u8);
                writer.WriteObjectValue(ExtendedInfo);
            }
            if (Optional.IsDefined(WorkloadType))
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType.Value.ToString());
            }
            if (Optional.IsDefined(OperationType))
            {
                writer.WritePropertyName("operationType"u8);
                writer.WriteStringValue(OperationType.Value.ToString());
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (Optional.IsDefined(RegistrationStatus))
            {
                writer.WritePropertyName("registrationStatus"u8);
                writer.WriteStringValue(RegistrationStatus);
            }
            if (Optional.IsDefined(HealthStatus))
            {
                writer.WritePropertyName("healthStatus"u8);
                writer.WriteStringValue(HealthStatus);
            }
            writer.WritePropertyName("containerType"u8);
            writer.WriteStringValue(ContainerType.ToSerialString());
            if (Optional.IsDefined(ProtectableObjectType))
            {
                writer.WritePropertyName("protectableObjectType"u8);
                writer.WriteStringValue(ProtectableObjectType);
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

        SqlAvailabilityGroupWorkloadProtectionContainer IJsonModel<SqlAvailabilityGroupWorkloadProtectionContainer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAvailabilityGroupWorkloadProtectionContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlAvailabilityGroupWorkloadProtectionContainer)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlAvailabilityGroupWorkloadProtectionContainer(document.RootElement, options);
        }

        internal static SqlAvailabilityGroupWorkloadProtectionContainer DeserializeSqlAvailabilityGroupWorkloadProtectionContainer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> sourceResourceId = default;
            Optional<DateTimeOffset> lastUpdatedTime = default;
            Optional<WorkloadContainerExtendedInfo> extendedInfo = default;
            Optional<BackupWorkloadType> workloadType = default;
            Optional<WorkloadOperationType> operationType = default;
            Optional<string> friendlyName = default;
            Optional<BackupManagementType> backupManagementType = default;
            Optional<string> registrationStatus = default;
            Optional<string> healthStatus = default;
            ProtectableContainerType containerType = default;
            Optional<string> protectableObjectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastUpdatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("extendedInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedInfo = WorkloadContainerExtendedInfo.DeserializeWorkloadContainerExtendedInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("workloadType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workloadType = new BackupWorkloadType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationType = new WorkloadOperationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupManagementType = new BackupManagementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("registrationStatus"u8))
                {
                    registrationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthStatus"u8))
                {
                    healthStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerType"u8))
                {
                    containerType = property.Value.GetString().ToProtectableContainerType();
                    continue;
                }
                if (property.NameEquals("protectableObjectType"u8))
                {
                    protectableObjectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlAvailabilityGroupWorkloadProtectionContainer(friendlyName.Value, Optional.ToNullable(backupManagementType), registrationStatus.Value, healthStatus.Value, containerType, protectableObjectType.Value, serializedAdditionalRawData, sourceResourceId.Value, Optional.ToNullable(lastUpdatedTime), extendedInfo.Value, Optional.ToNullable(workloadType), Optional.ToNullable(operationType));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(SourceResourceId))
            {
                builder.Append("  sourceResourceId:");
                builder.AppendLine($" '{SourceResourceId.ToString()}'");
            }

            if (Optional.IsDefined(LastUpdatedOn))
            {
                builder.Append("  lastUpdatedTime:");
                var formattedDateTimeString = TypeFormatters.ToString(LastUpdatedOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(ExtendedInfo))
            {
                builder.Append("  extendedInfo:");
                AppendChildObject(builder, ExtendedInfo, options, 2, false);
            }

            if (Optional.IsDefined(WorkloadType))
            {
                builder.Append("  workloadType:");
                builder.AppendLine($" '{WorkloadType.Value.ToString()}'");
            }

            if (Optional.IsDefined(OperationType))
            {
                builder.Append("  operationType:");
                builder.AppendLine($" '{OperationType.Value.ToString()}'");
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

            if (Optional.IsDefined(BackupManagementType))
            {
                builder.Append("  backupManagementType:");
                builder.AppendLine($" '{BackupManagementType.Value.ToString()}'");
            }

            if (Optional.IsDefined(RegistrationStatus))
            {
                builder.Append("  registrationStatus:");
                if (RegistrationStatus.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{RegistrationStatus}'''");
                }
                else
                {
                    builder.AppendLine($" '{RegistrationStatus}'");
                }
            }

            if (Optional.IsDefined(HealthStatus))
            {
                builder.Append("  healthStatus:");
                if (HealthStatus.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{HealthStatus}'''");
                }
                else
                {
                    builder.AppendLine($" '{HealthStatus}'");
                }
            }

            if (Optional.IsDefined(ContainerType))
            {
                builder.Append("  containerType:");
                builder.AppendLine($" '{ContainerType.ToSerialString()}'");
            }

            if (Optional.IsDefined(ProtectableObjectType))
            {
                builder.Append("  protectableObjectType:");
                if (ProtectableObjectType.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ProtectableObjectType}'''");
                }
                else
                {
                    builder.AppendLine($" '{ProtectableObjectType}'");
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

        BinaryData IPersistableModel<SqlAvailabilityGroupWorkloadProtectionContainer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAvailabilityGroupWorkloadProtectionContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SqlAvailabilityGroupWorkloadProtectionContainer)} does not support '{options.Format}' format.");
            }
        }

        SqlAvailabilityGroupWorkloadProtectionContainer IPersistableModel<SqlAvailabilityGroupWorkloadProtectionContainer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAvailabilityGroupWorkloadProtectionContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlAvailabilityGroupWorkloadProtectionContainer(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SqlAvailabilityGroupWorkloadProtectionContainer)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlAvailabilityGroupWorkloadProtectionContainer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
