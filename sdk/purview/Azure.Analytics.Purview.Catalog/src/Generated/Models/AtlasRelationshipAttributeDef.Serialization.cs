// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Catalog.Models
{
    public partial class AtlasRelationshipAttributeDef : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsLegacyAttribute))
            {
                writer.WritePropertyName("isLegacyAttribute");
                writer.WriteBooleanValue(IsLegacyAttribute.Value);
            }
            if (Optional.IsDefined(RelationshipTypeName))
            {
                writer.WritePropertyName("relationshipTypeName");
                writer.WriteStringValue(RelationshipTypeName);
            }
            if (Optional.IsDefined(Cardinality))
            {
                writer.WritePropertyName("cardinality");
                writer.WriteStringValue(Cardinality.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Constraints))
            {
                writer.WritePropertyName("constraints");
                writer.WriteStartArray();
                foreach (var item in Constraints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue");
                writer.WriteStringValue(DefaultValue);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(IncludeInNotification))
            {
                writer.WritePropertyName("includeInNotification");
                writer.WriteBooleanValue(IncludeInNotification.Value);
            }
            if (Optional.IsDefined(IsIndexable))
            {
                writer.WritePropertyName("isIndexable");
                writer.WriteBooleanValue(IsIndexable.Value);
            }
            if (Optional.IsDefined(IsOptional))
            {
                writer.WritePropertyName("isOptional");
                writer.WriteBooleanValue(IsOptional.Value);
            }
            if (Optional.IsDefined(IsUnique))
            {
                writer.WritePropertyName("isUnique");
                writer.WriteBooleanValue(IsUnique.Value);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(Options))
            {
                writer.WritePropertyName("options");
                writer.WriteStartObject();
                foreach (var item in Options)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(TypeName))
            {
                writer.WritePropertyName("typeName");
                writer.WriteStringValue(TypeName);
            }
            if (Optional.IsDefined(ValuesMaxCount))
            {
                writer.WritePropertyName("valuesMaxCount");
                writer.WriteNumberValue(ValuesMaxCount.Value);
            }
            if (Optional.IsDefined(ValuesMinCount))
            {
                writer.WritePropertyName("valuesMinCount");
                writer.WriteNumberValue(ValuesMinCount.Value);
            }
            writer.WriteEndObject();
        }

        internal static AtlasRelationshipAttributeDef DeserializeAtlasRelationshipAttributeDef(JsonElement element)
        {
            Optional<bool> isLegacyAttribute = default;
            Optional<string> relationshipTypeName = default;
            Optional<Cardinality> cardinality = default;
            Optional<IList<AtlasConstraintDef>> constraints = default;
            Optional<string> defaultValue = default;
            Optional<string> description = default;
            Optional<bool> includeInNotification = default;
            Optional<bool> isIndexable = default;
            Optional<bool> isOptional = default;
            Optional<bool> isUnique = default;
            Optional<string> name = default;
            Optional<IDictionary<string, string>> options = default;
            Optional<string> typeName = default;
            Optional<int> valuesMaxCount = default;
            Optional<int> valuesMinCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isLegacyAttribute"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isLegacyAttribute = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("relationshipTypeName"))
                {
                    relationshipTypeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cardinality"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cardinality = new Cardinality(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("constraints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AtlasConstraintDef> array = new List<AtlasConstraintDef>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AtlasConstraintDef.DeserializeAtlasConstraintDef(item));
                    }
                    constraints = array;
                    continue;
                }
                if (property.NameEquals("defaultValue"))
                {
                    defaultValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("includeInNotification"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    includeInNotification = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isIndexable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isIndexable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isOptional"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isOptional = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isUnique"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isUnique = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("options"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    options = dictionary;
                    continue;
                }
                if (property.NameEquals("typeName"))
                {
                    typeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valuesMaxCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    valuesMaxCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("valuesMinCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    valuesMinCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new AtlasRelationshipAttributeDef(Optional.ToNullable(cardinality), Optional.ToList(constraints), defaultValue.Value, description.Value, Optional.ToNullable(includeInNotification), Optional.ToNullable(isIndexable), Optional.ToNullable(isOptional), Optional.ToNullable(isUnique), name.Value, Optional.ToDictionary(options), typeName.Value, Optional.ToNullable(valuesMaxCount), Optional.ToNullable(valuesMinCount), Optional.ToNullable(isLegacyAttribute), relationshipTypeName.Value);
        }
    }
}
