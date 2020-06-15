// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VirtualWanSecurityProvider
    {
        internal static VirtualWanSecurityProvider DeserializeVirtualWanSecurityProvider(JsonElement element)
        {
            string name = default;
            string url = default;
            VirtualWanSecurityProviderType? type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new VirtualWanSecurityProviderType(property.Value.GetString());
                    continue;
                }
            }
            return new VirtualWanSecurityProvider(name, url, type);
        }
    }
}
