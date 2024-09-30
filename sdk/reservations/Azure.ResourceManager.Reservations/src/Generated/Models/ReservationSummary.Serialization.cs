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
    internal partial class ReservationSummary : IUtf8JsonSerializable, IJsonModel<ReservationSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReservationSummary>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ReservationSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationSummary)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(SucceededCount))
            {
                writer.WritePropertyName("succeededCount"u8);
                writer.WriteNumberValue(SucceededCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(FailedCount))
            {
                writer.WritePropertyName("failedCount"u8);
                writer.WriteNumberValue(FailedCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ExpiringCount))
            {
                writer.WritePropertyName("expiringCount"u8);
                writer.WriteNumberValue(ExpiringCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ExpiredCount))
            {
                writer.WritePropertyName("expiredCount"u8);
                writer.WriteNumberValue(ExpiredCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PendingCount))
            {
                writer.WritePropertyName("pendingCount"u8);
                writer.WriteNumberValue(PendingCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CancelledCount))
            {
                writer.WritePropertyName("cancelledCount"u8);
                writer.WriteNumberValue(CancelledCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ProcessingCount))
            {
                writer.WritePropertyName("processingCount"u8);
                writer.WriteNumberValue(ProcessingCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(WarningCount))
            {
                writer.WritePropertyName("warningCount"u8);
                writer.WriteNumberValue(WarningCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NoBenefitCount))
            {
                writer.WritePropertyName("noBenefitCount"u8);
                writer.WriteNumberValue(NoBenefitCount.Value);
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

        ReservationSummary IJsonModel<ReservationSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationSummary)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationSummary(document.RootElement, options);
        }

        internal static ReservationSummary DeserializeReservationSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float? succeededCount = default;
            float? failedCount = default;
            float? expiringCount = default;
            float? expiredCount = default;
            float? pendingCount = default;
            float? cancelledCount = default;
            float? processingCount = default;
            float? warningCount = default;
            float? noBenefitCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("succeededCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    succeededCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("failedCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failedCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("expiringCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiringCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("expiredCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiredCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("pendingCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pendingCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("cancelledCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cancelledCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("processingCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processingCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("warningCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    warningCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("noBenefitCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    noBenefitCount = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ReservationSummary(
                succeededCount,
                failedCount,
                expiringCount,
                expiredCount,
                pendingCount,
                cancelledCount,
                processingCount,
                warningCount,
                noBenefitCount,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReservationSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReservationSummary)} does not support writing '{options.Format}' format.");
            }
        }

        ReservationSummary IPersistableModel<ReservationSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReservationSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReservationSummary)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReservationSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
