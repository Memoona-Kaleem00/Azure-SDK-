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
    public partial class MigrateSchemaSqlServerSqlDBDatabaseInput : IUtf8JsonSerializable, IJsonModel<MigrateSchemaSqlServerSqlDBDatabaseInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateSchemaSqlServerSqlDBDatabaseInput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateSchemaSqlServerSqlDBDatabaseInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSchemaSqlServerSqlDBDatabaseInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSchemaSqlServerSqlDBDatabaseInput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(TargetDatabaseName))
            {
                writer.WritePropertyName("targetDatabaseName"u8);
                writer.WriteStringValue(TargetDatabaseName);
            }
            if (Optional.IsDefined(SchemaSetting))
            {
                writer.WritePropertyName("schemaSetting"u8);
                writer.WriteObjectValue(SchemaSetting);
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

        MigrateSchemaSqlServerSqlDBDatabaseInput IJsonModel<MigrateSchemaSqlServerSqlDBDatabaseInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSchemaSqlServerSqlDBDatabaseInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSchemaSqlServerSqlDBDatabaseInput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSchemaSqlServerSqlDBDatabaseInput(document.RootElement, options);
        }

        internal static MigrateSchemaSqlServerSqlDBDatabaseInput DeserializeMigrateSchemaSqlServerSqlDBDatabaseInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string id = default;
            string targetDatabaseName = default;
            SchemaMigrationSetting schemaSetting = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDatabaseName"u8))
                {
                    targetDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schemaSetting = SchemaMigrationSetting.DeserializeSchemaMigrationSetting(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrateSchemaSqlServerSqlDBDatabaseInput(name, id, targetDatabaseName, schemaSetting, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MigrateSchemaSqlServerSqlDBDatabaseInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSchemaSqlServerSqlDBDatabaseInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateSchemaSqlServerSqlDBDatabaseInput)} does not support '{options.Format}' format.");
            }
        }

        MigrateSchemaSqlServerSqlDBDatabaseInput IPersistableModel<MigrateSchemaSqlServerSqlDBDatabaseInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSchemaSqlServerSqlDBDatabaseInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateSchemaSqlServerSqlDBDatabaseInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateSchemaSqlServerSqlDBDatabaseInput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateSchemaSqlServerSqlDBDatabaseInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
