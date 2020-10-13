// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class LoadBalancingRule : IUtf8JsonSerializable
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
            if (Optional.IsDefined(FrontendIPConfiguration))
            {
                writer.WritePropertyName("frontendIPConfiguration");
                writer.WriteObjectValue(FrontendIPConfiguration);
            }
            if (Optional.IsDefined(BackendAddressPool))
            {
                writer.WritePropertyName("backendAddressPool");
                writer.WriteObjectValue(BackendAddressPool);
            }
            if (Optional.IsDefined(Probe))
            {
                writer.WritePropertyName("probe");
                writer.WriteObjectValue(Probe);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(LoadDistribution))
            {
                writer.WritePropertyName("loadDistribution");
                writer.WriteStringValue(LoadDistribution.Value.ToString());
            }
            if (Optional.IsDefined(FrontendPort))
            {
                writer.WritePropertyName("frontendPort");
                writer.WriteNumberValue(FrontendPort.Value);
            }
            if (Optional.IsDefined(BackendPort))
            {
                writer.WritePropertyName("backendPort");
                writer.WriteNumberValue(BackendPort.Value);
            }
            if (Optional.IsDefined(IdleTimeoutInMinutes))
            {
                writer.WritePropertyName("idleTimeoutInMinutes");
                writer.WriteNumberValue(IdleTimeoutInMinutes.Value);
            }
            if (Optional.IsDefined(EnableFloatingIP))
            {
                writer.WritePropertyName("enableFloatingIP");
                writer.WriteBooleanValue(EnableFloatingIP.Value);
            }
            if (Optional.IsDefined(EnableTcpReset))
            {
                writer.WritePropertyName("enableTcpReset");
                writer.WriteBooleanValue(EnableTcpReset.Value);
            }
            if (Optional.IsDefined(DisableOutboundSnat))
            {
                writer.WritePropertyName("disableOutboundSnat");
                writer.WriteBooleanValue(DisableOutboundSnat.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static LoadBalancingRule DeserializeLoadBalancingRule(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            Optional<string> id = default;
            Optional<SubResource> frontendIPConfiguration = default;
            Optional<SubResource> backendAddressPool = default;
            Optional<SubResource> probe = default;
            Optional<TransportProtocol> protocol = default;
            Optional<LoadDistribution> loadDistribution = default;
            Optional<int> frontendPort = default;
            Optional<int> backendPort = default;
            Optional<int> idleTimeoutInMinutes = default;
            Optional<bool> enableFloatingIP = default;
            Optional<bool> enableTcpReset = default;
            Optional<bool> disableOutboundSnat = default;
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
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
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
                        if (property0.NameEquals("frontendIPConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            frontendIPConfiguration = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("backendAddressPool"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            backendAddressPool = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("probe"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            probe = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("protocol"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            protocol = new TransportProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("loadDistribution"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            loadDistribution = new LoadDistribution(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("frontendPort"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            frontendPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("backendPort"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            backendPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("idleTimeoutInMinutes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            idleTimeoutInMinutes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enableFloatingIP"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableFloatingIP = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableTcpReset"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enableTcpReset = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("disableOutboundSnat"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            disableOutboundSnat = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new LoadBalancingRule(id.Value, name.Value, etag.Value, type.Value, frontendIPConfiguration.Value, backendAddressPool.Value, probe.Value, Optional.ToNullable(protocol), Optional.ToNullable(loadDistribution), Optional.ToNullable(frontendPort), Optional.ToNullable(backendPort), Optional.ToNullable(idleTimeoutInMinutes), Optional.ToNullable(enableFloatingIP), Optional.ToNullable(enableTcpReset), Optional.ToNullable(disableOutboundSnat), Optional.ToNullable(provisioningState));
        }
    }
}
