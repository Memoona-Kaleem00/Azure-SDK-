// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventHubs
{
    public partial class SchemaGroupData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(GroupProperties))
            {
                writer.WritePropertyName("groupProperties");
                writer.WriteStartObject();
                foreach (var item in GroupProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(SchemaCompatibility))
            {
                writer.WritePropertyName("schemaCompatibility");
                writer.WriteStringValue(SchemaCompatibility.Value.ToString());
            }
            if (Optional.IsDefined(SchemaType))
            {
                writer.WritePropertyName("schemaType");
                writer.WriteStringValue(SchemaType.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SchemaGroupData DeserializeSchemaGroupData(JsonElement element)
        {
            Optional<string> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<DateTimeOffset> updatedAtUtc = default;
            Optional<DateTimeOffset> createdAtUtc = default;
            Optional<Guid> eTag = default;
            Optional<IDictionary<string, string>> groupProperties = default;
            Optional<SchemaCompatibility> schemaCompatibility = default;
            Optional<SchemaType> schemaType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
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
                        if (property0.NameEquals("updatedAtUtc"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            updatedAtUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("createdAtUtc"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdAtUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("eTag"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            eTag = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("groupProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            groupProperties = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("schemaCompatibility"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            schemaCompatibility = new SchemaCompatibility(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("schemaType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            schemaType = new SchemaType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SchemaGroupData(id, name, type, systemData, Optional.ToNullable(updatedAtUtc), Optional.ToNullable(createdAtUtc), Optional.ToNullable(eTag), Optional.ToDictionary(groupProperties), Optional.ToNullable(schemaCompatibility), Optional.ToNullable(schemaType), location.Value);
        }
    }
}
