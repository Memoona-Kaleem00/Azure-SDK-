// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class ClearKeyEncryptionConfiguration : IUtf8JsonSerializable, IJsonModel<ClearKeyEncryptionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClearKeyEncryptionConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClearKeyEncryptionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClearKeyEncryptionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClearKeyEncryptionConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CustomKeysAcquisitionUriTemplate))
            {
                writer.WritePropertyName("customKeysAcquisitionUrlTemplate"u8);
                writer.WriteStringValue(CustomKeysAcquisitionUriTemplate);
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

        ClearKeyEncryptionConfiguration IJsonModel<ClearKeyEncryptionConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClearKeyEncryptionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClearKeyEncryptionConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClearKeyEncryptionConfiguration(document.RootElement, options);
        }

        internal static ClearKeyEncryptionConfiguration DeserializeClearKeyEncryptionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string customKeysAcquisitionUriTemplate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customKeysAcquisitionUrlTemplate"u8))
                {
                    customKeysAcquisitionUriTemplate = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClearKeyEncryptionConfiguration(customKeysAcquisitionUriTemplate, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClearKeyEncryptionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClearKeyEncryptionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClearKeyEncryptionConfiguration)} does not support '{options.Format}' format.");
            }
        }

        ClearKeyEncryptionConfiguration IPersistableModel<ClearKeyEncryptionConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClearKeyEncryptionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClearKeyEncryptionConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClearKeyEncryptionConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClearKeyEncryptionConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
