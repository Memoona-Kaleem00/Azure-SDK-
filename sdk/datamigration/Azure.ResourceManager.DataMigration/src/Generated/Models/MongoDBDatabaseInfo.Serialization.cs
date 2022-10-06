// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MongoDBDatabaseInfo
    {
        internal static MongoDBDatabaseInfo DeserializeMongoDBDatabaseInfo(JsonElement element)
        {
            IReadOnlyList<MongoDBCollectionInfo> collections = default;
            bool supportsSharding = default;
            long averageDocumentSize = default;
            long dataSize = default;
            long documentCount = default;
            string name = default;
            string qualifiedName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("collections"))
                {
                    List<MongoDBCollectionInfo> array = new List<MongoDBCollectionInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MongoDBCollectionInfo.DeserializeMongoDBCollectionInfo(item));
                    }
                    collections = array;
                    continue;
                }
                if (property.NameEquals("supportsSharding"))
                {
                    supportsSharding = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("averageDocumentSize"))
                {
                    averageDocumentSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("dataSize"))
                {
                    dataSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("documentCount"))
                {
                    documentCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("qualifiedName"))
                {
                    qualifiedName = property.Value.GetString();
                    continue;
                }
            }
            return new MongoDBDatabaseInfo(averageDocumentSize, dataSize, documentCount, name, qualifiedName, collections, supportsSharding);
        }
    }
}
