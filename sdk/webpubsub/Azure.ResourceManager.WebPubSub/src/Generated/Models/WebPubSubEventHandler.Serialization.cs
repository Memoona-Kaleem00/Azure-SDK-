// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    public partial class WebPubSubEventHandler : IUtf8JsonSerializable, IJsonModel<WebPubSubEventHandler>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebPubSubEventHandler>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebPubSubEventHandler>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebPubSubEventHandler>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebPubSubEventHandler)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("urlTemplate"u8);
            writer.WriteStringValue(UrlTemplate);
            if (Optional.IsDefined(UserEventPattern))
            {
                writer.WritePropertyName("userEventPattern"u8);
                writer.WriteStringValue(UserEventPattern);
            }
            if (Optional.IsCollectionDefined(SystemEvents))
            {
                writer.WritePropertyName("systemEvents"u8);
                writer.WriteStartArray();
                foreach (var item in SystemEvents)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Auth))
            {
                writer.WritePropertyName("auth"u8);
                writer.WriteObjectValue<UpstreamAuthSettings>(Auth, options);
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

        WebPubSubEventHandler IJsonModel<WebPubSubEventHandler>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebPubSubEventHandler>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebPubSubEventHandler)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebPubSubEventHandler(document.RootElement, options);
        }

        internal static WebPubSubEventHandler DeserializeWebPubSubEventHandler(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string urlTemplate = default;
            string userEventPattern = default;
            IList<string> systemEvents = default;
            UpstreamAuthSettings auth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("urlTemplate"u8))
                {
                    urlTemplate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userEventPattern"u8))
                {
                    userEventPattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemEvents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    systemEvents = array;
                    continue;
                }
                if (property.NameEquals("auth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    auth = UpstreamAuthSettings.DeserializeUpstreamAuthSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebPubSubEventHandler(urlTemplate, userEventPattern, systemEvents ?? new ChangeTrackingList<string>(), auth, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebPubSubEventHandler>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebPubSubEventHandler>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebPubSubEventHandler)} does not support writing '{options.Format}' format.");
            }
        }

        WebPubSubEventHandler IPersistableModel<WebPubSubEventHandler>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebPubSubEventHandler>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebPubSubEventHandler(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebPubSubEventHandler)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebPubSubEventHandler>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
