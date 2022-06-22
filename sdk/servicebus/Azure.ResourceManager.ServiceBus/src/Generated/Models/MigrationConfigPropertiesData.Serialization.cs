// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ServiceBus
{
    public partial class MigrationConfigPropertiesData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetNamespace))
            {
                writer.WritePropertyName("targetNamespace");
                writer.WriteStringValue(TargetNamespace);
            }
            if (Optional.IsDefined(PostMigrationName))
            {
                writer.WritePropertyName("postMigrationName");
                writer.WriteStringValue(PostMigrationName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MigrationConfigPropertiesData DeserializeMigrationConfigPropertiesData(JsonElement element)
        {
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> provisioningState = default;
            Optional<long> pendingReplicationOperationsCount = default;
            Optional<string> targetNamespace = default;
            Optional<string> postMigrationName = default;
            Optional<string> migrationState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("pendingReplicationOperationsCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            pendingReplicationOperationsCount = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("targetNamespace"))
                        {
                            targetNamespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("postMigrationName"))
                        {
                            postMigrationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("migrationState"))
                        {
                            migrationState = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MigrationConfigPropertiesData(id, name, type, systemData.Value, provisioningState.Value, Optional.ToNullable(pendingReplicationOperationsCount), targetNamespace.Value, postMigrationName.Value, migrationState.Value, Optional.ToNullable(location));
        }
    }
}
