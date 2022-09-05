// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Marketplace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Marketplace
{
    public partial class PrivateStoreData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Availability))
            {
                writer.WritePropertyName("availability");
                writer.WriteStringValue(Availability.Value.ToString());
            }
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag");
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(PrivateStoreName))
            {
                writer.WritePropertyName("privateStoreName");
                writer.WriteStringValue(PrivateStoreName);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId");
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(IsGov))
            {
                writer.WritePropertyName("isGov");
                writer.WriteBooleanValue(IsGov.Value);
            }
            if (Optional.IsCollectionDefined(Branding))
            {
                writer.WritePropertyName("branding");
                writer.WriteStartObject();
                foreach (var item in Branding)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("notificationsSettings");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Recipients))
            {
                writer.WritePropertyName("recipients");
                writer.WriteStartArray();
                foreach (var item in Recipients)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SendToAllMarketplaceAdmins))
            {
                writer.WritePropertyName("sendToAllMarketplaceAdmins");
                writer.WriteBooleanValue(SendToAllMarketplaceAdmins.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PrivateStoreData DeserializePrivateStoreData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Availability> availability = default;
            Optional<string> privateStoreId = default;
            Optional<ETag> eTag = default;
            Optional<string> privateStoreName = default;
            Optional<Guid> tenantId = default;
            Optional<bool> isGov = default;
            Optional<IReadOnlyList<string>> collectionIds = default;
            Optional<IDictionary<string, string>> branding = default;
            Optional<IList<Recipient>> recipients = default;
            Optional<bool> sendToAllMarketplaceAdmins = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("availability"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            availability = new Availability(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateStoreId"))
                        {
                            privateStoreId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("eTag"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            eTag = new ETag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateStoreName"))
                        {
                            privateStoreName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tenantId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("isGov"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isGov = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("collectionIds"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            collectionIds = array;
                            continue;
                        }
                        if (property0.NameEquals("branding"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
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
                        if (property0.NameEquals("notificationsSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("recipients"))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        property1.ThrowNonNullablePropertyIsNull();
                                        continue;
                                    }
                                    List<Recipient> array = new List<Recipient>();
                                    foreach (var item in property1.Value.EnumerateArray())
                                    {
                                        array.Add(Recipient.DeserializeRecipient(item));
                                    }
                                    recipients = array;
                                    continue;
                                }
                                if (property1.NameEquals("sendToAllMarketplaceAdmins"))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        property1.ThrowNonNullablePropertyIsNull();
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
            }
            return new PrivateStoreData(id, name, type, systemData.Value, Optional.ToNullable(availability), privateStoreId.Value, Optional.ToNullable(eTag), privateStoreName.Value, Optional.ToNullable(tenantId), Optional.ToNullable(isGov), Optional.ToList(collectionIds), Optional.ToDictionary(branding), Optional.ToList(recipients), Optional.ToNullable(sendToAllMarketplaceAdmins));
        }
    }
}
