// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Marketplace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Marketplace
{
    public partial class MarketplaceApprovalRequestData : IUtf8JsonSerializable, IJsonModel<MarketplaceApprovalRequestData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MarketplaceApprovalRequestData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MarketplaceApprovalRequestData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceApprovalRequestData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MarketplaceApprovalRequestData)} does not support '{format}' format.");
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
            if (OfferId != null)
            {
                writer.WritePropertyName("offerId"u8);
                writer.WriteStringValue(OfferId);
            }
            if (options.Format != "W" && OfferDisplayName != null)
            {
                writer.WritePropertyName("offerDisplayName"u8);
                writer.WriteStringValue(OfferDisplayName);
            }
            if (PublisherId != null)
            {
                writer.WritePropertyName("publisherId"u8);
                writer.WriteStringValue(PublisherId);
            }
            if (!(PlansDetails is ChangeTrackingList<PrivateStorePlanDetails> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("plansDetails"u8);
                writer.WriteStartArray();
                foreach (var item in PlansDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && IsClosed.HasValue)
            {
                writer.WritePropertyName("isClosed"u8);
                writer.WriteBooleanValue(IsClosed.Value);
            }
            if (MessageCode.HasValue)
            {
                writer.WritePropertyName("messageCode"u8);
                writer.WriteNumberValue(MessageCode.Value);
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

        MarketplaceApprovalRequestData IJsonModel<MarketplaceApprovalRequestData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceApprovalRequestData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MarketplaceApprovalRequestData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMarketplaceApprovalRequestData(document.RootElement, options);
        }

        internal static MarketplaceApprovalRequestData DeserializeMarketplaceApprovalRequestData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<string> offerId = default;
            Optional<string> offerDisplayName = default;
            Optional<string> publisherId = default;
            IList<PrivateStorePlanDetails> plansDetails = default;
            Optional<bool> isClosed = default;
            Optional<long> messageCode = default;
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
                        if (property0.NameEquals("offerId"u8))
                        {
                            offerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("offerDisplayName"u8))
                        {
                            offerDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherId"u8))
                        {
                            publisherId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("plansDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PrivateStorePlanDetails> array = new List<PrivateStorePlanDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrivateStorePlanDetails.DeserializePrivateStorePlanDetails(item, options));
                            }
                            plansDetails = array;
                            continue;
                        }
                        if (property0.NameEquals("isClosed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isClosed = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("messageCode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            messageCode = property0.Value.GetInt64();
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
            return new MarketplaceApprovalRequestData(
                id,
                name,
                type,
                systemData.Value,
                offerId.Value,
                offerDisplayName.Value,
                publisherId.Value,
                plansDetails ?? new ChangeTrackingList<PrivateStorePlanDetails>(),
                Optional.ToNullable(isClosed),
                Optional.ToNullable(messageCode),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MarketplaceApprovalRequestData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceApprovalRequestData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MarketplaceApprovalRequestData)} does not support '{options.Format}' format.");
            }
        }

        MarketplaceApprovalRequestData IPersistableModel<MarketplaceApprovalRequestData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceApprovalRequestData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMarketplaceApprovalRequestData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MarketplaceApprovalRequestData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MarketplaceApprovalRequestData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
