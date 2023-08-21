// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class VpnSiteLinkConnectionData : Core.IUtf8JsonSerializable
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
            if (Core.Optional.IsDefined(VpnSiteLink))
            {
                writer.WritePropertyName("vpnSiteLink"u8);
                JsonSerializer.Serialize(writer, VpnSiteLink);
            }
            if (Core.Optional.IsDefined(RoutingWeight))
            {
                writer.WritePropertyName("routingWeight"u8);
                writer.WriteNumberValue(RoutingWeight.Value);
            }
            if (Core.Optional.IsDefined(VpnLinkConnectionMode))
            {
                writer.WritePropertyName("vpnLinkConnectionMode"u8);
                writer.WriteStringValue(VpnLinkConnectionMode.Value.ToString());
            }
            if (Core.Optional.IsDefined(VpnConnectionProtocolType))
            {
                writer.WritePropertyName("vpnConnectionProtocolType"u8);
                writer.WriteStringValue(VpnConnectionProtocolType.Value.ToString());
            }
            if (Core.Optional.IsDefined(ConnectionBandwidth))
            {
                writer.WritePropertyName("connectionBandwidth"u8);
                writer.WriteNumberValue(ConnectionBandwidth.Value);
            }
            if (Core.Optional.IsDefined(SharedKey))
            {
                writer.WritePropertyName("sharedKey"u8);
                writer.WriteStringValue(SharedKey);
            }
            if (Core.Optional.IsDefined(EnableBgp))
            {
                writer.WritePropertyName("enableBgp"u8);
                writer.WriteBooleanValue(EnableBgp.Value);
            }
            if (Core.Optional.IsCollectionDefined(VpnGatewayCustomBgpAddresses))
            {
                writer.WritePropertyName("vpnGatewayCustomBgpAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in VpnGatewayCustomBgpAddresses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(UsePolicyBasedTrafficSelectors))
            {
                writer.WritePropertyName("usePolicyBasedTrafficSelectors"u8);
                writer.WriteBooleanValue(UsePolicyBasedTrafficSelectors.Value);
            }
            if (Core.Optional.IsCollectionDefined(IPsecPolicies))
            {
                writer.WritePropertyName("ipsecPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in IPsecPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(EnableRateLimiting))
            {
                writer.WritePropertyName("enableRateLimiting"u8);
                writer.WriteBooleanValue(EnableRateLimiting.Value);
            }
            if (Core.Optional.IsDefined(UseLocalAzureIPAddress))
            {
                writer.WritePropertyName("useLocalAzureIpAddress"u8);
                writer.WriteBooleanValue(UseLocalAzureIPAddress.Value);
            }
            if (Core.Optional.IsCollectionDefined(IngressNatRules))
            {
                writer.WritePropertyName("ingressNatRules"u8);
                writer.WriteStartArray();
                foreach (var item in IngressNatRules)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(EgressNatRules))
            {
                writer.WritePropertyName("egressNatRules"u8);
                writer.WriteStartArray();
                foreach (var item in EgressNatRules)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VpnSiteLinkConnectionData DeserializeVpnSiteLinkConnectionData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ETag> etag = default;
            Core.Optional<ResourceIdentifier> id = default;
            Core.Optional<string> name = default;
            Core.Optional<ResourceType> type = default;
            Core.Optional<WritableSubResource> vpnSiteLink = default;
            Core.Optional<int> routingWeight = default;
            Core.Optional<VpnLinkConnectionMode> vpnLinkConnectionMode = default;
            Core.Optional<VpnConnectionStatus> connectionStatus = default;
            Core.Optional<VirtualNetworkGatewayConnectionProtocol> vpnConnectionProtocolType = default;
            Core.Optional<long> ingressBytesTransferred = default;
            Core.Optional<long> egressBytesTransferred = default;
            Core.Optional<int> connectionBandwidth = default;
            Core.Optional<string> sharedKey = default;
            Core.Optional<bool> enableBgp = default;
            Core.Optional<IList<GatewayCustomBgpIPAddressIPConfiguration>> vpnGatewayCustomBgpAddresses = default;
            Core.Optional<bool> usePolicyBasedTrafficSelectors = default;
            Core.Optional<IList<IPsecPolicy>> ipsecPolicies = default;
            Core.Optional<bool> enableRateLimiting = default;
            Core.Optional<bool> useLocalAzureIPAddress = default;
            Core.Optional<NetworkProvisioningState> provisioningState = default;
            Core.Optional<IList<WritableSubResource>> ingressNatRules = default;
            Core.Optional<IList<WritableSubResource>> egressNatRules = default;
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
                        if (property0.NameEquals("vpnSiteLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnSiteLink = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("routingWeight"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingWeight = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("vpnLinkConnectionMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnLinkConnectionMode = new VpnLinkConnectionMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("connectionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionStatus = new VpnConnectionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vpnConnectionProtocolType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnConnectionProtocolType = new VirtualNetworkGatewayConnectionProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ingressBytesTransferred"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ingressBytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("egressBytesTransferred"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            egressBytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("connectionBandwidth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionBandwidth = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("sharedKey"u8))
                        {
                            sharedKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enableBgp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableBgp = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("vpnGatewayCustomBgpAddresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<GatewayCustomBgpIPAddressIPConfiguration> array = new List<GatewayCustomBgpIPAddressIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(GatewayCustomBgpIPAddressIPConfiguration.DeserializeGatewayCustomBgpIPAddressIPConfiguration(item));
                            }
                            vpnGatewayCustomBgpAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("usePolicyBasedTrafficSelectors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usePolicyBasedTrafficSelectors = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ipsecPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IPsecPolicy> array = new List<IPsecPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IPsecPolicy.DeserializeIPsecPolicy(item));
                            }
                            ipsecPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("enableRateLimiting"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableRateLimiting = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("useLocalAzureIpAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useLocalAzureIPAddress = property0.Value.GetBoolean();
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
                        if (property0.NameEquals("ingressNatRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            ingressNatRules = array;
                            continue;
                        }
                        if (property0.NameEquals("egressNatRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            egressNatRules = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VpnSiteLinkConnectionData(id.Value, name.Value, Core.Optional.ToNullable(type), Core.Optional.ToNullable(etag), vpnSiteLink, Core.Optional.ToNullable(routingWeight), Core.Optional.ToNullable(vpnLinkConnectionMode), Core.Optional.ToNullable(connectionStatus), Core.Optional.ToNullable(vpnConnectionProtocolType), Core.Optional.ToNullable(ingressBytesTransferred), Core.Optional.ToNullable(egressBytesTransferred), Core.Optional.ToNullable(connectionBandwidth), sharedKey.Value, Core.Optional.ToNullable(enableBgp), Core.Optional.ToList(vpnGatewayCustomBgpAddresses), Core.Optional.ToNullable(usePolicyBasedTrafficSelectors), Core.Optional.ToList(ipsecPolicies), Core.Optional.ToNullable(enableRateLimiting), Core.Optional.ToNullable(useLocalAzureIPAddress), Core.Optional.ToNullable(provisioningState), Core.Optional.ToList(ingressNatRules), Core.Optional.ToList(egressNatRules));
        }
    }
}
