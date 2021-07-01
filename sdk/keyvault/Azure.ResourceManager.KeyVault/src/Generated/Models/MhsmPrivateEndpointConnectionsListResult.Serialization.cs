// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    internal partial class MhsmPrivateEndpointConnectionsListResult
    {
        internal static MhsmPrivateEndpointConnectionsListResult DeserializeMhsmPrivateEndpointConnectionsListResult(JsonElement element)
        {
            Optional<IReadOnlyList<MhsmPrivateEndpointConnection>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MhsmPrivateEndpointConnection> array = new List<MhsmPrivateEndpointConnection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MhsmPrivateEndpointConnection.DeserializeMhsmPrivateEndpointConnection(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new MhsmPrivateEndpointConnectionsListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
