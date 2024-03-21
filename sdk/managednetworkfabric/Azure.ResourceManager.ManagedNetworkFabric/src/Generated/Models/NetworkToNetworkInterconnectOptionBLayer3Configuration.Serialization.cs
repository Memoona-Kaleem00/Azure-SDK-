// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NetworkToNetworkInterconnectOptionBLayer3Configuration : IUtf8JsonSerializable, IJsonModel<NetworkToNetworkInterconnectOptionBLayer3Configuration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkToNetworkInterconnectOptionBLayer3Configuration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkToNetworkInterconnectOptionBLayer3Configuration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkToNetworkInterconnectOptionBLayer3Configuration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkToNetworkInterconnectOptionBLayer3Configuration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PeerAsn))
            {
                writer.WritePropertyName("peerASN"u8);
                writer.WriteNumberValue(PeerAsn.Value);
            }
            if (Optional.IsDefined(VlanId))
            {
                writer.WritePropertyName("vlanId"u8);
                writer.WriteNumberValue(VlanId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(FabricAsn))
            {
                writer.WritePropertyName("fabricASN"u8);
                writer.WriteNumberValue(FabricAsn.Value);
            }
            if (Optional.IsDefined(PrimaryIPv4Prefix))
            {
                writer.WritePropertyName("primaryIpv4Prefix"u8);
                writer.WriteStringValue(PrimaryIPv4Prefix);
            }
            if (Optional.IsDefined(PrimaryIPv6Prefix))
            {
                writer.WritePropertyName("primaryIpv6Prefix"u8);
                writer.WriteStringValue(PrimaryIPv6Prefix);
            }
            if (Optional.IsDefined(SecondaryIPv4Prefix))
            {
                writer.WritePropertyName("secondaryIpv4Prefix"u8);
                writer.WriteStringValue(SecondaryIPv4Prefix);
            }
            if (Optional.IsDefined(SecondaryIPv6Prefix))
            {
                writer.WritePropertyName("secondaryIpv6Prefix"u8);
                writer.WriteStringValue(SecondaryIPv6Prefix);
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

        NetworkToNetworkInterconnectOptionBLayer3Configuration IJsonModel<NetworkToNetworkInterconnectOptionBLayer3Configuration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkToNetworkInterconnectOptionBLayer3Configuration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkToNetworkInterconnectOptionBLayer3Configuration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkToNetworkInterconnectOptionBLayer3Configuration(document.RootElement, options);
        }

        internal static NetworkToNetworkInterconnectOptionBLayer3Configuration DeserializeNetworkToNetworkInterconnectOptionBLayer3Configuration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? peerAsn = default;
            int? vlanId = default;
            long? fabricAsn = default;
            string primaryIPv4Prefix = default;
            string primaryIPv6Prefix = default;
            string secondaryIPv4Prefix = default;
            string secondaryIPv6Prefix = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("peerASN"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peerAsn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("vlanId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vlanId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("fabricASN"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricAsn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("primaryIpv4Prefix"u8))
                {
                    primaryIPv4Prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryIpv6Prefix"u8))
                {
                    primaryIPv6Prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryIpv4Prefix"u8))
                {
                    secondaryIPv4Prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryIpv6Prefix"u8))
                {
                    secondaryIPv6Prefix = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkToNetworkInterconnectOptionBLayer3Configuration(
                primaryIPv4Prefix,
                primaryIPv6Prefix,
                secondaryIPv4Prefix,
                secondaryIPv6Prefix,
                serializedAdditionalRawData,
                peerAsn,
                vlanId,
                fabricAsn);
        }

        BinaryData IPersistableModel<NetworkToNetworkInterconnectOptionBLayer3Configuration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkToNetworkInterconnectOptionBLayer3Configuration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkToNetworkInterconnectOptionBLayer3Configuration)} does not support '{options.Format}' format.");
            }
        }

        NetworkToNetworkInterconnectOptionBLayer3Configuration IPersistableModel<NetworkToNetworkInterconnectOptionBLayer3Configuration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkToNetworkInterconnectOptionBLayer3Configuration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkToNetworkInterconnectOptionBLayer3Configuration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkToNetworkInterconnectOptionBLayer3Configuration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkToNetworkInterconnectOptionBLayer3Configuration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
