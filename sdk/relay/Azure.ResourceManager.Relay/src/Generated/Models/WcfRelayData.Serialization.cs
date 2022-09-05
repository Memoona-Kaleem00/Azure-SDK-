// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Relay.Models;

namespace Azure.ResourceManager.Relay
{
    public partial class WcfRelayData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(RelayType))
            {
                writer.WritePropertyName("relayType");
                writer.WriteStringValue(RelayType.Value.ToSerialString());
            }
            if (Optional.IsDefined(IsClientAuthorizationRequired))
            {
                writer.WritePropertyName("requiresClientAuthorization");
                writer.WriteBooleanValue(IsClientAuthorizationRequired.Value);
            }
            if (Optional.IsDefined(IsTransportSecurityRequired))
            {
                writer.WritePropertyName("requiresTransportSecurity");
                writer.WriteBooleanValue(IsTransportSecurityRequired.Value);
            }
            if (Optional.IsDefined(UserMetadata))
            {
                writer.WritePropertyName("userMetadata");
                writer.WriteStringValue(UserMetadata);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WcfRelayData DeserializeWcfRelayData(JsonElement element)
        {
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<bool> isDynamic = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<DateTimeOffset> updatedAt = default;
            Optional<int> listenerCount = default;
            Optional<RelayType> relayType = default;
            Optional<bool> requiresClientAuthorization = default;
            Optional<bool> requiresTransportSecurity = default;
            Optional<string> userMetadata = default;
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
                        if (property0.NameEquals("isDynamic"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isDynamic = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("createdAt"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updatedAt"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            updatedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("listenerCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            listenerCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("relayType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            relayType = property0.Value.GetString().ToRelayType();
                            continue;
                        }
                        if (property0.NameEquals("requiresClientAuthorization"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            requiresClientAuthorization = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("requiresTransportSecurity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            requiresTransportSecurity = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("userMetadata"))
                        {
                            userMetadata = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WcfRelayData(id, name, type, systemData.Value, Optional.ToNullable(isDynamic), Optional.ToNullable(createdAt), Optional.ToNullable(updatedAt), Optional.ToNullable(listenerCount), Optional.ToNullable(relayType), Optional.ToNullable(requiresClientAuthorization), Optional.ToNullable(requiresTransportSecurity), userMetadata.Value, Optional.ToNullable(location));
        }
    }
}
