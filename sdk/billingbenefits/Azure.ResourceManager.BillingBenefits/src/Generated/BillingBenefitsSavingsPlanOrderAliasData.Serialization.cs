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
    public partial class BillingBenefitsSavingsPlanOrderAliasData : IUtf8JsonSerializable, IJsonModel<BillingBenefitsSavingsPlanOrderAliasData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingBenefitsSavingsPlanOrderAliasData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BillingBenefitsSavingsPlanOrderAliasData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsSavingsPlanOrderAliasData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingBenefitsSavingsPlanOrderAliasData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku);
            if (Kind != null)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && SavingsPlanOrderId != null)
            {
                writer.WritePropertyName("savingsPlanOrderId"u8);
                writer.WriteStringValue(SavingsPlanOrderId);
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (BillingScopeId != null)
            {
                writer.WritePropertyName("billingScopeId"u8);
                writer.WriteStringValue(BillingScopeId);
            }
            if (Term.HasValue)
            {
                writer.WritePropertyName("term"u8);
                writer.WriteStringValue(Term.Value.ToString());
            }
            if (BillingPlan.HasValue)
            {
                writer.WritePropertyName("billingPlan"u8);
                writer.WriteStringValue(BillingPlan.Value.ToString());
            }
            if (AppliedScopeType.HasValue)
            {
                writer.WritePropertyName("appliedScopeType"u8);
                writer.WriteStringValue(AppliedScopeType.Value.ToString());
            }
            if (AppliedScopeProperties != null)
            {
                writer.WritePropertyName("appliedScopeProperties"u8);
                writer.WriteObjectValue(AppliedScopeProperties);
            }
            if (Commitment != null)
            {
                writer.WritePropertyName("commitment"u8);
                writer.WriteObjectValue(Commitment);
            }
            writer.WriteEndObject();
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

        BillingBenefitsSavingsPlanOrderAliasData IJsonModel<BillingBenefitsSavingsPlanOrderAliasData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsSavingsPlanOrderAliasData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingBenefitsSavingsPlanOrderAliasData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingBenefitsSavingsPlanOrderAliasData(document.RootElement, options);
        }

        internal static BillingBenefitsSavingsPlanOrderAliasData DeserializeBillingBenefitsSavingsPlanOrderAliasData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BillingBenefitsSku sku = default;
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> displayName = default;
            Optional<ResourceIdentifier> savingsPlanOrderId = default;
            Optional<BillingBenefitsProvisioningState> provisioningState = default;
            Optional<ResourceIdentifier> billingScopeId = default;
            Optional<BillingBenefitsTerm> term = default;
            Optional<BillingBenefitsBillingPlan> billingPlan = default;
            Optional<BillingBenefitsAppliedScopeType> appliedScopeType = default;
            Optional<BillingBenefitsAppliedScopeProperties> appliedScopeProperties = default;
            Optional<BillingBenefitsCommitment> commitment = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = BillingBenefitsSku.DeserializeBillingBenefitsSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("savingsPlanOrderId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            savingsPlanOrderId = new ResourceIdentifier(property0.Value.GetString());
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
                        if (property0.NameEquals("appliedScopeType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appliedScopeType = new BillingBenefitsAppliedScopeType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("appliedScopeProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appliedScopeProperties = BillingBenefitsAppliedScopeProperties.DeserializeBillingBenefitsAppliedScopeProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("commitment"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            commitment = BillingBenefitsCommitment.DeserializeBillingBenefitsCommitment(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BillingBenefitsSavingsPlanOrderAliasData(
                id,
                name,
                type,
                systemData.Value,
                sku,
                kind.Value,
                displayName.Value,
                savingsPlanOrderId.Value,
                Optional.ToNullable(provisioningState),
                billingScopeId.Value,
                Optional.ToNullable(term),
                Optional.ToNullable(billingPlan),
                Optional.ToNullable(appliedScopeType),
                appliedScopeProperties.Value,
                commitment.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BillingBenefitsSavingsPlanOrderAliasData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsSavingsPlanOrderAliasData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BillingBenefitsSavingsPlanOrderAliasData)} does not support '{options.Format}' format.");
            }
        }

        BillingBenefitsSavingsPlanOrderAliasData IPersistableModel<BillingBenefitsSavingsPlanOrderAliasData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingBenefitsSavingsPlanOrderAliasData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBillingBenefitsSavingsPlanOrderAliasData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingBenefitsSavingsPlanOrderAliasData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingBenefitsSavingsPlanOrderAliasData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
