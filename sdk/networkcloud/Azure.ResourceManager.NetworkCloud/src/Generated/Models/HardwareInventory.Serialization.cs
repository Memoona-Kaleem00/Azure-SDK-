// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class HardwareInventory : IUtf8JsonSerializable, IJsonModel<HardwareInventory>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HardwareInventory>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HardwareInventory>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HardwareInventory>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HardwareInventory)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && AdditionalHostInformation != null)
            {
                writer.WritePropertyName("additionalHostInformation"u8);
                writer.WriteStringValue(AdditionalHostInformation);
            }
            if (options.Format != "W" && !(Interfaces is ChangeTrackingList<HardwareInventoryNetworkInterface> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("interfaces"u8);
                writer.WriteStartArray();
                foreach (var item in Interfaces)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(Nics is ChangeTrackingList<NetworkCloudNic> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("nics"u8);
                writer.WriteStartArray();
                foreach (var item in Nics)
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

        HardwareInventory IJsonModel<HardwareInventory>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HardwareInventory>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HardwareInventory)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHardwareInventory(document.RootElement, options);
        }

        internal static HardwareInventory DeserializeHardwareInventory(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string additionalHostInformation = default;
            IReadOnlyList<HardwareInventoryNetworkInterface> interfaces = default;
            IReadOnlyList<NetworkCloudNic> nics = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("additionalHostInformation"u8))
                {
                    additionalHostInformation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("interfaces"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HardwareInventoryNetworkInterface> array = new List<HardwareInventoryNetworkInterface>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HardwareInventoryNetworkInterface.DeserializeHardwareInventoryNetworkInterface(item, options));
                    }
                    interfaces = array;
                    continue;
                }
                if (property.NameEquals("nics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkCloudNic> array = new List<NetworkCloudNic>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkCloudNic.DeserializeNetworkCloudNic(item, options));
                    }
                    nics = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HardwareInventory(additionalHostInformation, interfaces ?? new ChangeTrackingList<HardwareInventoryNetworkInterface>(), nics ?? new ChangeTrackingList<NetworkCloudNic>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HardwareInventory>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HardwareInventory>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HardwareInventory)} does not support '{options.Format}' format.");
            }
        }

        HardwareInventory IPersistableModel<HardwareInventory>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HardwareInventory>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHardwareInventory(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HardwareInventory)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HardwareInventory>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
