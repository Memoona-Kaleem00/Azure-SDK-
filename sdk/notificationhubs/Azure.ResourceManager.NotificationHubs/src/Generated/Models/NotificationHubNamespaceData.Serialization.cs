// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NotificationHubs.Models;

namespace Azure.ResourceManager.NotificationHubs
{
    public partial class NotificationHubNamespaceData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Core.Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(NamespaceName))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(NamespaceName);
            }
            if (Core.Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Core.Optional.IsDefined(Region))
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region);
            }
            if (Core.Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Core.Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdAt"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Core.Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updatedAt"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            if (Core.Optional.IsDefined(ServiceBusEndpoint))
            {
                writer.WritePropertyName("serviceBusEndpoint"u8);
                writer.WriteStringValue(ServiceBusEndpoint.AbsoluteUri);
            }
            if (Core.Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (Core.Optional.IsDefined(ScaleUnit))
            {
                writer.WritePropertyName("scaleUnit"u8);
                writer.WriteStringValue(ScaleUnit);
            }
            if (Core.Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Core.Optional.IsDefined(IsCritical))
            {
                writer.WritePropertyName("critical"u8);
                writer.WriteBooleanValue(IsCritical.Value);
            }
            if (Core.Optional.IsDefined(DataCenter))
            {
                writer.WritePropertyName("dataCenter"u8);
                writer.WriteStringValue(DataCenter);
            }
            if (Core.Optional.IsDefined(NamespaceType))
            {
                writer.WritePropertyName("namespaceType"u8);
                writer.WriteStringValue(NamespaceType.Value.ToSerialString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NotificationHubNamespaceData DeserializeNotificationHubNamespaceData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<NotificationHubSku> sku = default;
            Core.Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<string> name0 = default;
            Core.Optional<string> provisioningState = default;
            Core.Optional<string> region = default;
            Core.Optional<string> metricId = default;
            Core.Optional<string> status = default;
            Core.Optional<DateTimeOffset> createdAt = default;
            Core.Optional<DateTimeOffset> updatedAt = default;
            Core.Optional<Uri> serviceBusEndpoint = default;
            Core.Optional<string> subscriptionId = default;
            Core.Optional<string> scaleUnit = default;
            Core.Optional<bool> enabled = default;
            Core.Optional<bool> critical = default;
            Core.Optional<string> dataCenter = default;
            Core.Optional<NotificationHubNamespaceType> namespaceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = NotificationHubSku.DeserializeNotificationHubSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("name"u8))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("region"u8))
                        {
                            region = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metricId"u8))
                        {
                            metricId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            status = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updatedAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updatedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("serviceBusEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceBusEndpoint = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("subscriptionId"u8))
                        {
                            subscriptionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scaleUnit"u8))
                        {
                            scaleUnit = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("critical"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            critical = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("dataCenter"u8))
                        {
                            dataCenter = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("namespaceType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            namespaceType = property0.Value.GetString().ToNotificationHubNamespaceType();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NotificationHubNamespaceData(id, name, type, systemData.Value, Core.Optional.ToDictionary(tags), location, name0.Value, provisioningState.Value, region.Value, metricId.Value, status.Value, Core.Optional.ToNullable(createdAt), Core.Optional.ToNullable(updatedAt), serviceBusEndpoint.Value, subscriptionId.Value, scaleUnit.Value, Core.Optional.ToNullable(enabled), Core.Optional.ToNullable(critical), dataCenter.Value, Core.Optional.ToNullable(namespaceType), sku.Value);
        }
    }
}
