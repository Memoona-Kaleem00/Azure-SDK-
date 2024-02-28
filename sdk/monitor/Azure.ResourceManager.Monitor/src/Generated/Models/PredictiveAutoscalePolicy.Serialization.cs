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
    public partial class PredictiveAutoscalePolicy : IUtf8JsonSerializable, IJsonModel<PredictiveAutoscalePolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PredictiveAutoscalePolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PredictiveAutoscalePolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictiveAutoscalePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PredictiveAutoscalePolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("scaleMode"u8);
            writer.WriteStringValue(ScaleMode.ToSerialString());
            if (ScaleLookAheadTime.HasValue)
            {
                writer.WritePropertyName("scaleLookAheadTime"u8);
                writer.WriteStringValue(ScaleLookAheadTime.Value, "P");
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

        PredictiveAutoscalePolicy IJsonModel<PredictiveAutoscalePolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictiveAutoscalePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PredictiveAutoscalePolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePredictiveAutoscalePolicy(document.RootElement, options);
        }

        internal static PredictiveAutoscalePolicy DeserializePredictiveAutoscalePolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PredictiveAutoscalePolicyScaleMode scaleMode = default;
            TimeSpan? scaleLookAheadTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scaleMode"u8))
                {
                    scaleMode = property.Value.GetString().ToPredictiveAutoscalePolicyScaleMode();
                    continue;
                }
                if (property.NameEquals("scaleLookAheadTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scaleLookAheadTime = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PredictiveAutoscalePolicy(scaleMode, scaleLookAheadTime, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PredictiveAutoscalePolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictiveAutoscalePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PredictiveAutoscalePolicy)} does not support '{options.Format}' format.");
            }
        }

        PredictiveAutoscalePolicy IPersistableModel<PredictiveAutoscalePolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictiveAutoscalePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePredictiveAutoscalePolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PredictiveAutoscalePolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PredictiveAutoscalePolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
