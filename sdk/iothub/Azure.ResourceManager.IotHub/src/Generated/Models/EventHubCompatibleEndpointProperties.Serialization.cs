// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class EventHubCompatibleEndpointProperties : IUtf8JsonSerializable, IJsonModel<EventHubCompatibleEndpointProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventHubCompatibleEndpointProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventHubCompatibleEndpointProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubCompatibleEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubCompatibleEndpointProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (RetentionTimeInDays.HasValue)
            {
                writer.WritePropertyName("retentionTimeInDays"u8);
                writer.WriteNumberValue(RetentionTimeInDays.Value);
            }
            if (PartitionCount.HasValue)
            {
                writer.WritePropertyName("partitionCount"u8);
                writer.WriteNumberValue(PartitionCount.Value);
            }
            if (options.Format != "W" && !(PartitionIds is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("partitionIds"u8);
                writer.WriteStartArray();
                foreach (var item in PartitionIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && EventHubCompatibleName != null)
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(EventHubCompatibleName);
            }
            if (options.Format != "W" && Endpoint != null)
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint);
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

        EventHubCompatibleEndpointProperties IJsonModel<EventHubCompatibleEndpointProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubCompatibleEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubCompatibleEndpointProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubCompatibleEndpointProperties(document.RootElement, options);
        }

        internal static EventHubCompatibleEndpointProperties DeserializeEventHubCompatibleEndpointProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> retentionTimeInDays = default;
            Optional<int> partitionCount = default;
            Optional<IReadOnlyList<string>> partitionIds = default;
            Optional<string> path = default;
            Optional<string> endpoint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("retentionTimeInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionTimeInDays = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("partitionCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("partitionIds"u8))
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
                    partitionIds = array;
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EventHubCompatibleEndpointProperties(Optional.ToNullable(retentionTimeInDays), Optional.ToNullable(partitionCount), Optional.ToList(partitionIds), path.Value, endpoint.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EventHubCompatibleEndpointProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubCompatibleEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventHubCompatibleEndpointProperties)} does not support '{options.Format}' format.");
            }
        }

        EventHubCompatibleEndpointProperties IPersistableModel<EventHubCompatibleEndpointProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubCompatibleEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventHubCompatibleEndpointProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventHubCompatibleEndpointProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventHubCompatibleEndpointProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
