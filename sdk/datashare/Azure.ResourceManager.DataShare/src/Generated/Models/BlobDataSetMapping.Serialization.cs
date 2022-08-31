// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class BlobDataSetMapping : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("containerName");
            writer.WriteStringValue(ContainerName);
            writer.WritePropertyName("dataSetId");
            writer.WriteStringValue(DataSetId);
            writer.WritePropertyName("filePath");
            writer.WriteStringValue(FilePath);
            if (Optional.IsDefined(OutputType))
            {
                writer.WritePropertyName("outputType");
                writer.WriteStringValue(OutputType.Value.ToString());
            }
            writer.WritePropertyName("resourceGroup");
            writer.WriteStringValue(ResourceGroup);
            writer.WritePropertyName("storageAccountName");
            writer.WriteStringValue(StorageAccountName);
            writer.WritePropertyName("subscriptionId");
            writer.WriteStringValue(SubscriptionId);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static BlobDataSetMapping DeserializeBlobDataSetMapping(JsonElement element)
        {
            DataSetMappingKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            string containerName = default;
            string dataSetId = default;
            Optional<DataSetMappingStatus> dataSetMappingStatus = default;
            string filePath = default;
            Optional<OutputType> outputType = default;
            Optional<ProvisioningState> provisioningState = default;
            string resourceGroup = default;
            string storageAccountName = default;
            string subscriptionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new DataSetMappingKind(property.Value.GetString());
                    continue;
                }
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
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
                        if (property0.NameEquals("containerName"))
                        {
                            containerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataSetId"))
                        {
                            dataSetId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataSetMappingStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dataSetMappingStatus = new DataSetMappingStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("filePath"))
                        {
                            filePath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("outputType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            outputType = new OutputType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceGroup"))
                        {
                            resourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountName"))
                        {
                            storageAccountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subscriptionId"))
                        {
                            subscriptionId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new BlobDataSetMapping(id, name, type, systemData.Value, kind, containerName, dataSetId, Optional.ToNullable(dataSetMappingStatus), filePath, Optional.ToNullable(outputType), Optional.ToNullable(provisioningState), resourceGroup, storageAccountName, subscriptionId);
        }
    }
}
