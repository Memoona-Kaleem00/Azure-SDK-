// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    public partial class MediaCompositionBody : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Layout))
            {
                writer.WritePropertyName("layout");
                writer.WriteObjectValue(Layout);
            }
            if (Optional.IsCollectionDefined(MediaInputs))
            {
                writer.WritePropertyName("mediaInputs");
                writer.WriteStartObject();
                foreach (var item in MediaInputs)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(MediaOutputs))
            {
                writer.WritePropertyName("mediaOutputs");
                writer.WriteStartObject();
                foreach (var item in MediaOutputs)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Sources))
            {
                writer.WritePropertyName("sources");
                writer.WriteStartObject();
                foreach (var item in Sources)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(StreamState))
            {
                writer.WritePropertyName("streamState");
                writer.WriteStringValue(StreamState.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static MediaCompositionBody DeserializeMediaCompositionBody(JsonElement element)
        {
            Optional<string> id = default;
            Optional<MediaLayout> layout = default;
            Optional<IDictionary<string, MediaInput>> mediaInputs = default;
            Optional<IDictionary<string, MediaOutput>> mediaOutputs = default;
            Optional<IDictionary<string, MediaSource>> sources = default;
            Optional<CompositionStreamState> streamState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("layout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    layout = MediaLayout.DeserializeMediaLayout(property.Value);
                    continue;
                }
                if (property.NameEquals("mediaInputs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, MediaInput> dictionary = new Dictionary<string, MediaInput>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MediaInput.DeserializeMediaInput(property0.Value));
                    }
                    mediaInputs = dictionary;
                    continue;
                }
                if (property.NameEquals("mediaOutputs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, MediaOutput> dictionary = new Dictionary<string, MediaOutput>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MediaOutput.DeserializeMediaOutput(property0.Value));
                    }
                    mediaOutputs = dictionary;
                    continue;
                }
                if (property.NameEquals("sources"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, MediaSource> dictionary = new Dictionary<string, MediaSource>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MediaSource.DeserializeMediaSource(property0.Value));
                    }
                    sources = dictionary;
                    continue;
                }
                if (property.NameEquals("streamState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    streamState = new CompositionStreamState(property.Value.GetString());
                    continue;
                }
            }
            return new MediaCompositionBody(id.Value, layout.Value, Optional.ToDictionary(mediaInputs), Optional.ToDictionary(mediaOutputs), Optional.ToDictionary(sources), Optional.ToNullable(streamState));
        }
    }
}
