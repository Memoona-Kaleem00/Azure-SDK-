// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.Chat
{
    internal partial class ChatParticipantInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("communicationIdentifier"u8);
            writer.WriteObjectValue(CommunicationIdentifier);
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (ShareHistoryTime.HasValue)
            {
                writer.WritePropertyName("shareHistoryTime"u8);
                writer.WriteStringValue(ShareHistoryTime.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static ChatParticipantInternal DeserializeChatParticipantInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CommunicationIdentifierModel communicationIdentifier = default;
            string displayName = default;
            DateTimeOffset? shareHistoryTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("communicationIdentifier"u8))
                {
                    communicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shareHistoryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shareHistoryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ChatParticipantInternal(communicationIdentifier, displayName, shareHistoryTime);
        }
    }
}
