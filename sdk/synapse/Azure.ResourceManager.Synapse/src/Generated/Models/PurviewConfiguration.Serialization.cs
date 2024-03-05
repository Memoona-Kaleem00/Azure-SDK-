// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class PurviewConfiguration : IUtf8JsonSerializable, IJsonModel<PurviewConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PurviewConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PurviewConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PurviewConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PurviewResourceId))
            {
                writer.WritePropertyName("purviewResourceId"u8);
                writer.WriteStringValue(PurviewResourceId);
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

        PurviewConfiguration IJsonModel<PurviewConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PurviewConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePurviewConfiguration(document.RootElement, options);
        }

        internal static PurviewConfiguration DeserializePurviewConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier purviewResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("purviewResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    purviewResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PurviewConfiguration(purviewResourceId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PurviewConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PurviewConfiguration)} does not support '{options.Format}' format.");
            }
        }

        PurviewConfiguration IPersistableModel<PurviewConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PurviewConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePurviewConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PurviewConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PurviewConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
