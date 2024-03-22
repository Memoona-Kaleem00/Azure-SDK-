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
    public partial class CalculateExchangeResultProperties : IUtf8JsonSerializable, IJsonModel<CalculateExchangeResultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CalculateExchangeResultProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CalculateExchangeResultProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CalculateExchangeResultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CalculateExchangeResultProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId.Value);
            }
            if (Optional.IsDefined(NetPayable))
            {
                writer.WritePropertyName("netPayable"u8);
                writer.WriteObjectValue<PurchasePrice>(NetPayable, options);
            }
            if (Optional.IsDefined(RefundsTotal))
            {
                writer.WritePropertyName("refundsTotal"u8);
                writer.WriteObjectValue<PurchasePrice>(RefundsTotal, options);
            }
            if (Optional.IsDefined(PurchasesTotal))
            {
                writer.WritePropertyName("purchasesTotal"u8);
                writer.WriteObjectValue<PurchasePrice>(PurchasesTotal, options);
            }
            if (Optional.IsCollectionDefined(ReservationsToPurchase))
            {
                writer.WritePropertyName("reservationsToPurchase"u8);
                writer.WriteStartArray();
                foreach (var item in ReservationsToPurchase)
                {
                    writer.WriteObjectValue<ReservationToPurchaseCalculateExchange>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SavingsPlansToPurchase))
            {
                writer.WritePropertyName("savingsPlansToPurchase"u8);
                writer.WriteStartArray();
                foreach (var item in SavingsPlansToPurchase)
                {
                    writer.WriteObjectValue<SavingsPlanToPurchaseCalculateExchange>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ReservationsToExchange))
            {
                writer.WritePropertyName("reservationsToExchange"u8);
                writer.WriteStartArray();
                foreach (var item in ReservationsToExchange)
                {
                    writer.WriteObjectValue<ReservationToExchange>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PolicyResult))
            {
                writer.WritePropertyName("policyResult"u8);
                writer.WriteObjectValue<ExchangePolicyErrors>(PolicyResult, options);
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

        CalculateExchangeResultProperties IJsonModel<CalculateExchangeResultProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CalculateExchangeResultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CalculateExchangeResultProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCalculateExchangeResultProperties(document.RootElement, options);
        }

        internal static CalculateExchangeResultProperties DeserializeCalculateExchangeResultProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? sessionId = default;
            PurchasePrice netPayable = default;
            PurchasePrice refundsTotal = default;
            PurchasePrice purchasesTotal = default;
            IReadOnlyList<ReservationToPurchaseCalculateExchange> reservationsToPurchase = default;
            IReadOnlyList<SavingsPlanToPurchaseCalculateExchange> savingsPlansToPurchase = default;
            IReadOnlyList<ReservationToExchange> reservationsToExchange = default;
            ExchangePolicyErrors policyResult = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("netPayable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    netPayable = PurchasePrice.DeserializePurchasePrice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("refundsTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refundsTotal = PurchasePrice.DeserializePurchasePrice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("purchasesTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    purchasesTotal = PurchasePrice.DeserializePurchasePrice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("reservationsToPurchase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReservationToPurchaseCalculateExchange> array = new List<ReservationToPurchaseCalculateExchange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReservationToPurchaseCalculateExchange.DeserializeReservationToPurchaseCalculateExchange(item, options));
                    }
                    reservationsToPurchase = array;
                    continue;
                }
                if (property.NameEquals("savingsPlansToPurchase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SavingsPlanToPurchaseCalculateExchange> array = new List<SavingsPlanToPurchaseCalculateExchange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SavingsPlanToPurchaseCalculateExchange.DeserializeSavingsPlanToPurchaseCalculateExchange(item, options));
                    }
                    savingsPlansToPurchase = array;
                    continue;
                }
                if (property.NameEquals("reservationsToExchange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReservationToExchange> array = new List<ReservationToExchange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReservationToExchange.DeserializeReservationToExchange(item, options));
                    }
                    reservationsToExchange = array;
                    continue;
                }
                if (property.NameEquals("policyResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyResult = ExchangePolicyErrors.DeserializeExchangePolicyErrors(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CalculateExchangeResultProperties(
                sessionId,
                netPayable,
                refundsTotal,
                purchasesTotal,
                reservationsToPurchase ?? new ChangeTrackingList<ReservationToPurchaseCalculateExchange>(),
                savingsPlansToPurchase ?? new ChangeTrackingList<SavingsPlanToPurchaseCalculateExchange>(),
                reservationsToExchange ?? new ChangeTrackingList<ReservationToExchange>(),
                policyResult,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CalculateExchangeResultProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CalculateExchangeResultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CalculateExchangeResultProperties)} does not support writing '{options.Format}' format.");
            }
        }

        CalculateExchangeResultProperties IPersistableModel<CalculateExchangeResultProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CalculateExchangeResultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCalculateExchangeResultProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CalculateExchangeResultProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CalculateExchangeResultProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
