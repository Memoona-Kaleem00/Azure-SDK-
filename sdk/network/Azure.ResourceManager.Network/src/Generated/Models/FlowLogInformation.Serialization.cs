// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FlowLogInformation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetResourceId");
            writer.WriteStringValue(TargetResourceId);
            if (Optional.IsDefined(FlowAnalyticsConfiguration))
            {
                writer.WritePropertyName("flowAnalyticsConfiguration");
                writer.WriteObjectValue(FlowAnalyticsConfiguration);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("storageId");
            writer.WriteStringValue(StorageId);
            writer.WritePropertyName("enabled");
            writer.WriteBooleanValue(Enabled);
            if (Optional.IsDefined(RetentionPolicy))
            {
                writer.WritePropertyName("retentionPolicy");
                writer.WriteObjectValue(RetentionPolicy);
            }
            if (Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format");
                writer.WriteObjectValue(Format);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FlowLogInformation DeserializeFlowLogInformation(JsonElement element)
        {
            string targetResourceId = default;
            Optional<TrafficAnalyticsProperties> flowAnalyticsConfiguration = default;
            string storageId = default;
            bool enabled = default;
            Optional<RetentionPolicyParameters> retentionPolicy = default;
            Optional<FlowLogFormatParameters> format = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetResourceId"))
                {
                    targetResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("flowAnalyticsConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    flowAnalyticsConfiguration = TrafficAnalyticsProperties.DeserializeTrafficAnalyticsProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("storageId"))
                        {
                            storageId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enabled"))
                        {
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("retentionPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            retentionPolicy = RetentionPolicyParameters.DeserializeRetentionPolicyParameters(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("format"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            format = FlowLogFormatParameters.DeserializeFlowLogFormatParameters(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FlowLogInformation(targetResourceId, flowAnalyticsConfiguration.Value, storageId, enabled, retentionPolicy.Value, format.Value);
        }
    }
}
