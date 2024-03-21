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
    public partial class SchemaComparisonValidationResult : IUtf8JsonSerializable, IJsonModel<SchemaComparisonValidationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SchemaComparisonValidationResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SchemaComparisonValidationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SchemaComparisonValidationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SchemaComparisonValidationResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SchemaDifferences))
            {
                writer.WritePropertyName("schemaDifferences"u8);
                writer.WriteObjectValue(SchemaDifferences);
            }
            if (Optional.IsDefined(ValidationErrors))
            {
                writer.WritePropertyName("validationErrors"u8);
                writer.WriteObjectValue(ValidationErrors);
            }
            if (Optional.IsCollectionDefined(SourceDatabaseObjectCount))
            {
                writer.WritePropertyName("sourceDatabaseObjectCount"u8);
                writer.WriteStartObject();
                foreach (var item in SourceDatabaseObjectCount)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteNumberValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(TargetDatabaseObjectCount))
            {
                writer.WritePropertyName("targetDatabaseObjectCount"u8);
                writer.WriteStartObject();
                foreach (var item in TargetDatabaseObjectCount)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteNumberValue(item.Value);
                }
                writer.WriteEndObject();
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

        SchemaComparisonValidationResult IJsonModel<SchemaComparisonValidationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SchemaComparisonValidationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SchemaComparisonValidationResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSchemaComparisonValidationResult(document.RootElement, options);
        }

        internal static SchemaComparisonValidationResult DeserializeSchemaComparisonValidationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SchemaComparisonValidationResultType schemaDifferences = default;
            ValidationError validationErrors = default;
            IReadOnlyDictionary<string, long> sourceDatabaseObjectCount = default;
            IReadOnlyDictionary<string, long> targetDatabaseObjectCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schemaDifferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schemaDifferences = SchemaComparisonValidationResultType.DeserializeSchemaComparisonValidationResultType(property.Value, options);
                    continue;
                }
                if (property.NameEquals("validationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationErrors = ValidationError.DeserializeValidationError(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sourceDatabaseObjectCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, long> dictionary = new Dictionary<string, long>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetInt64());
                    }
                    sourceDatabaseObjectCount = dictionary;
                    continue;
                }
                if (property.NameEquals("targetDatabaseObjectCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, long> dictionary = new Dictionary<string, long>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetInt64());
                    }
                    targetDatabaseObjectCount = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SchemaComparisonValidationResult(schemaDifferences, validationErrors, sourceDatabaseObjectCount ?? new ChangeTrackingDictionary<string, long>(), targetDatabaseObjectCount ?? new ChangeTrackingDictionary<string, long>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SchemaComparisonValidationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SchemaComparisonValidationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SchemaComparisonValidationResult)} does not support '{options.Format}' format.");
            }
        }

        SchemaComparisonValidationResult IPersistableModel<SchemaComparisonValidationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SchemaComparisonValidationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSchemaComparisonValidationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SchemaComparisonValidationResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SchemaComparisonValidationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
