// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor
{
    public partial class MetricPeriodFeedback : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteObjectValue(ValueInternal);
            writer.WritePropertyName("feedbackType"u8);
            writer.WriteStringValue(FeedbackKind.ToString());
            writer.WritePropertyName("metricId"u8);
            writer.WriteStringValue(MetricId);
            writer.WritePropertyName("dimensionFilter"u8);
            writer.WriteObjectValue(DimensionFilter);
            writer.WriteEndObject();
        }

        internal static MetricPeriodFeedback DeserializeMetricPeriodFeedback(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PeriodFeedbackValue value = default;
            MetricFeedbackKind feedbackType = default;
            Core.Optional<string> feedbackId = default;
            Core.Optional<DateTimeOffset> createdTime = default;
            Core.Optional<string> userPrincipal = default;
            string metricId = default;
            FeedbackFilter dimensionFilter = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = PeriodFeedbackValue.DeserializePeriodFeedbackValue(property.Value);
                    continue;
                }
                if (property.NameEquals("feedbackType"u8))
                {
                    feedbackType = new MetricFeedbackKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("feedbackId"u8))
                {
                    feedbackId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("userPrincipal"u8))
                {
                    userPrincipal = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricId"u8))
                {
                    metricId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensionFilter"u8))
                {
                    dimensionFilter = FeedbackFilter.DeserializeFeedbackFilter(property.Value);
                    continue;
                }
            }
            return new MetricPeriodFeedback(feedbackType, feedbackId.Value, Core.Optional.ToNullable(createdTime), userPrincipal.Value, metricId, dimensionFilter, value);
        }
    }
}
