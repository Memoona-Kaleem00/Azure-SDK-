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
    [JsonConverter(typeof(AmazonRdsForOracleSourceConverter))]
    public partial class AmazonRdsForOracleSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OracleReaderQuery))
            {
                writer.WritePropertyName("oracleReaderQuery"u8);
                writer.WriteObjectValue<object>(OracleReaderQuery);
            }
            if (Optional.IsDefined(QueryTimeout))
            {
                writer.WritePropertyName("queryTimeout"u8);
                writer.WriteObjectValue<object>(QueryTimeout);
            }
            if (Optional.IsDefined(PartitionOption))
            {
                writer.WritePropertyName("partitionOption"u8);
                writer.WriteObjectValue<object>(PartitionOption);
            }
            if (Optional.IsDefined(PartitionSettings))
            {
                writer.WritePropertyName("partitionSettings"u8);
                writer.WriteObjectValue<AmazonRdsForOraclePartitionSettings>(PartitionSettings);
            }
            if (Optional.IsDefined(AdditionalColumns))
            {
                writer.WritePropertyName("additionalColumns"u8);
                writer.WriteObjectValue<object>(AdditionalColumns);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(SourceRetryCount))
            {
                writer.WritePropertyName("sourceRetryCount"u8);
                writer.WriteObjectValue<object>(SourceRetryCount);
            }
            if (Optional.IsDefined(SourceRetryWait))
            {
                writer.WritePropertyName("sourceRetryWait"u8);
                writer.WriteObjectValue<object>(SourceRetryWait);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue<object>(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue<object>(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static AmazonRdsForOracleSource DeserializeAmazonRdsForOracleSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object oracleReaderQuery = default;
            object queryTimeout = default;
            object partitionOption = default;
            AmazonRdsForOraclePartitionSettings partitionSettings = default;
            object additionalColumns = default;
            string type = default;
            object sourceRetryCount = default;
            object sourceRetryWait = default;
            object maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("oracleReaderQuery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    oracleReaderQuery = property.Value.GetObject();
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
                if (property.NameEquals("partitionOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionOption = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionSettings = AmazonRdsForOraclePartitionSettings.DeserializeAmazonRdsForOraclePartitionSettings(property.Value);
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
            return new AmazonRdsForOracleSource(
                type,
                sourceRetryCount,
                sourceRetryWait,
                maxConcurrentConnections,
                additionalProperties,
                oracleReaderQuery,
                queryTimeout,
                partitionOption,
                partitionSettings,
                additionalColumns);
        }

        internal partial class AmazonRdsForOracleSourceConverter : JsonConverter<AmazonRdsForOracleSource>
        {
            public override void Write(Utf8JsonWriter writer, AmazonRdsForOracleSource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue<AmazonRdsForOracleSource>(model);
            }
            public override AmazonRdsForOracleSource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAmazonRdsForOracleSource(document.RootElement);
            }
        }
    }
}
