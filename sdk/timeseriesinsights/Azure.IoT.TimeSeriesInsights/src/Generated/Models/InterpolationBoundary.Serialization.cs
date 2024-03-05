// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    public partial class InterpolationBoundary : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Span))
            {
                writer.WritePropertyName("span"u8);
                writer.WriteStringValue(Span.Value, "P");
            }
            writer.WriteEndObject();
        }

        internal static InterpolationBoundary DeserializeInterpolationBoundary(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSpan? span = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("span"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    span = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new InterpolationBoundary(span);
        }
    }
}
