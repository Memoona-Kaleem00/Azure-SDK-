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
using Azure.ResourceManager;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CassandraClusterBackupResourceInfo : IUtf8JsonSerializable, IJsonModel<CassandraClusterBackupResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CassandraClusterBackupResourceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CassandraClusterBackupResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterBackupResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraClusterBackupResourceInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BackupId))
            {
                writer.WritePropertyName("backupId"u8);
                writer.WriteStringValue(BackupId);
            }
            if (Optional.IsDefined(BackupState))
            {
                writer.WritePropertyName("backupState"u8);
                writer.WriteStringValue(BackupState.Value.ToString());
            }
            if (Optional.IsDefined(BackupStartTimestamp))
            {
                writer.WritePropertyName("backupStartTimestamp"u8);
                writer.WriteStringValue(BackupStartTimestamp.Value, "O");
            }
            if (Optional.IsDefined(BackupStopTimestamp))
            {
                writer.WritePropertyName("backupStopTimestamp"u8);
                writer.WriteStringValue(BackupStopTimestamp.Value, "O");
            }
            if (Optional.IsDefined(BackupExpiryTimestamp))
            {
                writer.WritePropertyName("backupExpiryTimestamp"u8);
                writer.WriteStringValue(BackupExpiryTimestamp.Value, "O");
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

        CassandraClusterBackupResourceInfo IJsonModel<CassandraClusterBackupResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterBackupResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraClusterBackupResourceInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCassandraClusterBackupResourceInfo(document.RootElement, options);
        }

        internal static CassandraClusterBackupResourceInfo DeserializeCassandraClusterBackupResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> backupId = default;
            Optional<CassandraClusterBackupState> backupState = default;
            Optional<DateTimeOffset> backupStartTimestamp = default;
            Optional<DateTimeOffset> backupStopTimestamp = default;
            Optional<DateTimeOffset> backupExpiryTimestamp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupId"u8))
                {
                    backupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupState = new CassandraClusterBackupState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backupStartTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupStartTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("backupStopTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupStopTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("backupExpiryTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupExpiryTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CassandraClusterBackupResourceInfo(backupId.Value, Optional.ToNullable(backupState), Optional.ToNullable(backupStartTimestamp), Optional.ToNullable(backupStopTimestamp), Optional.ToNullable(backupExpiryTimestamp), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.ParameterOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BackupId), out propertyOverride);
            if (Optional.IsDefined(BackupId) || hasPropertyOverride)
            {
                builder.Append("  backupId: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (BackupId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{BackupId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{BackupId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BackupState), out propertyOverride);
            if (Optional.IsDefined(BackupState) || hasPropertyOverride)
            {
                builder.Append("  backupState: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{BackupState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BackupStartTimestamp), out propertyOverride);
            if (Optional.IsDefined(BackupStartTimestamp) || hasPropertyOverride)
            {
                builder.Append("  backupStartTimestamp: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    var formattedDateTimeString = TypeFormatters.ToString(BackupStartTimestamp.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BackupStopTimestamp), out propertyOverride);
            if (Optional.IsDefined(BackupStopTimestamp) || hasPropertyOverride)
            {
                builder.Append("  backupStopTimestamp: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    var formattedDateTimeString = TypeFormatters.ToString(BackupStopTimestamp.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BackupExpiryTimestamp), out propertyOverride);
            if (Optional.IsDefined(BackupExpiryTimestamp) || hasPropertyOverride)
            {
                builder.Append("  backupExpiryTimestamp: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    var formattedDateTimeString = TypeFormatters.ToString(BackupExpiryTimestamp.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine, string formattedPropertyName)
        {
            string indent = new string(' ', spaces);
            int emptyObjectLength = 2 + spaces + Environment.NewLine.Length + Environment.NewLine.Length;
            int length = stringBuilder.Length;
            bool inMultilineString = false;

            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
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
                    stringBuilder.AppendLine($"{line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
            if (stringBuilder.Length == length + emptyObjectLength)
            {
                stringBuilder.Length = stringBuilder.Length - emptyObjectLength - formattedPropertyName.Length;
            }
        }

        BinaryData IPersistableModel<CassandraClusterBackupResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterBackupResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CassandraClusterBackupResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        CassandraClusterBackupResourceInfo IPersistableModel<CassandraClusterBackupResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterBackupResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCassandraClusterBackupResourceInfo(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(CassandraClusterBackupResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CassandraClusterBackupResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
