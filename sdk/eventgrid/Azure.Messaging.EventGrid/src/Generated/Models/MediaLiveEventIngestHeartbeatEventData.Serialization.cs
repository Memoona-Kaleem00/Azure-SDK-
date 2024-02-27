// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(MediaLiveEventIngestHeartbeatEventDataConverter))]
    public partial class MediaLiveEventIngestHeartbeatEventData
    {
        internal static MediaLiveEventIngestHeartbeatEventData DeserializeMediaLiveEventIngestHeartbeatEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> trackType = default;
            Optional<string> trackName = default;
            Optional<string> transcriptionLanguage = default;
            Optional<string> transcriptionState = default;
            Optional<long> bitrate = default;
            Optional<long> incomingBitrate = default;
            Optional<string> ingestDriftValue = default;
            Optional<DateTimeOffset> lastFragmentArrivalTime = default;
            Optional<string> lastTimestamp = default;
            Optional<string> timescale = default;
            Optional<long> overlapCount = default;
            Optional<long> discontinuityCount = default;
            Optional<long> nonincreasingCount = default;
            Optional<bool> unexpectedBitrate = default;
            Optional<string> state = default;
            Optional<bool> healthy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trackType"u8))
                {
                    trackType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackName"u8))
                {
                    trackName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transcriptionLanguage"u8))
                {
                    transcriptionLanguage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transcriptionState"u8))
                {
                    transcriptionState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bitrate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bitrate = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("incomingBitrate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    incomingBitrate = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("ingestDriftValue"u8))
                {
                    ingestDriftValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastFragmentArrivalTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastFragmentArrivalTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastTimestamp"u8))
                {
                    lastTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timescale"u8))
                {
                    timescale = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("overlapCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    overlapCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("discontinuityCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    discontinuityCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("nonincreasingCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nonincreasingCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("unexpectedBitrate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unexpectedBitrate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthy = property.Value.GetBoolean();
                    continue;
                }
            }
            return new MediaLiveEventIngestHeartbeatEventData(
                trackType.Value,
                trackName.Value,
                transcriptionLanguage.Value,
                transcriptionState.Value,
                Optional.ToNullable(bitrate),
                Optional.ToNullable(incomingBitrate),
                ingestDriftValue.Value,
                Optional.ToNullable(lastFragmentArrivalTime),
                lastTimestamp.Value,
                timescale.Value,
                Optional.ToNullable(overlapCount),
                Optional.ToNullable(discontinuityCount),
                Optional.ToNullable(nonincreasingCount),
                Optional.ToNullable(unexpectedBitrate),
                state.Value,
                Optional.ToNullable(healthy));
        }

        internal partial class MediaLiveEventIngestHeartbeatEventDataConverter : JsonConverter<MediaLiveEventIngestHeartbeatEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaLiveEventIngestHeartbeatEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override MediaLiveEventIngestHeartbeatEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaLiveEventIngestHeartbeatEventData(document.RootElement);
            }
        }
    }
}
