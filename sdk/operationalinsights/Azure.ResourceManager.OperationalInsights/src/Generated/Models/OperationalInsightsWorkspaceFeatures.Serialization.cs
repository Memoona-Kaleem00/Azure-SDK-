// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsWorkspaceFeatures : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(IsDataExportEnabled))
            {
                if (IsDataExportEnabled != null)
                {
                    writer.WritePropertyName("enableDataExport"u8);
                    writer.WriteBooleanValue(IsDataExportEnabled.Value);
                }
                else
                {
                    writer.WriteNull("enableDataExport");
                }
            }
            if (Core.Optional.IsDefined(ImmediatePurgeDataOn30Days))
            {
                if (ImmediatePurgeDataOn30Days != null)
                {
                    writer.WritePropertyName("immediatePurgeDataOn30Days"u8);
                    writer.WriteBooleanValue(ImmediatePurgeDataOn30Days.Value);
                }
                else
                {
                    writer.WriteNull("immediatePurgeDataOn30Days");
                }
            }
            if (Core.Optional.IsDefined(IsLogAccessUsingOnlyResourcePermissionsEnabled))
            {
                if (IsLogAccessUsingOnlyResourcePermissionsEnabled != null)
                {
                    writer.WritePropertyName("enableLogAccessUsingOnlyResourcePermissions"u8);
                    writer.WriteBooleanValue(IsLogAccessUsingOnlyResourcePermissionsEnabled.Value);
                }
                else
                {
                    writer.WriteNull("enableLogAccessUsingOnlyResourcePermissions");
                }
            }
            if (Core.Optional.IsDefined(ClusterResourceId))
            {
                if (ClusterResourceId != null)
                {
                    writer.WritePropertyName("clusterResourceId"u8);
                    writer.WriteStringValue(ClusterResourceId);
                }
                else
                {
                    writer.WriteNull("clusterResourceId");
                }
            }
            if (Core.Optional.IsDefined(IsLocalAuthDisabled))
            {
                if (IsLocalAuthDisabled != null)
                {
                    writer.WritePropertyName("disableLocalAuth"u8);
                    writer.WriteBooleanValue(IsLocalAuthDisabled.Value);
                }
                else
                {
                    writer.WriteNull("disableLocalAuth");
                }
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static OperationalInsightsWorkspaceFeatures DeserializeOperationalInsightsWorkspaceFeatures(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<bool?> enableDataExport = default;
            Core.Optional<bool?> immediatePurgeDataOn30Days = default;
            Core.Optional<bool?> enableLogAccessUsingOnlyResourcePermissions = default;
            Core.Optional<ResourceIdentifier> clusterResourceId = default;
            Core.Optional<bool?> disableLocalAuth = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableDataExport"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableDataExport = null;
                        continue;
                    }
                    enableDataExport = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("immediatePurgeDataOn30Days"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        immediatePurgeDataOn30Days = null;
                        continue;
                    }
                    immediatePurgeDataOn30Days = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableLogAccessUsingOnlyResourcePermissions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableLogAccessUsingOnlyResourcePermissions = null;
                        continue;
                    }
                    enableLogAccessUsingOnlyResourcePermissions = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("clusterResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clusterResourceId = null;
                        continue;
                    }
                    clusterResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("disableLocalAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        disableLocalAuth = null;
                        continue;
                    }
                    disableLocalAuth = property.Value.GetBoolean();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new OperationalInsightsWorkspaceFeatures(Core.Optional.ToNullable(enableDataExport), Core.Optional.ToNullable(immediatePurgeDataOn30Days), Core.Optional.ToNullable(enableLogAccessUsingOnlyResourcePermissions), clusterResourceId.Value, Core.Optional.ToNullable(disableLocalAuth), additionalProperties);
        }
    }
}
