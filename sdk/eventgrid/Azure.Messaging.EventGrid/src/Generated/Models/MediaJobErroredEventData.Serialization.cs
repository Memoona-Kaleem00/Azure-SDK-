// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Messaging.EventGrid;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(MediaJobErroredEventDataConverter))]
    public partial class MediaJobErroredEventData
    {
        internal static MediaJobErroredEventData DeserializeMediaJobErroredEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<MediaJobOutput> outputs = default;
            MediaJobState? previousState = default;
            MediaJobState? state = default;
            IReadOnlyDictionary<string, string> correlationData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("outputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaJobOutput> array = new List<MediaJobOutput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaJobOutput.DeserializeMediaJobOutput(item));
                    }
                    outputs = array;
                    continue;
                }
                if (property.NameEquals("previousState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    previousState = property.Value.GetString().ToMediaJobState();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = property.Value.GetString().ToMediaJobState();
                    continue;
                }
                if (property.NameEquals("correlationData"u8))
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
                    correlationData = dictionary;
                    continue;
                }
            }
            return new MediaJobErroredEventData(previousState, state, correlationData ?? new ChangeTrackingDictionary<string, string>(), outputs ?? new ChangeTrackingList<MediaJobOutput>());
        }

        internal partial class MediaJobErroredEventDataConverter : JsonConverter<MediaJobErroredEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaJobErroredEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override MediaJobErroredEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaJobErroredEventData(document.RootElement);
            }
        }
    }
}
