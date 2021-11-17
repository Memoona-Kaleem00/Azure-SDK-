// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class WorkloadNetworkPortMirroring : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Direction))
            {
                writer.WritePropertyName("direction");
                writer.WriteStringValue(Direction.Value.ToString());
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source");
                writer.WriteStringValue(Source);
            }
            if (Optional.IsDefined(Destination))
            {
                writer.WritePropertyName("destination");
                writer.WriteStringValue(Destination);
            }
            if (Optional.IsDefined(Revision))
            {
                writer.WritePropertyName("revision");
                writer.WriteNumberValue(Revision.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WorkloadNetworkPortMirroring DeserializeWorkloadNetworkPortMirroring(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> displayName = default;
            Optional<PortMirroringDirectionEnum> direction = default;
            Optional<string> source = default;
            Optional<string> destination = default;
            Optional<PortMirroringStatusEnum> status = default;
            Optional<WorkloadNetworkPortMirroringProvisioningState> provisioningState = default;
            Optional<long> revision = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("direction"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            direction = new PortMirroringDirectionEnum(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("source"))
                        {
                            source = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("destination"))
                        {
                            destination = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new PortMirroringStatusEnum(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new WorkloadNetworkPortMirroringProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("revision"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            revision = property0.Value.GetInt64();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WorkloadNetworkPortMirroring(id, name, type, displayName.Value, Optional.ToNullable(direction), source.Value, destination.Value, Optional.ToNullable(status), Optional.ToNullable(provisioningState), Optional.ToNullable(revision));
        }
    }
}
