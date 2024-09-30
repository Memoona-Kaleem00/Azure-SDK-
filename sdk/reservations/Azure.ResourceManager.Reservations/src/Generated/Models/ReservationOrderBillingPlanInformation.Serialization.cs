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
    public partial class ReservationOrderBillingPlanInformation : IUtf8JsonSerializable, IJsonModel<ReservationOrderBillingPlanInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReservationOrderBillingPlanInformation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ReservationOrderBillingPlanInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationOrderBillingPlanInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationOrderBillingPlanInformation)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PricingCurrencyTotal))
            {
                writer.WritePropertyName("pricingCurrencyTotal"u8);
                writer.WriteObjectValue(PricingCurrencyTotal, options);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startDate"u8);
                writer.WriteStringValue(StartOn.Value, "D");
            }
            if (Optional.IsDefined(NextPaymentDueOn))
            {
                writer.WritePropertyName("nextPaymentDueDate"u8);
                writer.WriteStringValue(NextPaymentDueOn.Value, "D");
            }
            if (Optional.IsCollectionDefined(Transactions))
            {
                writer.WritePropertyName("transactions"u8);
                writer.WriteStartArray();
                foreach (var item in Transactions)
                {
                    writer.WriteObjectValue(item, options);
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
        }

        ReservationOrderBillingPlanInformation IJsonModel<ReservationOrderBillingPlanInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationOrderBillingPlanInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationOrderBillingPlanInformation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationOrderBillingPlanInformation(document.RootElement, options);
        }

        internal static ReservationOrderBillingPlanInformation DeserializeReservationOrderBillingPlanInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PurchasePrice pricingCurrencyTotal = default;
            DateTimeOffset? startDate = default;
            DateTimeOffset? nextPaymentDueDate = default;
            IReadOnlyList<PaymentDetail> transactions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pricingCurrencyTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pricingCurrencyTotal = PurchasePrice.DeserializePurchasePrice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("startDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("nextPaymentDueDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextPaymentDueDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("transactions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PaymentDetail> array = new List<PaymentDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PaymentDetail.DeserializePaymentDetail(item, options));
                    }
                    transactions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ReservationOrderBillingPlanInformation(pricingCurrencyTotal, startDate, nextPaymentDueDate, transactions ?? new ChangeTrackingList<PaymentDetail>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReservationOrderBillingPlanInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationOrderBillingPlanInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReservationOrderBillingPlanInformation)} does not support writing '{options.Format}' format.");
            }
        }

        ReservationOrderBillingPlanInformation IPersistableModel<ReservationOrderBillingPlanInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationOrderBillingPlanInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReservationOrderBillingPlanInformation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReservationOrderBillingPlanInformation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReservationOrderBillingPlanInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
