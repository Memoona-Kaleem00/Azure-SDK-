// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.BillingBenefits.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.BillingBenefits
{
    public partial class BillingBenefitsSavingsPlanOrderData : IUtf8JsonSerializable, IJsonModel<BillingBenefitsSavingsPlanOrderData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingBenefitsSavingsPlanOrderData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BillingBenefitsSavingsPlanOrderData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsSavingsPlanOrderData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingBenefitsSavingsPlanOrderData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(BillingScopeId))
            {
                writer.WritePropertyName("billingScopeId"u8);
                writer.WriteStringValue(BillingScopeId);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingProfileId))
            {
                writer.WritePropertyName("billingProfileId"u8);
                writer.WriteStringValue(BillingProfileId);
            }
            if (options.Format != "W" && Optional.IsDefined(CustomerId))
            {
                writer.WritePropertyName("customerId"u8);
                writer.WriteStringValue(CustomerId);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingAccountId))
            {
                writer.WritePropertyName("billingAccountId"u8);
                writer.WriteStringValue(BillingAccountId);
            }
            if (Optional.IsDefined(Term))
            {
                writer.WritePropertyName("term"u8);
                writer.WriteStringValue(Term.Value.ToString());
            }
            if (Optional.IsDefined(BillingPlan))
            {
                writer.WritePropertyName("billingPlan"u8);
                writer.WriteStringValue(BillingPlan.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expiryDateTime"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(BenefitStartOn))
            {
                writer.WritePropertyName("benefitStartTime"u8);
                writer.WriteStringValue(BenefitStartOn.Value, "O");
            }
            if (Optional.IsDefined(PlanInformation))
            {
                writer.WritePropertyName("planInformation"u8);
                writer.WriteObjectValue(PlanInformation, options);
            }
            if (Optional.IsCollectionDefined(SavingsPlans))
            {
                writer.WritePropertyName("savingsPlans"u8);
                writer.WriteStartArray();
                foreach (var item in SavingsPlans)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ExtendedStatusInfo))
            {
                writer.WritePropertyName("extendedStatusInfo"u8);
                writer.WriteObjectValue(ExtendedStatusInfo, options);
            }
            writer.WriteEndObject();
        }

        BillingBenefitsSavingsPlanOrderData IJsonModel<BillingBenefitsSavingsPlanOrderData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsSavingsPlanOrderData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingBenefitsSavingsPlanOrderData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingBenefitsSavingsPlanOrderData(document.RootElement, options);
        }

        internal static BillingBenefitsSavingsPlanOrderData DeserializeBillingBenefitsSavingsPlanOrderData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BillingBenefitsSku sku = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string displayName = default;
            BillingBenefitsProvisioningState? provisioningState = default;
            ResourceIdentifier billingScopeId = default;
            ResourceIdentifier billingProfileId = default;
            string customerId = default;
            ResourceIdentifier billingAccountId = default;
            BillingBenefitsTerm? term = default;
            BillingBenefitsBillingPlan? billingPlan = default;
            DateTimeOffset? expiryDateTime = default;
            DateTimeOffset? benefitStartTime = default;
            BillingPlanInformation planInformation = default;
            IList<string> savingsPlans = default;
            BillingBenefitsExtendedStatusInfo extendedStatusInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = BillingBenefitsSku.DeserializeBillingBenefitsSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new BillingBenefitsProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingScopeId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingScopeId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingProfileId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingProfileId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customerId"u8))
                        {
                            customerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingAccountId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingAccountId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("term"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            term = new BillingBenefitsTerm(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingPlan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingPlan = new BillingBenefitsBillingPlan(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("expiryDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expiryDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("benefitStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            benefitStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("planInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            planInformation = BillingPlanInformation.DeserializeBillingPlanInformation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("savingsPlans"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            savingsPlans = array;
                            continue;
                        }
                        if (property0.NameEquals("extendedStatusInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            extendedStatusInfo = BillingBenefitsExtendedStatusInfo.DeserializeBillingBenefitsExtendedStatusInfo(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BillingBenefitsSavingsPlanOrderData(
                id,
                name,
                type,
                systemData,
                sku,
                displayName,
                provisioningState,
                billingScopeId,
                billingProfileId,
                customerId,
                billingAccountId,
                term,
                billingPlan,
                expiryDateTime,
                benefitStartTime,
                planInformation,
                savingsPlans ?? new ChangeTrackingList<string>(),
                extendedStatusInfo,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BillingBenefitsSavingsPlanOrderData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsSavingsPlanOrderData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BillingBenefitsSavingsPlanOrderData)} does not support writing '{options.Format}' format.");
            }
        }

        BillingBenefitsSavingsPlanOrderData IPersistableModel<BillingBenefitsSavingsPlanOrderData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsSavingsPlanOrderData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBillingBenefitsSavingsPlanOrderData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingBenefitsSavingsPlanOrderData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingBenefitsSavingsPlanOrderData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
