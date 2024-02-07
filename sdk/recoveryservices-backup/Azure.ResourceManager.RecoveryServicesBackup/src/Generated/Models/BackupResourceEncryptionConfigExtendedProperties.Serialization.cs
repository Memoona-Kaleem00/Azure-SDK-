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
    public partial class BackupResourceEncryptionConfigExtendedProperties : IUtf8JsonSerializable, IJsonModel<BackupResourceEncryptionConfigExtendedProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupResourceEncryptionConfigExtendedProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupResourceEncryptionConfigExtendedProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceEncryptionConfigExtendedProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupResourceEncryptionConfigExtendedProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(UserAssignedIdentity))
            {
                writer.WritePropertyName("userAssignedIdentity"u8);
                writer.WriteStringValue(UserAssignedIdentity);
            }
            if (Optional.IsDefined(UseSystemAssignedIdentity))
            {
                writer.WritePropertyName("useSystemAssignedIdentity"u8);
                writer.WriteBooleanValue(UseSystemAssignedIdentity.Value);
            }
            if (Optional.IsDefined(EncryptionAtRestType))
            {
                writer.WritePropertyName("encryptionAtRestType"u8);
                writer.WriteStringValue(EncryptionAtRestType.Value.ToString());
            }
            if (Optional.IsDefined(KeyUri))
            {
                writer.WritePropertyName("keyUri"u8);
                writer.WriteStringValue(KeyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (Optional.IsDefined(LastUpdateStatus))
            {
                writer.WritePropertyName("lastUpdateStatus"u8);
                writer.WriteStringValue(LastUpdateStatus.Value.ToString());
            }
            if (Optional.IsDefined(InfrastructureEncryptionState))
            {
                writer.WritePropertyName("infrastructureEncryptionState"u8);
                writer.WriteStringValue(InfrastructureEncryptionState.Value.ToString());
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

        BackupResourceEncryptionConfigExtendedProperties IJsonModel<BackupResourceEncryptionConfigExtendedProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceEncryptionConfigExtendedProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupResourceEncryptionConfigExtendedProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupResourceEncryptionConfigExtendedProperties(document.RootElement, options);
        }

        internal static BackupResourceEncryptionConfigExtendedProperties DeserializeBackupResourceEncryptionConfigExtendedProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> userAssignedIdentity = default;
            Optional<bool> useSystemAssignedIdentity = default;
            Optional<BackupEncryptionAtRestType> encryptionAtRestType = default;
            Optional<Uri> keyUri = default;
            Optional<string> subscriptionId = default;
            Optional<LastUpdateStatus> lastUpdateStatus = default;
            Optional<InfrastructureEncryptionState> infrastructureEncryptionState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userAssignedIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userAssignedIdentity = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useSystemAssignedIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useSystemAssignedIdentity = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("encryptionAtRestType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptionAtRestType = new BackupEncryptionAtRestType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdateStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdateStatus = new LastUpdateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("infrastructureEncryptionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    infrastructureEncryptionState = new InfrastructureEncryptionState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackupResourceEncryptionConfigExtendedProperties(Optional.ToNullable(encryptionAtRestType), keyUri.Value, subscriptionId.Value, Optional.ToNullable(lastUpdateStatus), Optional.ToNullable(infrastructureEncryptionState), serializedAdditionalRawData, userAssignedIdentity.Value, Optional.ToNullable(useSystemAssignedIdentity));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(UserAssignedIdentity))
            {
                builder.Append("  userAssignedIdentity:");
                builder.AppendLine($" '{UserAssignedIdentity.ToString()}'");
            }

            if (Optional.IsDefined(UseSystemAssignedIdentity))
            {
                builder.Append("  useSystemAssignedIdentity:");
                var boolValue = UseSystemAssignedIdentity.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(EncryptionAtRestType))
            {
                builder.Append("  encryptionAtRestType:");
                builder.AppendLine($" '{EncryptionAtRestType.Value.ToString()}'");
            }

            if (Optional.IsDefined(KeyUri))
            {
                builder.Append("  keyUri:");
                builder.AppendLine($" '{KeyUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(SubscriptionId))
            {
                builder.Append("  subscriptionId:");
                if (SubscriptionId.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{SubscriptionId}'''");
                }
                else
                {
                    builder.AppendLine($" '{SubscriptionId}'");
                }
            }

            if (Optional.IsDefined(LastUpdateStatus))
            {
                builder.Append("  lastUpdateStatus:");
                builder.AppendLine($" '{LastUpdateStatus.Value.ToString()}'");
            }

            if (Optional.IsDefined(InfrastructureEncryptionState))
            {
                builder.Append("  infrastructureEncryptionState:");
                builder.AppendLine($" '{InfrastructureEncryptionState.Value.ToString()}'");
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

        BinaryData IPersistableModel<BackupResourceEncryptionConfigExtendedProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceEncryptionConfigExtendedProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BackupResourceEncryptionConfigExtendedProperties)} does not support '{options.Format}' format.");
            }
        }

        BackupResourceEncryptionConfigExtendedProperties IPersistableModel<BackupResourceEncryptionConfigExtendedProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupResourceEncryptionConfigExtendedProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupResourceEncryptionConfigExtendedProperties(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(BackupResourceEncryptionConfigExtendedProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupResourceEncryptionConfigExtendedProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
