// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class LiveEventOutputTranscriptionTrack : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("trackName");
            writer.WriteStringValue(TrackName);
            writer.WriteEndObject();
        }

        internal static LiveEventOutputTranscriptionTrack DeserializeLiveEventOutputTranscriptionTrack(JsonElement element)
        {
            string trackName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trackName"))
                {
                    trackName = property.Value.GetString();
                    continue;
                }
            }
            return new LiveEventOutputTranscriptionTrack(trackName);
        }
    }
}
