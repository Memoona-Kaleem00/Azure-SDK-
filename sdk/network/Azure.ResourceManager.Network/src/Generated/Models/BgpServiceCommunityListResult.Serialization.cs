// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class BgpServiceCommunityListResult
    {
        internal static BgpServiceCommunityListResult DeserializeBgpServiceCommunityListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<BgpServiceCommunity>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BgpServiceCommunity> array = new List<BgpServiceCommunity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BgpServiceCommunity.DeserializeBgpServiceCommunity(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new BgpServiceCommunityListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
