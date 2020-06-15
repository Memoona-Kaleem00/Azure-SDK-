// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class PeerExpressRouteCircuitConnection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (ExpressRouteCircuitPeering != null)
            {
                writer.WritePropertyName("expressRouteCircuitPeering");
                writer.WriteObjectValue(ExpressRouteCircuitPeering);
            }
            if (PeerExpressRouteCircuitPeering != null)
            {
                writer.WritePropertyName("peerExpressRouteCircuitPeering");
                writer.WriteObjectValue(PeerExpressRouteCircuitPeering);
            }
            if (AddressPrefix != null)
            {
                writer.WritePropertyName("addressPrefix");
                writer.WriteStringValue(AddressPrefix);
            }
            if (CircuitConnectionStatus != null)
            {
                writer.WritePropertyName("circuitConnectionStatus");
                writer.WriteStringValue(CircuitConnectionStatus.Value.ToString());
            }
            if (ConnectionName != null)
            {
                writer.WritePropertyName("connectionName");
                writer.WriteStringValue(ConnectionName);
            }
            if (AuthResourceGuid != null)
            {
                writer.WritePropertyName("authResourceGuid");
                writer.WriteStringValue(AuthResourceGuid);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PeerExpressRouteCircuitConnection DeserializePeerExpressRouteCircuitConnection(JsonElement element)
        {
            string name = default;
            string etag = default;
            string type = default;
            string id = default;
            SubResource expressRouteCircuitPeering = default;
            SubResource peerExpressRouteCircuitPeering = default;
            string addressPrefix = default;
            CircuitConnectionStatus? circuitConnectionStatus = default;
            string connectionName = default;
            string authResourceGuid = default;
            ProvisioningState? provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("expressRouteCircuitPeering"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expressRouteCircuitPeering = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("peerExpressRouteCircuitPeering"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peerExpressRouteCircuitPeering = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("addressPrefix"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            addressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("circuitConnectionStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            circuitConnectionStatus = new CircuitConnectionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("connectionName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authResourceGuid"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authResourceGuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PeerExpressRouteCircuitConnection(id, name, etag, type, expressRouteCircuitPeering, peerExpressRouteCircuitPeering, addressPrefix, circuitConnectionStatus, connectionName, authResourceGuid, provisioningState);
        }
    }
}
