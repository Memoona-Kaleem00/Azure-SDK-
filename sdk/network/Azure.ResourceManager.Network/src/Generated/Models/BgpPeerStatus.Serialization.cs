// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class BgpPeerStatus
    {
        internal static BgpPeerStatus DeserializeBgpPeerStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> localAddress = default;
            Core.Optional<string> neighbor = default;
            Core.Optional<long> asn = default;
            Core.Optional<BgpPeerState> state = default;
            Core.Optional<TimeSpan> connectedDuration = default;
            Core.Optional<long> routesReceived = default;
            Core.Optional<long> messagesSent = default;
            Core.Optional<long> messagesReceived = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("localAddress"u8))
                {
                    localAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("neighbor"u8))
                {
                    neighbor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("asn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    asn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new BgpPeerState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("connectedDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectedDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("routesReceived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routesReceived = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("messagesSent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    messagesSent = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("messagesReceived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    messagesReceived = property.Value.GetInt64();
                    continue;
                }
            }
            return new BgpPeerStatus(localAddress.Value, neighbor.Value, Core.Optional.ToNullable(asn), Core.Optional.ToNullable(state), Core.Optional.ToNullable(connectedDuration), Core.Optional.ToNullable(routesReceived), Core.Optional.ToNullable(messagesSent), Core.Optional.ToNullable(messagesReceived));
        }
    }
}
