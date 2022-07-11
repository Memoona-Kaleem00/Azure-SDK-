// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SnapshotRestoreRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(SnapshotTime))
            {
                writer.WritePropertyName("snapshotTime");
                writer.WriteStringValue(SnapshotTime);
            }
            if (Optional.IsDefined(RecoverySource))
            {
                writer.WritePropertyName("recoverySource");
                writer.WriteObjectValue(RecoverySource);
            }
            if (Optional.IsDefined(IsOverwrite))
            {
                writer.WritePropertyName("overwrite");
                writer.WriteBooleanValue(IsOverwrite.Value);
            }
            if (Optional.IsDefined(IsRecoverConfiguration))
            {
                writer.WritePropertyName("recoverConfiguration");
                writer.WriteBooleanValue(IsRecoverConfiguration.Value);
            }
            if (Optional.IsDefined(IsIgnoreConflictingHostNames))
            {
                writer.WritePropertyName("ignoreConflictingHostNames");
                writer.WriteBooleanValue(IsIgnoreConflictingHostNames.Value);
            }
            if (Optional.IsDefined(UseDRSecondary))
            {
                writer.WritePropertyName("useDRSecondary");
                writer.WriteBooleanValue(UseDRSecondary.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SnapshotRestoreRequest DeserializeSnapshotRestoreRequest(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> snapshotTime = default;
            Optional<SnapshotRecoverySource> recoverySource = default;
            Optional<bool> overwrite = default;
            Optional<bool> recoverConfiguration = default;
            Optional<bool> ignoreConflictingHostNames = default;
            Optional<bool> useDRSecondary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("snapshotTime"))
                        {
                            snapshotTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("recoverySource"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            recoverySource = SnapshotRecoverySource.DeserializeSnapshotRecoverySource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("overwrite"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            overwrite = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("recoverConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            recoverConfiguration = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ignoreConflictingHostNames"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ignoreConflictingHostNames = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("useDRSecondary"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            useDRSecondary = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SnapshotRestoreRequest(id, name, type, systemData.Value, snapshotTime.Value, recoverySource.Value, Optional.ToNullable(overwrite), Optional.ToNullable(recoverConfiguration), Optional.ToNullable(ignoreConflictingHostNames), Optional.ToNullable(useDRSecondary), kind.Value);
        }
    }
}
