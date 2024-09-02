// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class TensorFlowDistributionConfiguration : IUtf8JsonSerializable, IJsonModel<TensorFlowDistributionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TensorFlowDistributionConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TensorFlowDistributionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TensorFlowDistributionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TensorFlowDistributionConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(WorkerCount))
            {
                if (WorkerCount != null)
                {
                    writer.WritePropertyName("workerCount"u8);
                    writer.WriteNumberValue(WorkerCount.Value);
                }
                else
                {
                    writer.WriteNull("workerCount");
                }
            }
            if (Optional.IsDefined(ParameterServerCount))
            {
                writer.WritePropertyName("parameterServerCount"u8);
                writer.WriteNumberValue(ParameterServerCount.Value);
            }
            writer.WritePropertyName("distributionType"u8);
            writer.WriteStringValue(DistributionType.ToString());
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

        TensorFlowDistributionConfiguration IJsonModel<TensorFlowDistributionConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TensorFlowDistributionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TensorFlowDistributionConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTensorFlowDistributionConfiguration(document.RootElement, options);
        }

        internal static TensorFlowDistributionConfiguration DeserializeTensorFlowDistributionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? workerCount = default;
            int? parameterServerCount = default;
            DistributionType distributionType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workerCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        workerCount = null;
                        continue;
                    }
                    workerCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("parameterServerCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameterServerCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("distributionType"u8))
                {
                    distributionType = new DistributionType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TensorFlowDistributionConfiguration(distributionType, serializedAdditionalRawData, workerCount, parameterServerCount);
        }

        BinaryData IPersistableModel<TensorFlowDistributionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TensorFlowDistributionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TensorFlowDistributionConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        TensorFlowDistributionConfiguration IPersistableModel<TensorFlowDistributionConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TensorFlowDistributionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTensorFlowDistributionConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TensorFlowDistributionConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TensorFlowDistributionConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
