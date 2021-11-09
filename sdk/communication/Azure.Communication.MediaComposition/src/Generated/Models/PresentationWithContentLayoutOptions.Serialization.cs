// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    public partial class PresentationWithContentLayoutOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ContentSourceId))
            {
                writer.WritePropertyName("contentSourceId");
                writer.WriteStringValue(ContentSourceId);
            }
            if (Optional.IsDefined(PresenterSourceId))
            {
                writer.WritePropertyName("presenterSourceId");
                writer.WriteStringValue(PresenterSourceId);
            }
            writer.WriteEndObject();
        }

        internal static PresentationWithContentLayoutOptions DeserializePresentationWithContentLayoutOptions(JsonElement element)
        {
            Optional<string> contentSourceId = default;
            Optional<string> presenterSourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contentSourceId"))
                {
                    contentSourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("presenterSourceId"))
                {
                    presenterSourceId = property.Value.GetString();
                    continue;
                }
            }
            return new PresentationWithContentLayoutOptions(contentSourceId.Value, presenterSourceId.Value);
        }
    }
}
