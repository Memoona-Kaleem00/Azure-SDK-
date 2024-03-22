// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    public partial class TimeSeriesInterpolation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Optional.IsDefined(Boundary))
            {
                writer.WritePropertyName("boundary"u8);
                writer.WriteObjectValue<InterpolationBoundary>(Boundary);
            }
            writer.WriteEndObject();
        }

        internal static TimeSeriesInterpolation DeserializeTimeSeriesInterpolation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InterpolationKind? kind = default;
            InterpolationBoundary boundary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new InterpolationKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("boundary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    boundary = InterpolationBoundary.DeserializeInterpolationBoundary(property.Value);
                    continue;
                }
            }
            return new TimeSeriesInterpolation(kind, boundary);
        }
    }
}
