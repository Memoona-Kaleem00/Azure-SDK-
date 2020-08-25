// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.AnomalyDetector.Models
{
    public partial class ChangePointDetectRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("series");
            writer.WriteStartArray();
            foreach (var item in Series)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("granularity");
            writer.WriteStringValue(Granularity.ToSerialString());
            if (Optional.IsDefined(CustomInterval))
            {
                writer.WritePropertyName("customInterval");
                writer.WriteNumberValue(CustomInterval.Value);
            }
            if (Optional.IsDefined(Period))
            {
                writer.WritePropertyName("period");
                writer.WriteNumberValue(Period.Value);
            }
            if (Optional.IsDefined(StableTrendWindow))
            {
                writer.WritePropertyName("stableTrendWindow");
                writer.WriteNumberValue(StableTrendWindow.Value);
            }
            if (Optional.IsDefined(Threshold))
            {
                writer.WritePropertyName("threshold");
                writer.WriteNumberValue(Threshold.Value);
            }
            writer.WriteEndObject();
        }
    }
}
