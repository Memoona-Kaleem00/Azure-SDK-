// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorTimeSeriesBaseline : IUtf8JsonSerializable, IJsonModel<MonitorTimeSeriesBaseline>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorTimeSeriesBaseline>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitorTimeSeriesBaseline>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorTimeSeriesBaseline>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorTimeSeriesBaseline)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("aggregation"u8);
            writer.WriteStringValue(Aggregation);
            if (!(Dimensions is ChangeTrackingList<MonitorMetricSingleDimension> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("dimensions"u8);
                writer.WriteStartArray();
                foreach (var item in Dimensions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("timestamps"u8);
            writer.WriteStartArray();
            foreach (var item in Timestamps)
            {
                writer.WriteStringValue(item, "O");
            }
            writer.WriteEndArray();
            writer.WritePropertyName("data"u8);
            writer.WriteStartArray();
            foreach (var item in Data)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (!(MetadataValues is ChangeTrackingList<MonitorBaselineMetadata> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("metadataValues"u8);
                writer.WriteStartArray();
                foreach (var item in MetadataValues)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        MonitorTimeSeriesBaseline IJsonModel<MonitorTimeSeriesBaseline>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorTimeSeriesBaseline>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorTimeSeriesBaseline)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorTimeSeriesBaseline(document.RootElement, options);
        }

        internal static MonitorTimeSeriesBaseline DeserializeMonitorTimeSeriesBaseline(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string aggregation = default;
            IReadOnlyList<MonitorMetricSingleDimension> dimensions = default;
            IReadOnlyList<DateTimeOffset> timestamps = default;
            IReadOnlyList<MonitorSingleBaseline> data = default;
            IReadOnlyList<MonitorBaselineMetadata> metadataValues = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aggregation"u8))
                {
                    aggregation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorMetricSingleDimension> array = new List<MonitorMetricSingleDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorMetricSingleDimension.DeserializeMonitorMetricSingleDimension(item, options));
                    }
                    dimensions = array;
                    continue;
                }
                if (property.NameEquals("timestamps"u8))
                {
                    List<DateTimeOffset> array = new List<DateTimeOffset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDateTimeOffset("O"));
                    }
                    timestamps = array;
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    List<MonitorSingleBaseline> array = new List<MonitorSingleBaseline>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorSingleBaseline.DeserializeMonitorSingleBaseline(item, options));
                    }
                    data = array;
                    continue;
                }
                if (property.NameEquals("metadataValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitorBaselineMetadata> array = new List<MonitorBaselineMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitorBaselineMetadata.DeserializeMonitorBaselineMetadata(item, options));
                    }
                    metadataValues = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitorTimeSeriesBaseline(
                aggregation,
                dimensions ?? new ChangeTrackingList<MonitorMetricSingleDimension>(),
                timestamps,
                data,
                metadataValues ?? new ChangeTrackingList<MonitorBaselineMetadata>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitorTimeSeriesBaseline>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorTimeSeriesBaseline>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorTimeSeriesBaseline)} does not support '{options.Format}' format.");
            }
        }

        MonitorTimeSeriesBaseline IPersistableModel<MonitorTimeSeriesBaseline>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorTimeSeriesBaseline>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorTimeSeriesBaseline(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorTimeSeriesBaseline)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorTimeSeriesBaseline>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
