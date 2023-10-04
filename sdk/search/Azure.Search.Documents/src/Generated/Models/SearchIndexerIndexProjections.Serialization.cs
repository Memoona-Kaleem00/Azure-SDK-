// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndexerIndexProjections : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("selectors"u8);
            writer.WriteStartArray();
            foreach (var item in Selectors)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteObjectValue(Parameters);
            }
            writer.WriteEndObject();
        }

        internal static SearchIndexerIndexProjections DeserializeSearchIndexerIndexProjections(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<SearchIndexerIndexProjectionSelector> selectors = default;
            Optional<SearchIndexerIndexProjectionsParameters> parameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("selectors"u8))
                {
                    List<SearchIndexerIndexProjectionSelector> array = new List<SearchIndexerIndexProjectionSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchIndexerIndexProjectionSelector.DeserializeSearchIndexerIndexProjectionSelector(item));
                    }
                    selectors = array;
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = SearchIndexerIndexProjectionsParameters.DeserializeSearchIndexerIndexProjectionsParameters(property.Value);
                    continue;
                }
            }
            return new SearchIndexerIndexProjections(selectors, parameters.Value);
        }
    }
}
