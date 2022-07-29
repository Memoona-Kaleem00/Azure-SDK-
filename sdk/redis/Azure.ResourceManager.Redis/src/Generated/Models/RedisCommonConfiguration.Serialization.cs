// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Redis.Models
{
    public partial class RedisCommonConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RdbBackupEnabled))
            {
                writer.WritePropertyName("rdb-backup-enabled");
                writer.WriteStringValue(RdbBackupEnabled);
            }
            if (Optional.IsDefined(RdbBackupFrequency))
            {
                writer.WritePropertyName("rdb-backup-frequency");
                writer.WriteStringValue(RdbBackupFrequency);
            }
            if (Optional.IsDefined(RdbBackupMaxSnapshotCount))
            {
                writer.WritePropertyName("rdb-backup-max-snapshot-count");
                writer.WriteStringValue(RdbBackupMaxSnapshotCount);
            }
            if (Optional.IsDefined(RdbStorageConnectionString))
            {
                writer.WritePropertyName("rdb-storage-connection-string");
                writer.WriteStringValue(RdbStorageConnectionString);
            }
            if (Optional.IsDefined(AofBackupEnabled))
            {
                writer.WritePropertyName("aof-backup-enabled");
                writer.WriteStringValue(AofBackupEnabled);
            }
            if (Optional.IsDefined(AofStorageConnectionString0))
            {
                writer.WritePropertyName("aof-storage-connection-string-0");
                writer.WriteStringValue(AofStorageConnectionString0);
            }
            if (Optional.IsDefined(AofStorageConnectionString1))
            {
                writer.WritePropertyName("aof-storage-connection-string-1");
                writer.WriteStringValue(AofStorageConnectionString1);
            }
            if (Optional.IsDefined(MaxFragmentationMemoryReserved))
            {
                writer.WritePropertyName("maxfragmentationmemory-reserved");
                writer.WriteStringValue(MaxFragmentationMemoryReserved);
            }
            if (Optional.IsDefined(MaxMemoryPolicy))
            {
                writer.WritePropertyName("maxmemory-policy");
                writer.WriteStringValue(MaxMemoryPolicy);
            }
            if (Optional.IsDefined(MaxMemoryReserved))
            {
                writer.WritePropertyName("maxmemory-reserved");
                writer.WriteStringValue(MaxMemoryReserved);
            }
            if (Optional.IsDefined(MaxMemoryDelta))
            {
                writer.WritePropertyName("maxmemory-delta");
                writer.WriteStringValue(MaxMemoryDelta);
            }
            if (Optional.IsDefined(AuthNotRequired))
            {
                writer.WritePropertyName("authnotrequired");
                writer.WriteStringValue(AuthNotRequired);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static RedisCommonConfiguration DeserializeRedisCommonConfiguration(JsonElement element)
        {
            Optional<string> rdbBackupEnabled = default;
            Optional<string> rdbBackupFrequency = default;
            Optional<string> rdbBackupMaxSnapshotCount = default;
            Optional<string> rdbStorageConnectionString = default;
            Optional<string> aofBackupEnabled = default;
            Optional<string> aofStorageConnectionString0 = default;
            Optional<string> aofStorageConnectionString1 = default;
            Optional<string> maxfragmentationmemoryReserved = default;
            Optional<string> maxmemoryPolicy = default;
            Optional<string> maxmemoryReserved = default;
            Optional<string> maxmemoryDelta = default;
            Optional<string> maxclients = default;
            Optional<string> preferredDataArchiveAuthMethod = default;
            Optional<string> preferredDataPersistenceAuthMethod = default;
            Optional<string> zonalConfiguration = default;
            Optional<string> authnotrequired = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rdb-backup-enabled"))
                {
                    rdbBackupEnabled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rdb-backup-frequency"))
                {
                    rdbBackupFrequency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rdb-backup-max-snapshot-count"))
                {
                    rdbBackupMaxSnapshotCount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rdb-storage-connection-string"))
                {
                    rdbStorageConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aof-backup-enabled"))
                {
                    aofBackupEnabled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aof-storage-connection-string-0"))
                {
                    aofStorageConnectionString0 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aof-storage-connection-string-1"))
                {
                    aofStorageConnectionString1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxfragmentationmemory-reserved"))
                {
                    maxfragmentationmemoryReserved = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxmemory-policy"))
                {
                    maxmemoryPolicy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxmemory-reserved"))
                {
                    maxmemoryReserved = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxmemory-delta"))
                {
                    maxmemoryDelta = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxclients"))
                {
                    maxclients = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("preferred-data-archive-auth-method"))
                {
                    preferredDataArchiveAuthMethod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("preferred-data-persistence-auth-method"))
                {
                    preferredDataPersistenceAuthMethod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zonal-configuration"))
                {
                    zonalConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authnotrequired"))
                {
                    authnotrequired = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new RedisCommonConfiguration(rdbBackupEnabled.Value, rdbBackupFrequency.Value, rdbBackupMaxSnapshotCount.Value, rdbStorageConnectionString.Value, aofBackupEnabled.Value, aofStorageConnectionString0.Value, aofStorageConnectionString1.Value, maxfragmentationmemoryReserved.Value, maxmemoryPolicy.Value, maxmemoryReserved.Value, maxmemoryDelta.Value, maxclients.Value, preferredDataArchiveAuthMethod.Value, preferredDataPersistenceAuthMethod.Value, zonalConfiguration.Value, authnotrequired.Value, additionalProperties);
        }
    }
}
