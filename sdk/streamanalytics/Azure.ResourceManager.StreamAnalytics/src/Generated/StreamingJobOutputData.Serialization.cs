// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.StreamAnalytics.Models;

namespace Azure.ResourceManager.StreamAnalytics
{
    public partial class StreamingJobOutputData : IUtf8JsonSerializable, IJsonModel<StreamingJobOutputData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingJobOutputData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamingJobOutputData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobOutputData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobOutputData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && ResourceType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Datasource != null)
            {
                writer.WritePropertyName("datasource"u8);
                writer.WriteObjectValue(Datasource);
            }
            if (TimeFrame.HasValue)
            {
                writer.WritePropertyName("timeWindow"u8);
                writer.WriteStringValue(TimeFrame.Value, "T");
            }
            if (SizeWindow.HasValue)
            {
                writer.WritePropertyName("sizeWindow"u8);
                writer.WriteNumberValue(SizeWindow.Value);
            }
            if (Serialization != null)
            {
                writer.WritePropertyName("serialization"u8);
                writer.WriteObjectValue(Serialization);
            }
            if (options.Format != "W" && Diagnostics != null)
            {
                writer.WritePropertyName("diagnostics"u8);
                writer.WriteObjectValue(Diagnostics);
            }
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (options.Format != "W" && !(LastOutputEventTimestamps is ChangeTrackingList<LastOutputEventTimestamp> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("lastOutputEventTimestamps"u8);
                writer.WriteStartArray();
                foreach (var item in LastOutputEventTimestamps)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (WatermarkSettings != null)
            {
                writer.WritePropertyName("watermarkSettings"u8);
                writer.WriteObjectValue(WatermarkSettings);
            }
            writer.WriteEndObject();
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

        StreamingJobOutputData IJsonModel<StreamingJobOutputData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobOutputData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobOutputData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingJobOutputData(document.RootElement, options);
        }

        internal static StreamingJobOutputData DeserializeStreamingJobOutputData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType? type = default;
            StreamingJobOutputDataSource datasource = default;
            TimeSpan? timeWindow = default;
            float? sizeWindow = default;
            StreamAnalyticsDataSerialization serialization = default;
            StreamingJobDiagnostics diagnostics = default;
            ETag? etag = default;
            IReadOnlyList<LastOutputEventTimestamp> lastOutputEventTimestamps = default;
            StreamingJobOutputWatermarkProperties watermarkSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("datasource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            datasource = StreamingJobOutputDataSource.DeserializeStreamingJobOutputDataSource(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("timeWindow"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeWindow = property0.Value.GetTimeSpan("T");
                            continue;
                        }
                        if (property0.NameEquals("sizeWindow"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sizeWindow = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("serialization"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serialization = StreamAnalyticsDataSerialization.DeserializeStreamAnalyticsDataSerialization(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("diagnostics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diagnostics = StreamingJobDiagnostics.DeserializeStreamingJobDiagnostics(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("etag"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            etag = new ETag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastOutputEventTimestamps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<LastOutputEventTimestamp> array = new List<LastOutputEventTimestamp>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LastOutputEventTimestamp.DeserializeLastOutputEventTimestamp(item, options));
                            }
                            lastOutputEventTimestamps = array;
                            continue;
                        }
                        if (property0.NameEquals("watermarkSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            watermarkSettings = StreamingJobOutputWatermarkProperties.DeserializeStreamingJobOutputWatermarkProperties(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StreamingJobOutputData(
                id,
                name,
                type,
                serializedAdditionalRawData,
                datasource,
                timeWindow,
                sizeWindow,
                serialization,
                diagnostics,
                etag,
                lastOutputEventTimestamps ?? new ChangeTrackingList<LastOutputEventTimestamp>(),
                watermarkSettings);
        }

        BinaryData IPersistableModel<StreamingJobOutputData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobOutputData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamingJobOutputData)} does not support '{options.Format}' format.");
            }
        }

        StreamingJobOutputData IPersistableModel<StreamingJobOutputData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobOutputData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamingJobOutputData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingJobOutputData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingJobOutputData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
