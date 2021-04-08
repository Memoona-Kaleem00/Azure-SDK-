// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Monitory.Query.Models
{
    public partial class MetadataSolution
    {
        internal static MetadataSolution DeserializeMetadataSolution(JsonElement element)
        {
            string id = default;
            string name = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<object> tags = default;
            Optional<object> properties = default;
            MetadataSolutionRelated related = default;
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
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
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
                if (property.NameEquals("related"))
                {
                    related = MetadataSolutionRelated.DeserializeMetadataSolutionRelated(property.Value);
                    continue;
                }
            }
            return new MetadataSolution(id, name, displayName.Value, description.Value, tags.Value, properties.Value, related);
        }
    }
}
