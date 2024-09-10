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
    internal partial class SavingsPlanSummaryCount : IUtf8JsonSerializable, IJsonModel<SavingsPlanSummaryCount>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SavingsPlanSummaryCount>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SavingsPlanSummaryCount>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanSummaryCount>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SavingsPlanSummaryCount)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (options.Format != "W" && Optional.IsDefined(NoBenefitCount))
            {
                writer.WritePropertyName("noBenefitCount"u8);
                writer.WriteNumberValue(NoBenefitCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(WarningCount))
            {
                writer.WritePropertyName("warningCount"u8);
                writer.WriteNumberValue(WarningCount.Value);
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

        SavingsPlanSummaryCount IJsonModel<SavingsPlanSummaryCount>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanSummaryCount>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SavingsPlanSummaryCount)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSavingsPlanSummaryCount(document.RootElement, options);
        }

        internal static SavingsPlanSummaryCount DeserializeSavingsPlanSummaryCount(JsonElement element, ModelReaderWriterOptions options = null)
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
            float? noBenefitCount = default;
            float? warningCount = default;
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
                if (property.NameEquals("noBenefitCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    noBenefitCount = property.Value.GetSingle();
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
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SavingsPlanSummaryCount(
                succeededCount,
                failedCount,
                expiringCount,
                expiredCount,
                pendingCount,
                cancelledCount,
                processingCount,
                noBenefitCount,
                warningCount,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SucceededCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  succeededCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SucceededCount))
                {
                    builder.Append("  succeededCount: ");
                    builder.AppendLine($"'{SucceededCount.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FailedCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  failedCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(FailedCount))
                {
                    builder.Append("  failedCount: ");
                    builder.AppendLine($"'{FailedCount.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExpiringCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  expiringCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExpiringCount))
                {
                    builder.Append("  expiringCount: ");
                    builder.AppendLine($"'{ExpiringCount.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExpiredCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  expiredCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExpiredCount))
                {
                    builder.Append("  expiredCount: ");
                    builder.AppendLine($"'{ExpiredCount.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PendingCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  pendingCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PendingCount))
                {
                    builder.Append("  pendingCount: ");
                    builder.AppendLine($"'{PendingCount.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CancelledCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  cancelledCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CancelledCount))
                {
                    builder.Append("  cancelledCount: ");
                    builder.AppendLine($"'{CancelledCount.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProcessingCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  processingCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProcessingCount))
                {
                    builder.Append("  processingCount: ");
                    builder.AppendLine($"'{ProcessingCount.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NoBenefitCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  noBenefitCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NoBenefitCount))
                {
                    builder.Append("  noBenefitCount: ");
                    builder.AppendLine($"'{NoBenefitCount.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WarningCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  warningCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WarningCount))
                {
                    builder.Append("  warningCount: ");
                    builder.AppendLine($"'{WarningCount.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SavingsPlanSummaryCount>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanSummaryCount>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SavingsPlanSummaryCount)} does not support writing '{options.Format}' format.");
            }
        }

        SavingsPlanSummaryCount IPersistableModel<SavingsPlanSummaryCount>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanSummaryCount>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSavingsPlanSummaryCount(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SavingsPlanSummaryCount)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SavingsPlanSummaryCount>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
