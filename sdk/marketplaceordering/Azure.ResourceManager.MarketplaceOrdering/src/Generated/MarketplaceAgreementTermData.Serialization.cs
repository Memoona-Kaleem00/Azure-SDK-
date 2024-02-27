// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MarketplaceOrdering
{
    public partial class MarketplaceAgreementTermData : IUtf8JsonSerializable, IJsonModel<MarketplaceAgreementTermData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MarketplaceAgreementTermData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MarketplaceAgreementTermData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceAgreementTermData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MarketplaceAgreementTermData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (Publisher != null)
            {
                writer.WritePropertyName("publisher"u8);
                writer.WriteStringValue(Publisher);
            }
            if (Product != null)
            {
                writer.WritePropertyName("product"u8);
                writer.WriteStringValue(Product);
            }
            if (Plan != null)
            {
                writer.WritePropertyName("plan"u8);
                writer.WriteStringValue(Plan);
            }
            if (LicenseTextLink != null)
            {
                writer.WritePropertyName("licenseTextLink"u8);
                writer.WriteStringValue(LicenseTextLink.AbsoluteUri);
            }
            if (PrivacyPolicyLink != null)
            {
                writer.WritePropertyName("privacyPolicyLink"u8);
                writer.WriteStringValue(PrivacyPolicyLink.AbsoluteUri);
            }
            if (MarketplaceTermsLink != null)
            {
                writer.WritePropertyName("marketplaceTermsLink"u8);
                writer.WriteStringValue(MarketplaceTermsLink.AbsoluteUri);
            }
            if (RetrievedOn.HasValue)
            {
                writer.WritePropertyName("retrieveDatetime"u8);
                writer.WriteStringValue(RetrievedOn.Value, "O");
            }
            if (Signature != null)
            {
                writer.WritePropertyName("signature"u8);
                writer.WriteStringValue(Signature);
            }
            if (IsAccepted.HasValue)
            {
                writer.WritePropertyName("accepted"u8);
                writer.WriteBooleanValue(IsAccepted.Value);
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

        MarketplaceAgreementTermData IJsonModel<MarketplaceAgreementTermData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceAgreementTermData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MarketplaceAgreementTermData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMarketplaceAgreementTermData(document.RootElement, options);
        }

        internal static MarketplaceAgreementTermData DeserializeMarketplaceAgreementTermData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> publisher = default;
            Optional<string> product = default;
            Optional<string> plan = default;
            Optional<Uri> licenseTextLink = default;
            Optional<Uri> privacyPolicyLink = default;
            Optional<Uri> marketplaceTermsLink = default;
            Optional<DateTimeOffset> retrieveDatetime = default;
            Optional<string> signature = default;
            Optional<bool> accepted = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("publisher"u8))
                        {
                            publisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("product"u8))
                        {
                            product = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("plan"u8))
                        {
                            plan = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("licenseTextLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            licenseTextLink = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privacyPolicyLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privacyPolicyLink = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("marketplaceTermsLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            marketplaceTermsLink = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("retrieveDatetime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retrieveDatetime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("signature"u8))
                        {
                            signature = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accepted"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accepted = property0.Value.GetBoolean();
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
            return new MarketplaceAgreementTermData(
                id,
                name,
                type,
                systemData.Value,
                publisher.Value,
                product.Value,
                plan.Value,
                licenseTextLink.Value,
                privacyPolicyLink.Value,
                marketplaceTermsLink.Value,
                Optional.ToNullable(retrieveDatetime),
                signature.Value,
                Optional.ToNullable(accepted),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MarketplaceAgreementTermData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceAgreementTermData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MarketplaceAgreementTermData)} does not support '{options.Format}' format.");
            }
        }

        MarketplaceAgreementTermData IPersistableModel<MarketplaceAgreementTermData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceAgreementTermData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMarketplaceAgreementTermData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MarketplaceAgreementTermData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MarketplaceAgreementTermData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
