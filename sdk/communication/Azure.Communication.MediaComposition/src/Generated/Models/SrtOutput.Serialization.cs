// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    public partial class SrtOutput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("resolution"u8);
            writer.WriteObjectValue<LayoutResolution>(Resolution);
            writer.WritePropertyName("streamUrl"u8);
            writer.WriteStringValue(StreamUrl);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WriteEndObject();
        }

        internal static SrtOutput DeserializeSrtOutput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LayoutResolution resolution = default;
            string streamUrl = default;
            MediaOutputType kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resolution"u8))
                {
                    resolution = LayoutResolution.DeserializeLayoutResolution(property.Value);
                    continue;
                }
                if (property.NameEquals("streamUrl"u8))
                {
                    streamUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new MediaOutputType(property.Value.GetString());
                    continue;
                }
            }
            return new SrtOutput(kind, resolution, streamUrl);
        }
    }
}
