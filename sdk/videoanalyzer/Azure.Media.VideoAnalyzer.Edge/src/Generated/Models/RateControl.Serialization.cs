// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class RateControl : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BitRateLimit))
            {
                writer.WritePropertyName("bitRateLimit");
                writer.WriteNumberValue(BitRateLimit.Value);
            }
            if (Optional.IsDefined(EncodingInterval))
            {
                writer.WritePropertyName("encodingInterval");
                writer.WriteNumberValue(EncodingInterval.Value);
            }
            if (Optional.IsDefined(FrameRateLimit))
            {
                writer.WritePropertyName("frameRateLimit");
                writer.WriteNumberValue(FrameRateLimit.Value);
            }
            if (Optional.IsDefined(GuaranteedFrameRate))
            {
                writer.WritePropertyName("guaranteedFrameRate");
                writer.WriteBooleanValue(GuaranteedFrameRate.Value);
            }
            writer.WriteEndObject();
        }

        internal static RateControl DeserializeRateControl(JsonElement element)
        {
            Optional<float> bitRateLimit = default;
            Optional<float> encodingInterval = default;
            Optional<float> frameRateLimit = default;
            Optional<bool> guaranteedFrameRate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bitRateLimit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    bitRateLimit = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("encodingInterval"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    encodingInterval = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("frameRateLimit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    frameRateLimit = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("guaranteedFrameRate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    guaranteedFrameRate = property.Value.GetBoolean();
                    continue;
                }
            }
            return new RateControl(Optional.ToNullable(bitRateLimit), Optional.ToNullable(encodingInterval), Optional.ToNullable(frameRateLimit), Optional.ToNullable(guaranteedFrameRate));
        }
    }
}
