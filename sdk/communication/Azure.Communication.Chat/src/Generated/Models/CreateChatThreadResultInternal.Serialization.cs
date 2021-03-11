// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Chat
{
    internal partial class CreateChatThreadResultInternal
    {
        internal static CreateChatThreadResultInternal DeserializeCreateChatThreadResultInternal(JsonElement element)
        {
            Optional<ChatThreadPropertiesInternal> chatThread = default;
            Optional<IReadOnlyList<CommunicationError>> invalidParticipants = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("chatThread"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    chatThread = ChatThreadPropertiesInternal.DeserializeChatThreadPropertiesInternal(property.Value);
                    continue;
                }
                if (property.NameEquals("invalidParticipants"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CommunicationError> array = new List<CommunicationError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CommunicationError.DeserializeCommunicationError(item));
                    }
                    invalidParticipants = array;
                    continue;
                }
            }
            return new CreateChatThreadResultInternal(chatThread.Value, Optional.ToList(invalidParticipants));
        }
    }
}
