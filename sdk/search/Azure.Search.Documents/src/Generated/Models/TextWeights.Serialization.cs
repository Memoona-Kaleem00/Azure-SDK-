// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class TextWeights : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Weights != null && Weights.Any())
            {
                writer.WritePropertyName("weights");
                writer.WriteStartObject();
                foreach (var item in Weights)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteNumberValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static TextWeights DeserializeTextWeights(JsonElement element)
        {
            IDictionary<string, double> weights = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("weights"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, double> dictionary = new Dictionary<string, double>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetDouble());
                    }
                    weights = dictionary;
                    continue;
                }
            }
            return new TextWeights(weights);
        }
    }
}
