// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ConnectToSourceSqlServerTaskOutputDatabaseLevel
    {
        internal static ConnectToSourceSqlServerTaskOutputDatabaseLevel DeserializeConnectToSourceSqlServerTaskOutputDatabaseLevel(JsonElement element)
        {
            Optional<string> name = default;
            Optional<double> sizeMB = default;
            Optional<IReadOnlyList<DatabaseFileInfo>> databaseFiles = default;
            Optional<DatabaseCompatLevel> compatibilityLevel = default;
            Optional<DatabaseState> databaseState = default;
            Optional<string> id = default;
            string resultType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sizeMB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sizeMB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("databaseFiles"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DatabaseFileInfo> array = new List<DatabaseFileInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatabaseFileInfo.DeserializeDatabaseFileInfo(item));
                    }
                    databaseFiles = array;
                    continue;
                }
                if (property.NameEquals("compatibilityLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    compatibilityLevel = new DatabaseCompatLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("databaseState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    databaseState = new DatabaseState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
            }
            return new ConnectToSourceSqlServerTaskOutputDatabaseLevel(id.Value, resultType, name.Value, Optional.ToNullable(sizeMB), Optional.ToList(databaseFiles), Optional.ToNullable(compatibilityLevel), Optional.ToNullable(databaseState));
        }
    }
}
