// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class StaticRoute : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Core.Optional.IsCollectionDefined(AddressPrefixes))
            {
                writer.WritePropertyName("addressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in AddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(NextHopIPAddress))
            {
                writer.WritePropertyName("nextHopIpAddress"u8);
                writer.WriteStringValue(NextHopIPAddress);
            }
            writer.WriteEndObject();
        }

        internal static StaticRoute DeserializeStaticRoute(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            Core.Optional<IList<string>> addressPrefixes = default;
            Core.Optional<string> nextHopIPAddress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addressPrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    addressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("nextHopIpAddress"u8))
                {
                    nextHopIPAddress = property.Value.GetString();
                    continue;
                }
            }
            return new StaticRoute(name.Value, Core.Optional.ToList(addressPrefixes), nextHopIPAddress.Value);
        }
    }
}
