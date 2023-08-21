// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult
    {
        internal static PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult DeserializePostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<PostgreSqlFlexibleServerDelegatedSubnetUsage>> delegatedSubnetsUsage = default;
            Core.Optional<AzureLocation> location = default;
            Core.Optional<string> subscriptionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("delegatedSubnetsUsage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlFlexibleServerDelegatedSubnetUsage> array = new List<PostgreSqlFlexibleServerDelegatedSubnetUsage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerDelegatedSubnetUsage.DeserializePostgreSqlFlexibleServerDelegatedSubnetUsage(item));
                    }
                    delegatedSubnetsUsage = array;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
            }
            return new PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult(Core.Optional.ToList(delegatedSubnetsUsage), Core.Optional.ToNullable(location), subscriptionId.Value);
        }
    }
}
