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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class BackupResourceVaultConfigProperties : IUtf8JsonSerializable, IJsonModel<BackupResourceVaultConfigProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupResourceVaultConfigProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupResourceVaultConfigProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceVaultConfigProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupResourceVaultConfigProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StorageModelType))
            {
                writer.WritePropertyName("storageModelType"u8);
                writer.WriteStringValue(StorageModelType.Value.ToString());
            }
            if (Optional.IsDefined(StorageType))
            {
                writer.WritePropertyName("storageType"u8);
                writer.WriteStringValue(StorageType.Value.ToString());
            }
            if (Optional.IsDefined(StorageTypeState))
            {
                writer.WritePropertyName("storageTypeState"u8);
                writer.WriteStringValue(StorageTypeState.Value.ToString());
            }
            if (Optional.IsDefined(EnhancedSecurityState))
            {
                writer.WritePropertyName("enhancedSecurityState"u8);
                writer.WriteStringValue(EnhancedSecurityState.Value.ToString());
            }
            if (Optional.IsDefined(SoftDeleteFeatureState))
            {
                writer.WritePropertyName("softDeleteFeatureState"u8);
                writer.WriteStringValue(SoftDeleteFeatureState.Value.ToString());
            }
            if (Optional.IsDefined(SoftDeleteRetentionPeriodInDays))
            {
                writer.WritePropertyName("softDeleteRetentionPeriodInDays"u8);
                writer.WriteNumberValue(SoftDeleteRetentionPeriodInDays.Value);
            }
            if (Optional.IsCollectionDefined(ResourceGuardOperationRequests))
            {
                writer.WritePropertyName("resourceGuardOperationRequests"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGuardOperationRequests)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsSoftDeleteFeatureStateEditable))
            {
                writer.WritePropertyName("isSoftDeleteFeatureStateEditable"u8);
                writer.WriteBooleanValue(IsSoftDeleteFeatureStateEditable.Value);
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

        BackupResourceVaultConfigProperties IJsonModel<BackupResourceVaultConfigProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceVaultConfigProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupResourceVaultConfigProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupResourceVaultConfigProperties(document.RootElement, options);
        }

        internal static BackupResourceVaultConfigProperties DeserializeBackupResourceVaultConfigProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BackupStorageType> storageModelType = default;
            Optional<BackupStorageType> storageType = default;
            Optional<BackupStorageTypeState> storageTypeState = default;
            Optional<EnhancedSecurityState> enhancedSecurityState = default;
            Optional<SoftDeleteFeatureState> softDeleteFeatureState = default;
            Optional<int> softDeleteRetentionPeriodInDays = default;
            Optional<IList<string>> resourceGuardOperationRequests = default;
            Optional<bool> isSoftDeleteFeatureStateEditable = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageModelType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageModelType = new BackupStorageType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageType = new BackupStorageType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageTypeState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageTypeState = new BackupStorageTypeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enhancedSecurityState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enhancedSecurityState = new EnhancedSecurityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("softDeleteFeatureState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softDeleteFeatureState = new SoftDeleteFeatureState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("softDeleteRetentionPeriodInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softDeleteRetentionPeriodInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resourceGuardOperationRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resourceGuardOperationRequests = array;
                    continue;
                }
                if (property.NameEquals("isSoftDeleteFeatureStateEditable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSoftDeleteFeatureStateEditable = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackupResourceVaultConfigProperties(Optional.ToNullable(storageModelType), Optional.ToNullable(storageType), Optional.ToNullable(storageTypeState), Optional.ToNullable(enhancedSecurityState), Optional.ToNullable(softDeleteFeatureState), Optional.ToNullable(softDeleteRetentionPeriodInDays), Optional.ToList(resourceGuardOperationRequests), Optional.ToNullable(isSoftDeleteFeatureStateEditable), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(StorageModelType))
            {
                builder.Append("  storageModelType:");
                builder.AppendLine($" '{StorageModelType.Value.ToString()}'");
            }

            if (Optional.IsDefined(StorageType))
            {
                builder.Append("  storageType:");
                builder.AppendLine($" '{StorageType.Value.ToString()}'");
            }

            if (Optional.IsDefined(StorageTypeState))
            {
                builder.Append("  storageTypeState:");
                builder.AppendLine($" '{StorageTypeState.Value.ToString()}'");
            }

            if (Optional.IsDefined(EnhancedSecurityState))
            {
                builder.Append("  enhancedSecurityState:");
                builder.AppendLine($" '{EnhancedSecurityState.Value.ToString()}'");
            }

            if (Optional.IsDefined(SoftDeleteFeatureState))
            {
                builder.Append("  softDeleteFeatureState:");
                builder.AppendLine($" '{SoftDeleteFeatureState.Value.ToString()}'");
            }

            if (Optional.IsDefined(SoftDeleteRetentionPeriodInDays))
            {
                builder.Append("  softDeleteRetentionPeriodInDays:");
                builder.AppendLine($" {SoftDeleteRetentionPeriodInDays.Value}");
            }

            if (Optional.IsCollectionDefined(ResourceGuardOperationRequests))
            {
                if (ResourceGuardOperationRequests.Any())
                {
                    builder.Append("  resourceGuardOperationRequests:");
                    builder.AppendLine(" [");
                    foreach (var item in ResourceGuardOperationRequests)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        if (item.Contains(Environment.NewLine))
                        {
                            builder.AppendLine("    '''");
                            builder.AppendLine($"{item}'''");
                        }
                        else
                        {
                            builder.AppendLine($"    '{item}'");
                        }
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(IsSoftDeleteFeatureStateEditable))
            {
                builder.Append("  isSoftDeleteFeatureStateEditable:");
                var boolValue = IsSoftDeleteFeatureStateEditable.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
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

        BinaryData IPersistableModel<BackupResourceVaultConfigProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceVaultConfigProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BackupResourceVaultConfigProperties)} does not support '{options.Format}' format.");
            }
        }

        BackupResourceVaultConfigProperties IPersistableModel<BackupResourceVaultConfigProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceVaultConfigProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupResourceVaultConfigProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(BackupResourceVaultConfigProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupResourceVaultConfigProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
