// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SparkSourceConverter))]
    public partial class SparkSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Query != null)
            {
                writer.WritePropertyName("query"u8);
                writer.WriteObjectValue(Query);
            }
            if (QueryTimeout != null)
            {
                writer.WritePropertyName("queryTimeout"u8);
                writer.WriteObjectValue(QueryTimeout);
            }
            if (AdditionalColumns != null)
            {
                writer.WritePropertyName("additionalColumns"u8);
                writer.WriteObjectValue(AdditionalColumns);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (SourceRetryCount != null)
            {
                writer.WritePropertyName("sourceRetryCount"u8);
                writer.WriteObjectValue(SourceRetryCount);
            }
            if (SourceRetryWait != null)
            {
                writer.WritePropertyName("sourceRetryWait"u8);
                writer.WriteObjectValue(SourceRetryWait);
            }
            if (MaxConcurrentConnections != null)
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static SparkSource DeserializeSparkSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> query = default;
            Optional<object> queryTimeout = default;
            Optional<object> additionalColumns = default;
            string type = default;
            Optional<object> sourceRetryCount = default;
            Optional<object> sourceRetryWait = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    query = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("queryTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryTimeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("additionalColumns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalColumns = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sourceRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryWait = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SparkSource(
                type,
                sourceRetryCount.Value,
                sourceRetryWait.Value,
                maxConcurrentConnections.Value,
                additionalProperties,
                queryTimeout.Value,
                additionalColumns.Value,
                query.Value);
        }

        internal partial class SparkSourceConverter : JsonConverter<SparkSource>
        {
            public override void Write(Utf8JsonWriter writer, SparkSource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SparkSource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSparkSource(document.RootElement);
            }
        }
    }
}
