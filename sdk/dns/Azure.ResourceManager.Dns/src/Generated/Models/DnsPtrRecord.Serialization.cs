// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dns.Models
{
    public partial class DnsPtrRecord : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PtrdName))
            {
                writer.WritePropertyName("ptrdname");
                writer.WriteStringValue(PtrdName);
            }
            writer.WriteEndObject();
        }

        internal static DnsPtrRecord DeserializeDnsPtrRecord(JsonElement element)
        {
            Optional<string> ptrdname = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ptrdname"))
                {
                    ptrdname = property.Value.GetString();
                    continue;
                }
            }
            return new DnsPtrRecord(ptrdname.Value);
        }
    }
}
