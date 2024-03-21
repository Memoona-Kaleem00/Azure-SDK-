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
    public partial class SqlInstanceSettings : IUtf8JsonSerializable, IJsonModel<SqlInstanceSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlInstanceSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlInstanceSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlInstanceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlInstanceSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Collation))
            {
                writer.WritePropertyName("collation"u8);
                writer.WriteStringValue(Collation);
            }
            if (Optional.IsDefined(MaxDop))
            {
                writer.WritePropertyName("maxDop"u8);
                writer.WriteNumberValue(MaxDop.Value);
            }
            if (Optional.IsDefined(IsOptimizeForAdHocWorkloadsEnabled))
            {
                writer.WritePropertyName("isOptimizeForAdHocWorkloadsEnabled"u8);
                writer.WriteBooleanValue(IsOptimizeForAdHocWorkloadsEnabled.Value);
            }
            if (Optional.IsDefined(MinServerMemoryInMB))
            {
                writer.WritePropertyName("minServerMemoryMB"u8);
                writer.WriteNumberValue(MinServerMemoryInMB.Value);
            }
            if (Optional.IsDefined(MaxServerMemoryInMB))
            {
                writer.WritePropertyName("maxServerMemoryMB"u8);
                writer.WriteNumberValue(MaxServerMemoryInMB.Value);
            }
            if (Optional.IsDefined(IsLpimEnabled))
            {
                writer.WritePropertyName("isLpimEnabled"u8);
                writer.WriteBooleanValue(IsLpimEnabled.Value);
            }
            if (Optional.IsDefined(IsIfiEnabled))
            {
                writer.WritePropertyName("isIfiEnabled"u8);
                writer.WriteBooleanValue(IsIfiEnabled.Value);
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

        SqlInstanceSettings IJsonModel<SqlInstanceSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlInstanceSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlInstanceSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlInstanceSettings(document.RootElement, options);
        }

        internal static SqlInstanceSettings DeserializeSqlInstanceSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string collation = default;
            int? maxDop = default;
            bool? isOptimizeForAdHocWorkloadsEnabled = default;
            int? minServerMemoryMB = default;
            int? maxServerMemoryMB = default;
            bool? isLpimEnabled = default;
            bool? isIfiEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("collation"u8))
                {
                    collation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxDop"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDop = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isOptimizeForAdHocWorkloadsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOptimizeForAdHocWorkloadsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("minServerMemoryMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minServerMemoryMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxServerMemoryMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxServerMemoryMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isLpimEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isLpimEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isIfiEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isIfiEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlInstanceSettings(
                collation,
                maxDop,
                isOptimizeForAdHocWorkloadsEnabled,
                minServerMemoryMB,
                maxServerMemoryMB,
                isLpimEnabled,
                isIfiEnabled,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlInstanceSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlInstanceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlInstanceSettings)} does not support '{options.Format}' format.");
            }
        }

        SqlInstanceSettings IPersistableModel<SqlInstanceSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlInstanceSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlInstanceSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlInstanceSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlInstanceSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
