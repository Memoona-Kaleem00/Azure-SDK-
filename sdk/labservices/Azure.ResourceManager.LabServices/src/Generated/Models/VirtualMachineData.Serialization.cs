// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.LabServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LabServices
{
    public partial class VirtualMachineData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualMachineData DeserializeVirtualMachineData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<VirtualMachineState> state = default;
            Optional<VirtualMachineConnectionProfile> connectionProfile = default;
            Optional<string> claimedByUserId = default;
            Optional<VirtualMachineType> vmType = default;
            foreach (var property in element.EnumerateObject())
            {
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
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("state"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            state = property0.Value.GetString().ToVirtualMachineState();
                            continue;
                        }
                        if (property0.NameEquals("connectionProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            connectionProfile = VirtualMachineConnectionProfile.DeserializeVirtualMachineConnectionProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("claimedByUserId"))
                        {
                            claimedByUserId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            vmType = property0.Value.GetString().ToVirtualMachineType();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualMachineData(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(state), connectionProfile.Value, claimedByUserId.Value, Optional.ToNullable(vmType));
        }
    }
}
