// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class VectorSearchProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("algorithm"u8);
            writer.WriteStringValue(AlgorithmConfigurationName);
            if (Optional.IsDefined(Vectorizer))
            {
                writer.WritePropertyName("vectorizer"u8);
                writer.WriteStringValue(Vectorizer);
            }
            if (Optional.IsDefined(CompressionConfigurationName))
            {
                writer.WritePropertyName("compression"u8);
                writer.WriteStringValue(CompressionConfigurationName);
            }
            writer.WriteEndObject();
        }

        internal static VectorSearchProfile DeserializeVectorSearchProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string algorithm = default;
            string vectorizer = default;
            string compression = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("algorithm"u8))
                {
                    algorithm = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vectorizer"u8))
                {
                    vectorizer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("compression"u8))
                {
                    compression = property.Value.GetString();
                    continue;
                }
            }
            return new VectorSearchProfile(name, algorithm, vectorizer, compression);
        }
    }
}
