// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkFunction.Models
{
    public partial class IngestionPolicyPropertiesFormat : IUtf8JsonSerializable, IJsonModel<IngestionPolicyPropertiesFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IngestionPolicyPropertiesFormat>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IngestionPolicyPropertiesFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IngestionPolicyPropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IngestionPolicyPropertiesFormat)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IngestionType))
            {
                writer.WritePropertyName("ingestionType"u8);
                writer.WriteStringValue(IngestionType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IngestionSources))
            {
                writer.WritePropertyName("ingestionSources"u8);
                writer.WriteStartArray();
                foreach (var item in IngestionSources)
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

        IngestionPolicyPropertiesFormat IJsonModel<IngestionPolicyPropertiesFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IngestionPolicyPropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IngestionPolicyPropertiesFormat)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIngestionPolicyPropertiesFormat(document.RootElement, options);
        }

        internal static IngestionPolicyPropertiesFormat DeserializeIngestionPolicyPropertiesFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IngestionType> ingestionType = default;
            Optional<IList<IngestionSourcesPropertiesFormat>> ingestionSources = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ingestionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ingestionType = new IngestionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ingestionSources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IngestionSourcesPropertiesFormat> array = new List<IngestionSourcesPropertiesFormat>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IngestionSourcesPropertiesFormat.DeserializeIngestionSourcesPropertiesFormat(item, options));
                    }
                    ingestionSources = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IngestionPolicyPropertiesFormat(Optional.ToNullable(ingestionType), Optional.ToList(ingestionSources), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IngestionPolicyPropertiesFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IngestionPolicyPropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IngestionPolicyPropertiesFormat)} does not support '{options.Format}' format.");
            }
        }

        IngestionPolicyPropertiesFormat IPersistableModel<IngestionPolicyPropertiesFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IngestionPolicyPropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIngestionPolicyPropertiesFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IngestionPolicyPropertiesFormat)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IngestionPolicyPropertiesFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
