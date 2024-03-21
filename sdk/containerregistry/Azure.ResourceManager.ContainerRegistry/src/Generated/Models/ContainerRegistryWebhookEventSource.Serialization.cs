// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryWebhookEventSource : IUtf8JsonSerializable, IJsonModel<ContainerRegistryWebhookEventSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryWebhookEventSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistryWebhookEventSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryWebhookEventSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryWebhookEventSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Addr))
            {
                writer.WritePropertyName("addr"u8);
                writer.WriteStringValue(Addr);
            }
            if (Optional.IsDefined(InstanceId))
            {
                writer.WritePropertyName("instanceID"u8);
                writer.WriteStringValue(InstanceId);
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

        ContainerRegistryWebhookEventSource IJsonModel<ContainerRegistryWebhookEventSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryWebhookEventSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryWebhookEventSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryWebhookEventSource(document.RootElement, options);
        }

        internal static ContainerRegistryWebhookEventSource DeserializeContainerRegistryWebhookEventSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string addr = default;
            string instanceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addr"u8))
                {
                    addr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceID"u8))
                {
                    instanceId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryWebhookEventSource(addr, instanceId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerRegistryWebhookEventSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryWebhookEventSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryWebhookEventSource)} does not support '{options.Format}' format.");
            }
        }

        ContainerRegistryWebhookEventSource IPersistableModel<ContainerRegistryWebhookEventSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryWebhookEventSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryWebhookEventSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryWebhookEventSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryWebhookEventSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
