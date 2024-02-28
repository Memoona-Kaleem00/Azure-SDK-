// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class CencDrmConfiguration : IUtf8JsonSerializable, IJsonModel<CencDrmConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CencDrmConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CencDrmConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CencDrmConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CencDrmConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (PlayReady != null)
            {
                writer.WritePropertyName("playReady"u8);
                writer.WriteObjectValue(PlayReady);
            }
            if (Widevine != null)
            {
                writer.WritePropertyName("widevine"u8);
                writer.WriteObjectValue(Widevine);
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

        CencDrmConfiguration IJsonModel<CencDrmConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CencDrmConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CencDrmConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCencDrmConfiguration(document.RootElement, options);
        }

        internal static CencDrmConfiguration DeserializeCencDrmConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StreamingPolicyPlayReadyConfiguration playReady = default;
            StreamingPolicyWidevineConfiguration widevine = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("playReady"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    playReady = StreamingPolicyPlayReadyConfiguration.DeserializeStreamingPolicyPlayReadyConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("widevine"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    widevine = StreamingPolicyWidevineConfiguration.DeserializeStreamingPolicyWidevineConfiguration(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CencDrmConfiguration(playReady, widevine, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CencDrmConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CencDrmConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CencDrmConfiguration)} does not support '{options.Format}' format.");
            }
        }

        CencDrmConfiguration IPersistableModel<CencDrmConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CencDrmConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCencDrmConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CencDrmConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CencDrmConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
