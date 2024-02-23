// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownPredictionDriftMetricThresholdBase))]
    public partial class PredictionDriftMetricThresholdBase : IUtf8JsonSerializable, IJsonModel<PredictionDriftMetricThresholdBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PredictionDriftMetricThresholdBase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PredictionDriftMetricThresholdBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionDriftMetricThresholdBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PredictionDriftMetricThresholdBase)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("dataType"u8);
            writer.WriteStringValue(DataType.ToString());
            if (Threshold != null)
            {
                if (Threshold != null)
                {
                    writer.WritePropertyName("threshold"u8);
                    writer.WriteObjectValue(Threshold);
                }
                else
                {
                    writer.WriteNull("threshold");
                }
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

        PredictionDriftMetricThresholdBase IJsonModel<PredictionDriftMetricThresholdBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionDriftMetricThresholdBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PredictionDriftMetricThresholdBase)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePredictionDriftMetricThresholdBase(document.RootElement, options);
        }

        internal static PredictionDriftMetricThresholdBase DeserializePredictionDriftMetricThresholdBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("dataType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Categorical": return CategoricalPredictionDriftMetricThreshold.DeserializeCategoricalPredictionDriftMetricThreshold(element, options);
                    case "Numerical": return NumericalPredictionDriftMetricThreshold.DeserializeNumericalPredictionDriftMetricThreshold(element, options);
                }
            }
            return UnknownPredictionDriftMetricThresholdBase.DeserializeUnknownPredictionDriftMetricThresholdBase(element, options);
        }

        BinaryData IPersistableModel<PredictionDriftMetricThresholdBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionDriftMetricThresholdBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PredictionDriftMetricThresholdBase)} does not support '{options.Format}' format.");
            }
        }

        PredictionDriftMetricThresholdBase IPersistableModel<PredictionDriftMetricThresholdBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PredictionDriftMetricThresholdBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePredictionDriftMetricThresholdBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PredictionDriftMetricThresholdBase)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PredictionDriftMetricThresholdBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
