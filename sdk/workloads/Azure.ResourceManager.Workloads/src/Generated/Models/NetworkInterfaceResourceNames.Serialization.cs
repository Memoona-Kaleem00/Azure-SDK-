// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Workloads;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class NetworkInterfaceResourceNames : IUtf8JsonSerializable, IJsonModel<NetworkInterfaceResourceNames>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkInterfaceResourceNames>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkInterfaceResourceNames>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceResourceNames>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceResourceNames)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NetworkInterfaceName))
            {
                writer.WritePropertyName("networkInterfaceName"u8);
                writer.WriteStringValue(NetworkInterfaceName);
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

        NetworkInterfaceResourceNames IJsonModel<NetworkInterfaceResourceNames>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceResourceNames>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceResourceNames)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkInterfaceResourceNames(document.RootElement, options);
        }

        internal static NetworkInterfaceResourceNames DeserializeNetworkInterfaceResourceNames(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string networkInterfaceName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkInterfaceName"u8))
                {
                    networkInterfaceName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkInterfaceResourceNames(networkInterfaceName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkInterfaceResourceNames>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceResourceNames>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkInterfaceResourceNames)} does not support '{options.Format}' format.");
            }
        }

        NetworkInterfaceResourceNames IPersistableModel<NetworkInterfaceResourceNames>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkInterfaceResourceNames>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkInterfaceResourceNames(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkInterfaceResourceNames)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkInterfaceResourceNames>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
