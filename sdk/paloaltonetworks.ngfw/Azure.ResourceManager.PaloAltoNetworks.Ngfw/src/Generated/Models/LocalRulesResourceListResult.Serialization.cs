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
    internal partial class LocalRulesResourceListResult
    {
        internal static LocalRulesResourceListResult DeserializeLocalRulesResourceListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<LocalRulestackRuleData> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<LocalRulestackRuleData> array = new List<LocalRulestackRuleData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LocalRulestackRuleData.DeserializeLocalRulestackRuleData(item));
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
            return new LocalRulesResourceListResult(value, nextLink.Value);
        }
    }
}
