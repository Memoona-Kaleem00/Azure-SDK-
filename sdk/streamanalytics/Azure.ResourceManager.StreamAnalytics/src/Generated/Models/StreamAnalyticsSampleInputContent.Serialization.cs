// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamAnalyticsSampleInputContent : IUtf8JsonSerializable, IJsonModel<StreamAnalyticsSampleInputContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamAnalyticsSampleInputContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StreamAnalyticsSampleInputContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsSampleInputContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamAnalyticsSampleInputContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Input))
            {
                writer.WritePropertyName("input"u8);
                writer.WriteObjectValue(Input);
            }
            if (Optional.IsDefined(CompatibilityLevel))
            {
                writer.WritePropertyName("compatibilityLevel"u8);
                writer.WriteStringValue(CompatibilityLevel);
            }
            if (Optional.IsDefined(EventsUri))
            {
                writer.WritePropertyName("eventsUri"u8);
                writer.WriteStringValue(EventsUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DataLocalion))
            {
                writer.WritePropertyName("dataLocale"u8);
                writer.WriteStringValue(DataLocalion.Value);
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

        StreamAnalyticsSampleInputContent IJsonModel<StreamAnalyticsSampleInputContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsSampleInputContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamAnalyticsSampleInputContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamAnalyticsSampleInputContent(document.RootElement, options);
        }

        internal static StreamAnalyticsSampleInputContent DeserializeStreamAnalyticsSampleInputContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StreamingJobInputData input = default;
            string compatibilityLevel = default;
            Uri eventsUri = default;
            AzureLocation? dataLocale = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("input"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    input = StreamingJobInputData.DeserializeStreamingJobInputData(property.Value, options);
                    continue;
                }
                if (property.NameEquals("compatibilityLevel"u8))
                {
                    compatibilityLevel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventsUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventsUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataLocale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataLocale = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StreamAnalyticsSampleInputContent(input, compatibilityLevel, eventsUri, dataLocale, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamAnalyticsSampleInputContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsSampleInputContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamAnalyticsSampleInputContent)} does not support '{options.Format}' format.");
            }
        }

        StreamAnalyticsSampleInputContent IPersistableModel<StreamAnalyticsSampleInputContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsSampleInputContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamAnalyticsSampleInputContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamAnalyticsSampleInputContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamAnalyticsSampleInputContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
