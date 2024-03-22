// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class ImageProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Scale))
            {
                writer.WritePropertyName("scale"u8);
                writer.WriteObjectValue<ImageScale>(Scale);
            }
            if (Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format"u8);
                writer.WriteObjectValue<ImageFormatProperties>(Format);
            }
            writer.WriteEndObject();
        }

        internal static ImageProperties DeserializeImageProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ImageScale scale = default;
            ImageFormatProperties format = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scale = ImageScale.DeserializeImageScale(property.Value);
                    continue;
                }
                if (property.NameEquals("format"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    format = ImageFormatProperties.DeserializeImageFormatProperties(property.Value);
                    continue;
                }
            }
            return new ImageProperties(scale, format);
        }
    }
}
