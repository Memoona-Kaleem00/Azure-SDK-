// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.MySql.FlexibleServers.Models;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    public partial class MySqlFlexibleServerData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Core.Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Core.Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(AdministratorLogin))
            {
                writer.WritePropertyName("administratorLogin"u8);
                writer.WriteStringValue(AdministratorLogin);
            }
            if (Core.Optional.IsDefined(AdministratorLoginPassword))
            {
                writer.WritePropertyName("administratorLoginPassword"u8);
                writer.WriteStringValue(AdministratorLoginPassword);
            }
            if (Core.Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version.Value.ToString());
            }
            if (Core.Optional.IsDefined(AvailabilityZone))
            {
                writer.WritePropertyName("availabilityZone"u8);
                writer.WriteStringValue(AvailabilityZone);
            }
            if (Core.Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            if (Core.Optional.IsDefined(SourceServerResourceId))
            {
                writer.WritePropertyName("sourceServerResourceId"u8);
                writer.WriteStringValue(SourceServerResourceId);
            }
            if (Core.Optional.IsDefined(RestorePointInTime))
            {
                writer.WritePropertyName("restorePointInTime"u8);
                writer.WriteStringValue(RestorePointInTime.Value, "O");
            }
            if (Core.Optional.IsDefined(ReplicationRole))
            {
                writer.WritePropertyName("replicationRole"u8);
                writer.WriteStringValue(ReplicationRole.Value.ToString());
            }
            if (Core.Optional.IsDefined(DataEncryption))
            {
                writer.WritePropertyName("dataEncryption"u8);
                writer.WriteObjectValue(DataEncryption);
            }
            if (Core.Optional.IsDefined(Storage))
            {
                writer.WritePropertyName("storage"u8);
                writer.WriteObjectValue(Storage);
            }
            if (Core.Optional.IsDefined(Backup))
            {
                writer.WritePropertyName("backup"u8);
                writer.WriteObjectValue(Backup);
            }
            if (Core.Optional.IsDefined(HighAvailability))
            {
                writer.WritePropertyName("highAvailability"u8);
                writer.WriteObjectValue(HighAvailability);
            }
            if (Core.Optional.IsDefined(Network))
            {
                writer.WritePropertyName("network"u8);
                writer.WriteObjectValue(Network);
            }
            if (Core.Optional.IsDefined(MaintenanceWindow))
            {
                writer.WritePropertyName("maintenanceWindow"u8);
                writer.WriteObjectValue(MaintenanceWindow);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MySqlFlexibleServerData DeserializeMySqlFlexibleServerData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ManagedServiceIdentity> identity = default;
            Core.Optional<MySqlFlexibleServerSku> sku = default;
            Core.Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<string> administratorLogin = default;
            Core.Optional<string> administratorLoginPassword = default;
            Core.Optional<MySqlFlexibleServerVersion> version = default;
            Core.Optional<string> availabilityZone = default;
            Core.Optional<MySqlFlexibleServerCreateMode> createMode = default;
            Core.Optional<ResourceIdentifier> sourceServerResourceId = default;
            Core.Optional<DateTimeOffset> restorePointInTime = default;
            Core.Optional<MySqlFlexibleServerReplicationRole> replicationRole = default;
            Core.Optional<int> replicaCapacity = default;
            Core.Optional<MySqlFlexibleServerDataEncryption> dataEncryption = default;
            Core.Optional<MySqlFlexibleServerState> state = default;
            Core.Optional<string> fullyQualifiedDomainName = default;
            Core.Optional<MySqlFlexibleServerStorage> storage = default;
            Core.Optional<MySqlFlexibleServerBackupProperties> backup = default;
            Core.Optional<MySqlFlexibleServerHighAvailability> highAvailability = default;
            Core.Optional<MySqlFlexibleServerNetwork> network = default;
            Core.Optional<MySqlFlexibleServerMaintenanceWindow> maintenanceWindow = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = MySqlFlexibleServerSku.DeserializeMySqlFlexibleServerSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("administratorLogin"u8))
                        {
                            administratorLogin = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("administratorLoginPassword"u8))
                        {
                            administratorLoginPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            version = new MySqlFlexibleServerVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("availabilityZone"u8))
                        {
                            availabilityZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createMode = new MySqlFlexibleServerCreateMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sourceServerResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceServerResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("restorePointInTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restorePointInTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("replicationRole"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicationRole = new MySqlFlexibleServerReplicationRole(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("replicaCapacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicaCapacity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dataEncryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataEncryption = MySqlFlexibleServerDataEncryption.DeserializeMySqlFlexibleServerDataEncryption(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new MySqlFlexibleServerState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("fullyQualifiedDomainName"u8))
                        {
                            fullyQualifiedDomainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storage = MySqlFlexibleServerStorage.DeserializeMySqlFlexibleServerStorage(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("backup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backup = MySqlFlexibleServerBackupProperties.DeserializeMySqlFlexibleServerBackupProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("highAvailability"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            highAvailability = MySqlFlexibleServerHighAvailability.DeserializeMySqlFlexibleServerHighAvailability(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("network"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            network = MySqlFlexibleServerNetwork.DeserializeMySqlFlexibleServerNetwork(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("maintenanceWindow"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maintenanceWindow = MySqlFlexibleServerMaintenanceWindow.DeserializeMySqlFlexibleServerMaintenanceWindow(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MySqlFlexibleServerData(id, name, type, systemData.Value, Core.Optional.ToDictionary(tags), location, identity, sku.Value, administratorLogin.Value, administratorLoginPassword.Value, Core.Optional.ToNullable(version), availabilityZone.Value, Core.Optional.ToNullable(createMode), sourceServerResourceId.Value, Core.Optional.ToNullable(restorePointInTime), Core.Optional.ToNullable(replicationRole), Core.Optional.ToNullable(replicaCapacity), dataEncryption.Value, Core.Optional.ToNullable(state), fullyQualifiedDomainName.Value, storage.Value, backup.Value, highAvailability.Value, network.Value, maintenanceWindow.Value);
        }
    }
}
