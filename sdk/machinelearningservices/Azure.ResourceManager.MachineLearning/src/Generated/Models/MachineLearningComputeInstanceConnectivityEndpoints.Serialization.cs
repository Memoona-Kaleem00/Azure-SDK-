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
    public partial class MachineLearningComputeInstanceConnectivityEndpoints : IUtf8JsonSerializable, IJsonModel<MachineLearningComputeInstanceConnectivityEndpoints>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningComputeInstanceConnectivityEndpoints>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningComputeInstanceConnectivityEndpoints>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeInstanceConnectivityEndpoints>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningComputeInstanceConnectivityEndpoints)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && PublicIPAddress != null)
            {
                if (PublicIPAddress != null)
                {
                    writer.WritePropertyName("publicIpAddress"u8);
                    writer.WriteStringValue(PublicIPAddress);
                }
                else
                {
                    writer.WriteNull("publicIpAddress");
                }
            }
            if (options.Format != "W" && PrivateIPAddress != null)
            {
                if (PrivateIPAddress != null)
                {
                    writer.WritePropertyName("privateIpAddress"u8);
                    writer.WriteStringValue(PrivateIPAddress);
                }
                else
                {
                    writer.WriteNull("privateIpAddress");
                }
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

        MachineLearningComputeInstanceConnectivityEndpoints IJsonModel<MachineLearningComputeInstanceConnectivityEndpoints>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeInstanceConnectivityEndpoints>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningComputeInstanceConnectivityEndpoints)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningComputeInstanceConnectivityEndpoints(document.RootElement, options);
        }

        internal static MachineLearningComputeInstanceConnectivityEndpoints DeserializeMachineLearningComputeInstanceConnectivityEndpoints(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string publicIPAddress = default;
            string privateIPAddress = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        publicIPAddress = null;
                        continue;
                    }
                    publicIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        privateIPAddress = null;
                        continue;
                    }
                    privateIPAddress = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningComputeInstanceConnectivityEndpoints(publicIPAddress, privateIPAddress, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningComputeInstanceConnectivityEndpoints>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeInstanceConnectivityEndpoints>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningComputeInstanceConnectivityEndpoints)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningComputeInstanceConnectivityEndpoints IPersistableModel<MachineLearningComputeInstanceConnectivityEndpoints>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeInstanceConnectivityEndpoints>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningComputeInstanceConnectivityEndpoints(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningComputeInstanceConnectivityEndpoints)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningComputeInstanceConnectivityEndpoints>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
