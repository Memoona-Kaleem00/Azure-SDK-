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
    public partial class PostgreSqlConfigurationList : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static PostgreSqlConfigurationList DeserializePostgreSqlConfigurationList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IList<PostgreSqlConfigurationData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
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
            return new PostgreSqlConfigurationList(Core.Optional.ToList(value));
        }
    }
}
