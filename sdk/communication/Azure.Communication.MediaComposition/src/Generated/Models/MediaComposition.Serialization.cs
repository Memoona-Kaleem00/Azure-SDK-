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
    public partial class MediaComposition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Layout))
            {
                writer.WritePropertyName("layout"u8);
                writer.WriteObjectValue<MediaCompositionLayout>(Layout);
            }
            if (Optional.IsCollectionDefined(Inputs))
            {
                writer.WritePropertyName("inputs"u8);
                writer.WriteStartObject();
                foreach (var item in Inputs)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue<MediaInput>(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Outputs))
            {
                writer.WritePropertyName("outputs"u8);
                writer.WriteStartObject();
                foreach (var item in Outputs)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue<MediaOutput>(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(StreamState))
            {
                writer.WritePropertyName("streamState"u8);
                writer.WriteObjectValue<CompositionStreamState>(StreamState);
            }
            writer.WriteEndObject();
        }

        internal static MediaComposition DeserializeMediaComposition(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            MediaCompositionLayout layout = default;
            IDictionary<string, MediaInput> inputs = default;
            IDictionary<string, MediaOutput> outputs = default;
            CompositionStreamState streamState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("layout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    layout = MediaCompositionLayout.DeserializeMediaCompositionLayout(property.Value);
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, MediaInput> dictionary = new Dictionary<string, MediaInput>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MediaInput.DeserializeMediaInput(property0.Value));
                    }
                    inputs = dictionary;
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, MediaOutput> dictionary = new Dictionary<string, MediaOutput>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MediaOutput.DeserializeMediaOutput(property0.Value));
                    }
                    outputs = dictionary;
                    continue;
                }
                if (property.NameEquals("streamState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    streamState = CompositionStreamState.DeserializeCompositionStreamState(property.Value);
                    continue;
                }
            }
            return new MediaComposition(id, layout, inputs ?? new ChangeTrackingDictionary<string, MediaInput>(), outputs ?? new ChangeTrackingDictionary<string, MediaOutput>(), streamState);
        }
    }
}
