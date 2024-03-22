// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    internal partial class TransferConfigurationTransferFilterDetails : IUtf8JsonSerializable, IJsonModel<TransferConfigurationTransferFilterDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TransferConfigurationTransferFilterDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TransferConfigurationTransferFilterDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferConfigurationTransferFilterDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TransferConfigurationTransferFilterDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Include))
            {
                writer.WritePropertyName("include"u8);
                writer.WriteObjectValue<TransferFilterDetails>(Include, options);
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

        TransferConfigurationTransferFilterDetails IJsonModel<TransferConfigurationTransferFilterDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferConfigurationTransferFilterDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TransferConfigurationTransferFilterDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTransferConfigurationTransferFilterDetails(document.RootElement, options);
        }

        internal static TransferConfigurationTransferFilterDetails DeserializeTransferConfigurationTransferFilterDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TransferFilterDetails include = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("include"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    include = TransferFilterDetails.DeserializeTransferFilterDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TransferConfigurationTransferFilterDetails(include, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TransferConfigurationTransferFilterDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferConfigurationTransferFilterDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TransferConfigurationTransferFilterDetails)} does not support writing '{options.Format}' format.");
            }
        }

        TransferConfigurationTransferFilterDetails IPersistableModel<TransferConfigurationTransferFilterDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TransferConfigurationTransferFilterDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTransferConfigurationTransferFilterDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TransferConfigurationTransferFilterDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TransferConfigurationTransferFilterDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
