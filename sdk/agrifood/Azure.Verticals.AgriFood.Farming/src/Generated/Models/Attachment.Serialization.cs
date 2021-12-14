// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Verticals.AgriFood.Farming.Models
{
    public partial class Attachment
    {
        internal static Attachment DeserializeAttachment(JsonElement element)
        {
            Optional<string> farmerId = default;
            Optional<string> resourceId = default;
            Optional<string> resourceType = default;
            Optional<string> originalFileName = default;
            Optional<string> id = default;
            Optional<string> status = default;
            Optional<DateTimeOffset> createdDateTime = default;
            Optional<DateTimeOffset> modifiedDateTime = default;
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<string> eTag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("farmerId"))
                {
                    farmerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("originalFileName"))
                {
                    originalFileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("modifiedDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    modifiedDateTime = property.Value.GetDateTimeOffset("O");
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
                if (property.NameEquals("eTag"))
                {
                    eTag = property.Value.GetString();
                    continue;
                }
            }
            return new Attachment(farmerId.Value, resourceId.Value, resourceType.Value, originalFileName.Value, id.Value, status.Value, Optional.ToNullable(createdDateTime), Optional.ToNullable(modifiedDateTime), name.Value, description.Value, eTag.Value);
        }
    }
}
