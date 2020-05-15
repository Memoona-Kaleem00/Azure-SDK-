// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class BgpSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Asn != null)
            {
                writer.WritePropertyName("asn");
                writer.WriteNumberValue(Asn.Value);
            }
            if (BgpPeeringAddress != null)
            {
                writer.WritePropertyName("bgpPeeringAddress");
                writer.WriteStringValue(BgpPeeringAddress);
            }
            if (PeerWeight != null)
            {
                writer.WritePropertyName("peerWeight");
                writer.WriteNumberValue(PeerWeight.Value);
            }
            if (BgpPeeringAddresses != null)
            {
                writer.WritePropertyName("bgpPeeringAddresses");
                writer.WriteStartArray();
                foreach (var item in BgpPeeringAddresses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static BgpSettings DeserializeBgpSettings(JsonElement element)
        {
            long? asn = default;
            string bgpPeeringAddress = default;
            int? peerWeight = default;
            IList<IPConfigurationBgpPeeringAddress> bgpPeeringAddresses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("asn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    asn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("bgpPeeringAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bgpPeeringAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("peerWeight"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peerWeight = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bgpPeeringAddresses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPConfigurationBgpPeeringAddress> array = new List<IPConfigurationBgpPeeringAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(IPConfigurationBgpPeeringAddress.DeserializeIPConfigurationBgpPeeringAddress(item));
                        }
                    }
                    bgpPeeringAddresses = array;
                    continue;
                }
            }
            return new BgpSettings(asn, bgpPeeringAddress, peerWeight, bgpPeeringAddresses);
        }
    }
}
