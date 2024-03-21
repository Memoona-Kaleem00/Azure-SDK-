// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class SqlBackupFileInfo : IUtf8JsonSerializable, IJsonModel<SqlBackupFileInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlBackupFileInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlBackupFileInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlBackupFileInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlBackupFileInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("fileName"u8);
                writer.WriteStringValue(FileName);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (options.Format != "W" && Optional.IsDefined(TotalSize))
            {
                writer.WritePropertyName("totalSize"u8);
                writer.WriteNumberValue(TotalSize.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DataRead))
            {
                writer.WritePropertyName("dataRead"u8);
                writer.WriteNumberValue(DataRead.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DataWritten))
            {
                writer.WritePropertyName("dataWritten"u8);
                writer.WriteNumberValue(DataWritten.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CopyThroughput))
            {
                writer.WritePropertyName("copyThroughput"u8);
                writer.WriteNumberValue(CopyThroughput.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CopyDuration))
            {
                writer.WritePropertyName("copyDuration"u8);
                writer.WriteNumberValue(CopyDuration.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(FamilySequenceNumber))
            {
                writer.WritePropertyName("familySequenceNumber"u8);
                writer.WriteNumberValue(FamilySequenceNumber.Value);
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

        SqlBackupFileInfo IJsonModel<SqlBackupFileInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlBackupFileInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlBackupFileInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlBackupFileInfo(document.RootElement, options);
        }

        internal static SqlBackupFileInfo DeserializeSqlBackupFileInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string fileName = default;
            string status = default;
            long? totalSize = default;
            long? dataRead = default;
            long? dataWritten = default;
            double? copyThroughput = default;
            int? copyDuration = default;
            int? familySequenceNumber = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileName"u8))
                {
                    fileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("totalSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("dataRead"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataRead = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("dataWritten"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataWritten = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("copyThroughput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copyThroughput = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("copyDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copyDuration = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("familySequenceNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    familySequenceNumber = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlBackupFileInfo(
                fileName,
                status,
                totalSize,
                dataRead,
                dataWritten,
                copyThroughput,
                copyDuration,
                familySequenceNumber,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlBackupFileInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlBackupFileInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlBackupFileInfo)} does not support '{options.Format}' format.");
            }
        }

        SqlBackupFileInfo IPersistableModel<SqlBackupFileInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlBackupFileInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlBackupFileInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlBackupFileInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlBackupFileInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
