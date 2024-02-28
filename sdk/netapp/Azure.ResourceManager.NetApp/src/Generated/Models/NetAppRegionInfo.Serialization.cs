// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppRegionInfo : IUtf8JsonSerializable, IJsonModel<NetAppRegionInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppRegionInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetAppRegionInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppRegionInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppRegionInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (StorageToNetworkProximity.HasValue)
            {
                writer.WritePropertyName("storageToNetworkProximity"u8);
                writer.WriteStringValue(StorageToNetworkProximity.Value.ToString());
            }
            if (!(AvailabilityZoneMappings is ChangeTrackingList<AvailabilityZoneMapping> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("availabilityZoneMappings"u8);
                writer.WriteStartArray();
                foreach (var item in AvailabilityZoneMappings)
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

        NetAppRegionInfo IJsonModel<NetAppRegionInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppRegionInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppRegionInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppRegionInfo(document.RootElement, options);
        }

        internal static NetAppRegionInfo DeserializeNetAppRegionInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RegionStorageToNetworkProximity? storageToNetworkProximity = default;
            IReadOnlyList<AvailabilityZoneMapping> availabilityZoneMappings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageToNetworkProximity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageToNetworkProximity = new RegionStorageToNetworkProximity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("availabilityZoneMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AvailabilityZoneMapping> array = new List<AvailabilityZoneMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailabilityZoneMapping.DeserializeAvailabilityZoneMapping(item, options));
                    }
                    availabilityZoneMappings = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetAppRegionInfo(storageToNetworkProximity, availabilityZoneMappings ?? new ChangeTrackingList<AvailabilityZoneMapping>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppRegionInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppRegionInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetAppRegionInfo)} does not support '{options.Format}' format.");
            }
        }

        NetAppRegionInfo IPersistableModel<NetAppRegionInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppRegionInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetAppRegionInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetAppRegionInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppRegionInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
