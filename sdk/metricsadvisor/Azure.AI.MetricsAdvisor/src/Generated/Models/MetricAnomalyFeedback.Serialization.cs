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
    public partial class MetricAnomalyFeedback : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartsOn, "O");
            writer.WritePropertyName("endTime"u8);
            writer.WriteStringValue(EndsOn, "O");
            writer.WritePropertyName("value"u8);
            writer.WriteObjectValue(ValueInternal);
            if (DetectionConfigurationId != null)
            {
                if (DetectionConfigurationId != null)
                {
                    writer.WritePropertyName("anomalyDetectionConfigurationId"u8);
                    writer.WriteStringValue(DetectionConfigurationId);
                }
                else
                {
                    writer.WriteNull("anomalyDetectionConfigurationId");
                }
            }
            if (DetectionConfigurationSnapshot != null)
            {
                if (DetectionConfigurationSnapshot != null)
                {
                    writer.WritePropertyName("anomalyDetectionConfigurationSnapshot"u8);
                    writer.WriteObjectValue(DetectionConfigurationSnapshot);
                }
                else
                {
                    writer.WriteNull("anomalyDetectionConfigurationSnapshot");
                }
            }
            writer.WritePropertyName("feedbackType"u8);
            writer.WriteStringValue(FeedbackKind.ToString());
            writer.WritePropertyName("metricId"u8);
            writer.WriteStringValue(MetricId);
            writer.WritePropertyName("dimensionFilter"u8);
            writer.WriteObjectValue(DimensionFilter);
            writer.WriteEndObject();
        }

        internal static MetricAnomalyFeedback DeserializeMetricAnomalyFeedback(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset startTime = default;
            DateTimeOffset endTime = default;
            AnomalyFeedbackValue value = default;
            Optional<string> anomalyDetectionConfigurationId = default;
            Optional<AnomalyDetectionConfiguration> anomalyDetectionConfigurationSnapshot = default;
            MetricFeedbackKind feedbackType = default;
            Optional<string> feedbackId = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<string> userPrincipal = default;
            string metricId = default;
            FeedbackFilter dimensionFilter = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = AnomalyFeedbackValue.DeserializeAnomalyFeedbackValue(property.Value);
                    continue;
                }
                if (property.NameEquals("anomalyDetectionConfigurationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        anomalyDetectionConfigurationId = null;
                        continue;
                    }
                    anomalyDetectionConfigurationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("anomalyDetectionConfigurationSnapshot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        anomalyDetectionConfigurationSnapshot = null;
                        continue;
                    }
                    anomalyDetectionConfigurationSnapshot = AnomalyDetectionConfiguration.DeserializeAnomalyDetectionConfiguration(property.Value);
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
            return new MetricAnomalyFeedback(feedbackType, feedbackId.Value, Optional.ToNullable(createdTime), userPrincipal.Value, metricId, dimensionFilter, startTime, endTime, value, anomalyDetectionConfigurationId.Value, anomalyDetectionConfigurationSnapshot.Value);
        }
    }
}
