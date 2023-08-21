// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class TrafficAnalyticsConfigurationProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Core.Optional.IsDefined(WorkspaceId))
            {
                writer.WritePropertyName("workspaceId"u8);
                writer.WriteStringValue(WorkspaceId);
            }
            if (Core.Optional.IsDefined(WorkspaceRegion))
            {
                writer.WritePropertyName("workspaceRegion"u8);
                writer.WriteStringValue(WorkspaceRegion);
            }
            if (Core.Optional.IsDefined(WorkspaceResourceId))
            {
                writer.WritePropertyName("workspaceResourceId"u8);
                writer.WriteStringValue(WorkspaceResourceId);
            }
            if (Core.Optional.IsDefined(TrafficAnalyticsIntervalInMinutes))
            {
                writer.WritePropertyName("trafficAnalyticsInterval"u8);
                writer.WriteNumberValue(TrafficAnalyticsIntervalInMinutes.Value);
            }
            writer.WriteEndObject();
        }

        internal static TrafficAnalyticsConfigurationProperties DeserializeTrafficAnalyticsConfigurationProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<bool> enabled = default;
            Core.Optional<string> workspaceId = default;
            Core.Optional<string> workspaceRegion = default;
            Core.Optional<ResourceIdentifier> workspaceResourceId = default;
            Core.Optional<int> trafficAnalyticsInterval = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("workspaceId"u8))
                {
                    workspaceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceRegion"u8))
                {
                    workspaceRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trafficAnalyticsInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trafficAnalyticsInterval = property.Value.GetInt32();
                    continue;
                }
            }
            return new TrafficAnalyticsConfigurationProperties(Core.Optional.ToNullable(enabled), workspaceId.Value, workspaceRegion.Value, workspaceResourceId.Value, Core.Optional.ToNullable(trafficAnalyticsInterval));
        }
    }
}
