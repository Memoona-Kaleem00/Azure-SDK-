// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class PropagatedRouteTable : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels");
                writer.WriteStartArray();
                foreach (var item in Labels)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Ids))
            {
                writer.WritePropertyName("ids");
                writer.WriteStartArray();
                foreach (var item in Ids)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static PropagatedRouteTable DeserializePropagatedRouteTable(JsonElement element)
        {
            Optional<IList<string>> labels = default;
            Optional<IList<SubResource>> ids = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("labels"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    labels = array;
                    continue;
                }
                if (property.NameEquals("ids"))
                {
                    List<SubResource> array = new List<SubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SubResource.DeserializeSubResource(item));
                    }
                    ids = array;
                    continue;
                }
            }
            return new PropagatedRouteTable(Optional.ToList(labels), Optional.ToList(ids));
        }
    }
}
