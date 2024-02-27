// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Marketplace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Marketplace
{
    public partial class PrivateStoreData : IUtf8JsonSerializable, IJsonModel<PrivateStoreData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateStoreData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PrivateStoreData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateStoreData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateStoreData)} does not support '{format}' format.");
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
            if (Availability.HasValue)
            {
                writer.WritePropertyName("availability"u8);
                writer.WriteStringValue(Availability.Value.ToString());
            }
            if (options.Format != "W" && PrivateStoreId.HasValue)
            {
                writer.WritePropertyName("privateStoreId"u8);
                writer.WriteStringValue(PrivateStoreId.Value);
            }
            if (ETag.HasValue)
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (PrivateStoreName != null)
            {
                writer.WritePropertyName("privateStoreName"u8);
                writer.WriteStringValue(PrivateStoreName);
            }
            if (TenantId.HasValue)
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (IsGov.HasValue)
            {
                writer.WritePropertyName("isGov"u8);
                writer.WriteBooleanValue(IsGov.Value);
            }
            if (options.Format != "W" && !(CollectionIds is ChangeTrackingList<Guid> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("collectionIds"u8);
                writer.WriteStartArray();
                foreach (var item in CollectionIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Branding is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("branding"u8);
                writer.WriteStartObject();
                foreach (var item in Branding)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("notificationsSettings"u8);
            writer.WriteStartObject();
            if (!(Recipients is ChangeTrackingList<NotificationRecipient> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("recipients"u8);
                writer.WriteStartArray();
                foreach (var item in Recipients)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (SendToAllMarketplaceAdmins.HasValue)
            {
                writer.WritePropertyName("sendToAllMarketplaceAdmins"u8);
                writer.WriteBooleanValue(SendToAllMarketplaceAdmins.Value);
            }
            writer.WriteEndObject();
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

        PrivateStoreData IJsonModel<PrivateStoreData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateStoreData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateStoreData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateStoreData(document.RootElement, options);
        }

        internal static PrivateStoreData DeserializePrivateStoreData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<PrivateStoreAvailability> availability = default;
            Optional<Guid> privateStoreId = default;
            Optional<ETag> eTag = default;
            Optional<string> privateStoreName = default;
            Optional<Guid> tenantId = default;
            Optional<bool> isGov = default;
            IReadOnlyList<Guid> collectionIds = default;
            IDictionary<string, string> branding = default;
            IList<NotificationRecipient> recipients = default;
            Optional<bool> sendToAllMarketplaceAdmins = default;
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
                        if (property0.NameEquals("availability"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            availability = new PrivateStoreAvailability(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateStoreId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateStoreId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("eTag"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eTag = new ETag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateStoreName"u8))
                        {
                            privateStoreName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("isGov"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isGov = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("collectionIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<Guid> array = new List<Guid>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetGuid());
                            }
                            collectionIds = array;
                            continue;
                        }
                        if (property0.NameEquals("branding"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            branding = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("notificationsSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("recipients"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    List<NotificationRecipient> array = new List<NotificationRecipient>();
                                    foreach (var item in property1.Value.EnumerateArray())
                                    {
                                        array.Add(NotificationRecipient.DeserializeNotificationRecipient(item, options));
                                    }
                                    recipients = array;
                                    continue;
                                }
                                if (property1.NameEquals("sendToAllMarketplaceAdmins"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    sendToAllMarketplaceAdmins = property1.Value.GetBoolean();
                                    continue;
                                }
                            }
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
            return new PrivateStoreData(
                id,
                name,
                type,
                systemData.Value,
                Optional.ToNullable(availability),
                Optional.ToNullable(privateStoreId),
                Optional.ToNullable(eTag),
                privateStoreName.Value,
                Optional.ToNullable(tenantId),
                Optional.ToNullable(isGov),
                collectionIds ?? new ChangeTrackingList<Guid>(),
                branding ?? new ChangeTrackingDictionary<string, string>(),
                recipients ?? new ChangeTrackingList<NotificationRecipient>(),
                Optional.ToNullable(sendToAllMarketplaceAdmins),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PrivateStoreData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateStoreData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PrivateStoreData)} does not support '{options.Format}' format.");
            }
        }

        PrivateStoreData IPersistableModel<PrivateStoreData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateStoreData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateStoreData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateStoreData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateStoreData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
