// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class QueryStatistics : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Intervals))
            {
                writer.WritePropertyName("intervals");
                writer.WriteStartArray();
                foreach (var item in Intervals)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static QueryStatistics DeserializeQueryStatistics(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> databaseName = default;
            Optional<string> queryId = default;
            Optional<string> startTime = default;
            Optional<string> endTime = default;
            Optional<IList<QueryMetricInterval>> intervals = default;
            foreach (var property in element.EnumerateObject())
            {
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
                    type = (ResourceType)property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
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
                        if (property0.NameEquals("databaseName"))
                        {
                            databaseName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("queryId"))
                        {
                            queryId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startTime"))
                        {
                            startTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endTime"))
                        {
                            endTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("intervals"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<QueryMetricInterval> array = new List<QueryMetricInterval>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(QueryMetricInterval.DeserializeQueryMetricInterval(item));
                            }
                            intervals = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new QueryStatistics(id, name, type, systemData, databaseName.Value, queryId.Value, startTime.Value, endTime.Value, Optional.ToList(intervals));
        }
    }
}
