// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseDataConnectionValidation : IUtf8JsonSerializable, IJsonModel<SynapseDataConnectionValidation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseDataConnectionValidation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseDataConnectionValidation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseDataConnectionValidation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseDataConnectionValidation)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DataConnectionName))
            {
                writer.WritePropertyName("dataConnectionName"u8);
                writer.WriteStringValue(DataConnectionName);
            }
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue<SynapseDataConnectionData>(Properties, options);
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

        SynapseDataConnectionValidation IJsonModel<SynapseDataConnectionValidation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseDataConnectionValidation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseDataConnectionValidation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseDataConnectionValidation(document.RootElement, options);
        }

        internal static SynapseDataConnectionValidation DeserializeSynapseDataConnectionValidation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string dataConnectionName = default;
            SynapseDataConnectionData properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataConnectionName"u8))
                {
                    dataConnectionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = SynapseDataConnectionData.DeserializeSynapseDataConnectionData(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseDataConnectionValidation(dataConnectionName, properties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseDataConnectionValidation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseDataConnectionValidation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseDataConnectionValidation)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseDataConnectionValidation IPersistableModel<SynapseDataConnectionValidation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseDataConnectionValidation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseDataConnectionValidation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseDataConnectionValidation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseDataConnectionValidation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
