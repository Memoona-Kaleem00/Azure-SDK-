// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.Models
{
    public partial class PostgreSqlPerformanceTierProperties
    {
        internal static PostgreSqlPerformanceTierProperties DeserializePostgreSqlPerformanceTierProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> id = default;
            Core.Optional<int> maxBackupRetentionDays = default;
            Core.Optional<int> minBackupRetentionDays = default;
            Core.Optional<int> maxStorageMB = default;
            Core.Optional<int> minLargeStorageMB = default;
            Core.Optional<int> maxLargeStorageMB = default;
            Core.Optional<int> minStorageMB = default;
            Core.Optional<IReadOnlyList<PostgreSqlPerformanceTierServiceLevelObjectives>> serviceLevelObjectives = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxBackupRetentionDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxBackupRetentionDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minBackupRetentionDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minBackupRetentionDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxStorageMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minLargeStorageMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minLargeStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxLargeStorageMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxLargeStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minStorageMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("serviceLevelObjectives"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlPerformanceTierServiceLevelObjectives> array = new List<PostgreSqlPerformanceTierServiceLevelObjectives>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlPerformanceTierServiceLevelObjectives.DeserializePostgreSqlPerformanceTierServiceLevelObjectives(item));
                    }
                    serviceLevelObjectives = array;
                    continue;
                }
            }
            return new PostgreSqlPerformanceTierProperties(id.Value, Core.Optional.ToNullable(maxBackupRetentionDays), Core.Optional.ToNullable(minBackupRetentionDays), Core.Optional.ToNullable(maxStorageMB), Core.Optional.ToNullable(minLargeStorageMB), Core.Optional.ToNullable(maxLargeStorageMB), Core.Optional.ToNullable(minStorageMB), Core.Optional.ToList(serviceLevelObjectives));
        }
    }
}
