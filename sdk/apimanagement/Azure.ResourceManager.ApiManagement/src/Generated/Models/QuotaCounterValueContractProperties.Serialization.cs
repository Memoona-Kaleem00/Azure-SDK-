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
    public partial class QuotaCounterValueContractProperties : IUtf8JsonSerializable, IJsonModel<QuotaCounterValueContractProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QuotaCounterValueContractProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<QuotaCounterValueContractProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaCounterValueContractProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QuotaCounterValueContractProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CallsCount))
            {
                writer.WritePropertyName("callsCount"u8);
                writer.WriteNumberValue(CallsCount.Value);
            }
            if (Optional.IsDefined(KbTransferred))
            {
                writer.WritePropertyName("kbTransferred"u8);
                writer.WriteNumberValue(KbTransferred.Value);
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

        QuotaCounterValueContractProperties IJsonModel<QuotaCounterValueContractProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaCounterValueContractProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QuotaCounterValueContractProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQuotaCounterValueContractProperties(document.RootElement, options);
        }

        internal static QuotaCounterValueContractProperties DeserializeQuotaCounterValueContractProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? callsCount = default;
            double? kbTransferred = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("callsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    callsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("kbTransferred"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kbTransferred = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new QuotaCounterValueContractProperties(callsCount, kbTransferred, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QuotaCounterValueContractProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaCounterValueContractProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(QuotaCounterValueContractProperties)} does not support '{options.Format}' format.");
            }
        }

        QuotaCounterValueContractProperties IPersistableModel<QuotaCounterValueContractProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QuotaCounterValueContractProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQuotaCounterValueContractProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QuotaCounterValueContractProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<QuotaCounterValueContractProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
