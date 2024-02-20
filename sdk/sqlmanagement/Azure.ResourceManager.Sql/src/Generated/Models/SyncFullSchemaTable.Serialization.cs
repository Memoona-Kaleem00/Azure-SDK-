// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SyncFullSchemaTable : IUtf8JsonSerializable, IJsonModel<SyncFullSchemaTable>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SyncFullSchemaTable>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SyncFullSchemaTable>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncFullSchemaTable>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncFullSchemaTable)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(Columns))
            {
                writer.WritePropertyName("columns"u8);
                writer.WriteStartArray();
                foreach (var item in Columns)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorId))
            {
                writer.WritePropertyName("errorId"u8);
                writer.WriteStringValue(ErrorId);
            }
            if (options.Format != "W" && Optional.IsDefined(HasError))
            {
                writer.WritePropertyName("hasError"u8);
                writer.WriteBooleanValue(HasError.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(QuotedName))
            {
                writer.WritePropertyName("quotedName"u8);
                writer.WriteStringValue(QuotedName);
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

        SyncFullSchemaTable IJsonModel<SyncFullSchemaTable>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncFullSchemaTable>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncFullSchemaTable)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSyncFullSchemaTable(document.RootElement, options);
        }

        internal static SyncFullSchemaTable DeserializeSyncFullSchemaTable(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SyncFullSchemaTableColumn>> columns = default;
            Optional<string> errorId = default;
            Optional<bool> hasError = default;
            Optional<string> name = default;
            Optional<string> quotedName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("columns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SyncFullSchemaTableColumn> array = new List<SyncFullSchemaTableColumn>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyncFullSchemaTableColumn.DeserializeSyncFullSchemaTableColumn(item, options));
                    }
                    columns = array;
                    continue;
                }
                if (property.NameEquals("errorId"u8))
                {
                    errorId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hasError"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasError = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quotedName"u8))
                {
                    quotedName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SyncFullSchemaTable(Optional.ToList(columns), errorId.Value, Optional.ToNullable(hasError), name.Value, quotedName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SyncFullSchemaTable>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncFullSchemaTable>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SyncFullSchemaTable)} does not support '{options.Format}' format.");
            }
        }

        SyncFullSchemaTable IPersistableModel<SyncFullSchemaTable>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncFullSchemaTable>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSyncFullSchemaTable(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SyncFullSchemaTable)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SyncFullSchemaTable>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
