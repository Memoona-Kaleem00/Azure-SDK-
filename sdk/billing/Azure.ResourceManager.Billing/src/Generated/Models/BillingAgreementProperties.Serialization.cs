// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class BillingAgreementProperties : IUtf8JsonSerializable, IJsonModel<BillingAgreementProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingAgreementProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BillingAgreementProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingAgreementProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingAgreementProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(AcceptanceMode))
            {
                writer.WritePropertyName("acceptanceMode"u8);
                writer.WriteStringValue(AcceptanceMode.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AgreementLink))
            {
                writer.WritePropertyName("agreementLink"u8);
                writer.WriteStringValue(AgreementLink);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(BillingProfileInfo))
            {
                writer.WritePropertyName("billingProfileInfo"u8);
                writer.WriteStartArray();
                foreach (var item in BillingProfileInfo)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(EffectiveOn))
            {
                writer.WritePropertyName("effectiveDate"u8);
                writer.WriteStringValue(EffectiveOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationDate"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Participants))
            {
                writer.WritePropertyName("participants"u8);
                writer.WriteStartArray();
                foreach (var item in Participants)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (options.Format != "W" && Optional.IsDefined(LeadBillingAccountName))
            {
                writer.WritePropertyName("leadBillingAccountName"u8);
                writer.WriteStringValue(LeadBillingAccountName);
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

        BillingAgreementProperties IJsonModel<BillingAgreementProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingAgreementProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingAgreementProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingAgreementProperties(document.RootElement, options);
        }

        internal static BillingAgreementProperties DeserializeBillingAgreementProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AgreementAcceptanceMode? acceptanceMode = default;
            string agreementLink = default;
            IReadOnlyList<BillingProfileInfo> billingProfileInfo = default;
            BillingAgreementCategory? category = default;
            string displayName = default;
            DateTimeOffset? effectiveDate = default;
            DateTimeOffset? expirationDate = default;
            IReadOnlyList<BillingAgreementParticipant> participants = default;
            string status = default;
            string leadBillingAccountName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("acceptanceMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    acceptanceMode = new AgreementAcceptanceMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("agreementLink"u8))
                {
                    agreementLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("billingProfileInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BillingProfileInfo> array = new List<BillingProfileInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.BillingProfileInfo.DeserializeBillingProfileInfo(item, options));
                    }
                    billingProfileInfo = array;
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    category = new BillingAgreementCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("effectiveDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    effectiveDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expirationDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("participants"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BillingAgreementParticipant> array = new List<BillingAgreementParticipant>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BillingAgreementParticipant.DeserializeBillingAgreementParticipant(item, options));
                    }
                    participants = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("leadBillingAccountName"u8))
                {
                    leadBillingAccountName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BillingAgreementProperties(
                acceptanceMode,
                agreementLink,
                billingProfileInfo ?? new ChangeTrackingList<BillingProfileInfo>(),
                category,
                displayName,
                effectiveDate,
                expirationDate,
                participants ?? new ChangeTrackingList<BillingAgreementParticipant>(),
                status,
                leadBillingAccountName,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AcceptanceMode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  acceptanceMode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AcceptanceMode))
                {
                    builder.Append("  acceptanceMode: ");
                    builder.AppendLine($"'{AcceptanceMode.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AgreementLink), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  agreementLink: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AgreementLink))
                {
                    builder.Append("  agreementLink: ");
                    if (AgreementLink.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AgreementLink}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AgreementLink}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BillingProfileInfo), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  billingProfileInfo: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(BillingProfileInfo))
                {
                    if (BillingProfileInfo.Any())
                    {
                        builder.Append("  billingProfileInfo: ");
                        builder.AppendLine("[");
                        foreach (var item in BillingProfileInfo)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  billingProfileInfo: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Category), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  category: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Category))
                {
                    builder.Append("  category: ");
                    builder.AppendLine($"'{Category.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  displayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DisplayName))
                {
                    builder.Append("  displayName: ");
                    if (DisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EffectiveOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  effectiveDate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EffectiveOn))
                {
                    builder.Append("  effectiveDate: ");
                    var formattedDateTimeString = TypeFormatters.ToString(EffectiveOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExpireOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  expirationDate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExpireOn))
                {
                    builder.Append("  expirationDate: ");
                    var formattedDateTimeString = TypeFormatters.ToString(ExpireOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Participants), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  participants: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Participants))
                {
                    if (Participants.Any())
                    {
                        builder.Append("  participants: ");
                        builder.AppendLine("[");
                        foreach (var item in Participants)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  participants: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Status), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  status: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Status))
                {
                    builder.Append("  status: ");
                    if (Status.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Status}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Status}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LeadBillingAccountName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  leadBillingAccountName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LeadBillingAccountName))
                {
                    builder.Append("  leadBillingAccountName: ");
                    if (LeadBillingAccountName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LeadBillingAccountName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LeadBillingAccountName}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<BillingAgreementProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingAgreementProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BillingAgreementProperties)} does not support writing '{options.Format}' format.");
            }
        }

        BillingAgreementProperties IPersistableModel<BillingAgreementProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingAgreementProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBillingAgreementProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingAgreementProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingAgreementProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
