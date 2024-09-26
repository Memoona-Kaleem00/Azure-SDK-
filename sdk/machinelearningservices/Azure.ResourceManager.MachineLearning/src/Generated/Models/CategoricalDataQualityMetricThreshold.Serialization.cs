// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class CategoricalDataQualityMetricThreshold : IUtf8JsonSerializable, IJsonModel<CategoricalDataQualityMetricThreshold>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CategoricalDataQualityMetricThreshold>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CategoricalDataQualityMetricThreshold>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CategoricalDataQualityMetricThreshold>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CategoricalDataQualityMetricThreshold)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("metric"u8);
            writer.WriteStringValue(Metric.ToString());
        }

        CategoricalDataQualityMetricThreshold IJsonModel<CategoricalDataQualityMetricThreshold>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CategoricalDataQualityMetricThreshold>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CategoricalDataQualityMetricThreshold)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCategoricalDataQualityMetricThreshold(document.RootElement, options);
        }

        internal static CategoricalDataQualityMetricThreshold DeserializeCategoricalDataQualityMetricThreshold(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CategoricalDataQualityMetric metric = default;
            MonitoringFeatureDataType dataType = default;
            MonitoringThreshold threshold = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metric"u8))
                {
                    metric = new CategoricalDataQualityMetric(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataType"u8))
                {
                    dataType = new MonitoringFeatureDataType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("threshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        threshold = null;
                        continue;
                    }
                    threshold = MonitoringThreshold.DeserializeMonitoringThreshold(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CategoricalDataQualityMetricThreshold(dataType, threshold, serializedAdditionalRawData, metric);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Metric), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  metric: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  metric: ");
                builder.AppendLine($"'{Metric.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DataType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dataType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  dataType: ");
                builder.AppendLine($"'{DataType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("ThresholdValue", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  threshold: ");
                builder.AppendLine("{");
                builder.Append("    value: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(Threshold))
                {
                    builder.Append("  threshold: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Threshold, options, 2, false, "  threshold: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CategoricalDataQualityMetricThreshold>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CategoricalDataQualityMetricThreshold>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CategoricalDataQualityMetricThreshold)} does not support writing '{options.Format}' format.");
            }
        }

        CategoricalDataQualityMetricThreshold IPersistableModel<CategoricalDataQualityMetricThreshold>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CategoricalDataQualityMetricThreshold>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCategoricalDataQualityMetricThreshold(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CategoricalDataQualityMetricThreshold)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CategoricalDataQualityMetricThreshold>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
