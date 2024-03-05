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
    public partial class UnivariateLastDetectionResult : IUtf8JsonSerializable, IJsonModel<UnivariateLastDetectionResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UnivariateLastDetectionResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UnivariateLastDetectionResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UnivariateLastDetectionResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UnivariateLastDetectionResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("period"u8);
            writer.WriteNumberValue(Period);
            writer.WritePropertyName("suggestedWindow"u8);
            writer.WriteNumberValue(SuggestedWindow);
            writer.WritePropertyName("expectedValue"u8);
            writer.WriteNumberValue(ExpectedValue);
            writer.WritePropertyName("upperMargin"u8);
            writer.WriteNumberValue(UpperMargin);
            writer.WritePropertyName("lowerMargin"u8);
            writer.WriteNumberValue(LowerMargin);
            writer.WritePropertyName("isAnomaly"u8);
            writer.WriteBooleanValue(IsAnomaly);
            writer.WritePropertyName("isNegativeAnomaly"u8);
            writer.WriteBooleanValue(IsNegativeAnomaly);
            writer.WritePropertyName("isPositiveAnomaly"u8);
            writer.WriteBooleanValue(IsPositiveAnomaly);
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteNumberValue(Severity.Value);
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

        UnivariateLastDetectionResult IJsonModel<UnivariateLastDetectionResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UnivariateLastDetectionResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UnivariateLastDetectionResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnivariateLastDetectionResult(document.RootElement, options);
        }

        internal static UnivariateLastDetectionResult DeserializeUnivariateLastDetectionResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int period = default;
            int suggestedWindow = default;
            float expectedValue = default;
            float upperMargin = default;
            float lowerMargin = default;
            bool isAnomaly = default;
            bool isNegativeAnomaly = default;
            bool isPositiveAnomaly = default;
            float? severity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("period"u8))
                {
                    period = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("suggestedWindow"u8))
                {
                    suggestedWindow = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("expectedValue"u8))
                {
                    expectedValue = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("upperMargin"u8))
                {
                    upperMargin = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("lowerMargin"u8))
                {
                    lowerMargin = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("isAnomaly"u8))
                {
                    isAnomaly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isNegativeAnomaly"u8))
                {
                    isNegativeAnomaly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isPositiveAnomaly"u8))
                {
                    isPositiveAnomaly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severity = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnivariateLastDetectionResult(
                period,
                suggestedWindow,
                expectedValue,
                upperMargin,
                lowerMargin,
                isAnomaly,
                isNegativeAnomaly,
                isPositiveAnomaly,
                severity,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UnivariateLastDetectionResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UnivariateLastDetectionResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UnivariateLastDetectionResult)} does not support '{options.Format}' format.");
            }
        }

        UnivariateLastDetectionResult IPersistableModel<UnivariateLastDetectionResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UnivariateLastDetectionResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUnivariateLastDetectionResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UnivariateLastDetectionResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UnivariateLastDetectionResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static UnivariateLastDetectionResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUnivariateLastDetectionResult(document.RootElement);
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
