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
    public partial class VpnSiteData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Core.Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Core.Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(VirtualWan))
            {
                writer.WritePropertyName("virtualWan"u8);
                JsonSerializer.Serialize(writer, VirtualWan);
            }
            if (Core.Optional.IsDefined(DeviceProperties))
            {
                writer.WritePropertyName("deviceProperties"u8);
                writer.WriteObjectValue(DeviceProperties);
            }
            if (Core.Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress);
            }
            if (Core.Optional.IsDefined(SiteKey))
            {
                writer.WritePropertyName("siteKey"u8);
                writer.WriteStringValue(SiteKey);
            }
            if (Core.Optional.IsDefined(AddressSpace))
            {
                writer.WritePropertyName("addressSpace"u8);
                writer.WriteObjectValue(AddressSpace);
            }
            if (Core.Optional.IsDefined(BgpProperties))
            {
                writer.WritePropertyName("bgpProperties"u8);
                writer.WriteObjectValue(BgpProperties);
            }
            if (Core.Optional.IsDefined(IsSecuritySite))
            {
                writer.WritePropertyName("isSecuritySite"u8);
                writer.WriteBooleanValue(IsSecuritySite.Value);
            }
            if (Core.Optional.IsCollectionDefined(VpnSiteLinks))
            {
                writer.WritePropertyName("vpnSiteLinks"u8);
                writer.WriteStartArray();
                foreach (var item in VpnSiteLinks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(O365Policy))
            {
                writer.WritePropertyName("o365Policy"u8);
                writer.WriteObjectValue(O365Policy);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VpnSiteData DeserializeVpnSiteData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ETag> etag = default;
            Core.Optional<ResourceIdentifier> id = default;
            Core.Optional<string> name = default;
            Core.Optional<ResourceType> type = default;
            Core.Optional<AzureLocation> location = default;
            Core.Optional<IDictionary<string, string>> tags = default;
            Core.Optional<WritableSubResource> virtualWan = default;
            Core.Optional<DeviceProperties> deviceProperties = default;
            Core.Optional<string> ipAddress = default;
            Core.Optional<string> siteKey = default;
            Core.Optional<AddressSpace> addressSpace = default;
            Core.Optional<BgpSettings> bgpProperties = default;
            Core.Optional<NetworkProvisioningState> provisioningState = default;
            Core.Optional<bool> isSecuritySite = default;
            Core.Optional<IList<VpnSiteLinkData>> vpnSiteLinks = default;
            Core.Optional<O365PolicyProperties> o365Policy = default;
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
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("virtualWan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualWan = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("deviceProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deviceProperties = DeviceProperties.DeserializeDeviceProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ipAddress"u8))
                        {
                            ipAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("siteKey"u8))
                        {
                            siteKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("addressSpace"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            addressSpace = AddressSpace.DeserializeAddressSpace(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("bgpProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bgpProperties = BgpSettings.DeserializeBgpSettings(property0.Value);
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
                        if (property0.NameEquals("isSecuritySite"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isSecuritySite = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("vpnSiteLinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VpnSiteLinkData> array = new List<VpnSiteLinkData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnSiteLinkData.DeserializeVpnSiteLinkData(item));
                            }
                            vpnSiteLinks = array;
                            continue;
                        }
                        if (property0.NameEquals("o365Policy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            o365Policy = O365PolicyProperties.DeserializeO365PolicyProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VpnSiteData(id.Value, name.Value, Core.Optional.ToNullable(type), Core.Optional.ToNullable(location), Core.Optional.ToDictionary(tags), Core.Optional.ToNullable(etag), virtualWan, deviceProperties.Value, ipAddress.Value, siteKey.Value, addressSpace.Value, bgpProperties.Value, Core.Optional.ToNullable(provisioningState), Core.Optional.ToNullable(isSecuritySite), Core.Optional.ToList(vpnSiteLinks), o365Policy.Value);
        }
    }
}
