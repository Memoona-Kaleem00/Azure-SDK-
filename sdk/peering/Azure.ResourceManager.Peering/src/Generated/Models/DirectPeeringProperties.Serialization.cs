// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Peering.Models
{
    public partial class DirectPeeringProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(Connections))
            {
                writer.WritePropertyName("connections"u8);
                writer.WriteStartArray();
                foreach (var item in Connections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(PeerAsn))
            {
                writer.WritePropertyName("peerAsn"u8);
                JsonSerializer.Serialize(writer, PeerAsn);
            }
            if (Core.Optional.IsDefined(DirectPeeringType))
            {
                writer.WritePropertyName("directPeeringType"u8);
                writer.WriteStringValue(DirectPeeringType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static DirectPeeringProperties DeserializeDirectPeeringProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IList<PeeringDirectConnection>> connections = default;
            Core.Optional<bool> useForPeeringService = default;
            Core.Optional<WritableSubResource> peerAsn = default;
            Core.Optional<DirectPeeringType> directPeeringType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PeeringDirectConnection> array = new List<PeeringDirectConnection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PeeringDirectConnection.DeserializePeeringDirectConnection(item));
                    }
                    connections = array;
                    continue;
                }
                if (property.NameEquals("useForPeeringService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useForPeeringService = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("peerAsn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peerAsn = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("directPeeringType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    directPeeringType = new DirectPeeringType(property.Value.GetString());
                    continue;
                }
            }
            return new DirectPeeringProperties(Core.Optional.ToList(connections), Core.Optional.ToNullable(useForPeeringService), peerAsn, Core.Optional.ToNullable(directPeeringType));
        }
    }
}
