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
    public partial class WebPubSubNetworkAcls : IUtf8JsonSerializable, IJsonModel<WebPubSubNetworkAcls>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebPubSubNetworkAcls>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebPubSubNetworkAcls>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebPubSubNetworkAcls>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebPubSubNetworkAcls)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultAction))
            {
                writer.WritePropertyName("defaultAction"u8);
                writer.WriteStringValue(DefaultAction.Value.ToString());
            }
            if (Optional.IsDefined(PublicNetwork))
            {
                writer.WritePropertyName("publicNetwork"u8);
                writer.WriteObjectValue(PublicNetwork);
            }
            if (Optional.IsCollectionDefined(PrivateEndpoints))
            {
                writer.WritePropertyName("privateEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        WebPubSubNetworkAcls IJsonModel<WebPubSubNetworkAcls>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebPubSubNetworkAcls>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebPubSubNetworkAcls)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebPubSubNetworkAcls(document.RootElement, options);
        }

        internal static WebPubSubNetworkAcls DeserializeWebPubSubNetworkAcls(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AclAction> defaultAction = default;
            Optional<PublicNetworkAcls> publicNetwork = default;
            Optional<IList<PrivateEndpointAcl>> privateEndpoints = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultAction = new AclAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicNetwork"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetwork = PublicNetworkAcls.DeserializePublicNetworkAcls(property.Value);
                    continue;
                }
                if (property.NameEquals("privateEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrivateEndpointAcl> array = new List<PrivateEndpointAcl>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateEndpointAcl.DeserializePrivateEndpointAcl(item));
                    }
                    privateEndpoints = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebPubSubNetworkAcls(Optional.ToNullable(defaultAction), publicNetwork.Value, Optional.ToList(privateEndpoints), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebPubSubNetworkAcls>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebPubSubNetworkAcls>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebPubSubNetworkAcls)} does not support '{options.Format}' format.");
            }
        }

        WebPubSubNetworkAcls IPersistableModel<WebPubSubNetworkAcls>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebPubSubNetworkAcls>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebPubSubNetworkAcls(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebPubSubNetworkAcls)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebPubSubNetworkAcls>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
