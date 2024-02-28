// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StoragePool.Models
{
    public partial class StoragePoolOutboundEnvironment : IUtf8JsonSerializable, IJsonModel<StoragePoolOutboundEnvironment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StoragePoolOutboundEnvironment>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StoragePoolOutboundEnvironment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StoragePoolOutboundEnvironment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StoragePoolOutboundEnvironment)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Category != null)
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category);
            }
            if (!(Endpoints is ChangeTrackingList<OutboundEndpointDependency> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("endpoints"u8);
                writer.WriteStartArray();
                foreach (var item in Endpoints)
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

        StoragePoolOutboundEnvironment IJsonModel<StoragePoolOutboundEnvironment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StoragePoolOutboundEnvironment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StoragePoolOutboundEnvironment)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStoragePoolOutboundEnvironment(document.RootElement, options);
        }

        internal static StoragePoolOutboundEnvironment DeserializeStoragePoolOutboundEnvironment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string category = default;
            IReadOnlyList<OutboundEndpointDependency> endpoints = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OutboundEndpointDependency> array = new List<OutboundEndpointDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutboundEndpointDependency.DeserializeOutboundEndpointDependency(item, options));
                    }
                    endpoints = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StoragePoolOutboundEnvironment(category, endpoints ?? new ChangeTrackingList<OutboundEndpointDependency>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StoragePoolOutboundEnvironment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StoragePoolOutboundEnvironment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StoragePoolOutboundEnvironment)} does not support '{options.Format}' format.");
            }
        }

        StoragePoolOutboundEnvironment IPersistableModel<StoragePoolOutboundEnvironment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StoragePoolOutboundEnvironment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStoragePoolOutboundEnvironment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StoragePoolOutboundEnvironment)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StoragePoolOutboundEnvironment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
