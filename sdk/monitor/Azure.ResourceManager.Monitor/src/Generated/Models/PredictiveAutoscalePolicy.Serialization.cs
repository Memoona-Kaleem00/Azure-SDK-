// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class PredictiveAutoscalePolicy : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("scaleMode"u8);
            writer.WriteStringValue(ScaleMode.ToSerialString());
            if (Core.Optional.IsDefined(ScaleLookAheadTime))
            {
                writer.WritePropertyName("scaleLookAheadTime"u8);
                writer.WriteStringValue(ScaleLookAheadTime.Value, "P");
            }
            writer.WriteEndObject();
        }

        internal static PredictiveAutoscalePolicy DeserializePredictiveAutoscalePolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PredictiveAutoscalePolicyScaleMode scaleMode = default;
            Core.Optional<TimeSpan> scaleLookAheadTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scaleMode"u8))
                {
                    scaleMode = property.Value.GetString().ToPredictiveAutoscalePolicyScaleMode();
                    continue;
                }
                if (property.NameEquals("scaleLookAheadTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scaleLookAheadTime = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new PredictiveAutoscalePolicy(scaleMode, Core.Optional.ToNullable(scaleLookAheadTime));
        }
    }
}
