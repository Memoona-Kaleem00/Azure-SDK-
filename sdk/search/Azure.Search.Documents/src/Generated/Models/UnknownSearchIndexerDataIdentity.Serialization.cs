// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Search.Documents.Indexes.Models
{
    internal partial class UnknownSearchIndexerDataIdentity
    {
        internal static UnknownSearchIndexerDataIdentity DeserializeUnknownSearchIndexerDataIdentity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string odataType = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownSearchIndexerDataIdentity(odataType);
        }
    }
}
