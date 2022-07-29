// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PostgreSql;

namespace Azure.ResourceManager.PostgreSql.Models
{
    public partial class PostgreSqlConfigurationListResult
    {
        internal static PostgreSqlConfigurationListResult DeserializePostgreSqlConfigurationListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PostgreSqlConfigurationData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PostgreSqlConfigurationData> array = new List<PostgreSqlConfigurationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlConfigurationData.DeserializePostgreSqlConfigurationData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new PostgreSqlConfigurationListResult(Optional.ToList(value));
        }
    }
}
