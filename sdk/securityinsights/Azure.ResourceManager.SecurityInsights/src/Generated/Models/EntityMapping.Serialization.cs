// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class EntityMapping : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EntityType))
            {
                writer.WritePropertyName("entityType");
                writer.WriteStringValue(EntityType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(FieldMappings))
            {
                writer.WritePropertyName("fieldMappings");
                writer.WriteStartArray();
                foreach (var item in FieldMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static EntityMapping DeserializeEntityMapping(JsonElement element)
        {
            Optional<EntityMappingType> entityType = default;
            Optional<IList<FieldMapping>> fieldMappings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("entityType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    entityType = new EntityMappingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fieldMappings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<FieldMapping> array = new List<FieldMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FieldMapping.DeserializeFieldMapping(item));
                    }
                    fieldMappings = array;
                    continue;
                }
            }
            return new EntityMapping(Optional.ToNullable(entityType), Optional.ToList(fieldMappings));
        }
    }
}
