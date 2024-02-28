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
    public partial class ElasticPoolPerDatabaseMaxPerformanceLevelCapability : IUtf8JsonSerializable, IJsonModel<ElasticPoolPerDatabaseMaxPerformanceLevelCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ElasticPoolPerDatabaseMaxPerformanceLevelCapability>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ElasticPoolPerDatabaseMaxPerformanceLevelCapability>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolPerDatabaseMaxPerformanceLevelCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticPoolPerDatabaseMaxPerformanceLevelCapability)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Limit.HasValue)
            {
                writer.WritePropertyName("limit"u8);
                writer.WriteNumberValue(Limit.Value);
            }
            if (options.Format != "W" && Unit.HasValue)
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit.Value.ToString());
            }
            if (options.Format != "W" && !(SupportedPerDatabaseMinPerformanceLevels is ChangeTrackingList<ElasticPoolPerDatabaseMinPerformanceLevelCapability> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("supportedPerDatabaseMinPerformanceLevels"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedPerDatabaseMinPerformanceLevels)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Reason != null)
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
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

        ElasticPoolPerDatabaseMaxPerformanceLevelCapability IJsonModel<ElasticPoolPerDatabaseMaxPerformanceLevelCapability>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolPerDatabaseMaxPerformanceLevelCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticPoolPerDatabaseMaxPerformanceLevelCapability)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticPoolPerDatabaseMaxPerformanceLevelCapability(document.RootElement, options);
        }

        internal static ElasticPoolPerDatabaseMaxPerformanceLevelCapability DeserializeElasticPoolPerDatabaseMaxPerformanceLevelCapability(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double? limit = default;
            PerformanceLevelUnit? unit = default;
            IReadOnlyList<ElasticPoolPerDatabaseMinPerformanceLevelCapability> supportedPerDatabaseMinPerformanceLevels = default;
            SqlCapabilityStatus? status = default;
            string reason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("limit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limit = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unit = new PerformanceLevelUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("supportedPerDatabaseMinPerformanceLevels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ElasticPoolPerDatabaseMinPerformanceLevelCapability> array = new List<ElasticPoolPerDatabaseMinPerformanceLevelCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ElasticPoolPerDatabaseMinPerformanceLevelCapability.DeserializeElasticPoolPerDatabaseMinPerformanceLevelCapability(item, options));
                    }
                    supportedPerDatabaseMinPerformanceLevels = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToSqlCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ElasticPoolPerDatabaseMaxPerformanceLevelCapability(
                limit,
                unit,
                supportedPerDatabaseMinPerformanceLevels ?? new ChangeTrackingList<ElasticPoolPerDatabaseMinPerformanceLevelCapability>(),
                status,
                reason,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ElasticPoolPerDatabaseMaxPerformanceLevelCapability>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolPerDatabaseMaxPerformanceLevelCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ElasticPoolPerDatabaseMaxPerformanceLevelCapability)} does not support '{options.Format}' format.");
            }
        }

        ElasticPoolPerDatabaseMaxPerformanceLevelCapability IPersistableModel<ElasticPoolPerDatabaseMaxPerformanceLevelCapability>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticPoolPerDatabaseMaxPerformanceLevelCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeElasticPoolPerDatabaseMaxPerformanceLevelCapability(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ElasticPoolPerDatabaseMaxPerformanceLevelCapability)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ElasticPoolPerDatabaseMaxPerformanceLevelCapability>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
