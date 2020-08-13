// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ReferencedPublicIpAddress
    {
        internal static ReferencedPublicIpAddress DeserializeReferencedPublicIpAddress(JsonElement element)
        {
            Optional<string> id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new ReferencedPublicIpAddress(id.Value);
        }
    }
}
