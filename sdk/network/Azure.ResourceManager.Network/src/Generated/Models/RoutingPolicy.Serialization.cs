// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class RoutingPolicy : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("destinations"u8);
            writer.WriteStartArray();
            foreach (var item in Destinations)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("nextHop"u8);
            writer.WriteStringValue(NextHop);
            writer.WriteEndObject();
        }

        internal static RoutingPolicy DeserializeRoutingPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IList<string> destinations = default;
            string nextHop = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinations"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    destinations = array;
                    continue;
                }
                if (property.NameEquals("nextHop"u8))
                {
                    nextHop = property.Value.GetString();
                    continue;
                }
            }
            return new RoutingPolicy(name, destinations, nextHop);
        }
    }
}
