// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    public partial class HybridIdentityMetadataData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(VmId))
            {
                writer.WritePropertyName("vmId");
                writer.WriteStringValue(VmId);
            }
            if (Optional.IsDefined(PublicKey))
            {
                writer.WritePropertyName("publicKey");
                writer.WriteStringValue(PublicKey);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static HybridIdentityMetadataData DeserializeHybridIdentityMetadataData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> vmId = default;
            Optional<string> publicKey = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<string> provisioningState = default;
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
                        if (property0.NameEquals("vmId"))
                        {
                            vmId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicKey"))
                        {
                            publicKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("identity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new HybridIdentityMetadataData(id, name, type, systemData.Value, vmId.Value, publicKey.Value, identity, provisioningState.Value);
        }
    }
}
