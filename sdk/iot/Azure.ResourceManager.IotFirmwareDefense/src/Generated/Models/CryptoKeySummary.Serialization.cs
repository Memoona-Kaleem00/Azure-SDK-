// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class CryptoKeySummary : IUtf8JsonSerializable, IJsonModel<CryptoKeySummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CryptoKeySummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CryptoKeySummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CryptoKeySummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CryptoKeySummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (TotalKeys.HasValue)
            {
                writer.WritePropertyName("totalKeys"u8);
                writer.WriteNumberValue(TotalKeys.Value);
            }
            if (PublicKeys.HasValue)
            {
                writer.WritePropertyName("publicKeys"u8);
                writer.WriteNumberValue(PublicKeys.Value);
            }
            if (PrivateKeys.HasValue)
            {
                writer.WritePropertyName("privateKeys"u8);
                writer.WriteNumberValue(PrivateKeys.Value);
            }
            if (PairedKeys.HasValue)
            {
                writer.WritePropertyName("pairedKeys"u8);
                writer.WriteNumberValue(PairedKeys.Value);
            }
            if (ShortKeySize.HasValue)
            {
                writer.WritePropertyName("shortKeySize"u8);
                writer.WriteNumberValue(ShortKeySize.Value);
            }
            writer.WritePropertyName("summaryType"u8);
            writer.WriteStringValue(SummaryType.ToString());
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

        CryptoKeySummary IJsonModel<CryptoKeySummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CryptoKeySummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CryptoKeySummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCryptoKeySummary(document.RootElement, options);
        }

        internal static CryptoKeySummary DeserializeCryptoKeySummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? totalKeys = default;
            long? publicKeys = default;
            long? privateKeys = default;
            long? pairedKeys = default;
            long? shortKeySize = default;
            FirmwareAnalysisSummaryType summaryType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalKeys = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("publicKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicKeys = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("privateKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateKeys = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("pairedKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pairedKeys = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("shortKeySize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shortKeySize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("summaryType"u8))
                {
                    summaryType = new FirmwareAnalysisSummaryType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CryptoKeySummary(
                summaryType,
                serializedAdditionalRawData,
                totalKeys,
                publicKeys,
                privateKeys,
                pairedKeys,
                shortKeySize);
        }

        BinaryData IPersistableModel<CryptoKeySummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CryptoKeySummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CryptoKeySummary)} does not support '{options.Format}' format.");
            }
        }

        CryptoKeySummary IPersistableModel<CryptoKeySummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CryptoKeySummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCryptoKeySummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CryptoKeySummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CryptoKeySummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
