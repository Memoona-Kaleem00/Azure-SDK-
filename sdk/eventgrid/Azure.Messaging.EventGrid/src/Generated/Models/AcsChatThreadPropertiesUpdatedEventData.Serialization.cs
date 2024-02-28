// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsChatThreadPropertiesUpdatedEventDataConverter))]
    public partial class AcsChatThreadPropertiesUpdatedEventData
    {
        internal static AcsChatThreadPropertiesUpdatedEventData DeserializeAcsChatThreadPropertiesUpdatedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CommunicationIdentifierModel editedByCommunicationIdentifier = default;
            DateTimeOffset? editTime = default;
            IReadOnlyDictionary<string, object> properties = default;
            IReadOnlyDictionary<string, string> metadata = default;
            DateTimeOffset? createTime = default;
            long? version = default;
            string transactionId = default;
            string threadId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("editedByCommunicationIdentifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    editedByCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("editTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    editTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("metadata"u8))
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
                    metadata = dictionary;
                    continue;
                }
                if (property.NameEquals("createTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("transactionId"u8))
                {
                    transactionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("threadId"u8))
                {
                    threadId = property.Value.GetString();
                    continue;
                }
            }
            return new AcsChatThreadPropertiesUpdatedEventData(
                transactionId,
                threadId,
                createTime,
                version,
                editedByCommunicationIdentifier,
                editTime,
                properties ?? new ChangeTrackingDictionary<string, object>(),
                metadata ?? new ChangeTrackingDictionary<string, string>());
        }

        internal partial class AcsChatThreadPropertiesUpdatedEventDataConverter : JsonConverter<AcsChatThreadPropertiesUpdatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsChatThreadPropertiesUpdatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override AcsChatThreadPropertiesUpdatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsChatThreadPropertiesUpdatedEventData(document.RootElement);
            }
        }
    }
}
