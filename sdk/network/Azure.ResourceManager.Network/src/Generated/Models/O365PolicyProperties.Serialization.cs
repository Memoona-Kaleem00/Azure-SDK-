// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class O365PolicyProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(BreakOutCategories))
            {
                writer.WritePropertyName("breakOutCategories"u8);
                writer.WriteObjectValue(BreakOutCategories);
            }
            writer.WriteEndObject();
        }

        internal static O365PolicyProperties DeserializeO365PolicyProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<O365BreakOutCategoryPolicies> breakOutCategories = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("breakOutCategories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    breakOutCategories = O365BreakOutCategoryPolicies.DeserializeO365BreakOutCategoryPolicies(property.Value);
                    continue;
                }
            }
            return new O365PolicyProperties(breakOutCategories.Value);
        }
    }
}
