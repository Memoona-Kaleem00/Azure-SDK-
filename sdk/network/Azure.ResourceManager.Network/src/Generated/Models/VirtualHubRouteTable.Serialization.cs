// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class VirtualHubRouteTable : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(Routes))
            {
                writer.WritePropertyName("routes"u8);
                writer.WriteStartArray();
                foreach (var item in Routes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static VirtualHubRouteTable DeserializeVirtualHubRouteTable(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IList<VirtualHubRoute>> routes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualHubRoute> array = new List<VirtualHubRoute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualHubRoute.DeserializeVirtualHubRoute(item));
                    }
                    routes = array;
                    continue;
                }
            }
            return new VirtualHubRouteTable(Core.Optional.ToList(routes));
        }
    }
}
