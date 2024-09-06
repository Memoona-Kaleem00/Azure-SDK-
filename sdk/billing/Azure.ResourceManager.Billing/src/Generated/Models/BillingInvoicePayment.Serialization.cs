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
    public partial class BillingInvoicePayment : IUtf8JsonSerializable, IJsonModel<BillingInvoicePayment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingInvoicePayment>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BillingInvoicePayment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingInvoicePayment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingInvoicePayment)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Amount))
            {
                writer.WritePropertyName("amount"u8);
                writer.WriteObjectValue(Amount, options);
            }
            if (options.Format != "W" && Optional.IsDefined(MadeOn))
            {
                writer.WritePropertyName("date"u8);
                writer.WriteStringValue(MadeOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(PaymentMethodId))
            {
                writer.WritePropertyName("paymentMethodId"u8);
                writer.WriteStringValue(PaymentMethodId);
            }
            if (options.Format != "W" && Optional.IsDefined(PaymentMethodFamily))
            {
                writer.WritePropertyName("paymentMethodFamily"u8);
                writer.WriteStringValue(PaymentMethodFamily.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(PaymentMethodType))
            {
                writer.WritePropertyName("paymentMethodType"u8);
                writer.WriteStringValue(PaymentMethodType);
            }
            if (options.Format != "W" && Optional.IsDefined(PaymentType))
            {
                writer.WritePropertyName("paymentType"u8);
                writer.WriteStringValue(PaymentType);
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

        BillingInvoicePayment IJsonModel<BillingInvoicePayment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingInvoicePayment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingInvoicePayment)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingInvoicePayment(document.RootElement, options);
        }

        internal static BillingInvoicePayment DeserializeBillingInvoicePayment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BillingAmount amount = default;
            DateTimeOffset? date = default;
            ResourceIdentifier paymentMethodId = default;
            PaymentMethodFamily? paymentMethodFamily = default;
            string paymentMethodType = default;
            string paymentType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("amount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    amount = BillingAmount.DeserializeBillingAmount(property.Value, options);
                    continue;
                }
                if (property.NameEquals("date"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    date = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("paymentMethodId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    paymentMethodId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("paymentMethodFamily"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    paymentMethodFamily = new PaymentMethodFamily(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("paymentMethodType"u8))
                {
                    paymentMethodType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("paymentType"u8))
                {
                    paymentType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BillingInvoicePayment(
                amount,
                date,
                paymentMethodId,
                paymentMethodFamily,
                paymentMethodType,
                paymentType,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Amount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  amount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Amount))
                {
                    builder.Append("  amount: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Amount, options, 2, false, "  amount: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MadeOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  date: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MadeOn))
                {
                    builder.Append("  date: ");
                    var formattedDateTimeString = TypeFormatters.ToString(MadeOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PaymentMethodId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  paymentMethodId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PaymentMethodId))
                {
                    builder.Append("  paymentMethodId: ");
                    builder.AppendLine($"'{PaymentMethodId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PaymentMethodFamily), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  paymentMethodFamily: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PaymentMethodFamily))
                {
                    builder.Append("  paymentMethodFamily: ");
                    builder.AppendLine($"'{PaymentMethodFamily.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PaymentMethodType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  paymentMethodType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PaymentMethodType))
                {
                    builder.Append("  paymentMethodType: ");
                    if (PaymentMethodType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PaymentMethodType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PaymentMethodType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PaymentType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  paymentType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PaymentType))
                {
                    builder.Append("  paymentType: ");
                    if (PaymentType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PaymentType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PaymentType}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<BillingInvoicePayment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingInvoicePayment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BillingInvoicePayment)} does not support writing '{options.Format}' format.");
            }
        }

        BillingInvoicePayment IPersistableModel<BillingInvoicePayment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingInvoicePayment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBillingInvoicePayment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingInvoicePayment)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingInvoicePayment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
