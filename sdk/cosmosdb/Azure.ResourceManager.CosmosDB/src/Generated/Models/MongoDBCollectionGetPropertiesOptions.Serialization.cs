// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class MongoDBCollectionGetPropertiesOptions
    {
        internal static MongoDBCollectionGetPropertiesOptions DeserializeMongoDBCollectionGetPropertiesOptions(JsonElement element)
        {
            Optional<int> throughput = default;
            Optional<AutoscaleSettings> autoscaleSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("throughput"))
                {
                    throughput = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("autoscaleSettings"))
                {
                    autoscaleSettings = AutoscaleSettings.DeserializeAutoscaleSettings(property.Value);
                    continue;
                }
            }
            return new MongoDBCollectionGetPropertiesOptions(Optional.ToNullable(throughput), autoscaleSettings.Value);
        }
    }
}
