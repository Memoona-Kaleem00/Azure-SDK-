// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class UnknownActiveBaseSecurityAdminRule
    {
        internal static UnknownActiveBaseSecurityAdminRule DeserializeUnknownActiveBaseSecurityAdminRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> id = default;
            Core.Optional<DateTimeOffset> commitTime = default;
            Core.Optional<string> region = default;
            Core.Optional<string> configurationDescription = default;
            Core.Optional<string> ruleCollectionDescription = default;
            Core.Optional<IReadOnlyList<NetworkManagerSecurityGroupItem>> ruleCollectionAppliesToGroups = default;
            Core.Optional<IReadOnlyList<NetworkConfigurationGroup>> ruleGroups = default;
            EffectiveAdminRuleKind kind = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("commitTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    commitTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationDescription"u8))
                {
                    configurationDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleCollectionDescription"u8))
                {
                    ruleCollectionDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleCollectionAppliesToGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkManagerSecurityGroupItem> array = new List<NetworkManagerSecurityGroupItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkManagerSecurityGroupItem.DeserializeNetworkManagerSecurityGroupItem(item));
                    }
                    ruleCollectionAppliesToGroups = array;
                    continue;
                }
                if (property.NameEquals("ruleGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkConfigurationGroup> array = new List<NetworkConfigurationGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkConfigurationGroup.DeserializeNetworkConfigurationGroup(item));
                    }
                    ruleGroups = array;
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new EffectiveAdminRuleKind(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownActiveBaseSecurityAdminRule(id.Value, Core.Optional.ToNullable(commitTime), region.Value, configurationDescription.Value, ruleCollectionDescription.Value, Core.Optional.ToList(ruleCollectionAppliesToGroups), Core.Optional.ToList(ruleGroups), kind);
        }
    }
}
