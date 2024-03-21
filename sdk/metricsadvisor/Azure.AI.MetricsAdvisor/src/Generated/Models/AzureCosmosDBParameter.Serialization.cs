// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AzureCosmosDBParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectionString))
            {
                if (ConnectionString != null)
                {
                    writer.WritePropertyName("connectionString"u8);
                    writer.WriteStringValue(ConnectionString);
                }
                else
                {
                    writer.WriteNull("connectionString");
                }
            }
            if (SqlQuery != null)
            {
                writer.WritePropertyName("sqlQuery"u8);
                writer.WriteStringValue(SqlQuery);
            }
            else
            {
                writer.WriteNull("sqlQuery");
            }
            if (Database != null)
            {
                writer.WritePropertyName("database"u8);
                writer.WriteStringValue(Database);
            }
            else
            {
                writer.WriteNull("database");
            }
            if (CollectionId != null)
            {
                writer.WritePropertyName("collectionId"u8);
                writer.WriteStringValue(CollectionId);
            }
            else
            {
                writer.WriteNull("collectionId");
            }
            writer.WriteEndObject();
        }

        internal static AzureCosmosDBParameter DeserializeAzureCosmosDBParameter(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string connectionString = default;
            string sqlQuery = default;
            string database = default;
            string collectionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionString"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        connectionString = null;
                        continue;
                    }
                    connectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sqlQuery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sqlQuery = null;
                        continue;
                    }
                    sqlQuery = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("database"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        database = null;
                        continue;
                    }
                    database = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("collectionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        collectionId = null;
                        continue;
                    }
                    collectionId = property.Value.GetString();
                    continue;
                }
            }
            return new AzureCosmosDBParameter(connectionString, sqlQuery, database, collectionId);
        }
    }
}
