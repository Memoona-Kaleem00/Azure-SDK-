// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorArmRoleReceiver : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("roleId"u8);
            writer.WriteStringValue(RoleId);
            if (Core.Optional.IsDefined(UseCommonAlertSchema))
            {
                writer.WritePropertyName("useCommonAlertSchema"u8);
                writer.WriteBooleanValue(UseCommonAlertSchema.Value);
            }
            writer.WriteEndObject();
        }

        internal static MonitorArmRoleReceiver DeserializeMonitorArmRoleReceiver(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string roleId = default;
            Core.Optional<bool> useCommonAlertSchema = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roleId"u8))
                {
                    roleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("useCommonAlertSchema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useCommonAlertSchema = property.Value.GetBoolean();
                    continue;
                }
            }
            return new MonitorArmRoleReceiver(name, roleId, Core.Optional.ToNullable(useCommonAlertSchema));
        }
    }
}
