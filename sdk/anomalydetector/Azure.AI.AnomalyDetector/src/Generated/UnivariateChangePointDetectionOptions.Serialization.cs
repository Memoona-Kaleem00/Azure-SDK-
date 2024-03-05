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

namespace Azure.AI.AnomalyDetector
{
    public partial class UnivariateChangePointDetectionOptions : IUtf8JsonSerializable, IJsonModel<UnivariateChangePointDetectionOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UnivariateChangePointDetectionOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UnivariateChangePointDetectionOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UnivariateChangePointDetectionOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UnivariateChangePointDetectionOptions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("series"u8);
            writer.WriteStartArray();
            foreach (var item in Series)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("granularity"u8);
            writer.WriteStringValue(Granularity.ToString());
            if (Optional.IsDefined(CustomInterval))
            {
                writer.WritePropertyName("customInterval"u8);
                writer.WriteNumberValue(CustomInterval.Value);
            }
            if (Optional.IsDefined(Period))
            {
                writer.WritePropertyName("period"u8);
                writer.WriteNumberValue(Period.Value);
            }
            if (Optional.IsDefined(StableTrendWindow))
            {
                writer.WritePropertyName("stableTrendWindow"u8);
                writer.WriteNumberValue(StableTrendWindow.Value);
            }
            if (Optional.IsDefined(Threshold))
            {
                writer.WritePropertyName("threshold"u8);
                writer.WriteNumberValue(Threshold.Value);
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

        UnivariateChangePointDetectionOptions IJsonModel<UnivariateChangePointDetectionOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UnivariateChangePointDetectionOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UnivariateChangePointDetectionOptions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnivariateChangePointDetectionOptions(document.RootElement, options);
        }

        internal static UnivariateChangePointDetectionOptions DeserializeUnivariateChangePointDetectionOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<TimeSeriesPoint> series = default;
            TimeGranularity granularity = default;
            int? customInterval = default;
            int? period = default;
            int? stableTrendWindow = default;
            float? threshold = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("series"u8))
                {
                    List<TimeSeriesPoint> array = new List<TimeSeriesPoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimeSeriesPoint.DeserializeTimeSeriesPoint(item, options));
                    }
                    series = array;
                    continue;
                }
                if (property.NameEquals("granularity"u8))
                {
                    granularity = new TimeGranularity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customInterval = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("period"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    period = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("stableTrendWindow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stableTrendWindow = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("threshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    threshold = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnivariateChangePointDetectionOptions(
                series,
                granularity,
                customInterval,
                period,
                stableTrendWindow,
                threshold,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UnivariateChangePointDetectionOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UnivariateChangePointDetectionOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UnivariateChangePointDetectionOptions)} does not support '{options.Format}' format.");
            }
        }

        UnivariateChangePointDetectionOptions IPersistableModel<UnivariateChangePointDetectionOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UnivariateChangePointDetectionOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUnivariateChangePointDetectionOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UnivariateChangePointDetectionOptions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UnivariateChangePointDetectionOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static UnivariateChangePointDetectionOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUnivariateChangePointDetectionOptions(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
