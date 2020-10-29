// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class Workspace : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultDataLakeStorage))
            {
                writer.WritePropertyName("defaultDataLakeStorage");
                writer.WriteObjectValue(DefaultDataLakeStorage);
            }
            if (Optional.IsDefined(SqlAdministratorLoginPassword))
            {
                writer.WritePropertyName("sqlAdministratorLoginPassword");
                writer.WriteStringValue(SqlAdministratorLoginPassword);
            }
            if (Optional.IsDefined(ManagedResourceGroupName))
            {
                writer.WritePropertyName("managedResourceGroupName");
                writer.WriteStringValue(ManagedResourceGroupName);
            }
            if (Optional.IsDefined(SqlAdministratorLogin))
            {
                writer.WritePropertyName("sqlAdministratorLogin");
                writer.WriteStringValue(SqlAdministratorLogin);
            }
            if (Optional.IsDefined(VirtualNetworkProfile))
            {
                writer.WritePropertyName("virtualNetworkProfile");
                writer.WriteObjectValue(VirtualNetworkProfile);
            }
            if (Optional.IsCollectionDefined(ConnectivityEndpoints))
            {
                writer.WritePropertyName("connectivityEndpoints");
                writer.WriteStartObject();
                foreach (var item in ConnectivityEndpoints)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ManagedVirtualNetwork))
            {
                writer.WritePropertyName("managedVirtualNetwork");
                writer.WriteStringValue(ManagedVirtualNetwork);
            }
            if (Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections");
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption");
                writer.WriteObjectValue(Encryption);
            }
            if (Optional.IsDefined(ManagedVirtualNetworkSettings))
            {
                writer.WritePropertyName("managedVirtualNetworkSettings");
                writer.WriteObjectValue(ManagedVirtualNetworkSettings);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static Workspace DeserializeWorkspace(JsonElement element)
        {
            Optional<ManagedIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            string location = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<DataLakeStorageAccountDetails> defaultDataLakeStorage = default;
            Optional<string> sqlAdministratorLoginPassword = default;
            Optional<string> managedResourceGroupName = default;
            Optional<string> provisioningState = default;
            Optional<string> sqlAdministratorLogin = default;
            Optional<VirtualNetworkProfile> virtualNetworkProfile = default;
            Optional<IDictionary<string, string>> connectivityEndpoints = default;
            Optional<string> managedVirtualNetwork = default;
            Optional<IList<PrivateEndpointConnection>> privateEndpointConnections = default;
            Optional<EncryptionDetails> encryption = default;
            Optional<string> workspaceUID = default;
            Optional<IReadOnlyDictionary<string, object>> extraProperties = default;
            Optional<ManagedVirtualNetworkSettings> managedVirtualNetworkSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = ManagedIdentity.DeserializeManagedIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
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
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("defaultDataLakeStorage"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            defaultDataLakeStorage = DataLakeStorageAccountDetails.DeserializeDataLakeStorageAccountDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sqlAdministratorLoginPassword"))
                        {
                            sqlAdministratorLoginPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managedResourceGroupName"))
                        {
                            managedResourceGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sqlAdministratorLogin"))
                        {
                            sqlAdministratorLogin = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            virtualNetworkProfile = VirtualNetworkProfile.DeserializeVirtualNetworkProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("connectivityEndpoints"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            connectivityEndpoints = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("managedVirtualNetwork"))
                        {
                            managedVirtualNetwork = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<PrivateEndpointConnection> array = new List<PrivateEndpointConnection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrivateEndpointConnection.DeserializePrivateEndpointConnection(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("encryption"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryption = EncryptionDetails.DeserializeEncryptionDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("workspaceUID"))
                        {
                            workspaceUID = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("extraProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, object> dictionary = new Dictionary<string, object>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetObject());
                            }
                            extraProperties = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("managedVirtualNetworkSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            managedVirtualNetworkSettings = ManagedVirtualNetworkSettings.DeserializeManagedVirtualNetworkSettings(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Workspace(id.Value, name.Value, type.Value, Optional.ToDictionary(tags), location, identity.Value, defaultDataLakeStorage.Value, sqlAdministratorLoginPassword.Value, managedResourceGroupName.Value, provisioningState.Value, sqlAdministratorLogin.Value, virtualNetworkProfile.Value, Optional.ToDictionary(connectivityEndpoints), managedVirtualNetwork.Value, Optional.ToList(privateEndpointConnections), encryption.Value, workspaceUID.Value, Optional.ToDictionary(extraProperties), managedVirtualNetworkSettings.Value);
        }
    }
}
