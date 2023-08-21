// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class AutoscaleNotification : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("operation"u8);
            writer.WriteStringValue(Operation.ToString());
            if (Core.Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email"u8);
                writer.WriteObjectValue(Email);
            }
            if (Core.Optional.IsCollectionDefined(Webhooks))
            {
                writer.WritePropertyName("webhooks"u8);
                writer.WriteStartArray();
                foreach (var item in Webhooks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AutoscaleNotification DeserializeAutoscaleNotification(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MonitorOperationType operation = default;
            Core.Optional<EmailNotification> email = default;
            Core.Optional<IList<WebhookNotification>> webhooks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operation"u8))
                {
                    operation = new MonitorOperationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("email"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    email = EmailNotification.DeserializeEmailNotification(property.Value);
                    continue;
                }
                if (property.NameEquals("webhooks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WebhookNotification> array = new List<WebhookNotification>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebhookNotification.DeserializeWebhookNotification(item));
                    }
                    webhooks = array;
                    continue;
                }
            }
            return new AutoscaleNotification(operation, email.Value, Core.Optional.ToList(webhooks));
        }
    }
}
