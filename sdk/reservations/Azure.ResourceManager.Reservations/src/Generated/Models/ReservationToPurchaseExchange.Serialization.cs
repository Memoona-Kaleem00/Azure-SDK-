// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ReservationToPurchaseExchange : IUtf8JsonSerializable, IJsonModel<ReservationToPurchaseExchange>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReservationToPurchaseExchange>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReservationToPurchaseExchange>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationToPurchaseExchange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationToPurchaseExchange)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ReservationOrderId != null)
            {
                writer.WritePropertyName("reservationOrderId"u8);
                writer.WriteStringValue(ReservationOrderId);
            }
            if (ReservationId != null)
            {
                writer.WritePropertyName("reservationId"u8);
                writer.WriteStringValue(ReservationId);
            }
            if (Properties != null)
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties);
            }
            if (BillingCurrencyTotal != null)
            {
                writer.WritePropertyName("billingCurrencyTotal"u8);
                writer.WriteObjectValue(BillingCurrencyTotal);
            }
            if (Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
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

        ReservationToPurchaseExchange IJsonModel<ReservationToPurchaseExchange>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationToPurchaseExchange>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationToPurchaseExchange)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationToPurchaseExchange(document.RootElement, options);
        }

        internal static ReservationToPurchaseExchange DeserializeReservationToPurchaseExchange(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> reservationOrderId = default;
            Optional<ResourceIdentifier> reservationId = default;
            Optional<ReservationPurchaseContent> properties = default;
            Optional<PurchasePrice> billingCurrencyTotal = default;
            Optional<ReservationOperationStatus> status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("reservationOrderId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reservationOrderId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reservationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reservationId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = ReservationPurchaseContent.DeserializeReservationPurchaseContent(property.Value, options);
                    continue;
                }
                if (property.NameEquals("billingCurrencyTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyTotal = PurchasePrice.DeserializePurchasePrice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ReservationOperationStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReservationToPurchaseExchange(
                reservationOrderId.Value,
                reservationId.Value,
                properties.Value,
                billingCurrencyTotal.Value,
                Optional.ToNullable(status),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReservationToPurchaseExchange>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationToPurchaseExchange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReservationToPurchaseExchange)} does not support '{options.Format}' format.");
            }
        }

        ReservationToPurchaseExchange IPersistableModel<ReservationToPurchaseExchange>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationToPurchaseExchange>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReservationToPurchaseExchange(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReservationToPurchaseExchange)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReservationToPurchaseExchange>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
