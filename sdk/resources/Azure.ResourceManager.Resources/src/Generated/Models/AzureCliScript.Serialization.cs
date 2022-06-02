// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Resources.Models
{
    internal partial class AzureCliScript : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ContainerSettings))
            {
                writer.WritePropertyName("containerSettings");
                writer.WriteObjectValue(ContainerSettings);
            }
            if (Optional.IsDefined(StorageAccountSettings))
            {
                writer.WritePropertyName("storageAccountSettings");
                writer.WriteObjectValue(StorageAccountSettings);
            }
            if (Optional.IsDefined(CleanupPreference))
            {
                writer.WritePropertyName("cleanupPreference");
                writer.WriteStringValue(CleanupPreference.Value.ToString());
            }
            if (Optional.IsDefined(PrimaryScriptUri))
            {
                writer.WritePropertyName("primaryScriptUri");
                writer.WriteStringValue(PrimaryScriptUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(SupportingScriptUris))
            {
                writer.WritePropertyName("supportingScriptUris");
                writer.WriteStartArray();
                foreach (var item in SupportingScriptUris)
                {
                    writer.WriteStringValue(item.AbsoluteUri);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ScriptContent))
            {
                writer.WritePropertyName("scriptContent");
                writer.WriteStringValue(ScriptContent);
            }
            if (Optional.IsDefined(Arguments))
            {
                writer.WritePropertyName("arguments");
                writer.WriteStringValue(Arguments);
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                writer.WritePropertyName("environmentVariables");
                writer.WriteStartArray();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ForceUpdateTag))
            {
                writer.WritePropertyName("forceUpdateTag");
                writer.WriteStringValue(ForceUpdateTag);
            }
            writer.WritePropertyName("retentionInterval");
            writer.WriteStringValue(RetentionInterval, "P");
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout");
                writer.WriteStringValue(Timeout.Value, "P");
            }
            writer.WritePropertyName("azCliVersion");
            writer.WriteStringValue(AzCliVersion);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AzureCliScript DeserializeAzureCliScript(JsonElement element)
        {
            Optional<ArmDeploymentScriptManagedIdentity> identity = default;
            ScriptType kind = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<ContainerConfiguration> containerSettings = default;
            Optional<ScriptStorageConfiguration> storageAccountSettings = default;
            Optional<ScriptCleanupOptions> cleanupPreference = default;
            Optional<ScriptProvisioningState> provisioningState = default;
            Optional<ScriptStatus> status = default;
            Optional<BinaryData> outputs = default;
            Optional<Uri> primaryScriptUri = default;
            Optional<IList<Uri>> supportingScriptUris = default;
            Optional<string> scriptContent = default;
            Optional<string> arguments = default;
            Optional<IList<ScriptEnvironmentVariable>> environmentVariables = default;
            Optional<string> forceUpdateTag = default;
            TimeSpan retentionInterval = default;
            Optional<TimeSpan> timeout = default;
            string azCliVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = ArmDeploymentScriptManagedIdentity.DeserializeArmDeploymentScriptManagedIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new ScriptType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"))
                {
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
                        if (property0.NameEquals("containerSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            containerSettings = ContainerConfiguration.DeserializeContainerConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("storageAccountSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            storageAccountSettings = ScriptStorageConfiguration.DeserializeScriptStorageConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("cleanupPreference"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            cleanupPreference = new ScriptCleanupOptions(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ScriptProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = ScriptStatus.DeserializeScriptStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("outputs"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            outputs = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("primaryScriptUri"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                primaryScriptUri = null;
                                continue;
                            }
                            primaryScriptUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("supportingScriptUris"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<Uri> array = new List<Uri>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new Uri(item.GetString()));
                            }
                            supportingScriptUris = array;
                            continue;
                        }
                        if (property0.NameEquals("scriptContent"))
                        {
                            scriptContent = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("arguments"))
                        {
                            arguments = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("environmentVariables"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ScriptEnvironmentVariable> array = new List<ScriptEnvironmentVariable>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ScriptEnvironmentVariable.DeserializeScriptEnvironmentVariable(item));
                            }
                            environmentVariables = array;
                            continue;
                        }
                        if (property0.NameEquals("forceUpdateTag"))
                        {
                            forceUpdateTag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("retentionInterval"))
                        {
                            retentionInterval = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("timeout"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            timeout = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("azCliVersion"))
                        {
                            azCliVersion = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AzureCliScript(id, name, type, systemData, tags, location, containerSettings.Value, storageAccountSettings.Value, Optional.ToNullable(cleanupPreference), Optional.ToNullable(provisioningState), status.Value, outputs.Value, primaryScriptUri.Value, Optional.ToList(supportingScriptUris), scriptContent.Value, arguments.Value, Optional.ToList(environmentVariables), forceUpdateTag.Value, retentionInterval, Optional.ToNullable(timeout), azCliVersion, identity.Value, kind);
        }
    }
}
