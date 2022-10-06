// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.KubernetesConfiguration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.KubernetesConfiguration
{
    public partial class ExtensionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                JsonSerializer.Serialize(writer, Identity);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ExtensionType))
            {
                writer.WritePropertyName("extensionType");
                writer.WriteStringValue(ExtensionType);
            }
            if (Optional.IsDefined(AutoUpgradeMinorVersion))
            {
                writer.WritePropertyName("autoUpgradeMinorVersion");
                writer.WriteBooleanValue(AutoUpgradeMinorVersion.Value);
            }
            if (Optional.IsDefined(ReleaseTrain))
            {
                writer.WritePropertyName("releaseTrain");
                writer.WriteStringValue(ReleaseTrain);
            }
            if (Optional.IsDefined(Version))
            {
                if (Version != null)
                {
                    writer.WritePropertyName("version");
                    writer.WriteStringValue(Version);
                }
                else
                {
                    writer.WriteNull("version");
                }
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope");
                writer.WriteObjectValue(Scope);
            }
            if (Optional.IsCollectionDefined(ConfigurationSettings))
            {
                if (ConfigurationSettings != null)
                {
                    writer.WritePropertyName("configurationSettings");
                    writer.WriteStartObject();
                    foreach (var item in ConfigurationSettings)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("configurationSettings");
                }
            }
            if (Optional.IsCollectionDefined(ConfigurationProtectedSettings))
            {
                if (ConfigurationProtectedSettings != null)
                {
                    writer.WritePropertyName("configurationProtectedSettings");
                    writer.WriteStartObject();
                    foreach (var item in ConfigurationProtectedSettings)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("configurationProtectedSettings");
                }
            }
            if (Optional.IsCollectionDefined(Statuses))
            {
                if (Statuses != null)
                {
                    writer.WritePropertyName("statuses");
                    writer.WriteStartArray();
                    foreach (var item in Statuses)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("statuses");
                }
            }
            if (Optional.IsDefined(AksAssignedIdentity))
            {
                writer.WritePropertyName("aksAssignedIdentity");
                JsonSerializer.Serialize(writer, AksAssignedIdentity);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ExtensionData DeserializeExtensionData(JsonElement element)
        {
            Optional<ManagedServiceIdentity> identity = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> extensionType = default;
            Optional<bool> autoUpgradeMinorVersion = default;
            Optional<string> releaseTrain = default;
            Optional<string> version = default;
            Optional<Scope> scope = default;
            Optional<IDictionary<string, string>> configurationSettings = default;
            Optional<IDictionary<string, string>> configurationProtectedSettings = default;
            Optional<string> installedVersion = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<IList<ExtensionStatus>> statuses = default;
            Optional<ResponseError> errorInfo = default;
            Optional<IReadOnlyDictionary<string, string>> customLocationSettings = default;
            Optional<Uri> packageUri = default;
            Optional<ManagedServiceIdentity> aksAssignedIdentity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.ToString());
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
                        if (property0.NameEquals("extensionType"))
                        {
                            extensionType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("autoUpgradeMinorVersion"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            autoUpgradeMinorVersion = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("releaseTrain"))
                        {
                            releaseTrain = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                version = null;
                                continue;
                            }
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scope"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            scope = Scope.DeserializeScope(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("configurationSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                configurationSettings = null;
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            configurationSettings = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("configurationProtectedSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                configurationProtectedSettings = null;
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            configurationProtectedSettings = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("installedVersion"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                installedVersion = null;
                                continue;
                            }
                            installedVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("statuses"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                statuses = null;
                                continue;
                            }
                            List<ExtensionStatus> array = new List<ExtensionStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ExtensionStatus.DeserializeExtensionStatus(item));
                            }
                            statuses = array;
                            continue;
                        }
                        if (property0.NameEquals("errorInfo"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                errorInfo = null;
                                continue;
                            }
                            errorInfo = JsonSerializer.Deserialize<ResponseError>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("customLocationSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                customLocationSettings = null;
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            customLocationSettings = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("packageUri"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                packageUri = null;
                                continue;
                            }
                            packageUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("aksAssignedIdentity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            aksAssignedIdentity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property0.Value.ToString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ExtensionData(id, name, type, systemData.Value, identity, extensionType.Value, Optional.ToNullable(autoUpgradeMinorVersion), releaseTrain.Value, version.Value, scope.Value, Optional.ToDictionary(configurationSettings), Optional.ToDictionary(configurationProtectedSettings), installedVersion.Value, Optional.ToNullable(provisioningState), Optional.ToList(statuses), errorInfo.Value, Optional.ToDictionary(customLocationSettings), packageUri.Value, aksAssignedIdentity);
        }
    }
}
