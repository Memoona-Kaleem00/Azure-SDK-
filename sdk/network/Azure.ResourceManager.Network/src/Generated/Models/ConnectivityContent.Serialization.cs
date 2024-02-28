// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectivityContent : IUtf8JsonSerializable, IJsonModel<ConnectivityContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectivityContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectivityContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectivityContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("source"u8);
            writer.WriteObjectValue(Source);
            writer.WritePropertyName("destination"u8);
            writer.WriteObjectValue(Destination);
            if (Protocol.HasValue)
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (ProtocolConfiguration != null)
            {
                writer.WritePropertyName("protocolConfiguration"u8);
                writer.WriteObjectValue(ProtocolConfiguration);
            }
            if (PreferredIPVersion.HasValue)
            {
                writer.WritePropertyName("preferredIPVersion"u8);
                writer.WriteStringValue(PreferredIPVersion.Value.ToString());
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

        ConnectivityContent IJsonModel<ConnectivityContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectivityContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectivityContent(document.RootElement, options);
        }

        internal static ConnectivityContent DeserializeConnectivityContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ConnectivitySource source = default;
            ConnectivityDestination destination = default;
            NetworkWatcherProtocol? protocol = default;
            ProtocolConfiguration protocolConfiguration = default;
            NetworkIPVersion? preferredIPVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"u8))
                {
                    source = ConnectivitySource.DeserializeConnectivitySource(property.Value, options);
                    continue;
                }
                if (property.NameEquals("destination"u8))
                {
                    destination = ConnectivityDestination.DeserializeConnectivityDestination(property.Value, options);
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protocol = new NetworkWatcherProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protocolConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protocolConfiguration = ProtocolConfiguration.DeserializeProtocolConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("preferredIPVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preferredIPVersion = new NetworkIPVersion(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectivityContent(
                source,
                destination,
                protocol,
                protocolConfiguration,
                preferredIPVersion,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectivityContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectivityContent)} does not support '{options.Format}' format.");
            }
        }

        ConnectivityContent IPersistableModel<ConnectivityContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectivityContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectivityContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectivityContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
