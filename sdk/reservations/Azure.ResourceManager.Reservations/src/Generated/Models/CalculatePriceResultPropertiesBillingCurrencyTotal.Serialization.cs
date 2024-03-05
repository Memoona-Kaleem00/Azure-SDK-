// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Reservations;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class CalculatePriceResultPropertiesBillingCurrencyTotal : IUtf8JsonSerializable, IJsonModel<CalculatePriceResultPropertiesBillingCurrencyTotal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CalculatePriceResultPropertiesBillingCurrencyTotal>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CalculatePriceResultPropertiesBillingCurrencyTotal>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CalculatePriceResultPropertiesBillingCurrencyTotal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CalculatePriceResultPropertiesBillingCurrencyTotal)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CurrencyCode))
            {
                writer.WritePropertyName("currencyCode"u8);
                writer.WriteStringValue(CurrencyCode);
            }
            if (Optional.IsDefined(Amount))
            {
                writer.WritePropertyName("amount"u8);
                writer.WriteNumberValue(Amount.Value);
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

        CalculatePriceResultPropertiesBillingCurrencyTotal IJsonModel<CalculatePriceResultPropertiesBillingCurrencyTotal>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CalculatePriceResultPropertiesBillingCurrencyTotal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CalculatePriceResultPropertiesBillingCurrencyTotal)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCalculatePriceResultPropertiesBillingCurrencyTotal(document.RootElement, options);
        }

        internal static CalculatePriceResultPropertiesBillingCurrencyTotal DeserializeCalculatePriceResultPropertiesBillingCurrencyTotal(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string currencyCode = default;
            double? amount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("currencyCode"u8))
                {
                    currencyCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("amount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    amount = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CalculatePriceResultPropertiesBillingCurrencyTotal(currencyCode, amount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CalculatePriceResultPropertiesBillingCurrencyTotal>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CalculatePriceResultPropertiesBillingCurrencyTotal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CalculatePriceResultPropertiesBillingCurrencyTotal)} does not support '{options.Format}' format.");
            }
        }

        CalculatePriceResultPropertiesBillingCurrencyTotal IPersistableModel<CalculatePriceResultPropertiesBillingCurrencyTotal>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CalculatePriceResultPropertiesBillingCurrencyTotal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCalculatePriceResultPropertiesBillingCurrencyTotal(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CalculatePriceResultPropertiesBillingCurrencyTotal)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CalculatePriceResultPropertiesBillingCurrencyTotal>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
