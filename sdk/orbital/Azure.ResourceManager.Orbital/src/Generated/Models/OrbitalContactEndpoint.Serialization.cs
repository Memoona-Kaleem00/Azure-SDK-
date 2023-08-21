// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Orbital.Models
{
    public partial class OrbitalContactEndpoint : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ipAddress"u8);
            writer.WriteStringValue(IPAddress.ToString());
            writer.WritePropertyName("endPointName"u8);
            writer.WriteStringValue(EndPointName);
            writer.WritePropertyName("port"u8);
            writer.WriteStringValue(Port);
            writer.WritePropertyName("protocol"u8);
            writer.WriteStringValue(Protocol.ToString());
            writer.WriteEndObject();
        }

        internal static OrbitalContactEndpoint DeserializeOrbitalContactEndpoint(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IPAddress ipAddress = default;
            string endPointName = default;
            string port = default;
            OrbitalContactProtocol protocol = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddress"u8))
                {
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endPointName"u8))
                {
                    endPointName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    port = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    protocol = new OrbitalContactProtocol(property.Value.GetString());
                    continue;
                }
            }
            return new OrbitalContactEndpoint(ipAddress, endPointName, port, protocol);
        }
    }
}
