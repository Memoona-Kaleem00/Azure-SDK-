// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkManagerSecurityGroupItem : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("networkGroupId"u8);
            writer.WriteStringValue(NetworkGroupId);
            writer.WriteEndObject();
        }

        internal static NetworkManagerSecurityGroupItem DeserializeNetworkManagerSecurityGroupItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier networkGroupId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkGroupId"u8))
                {
                    networkGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new NetworkManagerSecurityGroupItem(networkGroupId);
        }
    }
}
