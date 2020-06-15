// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndexerDataSourceConnection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Description != null)
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("credentials");
            writer.WriteObjectValue(CredentialsInternal);
            writer.WritePropertyName("container");
            writer.WriteObjectValue(Container);
            if (DataChangeDetectionPolicy != null)
            {
                writer.WritePropertyName("dataChangeDetectionPolicy");
                writer.WriteObjectValue(DataChangeDetectionPolicy);
            }
            if (DataDeletionDetectionPolicy != null)
            {
                writer.WritePropertyName("dataDeletionDetectionPolicy");
                writer.WriteObjectValue(DataDeletionDetectionPolicy);
            }
            if (_etag != null)
            {
                writer.WritePropertyName("@odata.etag");
                writer.WriteStringValue(_etag);
            }
            writer.WriteEndObject();
        }

        internal static SearchIndexerDataSourceConnection DeserializeSearchIndexerDataSourceConnection(JsonElement element)
        {
            string name = default;
            string description = default;
            SearchIndexerDataSourceType type = default;
            DataSourceCredentials credentials = default;
            SearchIndexerDataContainer container = default;
            DataChangeDetectionPolicy dataChangeDetectionPolicy = default;
            DataDeletionDetectionPolicy dataDeletionDetectionPolicy = default;
            string odataEtag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new SearchIndexerDataSourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("credentials"))
                {
                    credentials = DataSourceCredentials.DeserializeDataSourceCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("container"))
                {
                    container = SearchIndexerDataContainer.DeserializeSearchIndexerDataContainer(property.Value);
                    continue;
                }
                if (property.NameEquals("dataChangeDetectionPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataChangeDetectionPolicy = DataChangeDetectionPolicy.DeserializeDataChangeDetectionPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("dataDeletionDetectionPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataDeletionDetectionPolicy = DataDeletionDetectionPolicy.DeserializeDataDeletionDetectionPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("@odata.etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    odataEtag = property.Value.GetString();
                    continue;
                }
            }
            return new SearchIndexerDataSourceConnection(name, description, type, credentials, container, dataChangeDetectionPolicy, dataDeletionDetectionPolicy, odataEtag);
        }
    }
}
