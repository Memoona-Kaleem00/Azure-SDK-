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
    [PersistableModelProxy(typeof(UnknownEarlyTerminationPolicy))]
    public partial class MachineLearningEarlyTerminationPolicy : IUtf8JsonSerializable, IJsonModel<MachineLearningEarlyTerminationPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningEarlyTerminationPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningEarlyTerminationPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEarlyTerminationPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningEarlyTerminationPolicy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("policyType"u8);
            writer.WriteStringValue(PolicyType.ToString());
            if (Optional.IsDefined(EvaluationInterval))
            {
                writer.WritePropertyName("evaluationInterval"u8);
                writer.WriteNumberValue(EvaluationInterval.Value);
            }
            if (Optional.IsDefined(DelayEvaluation))
            {
                writer.WritePropertyName("delayEvaluation"u8);
                writer.WriteNumberValue(DelayEvaluation.Value);
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

        MachineLearningEarlyTerminationPolicy IJsonModel<MachineLearningEarlyTerminationPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEarlyTerminationPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningEarlyTerminationPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningEarlyTerminationPolicy(document.RootElement, options);
        }

        internal static MachineLearningEarlyTerminationPolicy DeserializeMachineLearningEarlyTerminationPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("policyType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Bandit": return BanditPolicy.DeserializeBanditPolicy(element, options);
                    case "MedianStopping": return MedianStoppingPolicy.DeserializeMedianStoppingPolicy(element, options);
                    case "TruncationSelection": return TruncationSelectionPolicy.DeserializeTruncationSelectionPolicy(element, options);
                }
            }
            return UnknownEarlyTerminationPolicy.DeserializeUnknownEarlyTerminationPolicy(element, options);
        }

        BinaryData IPersistableModel<MachineLearningEarlyTerminationPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEarlyTerminationPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningEarlyTerminationPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningEarlyTerminationPolicy IPersistableModel<MachineLearningEarlyTerminationPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningEarlyTerminationPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningEarlyTerminationPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningEarlyTerminationPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningEarlyTerminationPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
