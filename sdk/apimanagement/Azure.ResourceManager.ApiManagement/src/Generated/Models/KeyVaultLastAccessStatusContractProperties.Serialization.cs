// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class KeyVaultLastAccessStatusContractProperties : IUtf8JsonSerializable, IJsonModel<KeyVaultLastAccessStatusContractProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KeyVaultLastAccessStatusContractProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KeyVaultLastAccessStatusContractProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultLastAccessStatusContractProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KeyVaultLastAccessStatusContractProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Code != null)
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (Message != null)
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (TimeStampUtc.HasValue)
            {
                writer.WritePropertyName("timeStampUtc"u8);
                writer.WriteStringValue(TimeStampUtc.Value, "O");
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

        KeyVaultLastAccessStatusContractProperties IJsonModel<KeyVaultLastAccessStatusContractProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultLastAccessStatusContractProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KeyVaultLastAccessStatusContractProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyVaultLastAccessStatusContractProperties(document.RootElement, options);
        }

        internal static KeyVaultLastAccessStatusContractProperties DeserializeKeyVaultLastAccessStatusContractProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string code = default;
            string message = default;
            DateTimeOffset? timeStampUtc = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeStampUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeStampUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KeyVaultLastAccessStatusContractProperties(code, message, timeStampUtc, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KeyVaultLastAccessStatusContractProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultLastAccessStatusContractProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KeyVaultLastAccessStatusContractProperties)} does not support '{options.Format}' format.");
            }
        }

        KeyVaultLastAccessStatusContractProperties IPersistableModel<KeyVaultLastAccessStatusContractProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeyVaultLastAccessStatusContractProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKeyVaultLastAccessStatusContractProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KeyVaultLastAccessStatusContractProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KeyVaultLastAccessStatusContractProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
