// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    public partial class MobileNetworkSimData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("internationalMobileSubscriberIdentity"u8);
            writer.WriteStringValue(InternationalMobileSubscriberIdentity);
            if (Core.Optional.IsDefined(IntegratedCircuitCardIdentifier))
            {
                writer.WritePropertyName("integratedCircuitCardIdentifier"u8);
                writer.WriteStringValue(IntegratedCircuitCardIdentifier);
            }
            if (Core.Optional.IsDefined(DeviceType))
            {
                writer.WritePropertyName("deviceType"u8);
                writer.WriteStringValue(DeviceType);
            }
            if (Core.Optional.IsDefined(SimPolicy))
            {
                writer.WritePropertyName("simPolicy"u8);
                JsonSerializer.Serialize(writer, SimPolicy);
            }
            if (Core.Optional.IsCollectionDefined(StaticIPConfiguration))
            {
                writer.WritePropertyName("staticIpConfiguration"u8);
                writer.WriteStartArray();
                foreach (var item in StaticIPConfiguration)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(AuthenticationKey))
            {
                writer.WritePropertyName("authenticationKey"u8);
                writer.WriteStringValue(AuthenticationKey);
            }
            if (Core.Optional.IsDefined(OperatorKeyCode))
            {
                writer.WritePropertyName("operatorKeyCode"u8);
                writer.WriteStringValue(OperatorKeyCode);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MobileNetworkSimData DeserializeMobileNetworkSimData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<MobileNetworkProvisioningState> provisioningState = default;
            Core.Optional<MobileNetworkSimState> simState = default;
            Core.Optional<IReadOnlyDictionary<string, MobileNetworkSiteProvisioningState>> siteProvisioningState = default;
            string internationalMobileSubscriberIdentity = default;
            Core.Optional<string> integratedCircuitCardIdentifier = default;
            Core.Optional<string> deviceType = default;
            Core.Optional<WritableSubResource> simPolicy = default;
            Core.Optional<IList<SimStaticIPProperties>> staticIPConfiguration = default;
            Core.Optional<string> vendorName = default;
            Core.Optional<string> vendorKeyFingerprint = default;
            Core.Optional<string> authenticationKey = default;
            Core.Optional<string> operatorKeyCode = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new MobileNetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("simState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            simState = new MobileNetworkSimState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("siteProvisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, MobileNetworkSiteProvisioningState> dictionary = new Dictionary<string, MobileNetworkSiteProvisioningState>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, new MobileNetworkSiteProvisioningState(property1.Value.GetString()));
                            }
                            siteProvisioningState = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("internationalMobileSubscriberIdentity"u8))
                        {
                            internationalMobileSubscriberIdentity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("integratedCircuitCardIdentifier"u8))
                        {
                            integratedCircuitCardIdentifier = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deviceType"u8))
                        {
                            deviceType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("simPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            simPolicy = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("staticIpConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SimStaticIPProperties> array = new List<SimStaticIPProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SimStaticIPProperties.DeserializeSimStaticIPProperties(item));
                            }
                            staticIPConfiguration = array;
                            continue;
                        }
                        if (property0.NameEquals("vendorName"u8))
                        {
                            vendorName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vendorKeyFingerprint"u8))
                        {
                            vendorKeyFingerprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationKey"u8))
                        {
                            authenticationKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operatorKeyCode"u8))
                        {
                            operatorKeyCode = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MobileNetworkSimData(id, name, type, systemData.Value, Core.Optional.ToNullable(provisioningState), Core.Optional.ToNullable(simState), Core.Optional.ToDictionary(siteProvisioningState), internationalMobileSubscriberIdentity, integratedCircuitCardIdentifier.Value, deviceType.Value, simPolicy, Core.Optional.ToList(staticIPConfiguration), vendorName.Value, vendorKeyFingerprint.Value, authenticationKey.Value, operatorKeyCode.Value);
        }
    }
}
