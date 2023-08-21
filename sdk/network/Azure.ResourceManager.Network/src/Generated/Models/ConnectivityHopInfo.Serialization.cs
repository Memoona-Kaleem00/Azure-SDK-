// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectivityHopInfo
    {
        internal static ConnectivityHopInfo DeserializeConnectivityHopInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> type = default;
            Core.Optional<string> id = default;
            Core.Optional<string> address = default;
            Core.Optional<ResourceIdentifier> resourceId = default;
            Core.Optional<IReadOnlyList<string>> nextHopIds = default;
            Core.Optional<IReadOnlyList<string>> previousHopIds = default;
            Core.Optional<IReadOnlyList<HopLink>> links = default;
            Core.Optional<IReadOnlyList<HopLink>> previousLinks = default;
            Core.Optional<IReadOnlyList<ConnectivityIssueInfo>> issues = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("address"u8))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nextHopIds"u8))
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
                    nextHopIds = array;
                    continue;
                }
                if (property.NameEquals("previousHopIds"u8))
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
                    previousHopIds = array;
                    continue;
                }
                if (property.NameEquals("links"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HopLink> array = new List<HopLink>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HopLink.DeserializeHopLink(item));
                    }
                    links = array;
                    continue;
                }
                if (property.NameEquals("previousLinks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HopLink> array = new List<HopLink>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HopLink.DeserializeHopLink(item));
                    }
                    previousLinks = array;
                    continue;
                }
                if (property.NameEquals("issues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectivityIssueInfo> array = new List<ConnectivityIssueInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectivityIssueInfo.DeserializeConnectivityIssueInfo(item));
                    }
                    issues = array;
                    continue;
                }
            }
            return new ConnectivityHopInfo(type.Value, id.Value, address.Value, resourceId.Value, Core.Optional.ToList(nextHopIds), Core.Optional.ToList(previousHopIds), Core.Optional.ToList(links), Core.Optional.ToList(previousLinks), Core.Optional.ToList(issues));
        }
    }
}
