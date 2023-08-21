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
    public partial class MetricCommentFeedback : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(StartsOn))
            {
                if (StartsOn != null)
                {
                    writer.WritePropertyName("startTime"u8);
                    writer.WriteStringValue(StartsOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("startTime");
                }
            }
            if (Core.Optional.IsDefined(EndsOn))
            {
                if (EndsOn != null)
                {
                    writer.WritePropertyName("endTime"u8);
                    writer.WriteStringValue(EndsOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("endTime");
                }
            }
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

        internal static MetricCommentFeedback DeserializeMetricCommentFeedback(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DateTimeOffset?> startTime = default;
            Core.Optional<DateTimeOffset?> endTime = default;
            CommentFeedbackValue value = default;
            MetricFeedbackKind feedbackType = default;
            Core.Optional<string> feedbackId = default;
            Core.Optional<DateTimeOffset> createdTime = default;
            Core.Optional<string> userPrincipal = default;
            string metricId = default;
            FeedbackFilter dimensionFilter = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startTime = null;
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endTime = null;
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = CommentFeedbackValue.DeserializeCommentFeedbackValue(property.Value);
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
            return new MetricCommentFeedback(feedbackType, feedbackId.Value, Core.Optional.ToNullable(createdTime), userPrincipal.Value, metricId, dimensionFilter, Core.Optional.ToNullable(startTime), Core.Optional.ToNullable(endTime), value);
        }
    }
}
