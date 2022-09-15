// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    public partial class RouteSectionTecCause
    {
        internal static RouteSectionTecCause DeserializeRouteSectionTecCause(JsonElement element)
        {
            Optional<int> mainCauseCode = default;
            Optional<int> subCauseCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mainCauseCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mainCauseCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("subCauseCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subCauseCode = property.Value.GetInt32();
                    continue;
                }
            }
            return new RouteSectionTecCause(Optional.ToNullable(mainCauseCode), Optional.ToNullable(subCauseCode));
        }
    }
}
