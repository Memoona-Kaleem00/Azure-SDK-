// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class SubscriptionStateOverrideAction : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("state"u8);
            writer.WriteStringValue(State.ToString());
            writer.WritePropertyName("action"u8);
            writer.WriteStringValue(Action.ToString());
            writer.WriteEndObject();
        }

        internal static SubscriptionStateOverrideAction DeserializeSubscriptionStateOverrideAction(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SubscriptionTransitioningState state = default;
            SubscriptionNotificationOperation action = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    state = new SubscriptionTransitioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    action = new SubscriptionNotificationOperation(property.Value.GetString());
                    continue;
                }
            }
            return new SubscriptionStateOverrideAction(state, action);
        }
    }
}
