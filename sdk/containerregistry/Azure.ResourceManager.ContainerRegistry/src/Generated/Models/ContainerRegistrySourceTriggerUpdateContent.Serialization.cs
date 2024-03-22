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
    public partial class ContainerRegistrySourceTriggerUpdateContent : IUtf8JsonSerializable, IJsonModel<ContainerRegistrySourceTriggerUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistrySourceTriggerUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistrySourceTriggerUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistrySourceTriggerUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistrySourceTriggerUpdateContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SourceRepository))
            {
                writer.WritePropertyName("sourceRepository"u8);
                writer.WriteObjectValue<SourceCodeRepoUpdateContent>(SourceRepository, options);
            }
            if (Optional.IsCollectionDefined(SourceTriggerEvents))
            {
                writer.WritePropertyName("sourceTriggerEvents"u8);
                writer.WriteStartArray();
                foreach (var item in SourceTriggerEvents)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
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

        ContainerRegistrySourceTriggerUpdateContent IJsonModel<ContainerRegistrySourceTriggerUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistrySourceTriggerUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistrySourceTriggerUpdateContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistrySourceTriggerUpdateContent(document.RootElement, options);
        }

        internal static ContainerRegistrySourceTriggerUpdateContent DeserializeContainerRegistrySourceTriggerUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SourceCodeRepoUpdateContent sourceRepository = default;
            IList<ContainerRegistrySourceTriggerEvent> sourceTriggerEvents = default;
            ContainerRegistryTriggerStatus? status = default;
            string name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceRepository"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRepository = SourceCodeRepoUpdateContent.DeserializeSourceCodeRepoUpdateContent(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sourceTriggerEvents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistrySourceTriggerEvent> array = new List<ContainerRegistrySourceTriggerEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ContainerRegistrySourceTriggerEvent(item.GetString()));
                    }
                    sourceTriggerEvents = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ContainerRegistryTriggerStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistrySourceTriggerUpdateContent(sourceRepository, sourceTriggerEvents ?? new ChangeTrackingList<ContainerRegistrySourceTriggerEvent>(), status, name, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerRegistrySourceTriggerUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistrySourceTriggerUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistrySourceTriggerUpdateContent)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerRegistrySourceTriggerUpdateContent IPersistableModel<ContainerRegistrySourceTriggerUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistrySourceTriggerUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistrySourceTriggerUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistrySourceTriggerUpdateContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistrySourceTriggerUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
