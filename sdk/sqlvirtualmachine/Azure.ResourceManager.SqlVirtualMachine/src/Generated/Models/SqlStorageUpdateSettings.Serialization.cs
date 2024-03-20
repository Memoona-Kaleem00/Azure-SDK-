// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class SqlStorageUpdateSettings : IUtf8JsonSerializable, IJsonModel<SqlStorageUpdateSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlStorageUpdateSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlStorageUpdateSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlStorageUpdateSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlStorageUpdateSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DiskCount))
            {
                writer.WritePropertyName("diskCount"u8);
                writer.WriteNumberValue(DiskCount.Value);
            }
            if (Optional.IsDefined(StartingDeviceId))
            {
                writer.WritePropertyName("startingDeviceId"u8);
                writer.WriteNumberValue(StartingDeviceId.Value);
            }
            if (Optional.IsDefined(DiskConfigurationType))
            {
                writer.WritePropertyName("diskConfigurationType"u8);
                writer.WriteStringValue(DiskConfigurationType.Value.ToString());
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

        SqlStorageUpdateSettings IJsonModel<SqlStorageUpdateSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlStorageUpdateSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlStorageUpdateSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlStorageUpdateSettings(document.RootElement, options);
        }

        internal static SqlStorageUpdateSettings DeserializeSqlStorageUpdateSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? diskCount = default;
            int? startingDeviceId = default;
            SqlVmDiskConfigurationType? diskConfigurationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("startingDeviceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startingDeviceId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("diskConfigurationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskConfigurationType = new SqlVmDiskConfigurationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlStorageUpdateSettings(diskCount, startingDeviceId, diskConfigurationType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlStorageUpdateSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlStorageUpdateSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlStorageUpdateSettings)} does not support '{options.Format}' format.");
            }
        }

        SqlStorageUpdateSettings IPersistableModel<SqlStorageUpdateSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlStorageUpdateSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlStorageUpdateSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlStorageUpdateSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlStorageUpdateSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
