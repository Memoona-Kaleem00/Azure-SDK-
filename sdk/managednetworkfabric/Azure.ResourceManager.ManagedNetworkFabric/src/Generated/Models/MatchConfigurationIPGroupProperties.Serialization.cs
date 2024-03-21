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
    public partial class MatchConfigurationIPGroupProperties : IUtf8JsonSerializable, IJsonModel<MatchConfigurationIPGroupProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MatchConfigurationIPGroupProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MatchConfigurationIPGroupProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MatchConfigurationIPGroupProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MatchConfigurationIPGroupProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(IPAddressType))
            {
                writer.WritePropertyName("ipAddressType"u8);
                writer.WriteStringValue(IPAddressType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IPPrefixes))
            {
                writer.WritePropertyName("ipPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in IPPrefixes)
                {
                    writer.WriteStringValue(item);
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

        MatchConfigurationIPGroupProperties IJsonModel<MatchConfigurationIPGroupProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MatchConfigurationIPGroupProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MatchConfigurationIPGroupProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMatchConfigurationIPGroupProperties(document.RootElement, options);
        }

        internal static MatchConfigurationIPGroupProperties DeserializeMatchConfigurationIPGroupProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            NetworkFabricIPAddressType? ipAddressType = default;
            IList<string> ipPrefixes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddressType = new NetworkFabricIPAddressType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipPrefixes"u8))
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
                    ipPrefixes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MatchConfigurationIPGroupProperties(name, ipAddressType, ipPrefixes ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MatchConfigurationIPGroupProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MatchConfigurationIPGroupProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MatchConfigurationIPGroupProperties)} does not support '{options.Format}' format.");
            }
        }

        MatchConfigurationIPGroupProperties IPersistableModel<MatchConfigurationIPGroupProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MatchConfigurationIPGroupProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMatchConfigurationIPGroupProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MatchConfigurationIPGroupProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MatchConfigurationIPGroupProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
