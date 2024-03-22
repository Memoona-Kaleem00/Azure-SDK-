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
    [JsonConverter(typeof(HdfsReadSettingsConverter))]
    public partial class HdfsReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Recursive))
            {
                writer.WritePropertyName("recursive"u8);
                writer.WriteObjectValue<object>(Recursive);
            }
            if (Optional.IsDefined(WildcardFolderPath))
            {
                writer.WritePropertyName("wildcardFolderPath"u8);
                writer.WriteObjectValue<object>(WildcardFolderPath);
            }
            if (Optional.IsDefined(WildcardFileName))
            {
                writer.WritePropertyName("wildcardFileName"u8);
                writer.WriteObjectValue<object>(WildcardFileName);
            }
            if (Optional.IsDefined(FileListPath))
            {
                writer.WritePropertyName("fileListPath"u8);
                writer.WriteObjectValue<object>(FileListPath);
            }
            if (Optional.IsDefined(EnablePartitionDiscovery))
            {
                writer.WritePropertyName("enablePartitionDiscovery"u8);
                writer.WriteObjectValue<object>(EnablePartitionDiscovery);
            }
            if (Optional.IsDefined(PartitionRootPath))
            {
                writer.WritePropertyName("partitionRootPath"u8);
                writer.WriteObjectValue<object>(PartitionRootPath);
            }
            if (Optional.IsDefined(ModifiedDatetimeStart))
            {
                writer.WritePropertyName("modifiedDatetimeStart"u8);
                writer.WriteObjectValue<object>(ModifiedDatetimeStart);
            }
            if (Optional.IsDefined(ModifiedDatetimeEnd))
            {
                writer.WritePropertyName("modifiedDatetimeEnd"u8);
                writer.WriteObjectValue<object>(ModifiedDatetimeEnd);
            }
            if (Optional.IsDefined(DistcpSettings))
            {
                writer.WritePropertyName("distcpSettings"u8);
                writer.WriteObjectValue<DistcpSettings>(DistcpSettings);
            }
            if (Optional.IsDefined(DeleteFilesAfterCompletion))
            {
                writer.WritePropertyName("deleteFilesAfterCompletion"u8);
                writer.WriteObjectValue<object>(DeleteFilesAfterCompletion);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
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

        internal static HdfsReadSettings DeserializeHdfsReadSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object recursive = default;
            object wildcardFolderPath = default;
            object wildcardFileName = default;
            object fileListPath = default;
            object enablePartitionDiscovery = default;
            object partitionRootPath = default;
            object modifiedDatetimeStart = default;
            object modifiedDatetimeEnd = default;
            DistcpSettings distcpSettings = default;
            object deleteFilesAfterCompletion = default;
            string type = default;
            object maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recursive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recursive = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("wildcardFolderPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wildcardFolderPath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("wildcardFileName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wildcardFileName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("fileListPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileListPath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("enablePartitionDiscovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enablePartitionDiscovery = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionRootPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionRootPath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("modifiedDatetimeStart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modifiedDatetimeStart = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("modifiedDatetimeEnd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modifiedDatetimeEnd = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("distcpSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    distcpSettings = DistcpSettings.DeserializeDistcpSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("deleteFilesAfterCompletion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deleteFilesAfterCompletion = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
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
            return new HdfsReadSettings(
                type,
                maxConcurrentConnections,
                additionalProperties,
                recursive,
                wildcardFolderPath,
                wildcardFileName,
                fileListPath,
                enablePartitionDiscovery,
                partitionRootPath,
                modifiedDatetimeStart,
                modifiedDatetimeEnd,
                distcpSettings,
                deleteFilesAfterCompletion);
        }

        internal partial class HdfsReadSettingsConverter : JsonConverter<HdfsReadSettings>
        {
            public override void Write(Utf8JsonWriter writer, HdfsReadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue<HdfsReadSettings>(model);
            }
            public override HdfsReadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeHdfsReadSettings(document.RootElement);
            }
        }
    }
}
