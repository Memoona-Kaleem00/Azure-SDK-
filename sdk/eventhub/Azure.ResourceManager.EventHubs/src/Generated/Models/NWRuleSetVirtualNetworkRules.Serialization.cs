// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class NWRuleSetVirtualNetworkRules : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Subnet))
            {
                writer.WritePropertyName("subnet");
                writer.WriteObjectValue(Subnet);
            }
            if (Optional.IsDefined(IgnoreMissingVnetServiceEndpoint))
            {
                writer.WritePropertyName("ignoreMissingVnetServiceEndpoint");
                writer.WriteBooleanValue(IgnoreMissingVnetServiceEndpoint.Value);
            }
            writer.WriteEndObject();
        }

        internal static NWRuleSetVirtualNetworkRules DeserializeNWRuleSetVirtualNetworkRules(JsonElement element)
        {
            Optional<Subnet> subnet = default;
            Optional<bool> ignoreMissingVnetServiceEndpoint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnet"))
                {
                    subnet = Subnet.DeserializeSubnet(property.Value);
                    continue;
                }
                if (property.NameEquals("ignoreMissingVnetServiceEndpoint"))
                {
                    ignoreMissingVnetServiceEndpoint = property.Value.GetBoolean();
                    continue;
                }
            }
            return new NWRuleSetVirtualNetworkRules(subnet.Value, Optional.ToNullable(ignoreMissingVnetServiceEndpoint));
        }
    }
}
