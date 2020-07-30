// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class DocumentStatistics
    {
        internal static DocumentStatistics DeserializeDocumentStatistics(JsonElement element)
        {
            int charactersCount = default;
            int transactionsCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("charactersCount"))
                {
                    charactersCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("transactionsCount"))
                {
                    transactionsCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new DocumentStatistics(charactersCount, transactionsCount);
        }
    }
}
