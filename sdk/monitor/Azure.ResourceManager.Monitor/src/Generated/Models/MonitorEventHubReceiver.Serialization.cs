// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorEventHubReceiver : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("eventHubNameSpace"u8);
            writer.WriteStringValue(EventHubNameSpace);
            writer.WritePropertyName("eventHubName"u8);
            writer.WriteStringValue(EventHubName);
            if (Core.Optional.IsDefined(UseCommonAlertSchema))
            {
                writer.WritePropertyName("useCommonAlertSchema"u8);
                writer.WriteBooleanValue(UseCommonAlertSchema.Value);
            }
            if (Core.Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            writer.WritePropertyName("subscriptionId"u8);
            writer.WriteStringValue(SubscriptionId);
            writer.WriteEndObject();
        }

        internal static MonitorEventHubReceiver DeserializeMonitorEventHubReceiver(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string eventHubNameSpace = default;
            string eventHubName = default;
            Core.Optional<bool> useCommonAlertSchema = default;
            Core.Optional<Guid> tenantId = default;
            string subscriptionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventHubNameSpace"u8))
                {
                    eventHubNameSpace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventHubName"u8))
                {
                    eventHubName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("useCommonAlertSchema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useCommonAlertSchema = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
            }
            return new MonitorEventHubReceiver(name, eventHubNameSpace, eventHubName, Core.Optional.ToNullable(useCommonAlertSchema), Core.Optional.ToNullable(tenantId), subscriptionId);
        }
    }
}
