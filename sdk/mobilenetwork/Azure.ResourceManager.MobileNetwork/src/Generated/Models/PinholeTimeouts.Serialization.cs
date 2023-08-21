// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class PinholeTimeouts : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Tcp))
            {
                writer.WritePropertyName("tcp"u8);
                writer.WriteNumberValue(Tcp.Value);
            }
            if (Core.Optional.IsDefined(Udp))
            {
                writer.WritePropertyName("udp"u8);
                writer.WriteNumberValue(Udp.Value);
            }
            if (Core.Optional.IsDefined(Icmp))
            {
                writer.WritePropertyName("icmp"u8);
                writer.WriteNumberValue(Icmp.Value);
            }
            writer.WriteEndObject();
        }

        internal static PinholeTimeouts DeserializePinholeTimeouts(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<int> tcp = default;
            Core.Optional<int> udp = default;
            Core.Optional<int> icmp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tcp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tcp = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("udp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    udp = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("icmp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    icmp = property.Value.GetInt32();
                    continue;
                }
            }
            return new PinholeTimeouts(Core.Optional.ToNullable(tcp), Core.Optional.ToNullable(udp), Core.Optional.ToNullable(icmp));
        }
    }
}
