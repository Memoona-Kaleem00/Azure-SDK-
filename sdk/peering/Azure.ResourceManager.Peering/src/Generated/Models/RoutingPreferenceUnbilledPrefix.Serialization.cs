// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Peering.Models
{
    public partial class RoutingPreferenceUnbilledPrefix
    {
        internal static RoutingPreferenceUnbilledPrefix DeserializeRoutingPreferenceUnbilledPrefix(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> prefix = default;
            Core.Optional<AzureLocation> azureRegion = default;
            Core.Optional<int> peerAsn = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prefix"u8))
                {
                    prefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureRegion = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("peerAsn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peerAsn = property.Value.GetInt32();
                    continue;
                }
            }
            return new RoutingPreferenceUnbilledPrefix(prefix.Value, Core.Optional.ToNullable(azureRegion), Core.Optional.ToNullable(peerAsn));
        }
    }
}
