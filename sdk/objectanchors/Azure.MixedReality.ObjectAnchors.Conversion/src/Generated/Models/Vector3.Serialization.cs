// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.MixedReality.ObjectAnchors.Conversion.Models
{
    internal partial class Vector3 : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("x"u8);
            writer.WriteNumberValue(X);
            writer.WritePropertyName("y"u8);
            writer.WriteNumberValue(Y);
            writer.WritePropertyName("z"u8);
            writer.WriteNumberValue(Z);
            writer.WriteEndObject();
        }

        internal static Vector3 DeserializeVector3(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float x = default;
            float y = default;
            float z = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("x"u8))
                {
                    x = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("y"u8))
                {
                    y = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("z"u8))
                {
                    z = property.Value.GetSingle();
                    continue;
                }
            }
            return new Vector3(x, y, z);
        }
    }
}
