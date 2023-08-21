// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class BgpServiceLoadBalancerConfiguration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(BgpAdvertisements))
            {
                writer.WritePropertyName("bgpAdvertisements"u8);
                writer.WriteStartArray();
                foreach (var item in BgpAdvertisements)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(BgpPeers))
            {
                writer.WritePropertyName("bgpPeers"u8);
                writer.WriteStartArray();
                foreach (var item in BgpPeers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(FabricPeeringEnabled))
            {
                writer.WritePropertyName("fabricPeeringEnabled"u8);
                writer.WriteStringValue(FabricPeeringEnabled.Value.ToString());
            }
            if (Core.Optional.IsCollectionDefined(IPAddressPools))
            {
                writer.WritePropertyName("ipAddressPools"u8);
                writer.WriteStartArray();
                foreach (var item in IPAddressPools)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static BgpServiceLoadBalancerConfiguration DeserializeBgpServiceLoadBalancerConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IList<BgpAdvertisement>> bgpAdvertisements = default;
            Core.Optional<IList<ServiceLoadBalancerBgpPeer>> bgpPeers = default;
            Core.Optional<FabricPeeringEnabled> fabricPeeringEnabled = default;
            Core.Optional<IList<IPAddressPool>> ipAddressPools = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bgpAdvertisements"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BgpAdvertisement> array = new List<BgpAdvertisement>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BgpAdvertisement.DeserializeBgpAdvertisement(item));
                    }
                    bgpAdvertisements = array;
                    continue;
                }
                if (property.NameEquals("bgpPeers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceLoadBalancerBgpPeer> array = new List<ServiceLoadBalancerBgpPeer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceLoadBalancerBgpPeer.DeserializeServiceLoadBalancerBgpPeer(item));
                    }
                    bgpPeers = array;
                    continue;
                }
                if (property.NameEquals("fabricPeeringEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricPeeringEnabled = new FabricPeeringEnabled(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipAddressPools"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPAddressPool> array = new List<IPAddressPool>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPAddressPool.DeserializeIPAddressPool(item));
                    }
                    ipAddressPools = array;
                    continue;
                }
            }
            return new BgpServiceLoadBalancerConfiguration(Core.Optional.ToList(bgpAdvertisements), Core.Optional.ToList(bgpPeers), Core.Optional.ToNullable(fabricPeeringEnabled), Core.Optional.ToList(ipAddressPools));
        }
    }
}
