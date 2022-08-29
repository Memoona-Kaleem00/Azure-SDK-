// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class StorageBlobDeadLetterDestination : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("endpointType");
            writer.WriteStringValue(EndpointType.ToString());
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId");
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(BlobContainerName))
            {
                writer.WritePropertyName("blobContainerName");
                writer.WriteStringValue(BlobContainerName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StorageBlobDeadLetterDestination DeserializeStorageBlobDeadLetterDestination(JsonElement element)
        {
            DeadLetterEndPointType endpointType = default;
            Optional<string> resourceId = default;
            Optional<string> blobContainerName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointType"))
                {
                    endpointType = new DeadLetterEndPointType(property.Value.GetString());
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
                        if (property0.NameEquals("resourceId"))
                        {
                            resourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("blobContainerName"))
                        {
                            blobContainerName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StorageBlobDeadLetterDestination(endpointType, resourceId.Value, blobContainerName.Value);
        }
    }
}
