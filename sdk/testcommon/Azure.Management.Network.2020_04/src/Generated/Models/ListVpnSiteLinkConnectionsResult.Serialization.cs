// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ListVpnSiteLinkConnectionsResult
    {
        internal static ListVpnSiteLinkConnectionsResult DeserializeListVpnSiteLinkConnectionsResult(JsonElement element)
        {
            Optional<IReadOnlyList<VpnSiteLinkConnection>> value = default;
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
                    List<VpnSiteLinkConnection> array = new List<VpnSiteLinkConnection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VpnSiteLinkConnection.DeserializeVpnSiteLinkConnection(item));
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
            return new ListVpnSiteLinkConnectionsResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
