// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class BillingInvoiceFailedPayment : IUtf8JsonSerializable, IJsonModel<BillingInvoiceFailedPayment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingInvoiceFailedPayment>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BillingInvoiceFailedPayment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingInvoiceFailedPayment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingInvoiceFailedPayment)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(On))
            {
                writer.WritePropertyName("date"u8);
                writer.WriteStringValue(On.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(FailedPaymentReason))
            {
                writer.WritePropertyName("failedPaymentReason"u8);
                writer.WriteStringValue(FailedPaymentReason.Value.ToString());
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

        BillingInvoiceFailedPayment IJsonModel<BillingInvoiceFailedPayment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingInvoiceFailedPayment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingInvoiceFailedPayment)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingInvoiceFailedPayment(document.RootElement, options);
        }

        internal static BillingInvoiceFailedPayment DeserializeBillingInvoiceFailedPayment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? date = default;
            BillingInvoiceFailedPaymentReason? failedPaymentReason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("date"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    date = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("failedPaymentReason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failedPaymentReason = new BillingInvoiceFailedPaymentReason(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BillingInvoiceFailedPayment(date, failedPaymentReason, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(On), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  date: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(On))
                {
                    builder.Append("  date: ");
                    var formattedDateTimeString = TypeFormatters.ToString(On.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FailedPaymentReason), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  failedPaymentReason: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(FailedPaymentReason))
                {
                    builder.Append("  failedPaymentReason: ");
                    builder.AppendLine($"'{FailedPaymentReason.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<BillingInvoiceFailedPayment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingInvoiceFailedPayment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BillingInvoiceFailedPayment)} does not support writing '{options.Format}' format.");
            }
        }

        BillingInvoiceFailedPayment IPersistableModel<BillingInvoiceFailedPayment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingInvoiceFailedPayment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBillingInvoiceFailedPayment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingInvoiceFailedPayment)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingInvoiceFailedPayment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
