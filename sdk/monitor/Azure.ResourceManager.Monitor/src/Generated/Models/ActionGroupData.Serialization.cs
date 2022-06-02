// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    public partial class ActionGroupData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(GroupShortName))
            {
                writer.WritePropertyName("groupShortName");
                writer.WriteStringValue(GroupShortName);
            }
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsCollectionDefined(EmailReceivers))
            {
                writer.WritePropertyName("emailReceivers");
                writer.WriteStartArray();
                foreach (var item in EmailReceivers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SmsReceivers))
            {
                writer.WritePropertyName("smsReceivers");
                writer.WriteStartArray();
                foreach (var item in SmsReceivers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(WebhookReceivers))
            {
                writer.WritePropertyName("webhookReceivers");
                writer.WriteStartArray();
                foreach (var item in WebhookReceivers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ItsmReceivers))
            {
                writer.WritePropertyName("itsmReceivers");
                writer.WriteStartArray();
                foreach (var item in ItsmReceivers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AzureAppPushReceivers))
            {
                writer.WritePropertyName("azureAppPushReceivers");
                writer.WriteStartArray();
                foreach (var item in AzureAppPushReceivers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AutomationRunbookReceivers))
            {
                writer.WritePropertyName("automationRunbookReceivers");
                writer.WriteStartArray();
                foreach (var item in AutomationRunbookReceivers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VoiceReceivers))
            {
                writer.WritePropertyName("voiceReceivers");
                writer.WriteStartArray();
                foreach (var item in VoiceReceivers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LogicAppReceivers))
            {
                writer.WritePropertyName("logicAppReceivers");
                writer.WriteStartArray();
                foreach (var item in LogicAppReceivers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AzureFunctionReceivers))
            {
                writer.WritePropertyName("azureFunctionReceivers");
                writer.WriteStartArray();
                foreach (var item in AzureFunctionReceivers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ArmRoleReceivers))
            {
                writer.WritePropertyName("armRoleReceivers");
                writer.WriteStartArray();
                foreach (var item in ArmRoleReceivers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EventHubReceivers))
            {
                writer.WritePropertyName("eventHubReceivers");
                writer.WriteStartArray();
                foreach (var item in EventHubReceivers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ActionGroupData DeserializeActionGroupData(JsonElement element)
        {
            Optional<string> kind = default;
            Optional<string> identity = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> groupShortName = default;
            Optional<bool> enabled = default;
            Optional<IList<EmailReceiver>> emailReceivers = default;
            Optional<IList<SmsReceiver>> smsReceivers = default;
            Optional<IList<WebhookReceiver>> webhookReceivers = default;
            Optional<IList<ItsmReceiver>> itsmReceivers = default;
            Optional<IList<AzureAppPushReceiver>> azureAppPushReceivers = default;
            Optional<IList<AutomationRunbookReceiver>> automationRunbookReceivers = default;
            Optional<IList<VoiceReceiver>> voiceReceivers = default;
            Optional<IList<LogicAppReceiver>> logicAppReceivers = default;
            Optional<IList<AzureFunctionReceiver>> azureFunctionReceivers = default;
            Optional<IList<ArmRoleReceiver>> armRoleReceivers = default;
            Optional<IList<EventHubReceiver>> eventHubReceivers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    identity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("groupShortName"))
                        {
                            groupShortName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("emailReceivers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<EmailReceiver> array = new List<EmailReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EmailReceiver.DeserializeEmailReceiver(item));
                            }
                            emailReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("smsReceivers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SmsReceiver> array = new List<SmsReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SmsReceiver.DeserializeSmsReceiver(item));
                            }
                            smsReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("webhookReceivers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WebhookReceiver> array = new List<WebhookReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(WebhookReceiver.DeserializeWebhookReceiver(item));
                            }
                            webhookReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("itsmReceivers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ItsmReceiver> array = new List<ItsmReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ItsmReceiver.DeserializeItsmReceiver(item));
                            }
                            itsmReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("azureAppPushReceivers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<AzureAppPushReceiver> array = new List<AzureAppPushReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AzureAppPushReceiver.DeserializeAzureAppPushReceiver(item));
                            }
                            azureAppPushReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("automationRunbookReceivers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<AutomationRunbookReceiver> array = new List<AutomationRunbookReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AutomationRunbookReceiver.DeserializeAutomationRunbookReceiver(item));
                            }
                            automationRunbookReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("voiceReceivers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VoiceReceiver> array = new List<VoiceReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VoiceReceiver.DeserializeVoiceReceiver(item));
                            }
                            voiceReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("logicAppReceivers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<LogicAppReceiver> array = new List<LogicAppReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LogicAppReceiver.DeserializeLogicAppReceiver(item));
                            }
                            logicAppReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("azureFunctionReceivers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<AzureFunctionReceiver> array = new List<AzureFunctionReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AzureFunctionReceiver.DeserializeAzureFunctionReceiver(item));
                            }
                            azureFunctionReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("armRoleReceivers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ArmRoleReceiver> array = new List<ArmRoleReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ArmRoleReceiver.DeserializeArmRoleReceiver(item));
                            }
                            armRoleReceivers = array;
                            continue;
                        }
                        if (property0.NameEquals("eventHubReceivers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<EventHubReceiver> array = new List<EventHubReceiver>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EventHubReceiver.DeserializeEventHubReceiver(item));
                            }
                            eventHubReceivers = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ActionGroupData(id, name, type, systemData, tags, location, groupShortName.Value, Optional.ToNullable(enabled), Optional.ToList(emailReceivers), Optional.ToList(smsReceivers), Optional.ToList(webhookReceivers), Optional.ToList(itsmReceivers), Optional.ToList(azureAppPushReceivers), Optional.ToList(automationRunbookReceivers), Optional.ToList(voiceReceivers), Optional.ToList(logicAppReceivers), Optional.ToList(azureFunctionReceivers), Optional.ToList(armRoleReceivers), Optional.ToList(eventHubReceivers), kind.Value, identity.Value);
        }
    }
}
