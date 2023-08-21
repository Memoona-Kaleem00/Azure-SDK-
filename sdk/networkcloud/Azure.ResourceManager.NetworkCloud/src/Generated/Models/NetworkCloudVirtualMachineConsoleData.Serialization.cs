// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    public partial class NetworkCloudVirtualMachineConsoleData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("extendedLocation"u8);
            writer.WriteObjectValue(ExtendedLocation);
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
            writer.WritePropertyName("enabled"u8);
            writer.WriteStringValue(Enabled.ToString());
            if (Core.Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expiration"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            writer.WritePropertyName("sshPublicKey"u8);
            writer.WriteObjectValue(SshPublicKey);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkCloudVirtualMachineConsoleData DeserializeNetworkCloudVirtualMachineConsoleData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtendedLocation extendedLocation = default;
            Core.Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<ConsoleDetailedStatus> detailedStatus = default;
            Core.Optional<string> detailedStatusMessage = default;
            ConsoleEnabled enabled = default;
            Core.Optional<DateTimeOffset> expiration = default;
            Core.Optional<ResourceIdentifier> privateLinkServiceId = default;
            Core.Optional<ConsoleProvisioningState> provisioningState = default;
            NetworkCloudSshPublicKey sshPublicKey = default;
            Core.Optional<Guid> virtualMachineAccessId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    extendedLocation = ExtendedLocation.DeserializeExtendedLocation(property.Value);
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
                        if (property0.NameEquals("detailedStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            detailedStatus = new ConsoleDetailedStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detailedStatusMessage"u8))
                        {
                            detailedStatusMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            enabled = new ConsoleEnabled(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("expiration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expiration = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("privateLinkServiceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateLinkServiceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ConsoleProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sshPublicKey"u8))
                        {
                            sshPublicKey = NetworkCloudSshPublicKey.DeserializeNetworkCloudSshPublicKey(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("virtualMachineAccessId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualMachineAccessId = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetworkCloudVirtualMachineConsoleData(id, name, type, systemData.Value, Core.Optional.ToDictionary(tags), location, extendedLocation, Core.Optional.ToNullable(detailedStatus), detailedStatusMessage.Value, enabled, Core.Optional.ToNullable(expiration), privateLinkServiceId.Value, Core.Optional.ToNullable(provisioningState), sshPublicKey, Core.Optional.ToNullable(virtualMachineAccessId));
        }
    }
}
