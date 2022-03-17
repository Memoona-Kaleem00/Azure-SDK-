// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectionMonitorEndpointFilterItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectionMonitorEndpointFilterItemType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(ConnectionMonitorEndpointFilterItemType.Value.ToString());
            }
            if (Optional.IsDefined(Address))
            {
                writer.WritePropertyName("address");
                writer.WriteStringValue(Address);
            }
            writer.WriteEndObject();
        }

        internal static ConnectionMonitorEndpointFilterItem DeserializeConnectionMonitorEndpointFilterItem(JsonElement element)
        {
            Optional<ConnectionMonitorEndpointFilterItemType> type = default;
            Optional<string> address = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new ConnectionMonitorEndpointFilterItemType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("address"))
                {
                    address = property.Value.GetString();
                    continue;
                }
            }
            return new ConnectionMonitorEndpointFilterItem(Optional.ToNullable(type), address.Value);
        }
    }
}
