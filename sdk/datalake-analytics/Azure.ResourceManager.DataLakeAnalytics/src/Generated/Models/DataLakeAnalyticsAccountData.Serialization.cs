// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataLakeAnalytics.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataLakeAnalytics
{
    public partial class DataLakeAnalyticsAccountData
    {
        internal static DataLakeAnalyticsAccountData DeserializeDataLakeAnalyticsAccountData(JsonElement element)
        {
            Optional<AzureLocation> location = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Guid> accountId = default;
            Optional<DataLakeAnalyticsAccountStatus> provisioningState = default;
            Optional<DataLakeAnalyticsAccountState> state = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<string> endpoint = default;
            Optional<string> defaultDataLakeStoreAccountType = default;
            Optional<string> defaultDataLakeStoreAccount = default;
            Optional<IReadOnlyList<DataLakeStoreAccountInformationData>> dataLakeStoreAccounts = default;
            Optional<IReadOnlyList<DataLakeStoreAccountInformationData>> publicDataLakeStoreAccounts = default;
            Optional<IReadOnlyList<StorageAccountInformationData>> storageAccounts = default;
            Optional<IReadOnlyList<ComputePolicyData>> computePolicies = default;
            Optional<IReadOnlyList<HiveMetastore>> hiveMetastores = default;
            Optional<IReadOnlyList<VirtualNetworkRule>> virtualNetworkRules = default;
            Optional<IReadOnlyList<FirewallRuleData>> firewallRules = default;
            Optional<FirewallState> firewallState = default;
            Optional<FirewallAllowAzureIPsState> firewallAllowAzureIPs = default;
            Optional<TierType> newTier = default;
            Optional<TierType> currentTier = default;
            Optional<int> maxJobCount = default;
            Optional<int> maxActiveJobCountPerUser = default;
            Optional<int> maxQueuedJobCountPerUser = default;
            Optional<int> maxJobRunningTimeInMin = default;
            Optional<int> systemMaxJobCount = default;
            Optional<int> maxDegreeOfParallelism = default;
            Optional<int> systemMaxDegreeOfParallelism = default;
            Optional<int> maxDegreeOfParallelismPerJob = default;
            Optional<int> minPriorityPerJob = default;
            Optional<int> queryStoreRetention = default;
            Optional<DebugDataAccessLevel> debugDataAccessLevel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("accountId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            accountId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToDataLakeAnalyticsAccountStatus();
                            continue;
                        }
                        if (property0.NameEquals("state"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            state = property0.Value.GetString().ToDataLakeAnalyticsAccountState();
                            continue;
                        }
                        if (property0.NameEquals("creationTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endpoint"))
                        {
                            endpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultDataLakeStoreAccountType"))
                        {
                            defaultDataLakeStoreAccountType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultDataLakeStoreAccount"))
                        {
                            defaultDataLakeStoreAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataLakeStoreAccounts"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DataLakeStoreAccountInformationData> array = new List<DataLakeStoreAccountInformationData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeStoreAccountInformationData.DeserializeDataLakeStoreAccountInformationData(item));
                            }
                            dataLakeStoreAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("publicDataLakeStoreAccounts"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DataLakeStoreAccountInformationData> array = new List<DataLakeStoreAccountInformationData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeStoreAccountInformationData.DeserializeDataLakeStoreAccountInformationData(item));
                            }
                            publicDataLakeStoreAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("storageAccounts"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<StorageAccountInformationData> array = new List<StorageAccountInformationData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StorageAccountInformationData.DeserializeStorageAccountInformationData(item));
                            }
                            storageAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("computePolicies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ComputePolicyData> array = new List<ComputePolicyData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ComputePolicyData.DeserializeComputePolicyData(item));
                            }
                            computePolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("hiveMetastores"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<HiveMetastore> array = new List<HiveMetastore>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HiveMetastore.DeserializeHiveMetastore(item));
                            }
                            hiveMetastores = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VirtualNetworkRule> array = new List<VirtualNetworkRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualNetworkRule.DeserializeVirtualNetworkRule(item));
                            }
                            virtualNetworkRules = array;
                            continue;
                        }
                        if (property0.NameEquals("firewallRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<FirewallRuleData> array = new List<FirewallRuleData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FirewallRuleData.DeserializeFirewallRuleData(item));
                            }
                            firewallRules = array;
                            continue;
                        }
                        if (property0.NameEquals("firewallState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            firewallState = property0.Value.GetString().ToFirewallState();
                            continue;
                        }
                        if (property0.NameEquals("firewallAllowAzureIps"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            firewallAllowAzureIPs = property0.Value.GetString().ToFirewallAllowAzureIPsState();
                            continue;
                        }
                        if (property0.NameEquals("newTier"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            newTier = property0.Value.GetString().ToTierType();
                            continue;
                        }
                        if (property0.NameEquals("currentTier"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            currentTier = property0.Value.GetString().ToTierType();
                            continue;
                        }
                        if (property0.NameEquals("maxJobCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxJobCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxActiveJobCountPerUser"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxActiveJobCountPerUser = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxQueuedJobCountPerUser"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxQueuedJobCountPerUser = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxJobRunningTimeInMin"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxJobRunningTimeInMin = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("systemMaxJobCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            systemMaxJobCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxDegreeOfParallelism"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxDegreeOfParallelism = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("systemMaxDegreeOfParallelism"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            systemMaxDegreeOfParallelism = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxDegreeOfParallelismPerJob"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxDegreeOfParallelismPerJob = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("minPriorityPerJob"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            minPriorityPerJob = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("queryStoreRetention"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            queryStoreRetention = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("debugDataAccessLevel"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            debugDataAccessLevel = property0.Value.GetString().ToDebugDataAccessLevel();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DataLakeAnalyticsAccountData(id, name, type, systemData.Value, Optional.ToNullable(accountId), Optional.ToNullable(provisioningState), Optional.ToNullable(state), Optional.ToNullable(creationTime), Optional.ToNullable(lastModifiedTime), endpoint.Value, defaultDataLakeStoreAccountType.Value, defaultDataLakeStoreAccount.Value, Optional.ToList(dataLakeStoreAccounts), Optional.ToList(publicDataLakeStoreAccounts), Optional.ToList(storageAccounts), Optional.ToList(computePolicies), Optional.ToList(hiveMetastores), Optional.ToList(virtualNetworkRules), Optional.ToList(firewallRules), Optional.ToNullable(firewallState), Optional.ToNullable(firewallAllowAzureIPs), Optional.ToNullable(newTier), Optional.ToNullable(currentTier), Optional.ToNullable(maxJobCount), Optional.ToNullable(maxActiveJobCountPerUser), Optional.ToNullable(maxQueuedJobCountPerUser), Optional.ToNullable(maxJobRunningTimeInMin), Optional.ToNullable(systemMaxJobCount), Optional.ToNullable(maxDegreeOfParallelism), Optional.ToNullable(systemMaxDegreeOfParallelism), Optional.ToNullable(maxDegreeOfParallelismPerJob), Optional.ToNullable(minPriorityPerJob), Optional.ToNullable(queryStoreRetention), Optional.ToNullable(debugDataAccessLevel), Optional.ToNullable(location), Optional.ToDictionary(tags));
        }
    }
}
