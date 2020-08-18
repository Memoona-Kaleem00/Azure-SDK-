// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class VirtualNetworkPeering : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AllowVirtualNetworkAccess))
            {
                writer.WritePropertyName("allowVirtualNetworkAccess");
                writer.WriteBooleanValue(AllowVirtualNetworkAccess.Value);
            }
            if (Optional.IsDefined(AllowForwardedTraffic))
            {
                writer.WritePropertyName("allowForwardedTraffic");
                writer.WriteBooleanValue(AllowForwardedTraffic.Value);
            }
            if (Optional.IsDefined(AllowGatewayTransit))
            {
                writer.WritePropertyName("allowGatewayTransit");
                writer.WriteBooleanValue(AllowGatewayTransit.Value);
            }
            if (Optional.IsDefined(UseRemoteGateways))
            {
                writer.WritePropertyName("useRemoteGateways");
                writer.WriteBooleanValue(UseRemoteGateways.Value);
            }
            if (Optional.IsDefined(RemoteVirtualNetwork))
            {
                writer.WritePropertyName("remoteVirtualNetwork");
                writer.WriteObjectValue(RemoteVirtualNetwork);
            }
            if (Optional.IsDefined(RemoteAddressSpace))
            {
                writer.WritePropertyName("remoteAddressSpace");
                writer.WriteObjectValue(RemoteAddressSpace);
            }
            if (Optional.IsDefined(PeeringState))
            {
                writer.WritePropertyName("peeringState");
                writer.WriteStringValue(PeeringState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualNetworkPeering DeserializeVirtualNetworkPeering(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<bool> allowVirtualNetworkAccess = default;
            Optional<bool> allowForwardedTraffic = default;
            Optional<bool> allowGatewayTransit = default;
            Optional<bool> useRemoteGateways = default;
            Optional<SubResource> remoteVirtualNetwork = default;
            Optional<AddressSpace> remoteAddressSpace = default;
            Optional<VirtualNetworkPeeringState> peeringState = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("allowVirtualNetworkAccess"))
                        {
                            allowVirtualNetworkAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowForwardedTraffic"))
                        {
                            allowForwardedTraffic = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowGatewayTransit"))
                        {
                            allowGatewayTransit = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("useRemoteGateways"))
                        {
                            useRemoteGateways = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("remoteVirtualNetwork"))
                        {
                            remoteVirtualNetwork = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("remoteAddressSpace"))
                        {
                            remoteAddressSpace = AddressSpace.DeserializeAddressSpace(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("peeringState"))
                        {
                            peeringState = new VirtualNetworkPeeringState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualNetworkPeering(id.Value, name.Value, etag.Value, Optional.ToNullable(allowVirtualNetworkAccess), Optional.ToNullable(allowForwardedTraffic), Optional.ToNullable(allowGatewayTransit), Optional.ToNullable(useRemoteGateways), remoteVirtualNetwork.Value, remoteAddressSpace.Value, Optional.ToNullable(peeringState), Optional.ToNullable(provisioningState));
        }
    }
}
