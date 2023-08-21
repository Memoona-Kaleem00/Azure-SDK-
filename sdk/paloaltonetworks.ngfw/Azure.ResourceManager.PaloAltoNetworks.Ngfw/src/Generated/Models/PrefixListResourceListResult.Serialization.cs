// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    internal partial class PrefixListResourceListResult
    {
        internal static PrefixListResourceListResult DeserializePrefixListResourceListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<LocalRulestackPrefixData> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<LocalRulestackPrefixData> array = new List<LocalRulestackPrefixData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LocalRulestackPrefixData.DeserializeLocalRulestackPrefixData(item));
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
            return new PrefixListResourceListResult(value, nextLink.Value);
        }
    }
}
