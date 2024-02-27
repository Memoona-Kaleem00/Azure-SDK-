// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataMigration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataMigration
{
    public partial class ProjectData : IUtf8JsonSerializable, IJsonModel<ProjectData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProjectData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProjectData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProjectData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProjectData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (SourcePlatform.HasValue)
            {
                writer.WritePropertyName("sourcePlatform"u8);
                writer.WriteStringValue(SourcePlatform.Value.ToString());
            }
            if (AzureAuthenticationInfo != null)
            {
                writer.WritePropertyName("azureAuthenticationInfo"u8);
                writer.WriteObjectValue(AzureAuthenticationInfo);
            }
            if (TargetPlatform.HasValue)
            {
                writer.WritePropertyName("targetPlatform"u8);
                writer.WriteStringValue(TargetPlatform.Value.ToString());
            }
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (SourceConnectionInfo != null)
            {
                writer.WritePropertyName("sourceConnectionInfo"u8);
                writer.WriteObjectValue(SourceConnectionInfo);
            }
            if (TargetConnectionInfo != null)
            {
                writer.WritePropertyName("targetConnectionInfo"u8);
                writer.WriteObjectValue(TargetConnectionInfo);
            }
            if (!(DatabasesInfo is ChangeTrackingList<DatabaseInfo> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("databasesInfo"u8);
                writer.WriteStartArray();
                foreach (var item in DatabasesInfo)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ProjectData IJsonModel<ProjectData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProjectData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProjectData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProjectData(document.RootElement, options);
        }

        internal static ProjectData DeserializeProjectData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            Core.ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ProjectSourcePlatform> sourcePlatform = default;
            Optional<AzureActiveDirectoryApp> azureAuthenticationInfo = default;
            Optional<ProjectTargetPlatform> targetPlatform = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<ConnectionInfo> sourceConnectionInfo = default;
            Optional<ConnectionInfo> targetConnectionInfo = default;
            IList<DatabaseInfo> databasesInfo = default;
            Optional<ProjectProvisioningState> provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new Core.ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sourcePlatform"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourcePlatform = new ProjectSourcePlatform(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("azureAuthenticationInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureAuthenticationInfo = AzureActiveDirectoryApp.DeserializeAzureActiveDirectoryApp(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("targetPlatform"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetPlatform = new ProjectTargetPlatform(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sourceConnectionInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceConnectionInfo = ConnectionInfo.DeserializeConnectionInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("targetConnectionInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetConnectionInfo = ConnectionInfo.DeserializeConnectionInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("databasesInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DatabaseInfo> array = new List<DatabaseInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DatabaseInfo.DeserializeDatabaseInfo(item, options));
                            }
                            databasesInfo = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProjectProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProjectData(
                id,
                name,
                type,
                systemData.Value,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                Optional.ToNullable(etag),
                Optional.ToNullable(sourcePlatform),
                azureAuthenticationInfo.Value,
                Optional.ToNullable(targetPlatform),
                Optional.ToNullable(creationTime),
                sourceConnectionInfo.Value,
                targetConnectionInfo.Value,
                databasesInfo ?? new ChangeTrackingList<DatabaseInfo>(),
                Optional.ToNullable(provisioningState),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProjectData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProjectData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProjectData)} does not support '{options.Format}' format.");
            }
        }

        ProjectData IPersistableModel<ProjectData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProjectData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProjectData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProjectData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProjectData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
