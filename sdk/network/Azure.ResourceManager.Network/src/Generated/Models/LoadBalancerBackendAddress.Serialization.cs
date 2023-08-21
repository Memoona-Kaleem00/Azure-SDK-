// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    public partial class LoadBalancerBackendAddress : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(VirtualNetwork))
            {
                writer.WritePropertyName("virtualNetwork"u8);
                JsonSerializer.Serialize(writer, VirtualNetwork);
            }
            if (Core.Optional.IsDefined(Subnet))
            {
                writer.WritePropertyName("subnet"u8);
                JsonSerializer.Serialize(writer, Subnet);
            }
            if (Core.Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress);
            }
            if (Core.Optional.IsDefined(LoadBalancerFrontendIPConfiguration))
            {
                writer.WritePropertyName("loadBalancerFrontendIPConfiguration"u8);
                JsonSerializer.Serialize(writer, LoadBalancerFrontendIPConfiguration);
            }
            if (Core.Optional.IsDefined(AdminState))
            {
                writer.WritePropertyName("adminState"u8);
                writer.WriteStringValue(AdminState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static LoadBalancerBackendAddress DeserializeLoadBalancerBackendAddress(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            Core.Optional<WritableSubResource> virtualNetwork = default;
            Core.Optional<WritableSubResource> subnet = default;
            Core.Optional<string> ipAddress = default;
            Core.Optional<WritableSubResource> networkInterfaceIPConfiguration = default;
            Core.Optional<WritableSubResource> loadBalancerFrontendIPConfiguration = default;
            Core.Optional<IReadOnlyList<NatRulePortMapping>> inboundNatRulesPortMapping = default;
            Core.Optional<LoadBalancerBackendAddressAdminState> adminState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
                        if (property0.NameEquals("virtualNetwork"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetwork = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("subnet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnet = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("ipAddress"u8))
                        {
                            ipAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkInterfaceIPConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkInterfaceIPConfiguration = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerFrontendIPConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            loadBalancerFrontendIPConfiguration = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("inboundNatRulesPortMapping"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NatRulePortMapping> array = new List<NatRulePortMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NatRulePortMapping.DeserializeNatRulePortMapping(item));
                            }
                            inboundNatRulesPortMapping = array;
                            continue;
                        }
                        if (property0.NameEquals("adminState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            adminState = new LoadBalancerBackendAddressAdminState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new LoadBalancerBackendAddress(name.Value, virtualNetwork, subnet, ipAddress.Value, networkInterfaceIPConfiguration, loadBalancerFrontendIPConfiguration, Core.Optional.ToList(inboundNatRulesPortMapping), Core.Optional.ToNullable(adminState));
        }
    }
}
