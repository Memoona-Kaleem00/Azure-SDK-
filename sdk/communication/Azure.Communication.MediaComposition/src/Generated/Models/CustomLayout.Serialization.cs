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
    public partial class CustomLayout : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Layers))
            {
                writer.WritePropertyName("layers"u8);
                writer.WriteStartObject();
                foreach (var item in Layers)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue<LayoutLayer>(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("inputGroups"u8);
            writer.WriteStartObject();
            foreach (var item in InputGroups)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue<InputGroup>(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(Resolution))
            {
                writer.WritePropertyName("resolution"u8);
                writer.WriteObjectValue<LayoutResolution>(Resolution);
            }
            if (Optional.IsDefined(PlaceholderImageUri))
            {
                writer.WritePropertyName("placeholderImageUri"u8);
                writer.WriteStringValue(PlaceholderImageUri);
            }
            if (Optional.IsDefined(ScalingMode))
            {
                writer.WritePropertyName("scalingMode"u8);
                writer.WriteStringValue(ScalingMode.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static CustomLayout DeserializeCustomLayout(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, LayoutLayer> layers = default;
            IDictionary<string, InputGroup> inputGroups = default;
            LayoutType kind = default;
            LayoutResolution resolution = default;
            string placeholderImageUri = default;
            ScalingMode? scalingMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("layers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, LayoutLayer> dictionary = new Dictionary<string, LayoutLayer>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, LayoutLayer.DeserializeLayoutLayer(property0.Value));
                    }
                    layers = dictionary;
                    continue;
                }
                if (property.NameEquals("inputGroups"u8))
                {
                    Dictionary<string, InputGroup> dictionary = new Dictionary<string, InputGroup>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, InputGroup.DeserializeInputGroup(property0.Value));
                    }
                    inputGroups = dictionary;
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new LayoutType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resolution"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resolution = LayoutResolution.DeserializeLayoutResolution(property.Value);
                    continue;
                }
                if (property.NameEquals("placeholderImageUri"u8))
                {
                    placeholderImageUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scalingMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scalingMode = new ScalingMode(property.Value.GetString());
                    continue;
                }
            }
            return new CustomLayout(
                kind,
                resolution,
                placeholderImageUri,
                scalingMode,
                layers ?? new ChangeTrackingDictionary<string, LayoutLayer>(),
                inputGroups);
        }
    }
}
