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
    public partial class NlpVerticalLimitSettings : IUtf8JsonSerializable, IJsonModel<NlpVerticalLimitSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NlpVerticalLimitSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NlpVerticalLimitSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NlpVerticalLimitSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NlpVerticalLimitSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout"u8);
                writer.WriteStringValue(Timeout.Value, "P");
            }
            if (Optional.IsDefined(MaxTrials))
            {
                writer.WritePropertyName("maxTrials"u8);
                writer.WriteNumberValue(MaxTrials.Value);
            }
            if (Optional.IsDefined(MaxConcurrentTrials))
            {
                writer.WritePropertyName("maxConcurrentTrials"u8);
                writer.WriteNumberValue(MaxConcurrentTrials.Value);
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

        NlpVerticalLimitSettings IJsonModel<NlpVerticalLimitSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NlpVerticalLimitSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NlpVerticalLimitSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNlpVerticalLimitSettings(document.RootElement, options);
        }

        internal static NlpVerticalLimitSettings DeserializeNlpVerticalLimitSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSpan? timeout = default;
            int? maxTrials = default;
            int? maxConcurrentTrials = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("maxTrials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxTrials = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxConcurrentTrials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentTrials = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NlpVerticalLimitSettings(timeout, maxTrials, maxConcurrentTrials, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NlpVerticalLimitSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NlpVerticalLimitSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NlpVerticalLimitSettings)} does not support writing '{options.Format}' format.");
            }
        }

        NlpVerticalLimitSettings IPersistableModel<NlpVerticalLimitSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NlpVerticalLimitSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNlpVerticalLimitSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NlpVerticalLimitSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NlpVerticalLimitSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
