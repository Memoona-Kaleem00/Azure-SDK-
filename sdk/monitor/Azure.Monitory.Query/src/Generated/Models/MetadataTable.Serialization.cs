// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Monitory.Query.Models
{
    public partial class MetadataTable
    {
        internal static MetadataTable DeserializeMetadataTable(JsonElement element)
        {
            string id = default;
            string name = default;
            Optional<string> description = default;
            Optional<string> timespanColumn = default;
            Optional<IReadOnlyList<string>> labels = default;
            Optional<object> tags = default;
            Optional<object> properties = default;
            Optional<IReadOnlyList<MetadataTableColumnsItem>> columns = default;
            Optional<MetadataTableRelated> related = default;
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
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timespanColumn"))
                {
                    timespanColumn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labels"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    labels = array;
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tags = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    properties = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("columns"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MetadataTableColumnsItem> array = new List<MetadataTableColumnsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetadataTableColumnsItem.DeserializeMetadataTableColumnsItem(item));
                    }
                    columns = array;
                    continue;
                }
                if (property.NameEquals("related"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    related = MetadataTableRelated.DeserializeMetadataTableRelated(property.Value);
                    continue;
                }
            }
            return new MetadataTable(id, name, description.Value, timespanColumn.Value, Optional.ToList(labels), tags.Value, properties.Value, Optional.ToList(columns), related.Value);
        }
    }
}
