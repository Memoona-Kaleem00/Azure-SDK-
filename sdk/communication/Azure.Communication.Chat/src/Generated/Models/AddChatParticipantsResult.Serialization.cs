// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Chat
{
    public partial class AddChatParticipantsResult
    {
        internal static AddChatParticipantsResult DeserializeAddChatParticipantsResult(JsonElement element)
        {
            Optional<IReadOnlyList<CommunicationError>> invalidParticipants = default;
            foreach (var property in element.EnumerateObject())
            {
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
            return new AddChatParticipantsResult(Optional.ToList(invalidParticipants));
        }
    }
}
