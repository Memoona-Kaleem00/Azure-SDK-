// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class PremierAddOnOffer : IUtf8JsonSerializable, IModelJsonSerializable<PremierAddOnOffer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PremierAddOnOffer>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PremierAddOnOffer>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PremierAddOnOffer>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteStringValue(Sku);
            }
            if (Optional.IsDefined(Product))
            {
                writer.WritePropertyName("product"u8);
                writer.WriteStringValue(Product);
            }
            if (Optional.IsDefined(Vendor))
            {
                writer.WritePropertyName("vendor"u8);
                writer.WriteStringValue(Vendor);
            }
            if (Optional.IsDefined(IsPromoCodeRequired))
            {
                writer.WritePropertyName("promoCodeRequired"u8);
                writer.WriteBooleanValue(IsPromoCodeRequired.Value);
            }
            if (Optional.IsDefined(Quota))
            {
                writer.WritePropertyName("quota"u8);
                writer.WriteNumberValue(Quota.Value);
            }
            if (Optional.IsDefined(WebHostingPlanRestrictions))
            {
                writer.WritePropertyName("webHostingPlanRestrictions"u8);
                writer.WriteStringValue(WebHostingPlanRestrictions.Value.ToSerialString());
            }
            if (Optional.IsDefined(PrivacyPolicyUri))
            {
                writer.WritePropertyName("privacyPolicyUrl"u8);
                writer.WriteStringValue(PrivacyPolicyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(LegalTermsUri))
            {
                writer.WritePropertyName("legalTermsUrl"u8);
                writer.WriteStringValue(LegalTermsUri.AbsoluteUri);
            }
            if (Optional.IsDefined(MarketplacePublisher))
            {
                writer.WritePropertyName("marketplacePublisher"u8);
                writer.WriteStringValue(MarketplacePublisher);
            }
            if (Optional.IsDefined(MarketplaceOffer))
            {
                writer.WritePropertyName("marketplaceOffer"u8);
                writer.WriteStringValue(MarketplaceOffer);
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static PremierAddOnOffer DeserializePremierAddOnOffer(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> sku = default;
            Optional<string> product = default;
            Optional<string> vendor = default;
            Optional<bool> promoCodeRequired = default;
            Optional<int> quota = default;
            Optional<AppServicePlanRestriction> webHostingPlanRestrictions = default;
            Optional<Uri> privacyPolicyUrl = default;
            Optional<Uri> legalTermsUrl = default;
            Optional<string> marketplacePublisher = default;
            Optional<string> marketplaceOffer = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("sku"u8))
                        {
                            sku = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("product"u8))
                        {
                            product = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vendor"u8))
                        {
                            vendor = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("promoCodeRequired"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            promoCodeRequired = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("quota"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            quota = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("webHostingPlanRestrictions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            webHostingPlanRestrictions = property0.Value.GetString().ToAppServicePlanRestriction();
                            continue;
                        }
                        if (property0.NameEquals("privacyPolicyUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privacyPolicyUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("legalTermsUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            legalTermsUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("marketplacePublisher"u8))
                        {
                            marketplacePublisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("marketplaceOffer"u8))
                        {
                            marketplaceOffer = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PremierAddOnOffer(id, name, type, systemData.Value, sku.Value, product.Value, vendor.Value, Optional.ToNullable(promoCodeRequired), Optional.ToNullable(quota), Optional.ToNullable(webHostingPlanRestrictions), privacyPolicyUrl.Value, legalTermsUrl.Value, marketplacePublisher.Value, marketplaceOffer.Value, kind.Value, rawData);
        }

        PremierAddOnOffer IModelJsonSerializable<PremierAddOnOffer>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PremierAddOnOffer>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePremierAddOnOffer(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PremierAddOnOffer>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PremierAddOnOffer>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PremierAddOnOffer IModelSerializable<PremierAddOnOffer>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PremierAddOnOffer>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePremierAddOnOffer(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PremierAddOnOffer"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PremierAddOnOffer"/> to convert. </param>
        public static implicit operator RequestContent(PremierAddOnOffer model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PremierAddOnOffer"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PremierAddOnOffer(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePremierAddOnOffer(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
