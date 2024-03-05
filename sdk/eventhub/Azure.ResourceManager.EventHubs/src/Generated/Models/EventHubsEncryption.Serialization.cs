// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class EventHubsEncryption : IUtf8JsonSerializable, IJsonModel<EventHubsEncryption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventHubsEncryption>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventHubsEncryption>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsEncryption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubsEncryption)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(KeyVaultProperties))
            {
                writer.WritePropertyName("keyVaultProperties"u8);
                writer.WriteStartArray();
                foreach (var item in KeyVaultProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(KeySource))
            {
                writer.WritePropertyName("keySource"u8);
                writer.WriteStringValue(KeySource.Value.ToString());
            }
            if (Optional.IsDefined(RequireInfrastructureEncryption))
            {
                writer.WritePropertyName("requireInfrastructureEncryption"u8);
                writer.WriteBooleanValue(RequireInfrastructureEncryption.Value);
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

        EventHubsEncryption IJsonModel<EventHubsEncryption>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsEncryption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubsEncryption)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubsEncryption(document.RootElement, options);
        }

        internal static EventHubsEncryption DeserializeEventHubsEncryption(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<EventHubsKeyVaultProperties> keyVaultProperties = default;
            EventHubsKeySource? keySource = default;
            bool? requireInfrastructureEncryption = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EventHubsKeyVaultProperties> array = new List<EventHubsKeyVaultProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventHubsKeyVaultProperties.DeserializeEventHubsKeyVaultProperties(item, options));
                    }
                    keyVaultProperties = array;
                    continue;
                }
                if (property.NameEquals("keySource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keySource = new EventHubsKeySource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requireInfrastructureEncryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requireInfrastructureEncryption = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EventHubsEncryption(keyVaultProperties ?? new ChangeTrackingList<EventHubsKeyVaultProperties>(), keySource, requireInfrastructureEncryption, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EventHubsEncryption>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsEncryption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventHubsEncryption)} does not support '{options.Format}' format.");
            }
        }

        EventHubsEncryption IPersistableModel<EventHubsEncryption>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsEncryption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventHubsEncryption(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventHubsEncryption)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventHubsEncryption>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
