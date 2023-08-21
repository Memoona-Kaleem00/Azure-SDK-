// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class PeerExpressRouteCircuitConnectionData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Core.Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ExpressRouteCircuitPeering))
            {
                writer.WritePropertyName("expressRouteCircuitPeering"u8);
                JsonSerializer.Serialize(writer, ExpressRouteCircuitPeering);
            }
            if (Core.Optional.IsDefined(PeerExpressRouteCircuitPeering))
            {
                writer.WritePropertyName("peerExpressRouteCircuitPeering"u8);
                JsonSerializer.Serialize(writer, PeerExpressRouteCircuitPeering);
            }
            if (Core.Optional.IsDefined(AddressPrefix))
            {
                writer.WritePropertyName("addressPrefix"u8);
                writer.WriteStringValue(AddressPrefix);
            }
            if (Core.Optional.IsDefined(ConnectionName))
            {
                writer.WritePropertyName("connectionName"u8);
                writer.WriteStringValue(ConnectionName);
            }
            if (Core.Optional.IsDefined(AuthResourceGuid))
            {
                writer.WritePropertyName("authResourceGuid"u8);
                writer.WriteStringValue(AuthResourceGuid.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PeerExpressRouteCircuitConnectionData DeserializePeerExpressRouteCircuitConnectionData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ETag> etag = default;
            Core.Optional<ResourceIdentifier> id = default;
            Core.Optional<string> name = default;
            Core.Optional<ResourceType> type = default;
            Core.Optional<WritableSubResource> expressRouteCircuitPeering = default;
            Core.Optional<WritableSubResource> peerExpressRouteCircuitPeering = default;
            Core.Optional<string> addressPrefix = default;
            Core.Optional<CircuitConnectionStatus> circuitConnectionStatus = default;
            Core.Optional<string> connectionName = default;
            Core.Optional<Guid> authResourceGuid = default;
            Core.Optional<NetworkProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("expressRouteCircuitPeering"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expressRouteCircuitPeering = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("peerExpressRouteCircuitPeering"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peerExpressRouteCircuitPeering = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("addressPrefix"u8))
                        {
                            addressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("circuitConnectionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            circuitConnectionStatus = new CircuitConnectionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("connectionName"u8))
                        {
                            connectionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authResourceGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authResourceGuid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PeerExpressRouteCircuitConnectionData(id.Value, name.Value, Core.Optional.ToNullable(type), Core.Optional.ToNullable(etag), expressRouteCircuitPeering, peerExpressRouteCircuitPeering, addressPrefix.Value, Core.Optional.ToNullable(circuitConnectionStatus), connectionName.Value, Core.Optional.ToNullable(authResourceGuid), Core.Optional.ToNullable(provisioningState));
        }
    }
}
