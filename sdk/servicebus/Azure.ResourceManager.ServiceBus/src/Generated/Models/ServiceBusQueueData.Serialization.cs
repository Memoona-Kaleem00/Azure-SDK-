// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    public partial class ServiceBusQueueData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(LockDuration))
            {
                writer.WritePropertyName("lockDuration");
                writer.WriteStringValue(LockDuration.Value, "P");
            }
            if (Optional.IsDefined(MaxSizeInMegabytes))
            {
                writer.WritePropertyName("maxSizeInMegabytes");
                writer.WriteNumberValue(MaxSizeInMegabytes.Value);
            }
            if (Optional.IsDefined(MaxMessageSizeInKilobytes))
            {
                writer.WritePropertyName("maxMessageSizeInKilobytes");
                writer.WriteNumberValue(MaxMessageSizeInKilobytes.Value);
            }
            if (Optional.IsDefined(RequiresDuplicateDetection))
            {
                writer.WritePropertyName("requiresDuplicateDetection");
                writer.WriteBooleanValue(RequiresDuplicateDetection.Value);
            }
            if (Optional.IsDefined(RequiresSession))
            {
                writer.WritePropertyName("requiresSession");
                writer.WriteBooleanValue(RequiresSession.Value);
            }
            if (Optional.IsDefined(DefaultMessageTimeToLive))
            {
                writer.WritePropertyName("defaultMessageTimeToLive");
                writer.WriteStringValue(DefaultMessageTimeToLive.Value, "P");
            }
            if (Optional.IsDefined(DeadLetteringOnMessageExpiration))
            {
                writer.WritePropertyName("deadLetteringOnMessageExpiration");
                writer.WriteBooleanValue(DeadLetteringOnMessageExpiration.Value);
            }
            if (Optional.IsDefined(DuplicateDetectionHistoryTimeWindow))
            {
                writer.WritePropertyName("duplicateDetectionHistoryTimeWindow");
                writer.WriteStringValue(DuplicateDetectionHistoryTimeWindow.Value, "P");
            }
            if (Optional.IsDefined(MaxDeliveryCount))
            {
                writer.WritePropertyName("maxDeliveryCount");
                writer.WriteNumberValue(MaxDeliveryCount.Value);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Optional.IsDefined(EnableBatchedOperations))
            {
                writer.WritePropertyName("enableBatchedOperations");
                writer.WriteBooleanValue(EnableBatchedOperations.Value);
            }
            if (Optional.IsDefined(AutoDeleteOnIdle))
            {
                writer.WritePropertyName("autoDeleteOnIdle");
                writer.WriteStringValue(AutoDeleteOnIdle.Value, "P");
            }
            if (Optional.IsDefined(EnablePartitioning))
            {
                writer.WritePropertyName("enablePartitioning");
                writer.WriteBooleanValue(EnablePartitioning.Value);
            }
            if (Optional.IsDefined(EnableExpress))
            {
                writer.WritePropertyName("enableExpress");
                writer.WriteBooleanValue(EnableExpress.Value);
            }
            if (Optional.IsDefined(ForwardTo))
            {
                writer.WritePropertyName("forwardTo");
                writer.WriteStringValue(ForwardTo);
            }
            if (Optional.IsDefined(ForwardDeadLetteredMessagesTo))
            {
                writer.WritePropertyName("forwardDeadLetteredMessagesTo");
                writer.WriteStringValue(ForwardDeadLetteredMessagesTo);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ServiceBusQueueData DeserializeServiceBusQueueData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<MessageCountDetails> countDetails = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<DateTimeOffset> updatedAt = default;
            Optional<DateTimeOffset> accessedAt = default;
            Optional<long> sizeInBytes = default;
            Optional<long> messageCount = default;
            Optional<TimeSpan> lockDuration = default;
            Optional<int> maxSizeInMegabytes = default;
            Optional<long> maxMessageSizeInKilobytes = default;
            Optional<bool> requiresDuplicateDetection = default;
            Optional<bool> requiresSession = default;
            Optional<TimeSpan> defaultMessageTimeToLive = default;
            Optional<bool> deadLetteringOnMessageExpiration = default;
            Optional<TimeSpan> duplicateDetectionHistoryTimeWindow = default;
            Optional<int> maxDeliveryCount = default;
            Optional<EntityStatus> status = default;
            Optional<bool> enableBatchedOperations = default;
            Optional<TimeSpan> autoDeleteOnIdle = default;
            Optional<bool> enablePartitioning = default;
            Optional<bool> enableExpress = default;
            Optional<string> forwardTo = default;
            Optional<string> forwardDeadLetteredMessagesTo = default;
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
                    type = (ResourceType)property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
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
                        if (property0.NameEquals("countDetails"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            countDetails = MessageCountDetails.DeserializeMessageCountDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("createdAt"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updatedAt"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            updatedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("accessedAt"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            accessedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sizeInBytes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sizeInBytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("messageCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            messageCount = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("lockDuration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lockDuration = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("maxSizeInMegabytes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxSizeInMegabytes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxMessageSizeInKilobytes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxMessageSizeInKilobytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("requiresDuplicateDetection"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            requiresDuplicateDetection = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("requiresSession"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            requiresSession = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultMessageTimeToLive"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            defaultMessageTimeToLive = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("deadLetteringOnMessageExpiration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deadLetteringOnMessageExpiration = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("duplicateDetectionHistoryTimeWindow"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            duplicateDetectionHistoryTimeWindow = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("maxDeliveryCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxDeliveryCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = property0.Value.GetString().ToEntityStatus();
                            continue;
                        }
                        if (property0.NameEquals("enableBatchedOperations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableBatchedOperations = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("autoDeleteOnIdle"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            autoDeleteOnIdle = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("enablePartitioning"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enablePartitioning = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableExpress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableExpress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("forwardTo"))
                        {
                            forwardTo = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("forwardDeadLetteredMessagesTo"))
                        {
                            forwardDeadLetteredMessagesTo = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ServiceBusQueueData(id, name, type, systemData, countDetails.Value, Optional.ToNullable(createdAt), Optional.ToNullable(updatedAt), Optional.ToNullable(accessedAt), Optional.ToNullable(sizeInBytes), Optional.ToNullable(messageCount), Optional.ToNullable(lockDuration), Optional.ToNullable(maxSizeInMegabytes), Optional.ToNullable(maxMessageSizeInKilobytes), Optional.ToNullable(requiresDuplicateDetection), Optional.ToNullable(requiresSession), Optional.ToNullable(defaultMessageTimeToLive), Optional.ToNullable(deadLetteringOnMessageExpiration), Optional.ToNullable(duplicateDetectionHistoryTimeWindow), Optional.ToNullable(maxDeliveryCount), Optional.ToNullable(status), Optional.ToNullable(enableBatchedOperations), Optional.ToNullable(autoDeleteOnIdle), Optional.ToNullable(enablePartitioning), Optional.ToNullable(enableExpress), forwardTo.Value, forwardDeadLetteredMessagesTo.Value);
        }
    }
}
