// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.Analytics.Edge.Models
{
    public partial class MediaGraphImageFormatJpeg : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Quality))
            {
                writer.WritePropertyName("quality");
                writer.WriteStringValue(Quality);
            }
            writer.WritePropertyName("@type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static MediaGraphImageFormatJpeg DeserializeMediaGraphImageFormatJpeg(JsonElement element)
        {
            Optional<string> quality = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("quality"))
                {
                    quality = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new MediaGraphImageFormatJpeg(type, quality.Value);
        }
    }
}
