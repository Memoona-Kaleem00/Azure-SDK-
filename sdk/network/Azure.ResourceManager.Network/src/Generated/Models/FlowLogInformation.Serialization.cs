// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FlowLogInformation : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetResourceId"u8);
            writer.WriteStringValue(TargetResourceId);
            if (Core.Optional.IsDefined(FlowAnalyticsConfiguration))
            {
                writer.WritePropertyName("flowAnalyticsConfiguration"u8);
                writer.WriteObjectValue(FlowAnalyticsConfiguration);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("storageId"u8);
            writer.WriteStringValue(StorageId);
            writer.WritePropertyName("enabled"u8);
            writer.WriteBooleanValue(Enabled);
            if (Core.Optional.IsDefined(RetentionPolicy))
            {
                writer.WritePropertyName("retentionPolicy"u8);
                writer.WriteObjectValue(RetentionPolicy);
            }
            if (Core.Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format"u8);
                writer.WriteObjectValue(Format);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FlowLogInformation DeserializeFlowLogInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier targetResourceId = default;
            Core.Optional<TrafficAnalyticsProperties> flowAnalyticsConfiguration = default;
            ResourceIdentifier storageId = default;
            bool enabled = default;
            Core.Optional<RetentionPolicyParameters> retentionPolicy = default;
            Core.Optional<FlowLogProperties> format = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetResourceId"u8))
                {
                    targetResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("flowAnalyticsConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    flowAnalyticsConfiguration = TrafficAnalyticsProperties.DeserializeTrafficAnalyticsProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("storageId"u8))
                        {
                            storageId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("retentionPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retentionPolicy = RetentionPolicyParameters.DeserializeRetentionPolicyParameters(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("format"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            format = FlowLogProperties.DeserializeFlowLogProperties(property0.Value);
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
