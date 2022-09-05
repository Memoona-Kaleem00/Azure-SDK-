// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class IncidentEntitiesResultsMetadata
    {
        internal static IncidentEntitiesResultsMetadata DeserializeIncidentEntitiesResultsMetadata(JsonElement element)
        {
            int count = default;
            EntityKind entityKind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"))
                {
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("entityKind"))
                {
                    entityKind = new EntityKind(property.Value.GetString());
                    continue;
                }
            }
            return new IncidentEntitiesResultsMetadata(count, entityKind);
        }
    }
}
