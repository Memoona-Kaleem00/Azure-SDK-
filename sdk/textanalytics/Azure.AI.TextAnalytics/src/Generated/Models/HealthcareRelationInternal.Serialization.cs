// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class HealthcareRelationInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("relationType"u8);
            writer.WriteStringValue(RelationType.ToString());
            if (Optional.IsDefined(ConfidenceScore))
            {
                writer.WritePropertyName("confidenceScore"u8);
                writer.WriteNumberValue(ConfidenceScore.Value);
            }
            writer.WritePropertyName("entities"u8);
            writer.WriteStartArray();
            foreach (var item in Entities)
            {
                writer.WriteObjectValue<HealthcareRelationEntity>(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static HealthcareRelationInternal DeserializeHealthcareRelationInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HealthcareEntityRelationType relationType = default;
            double? confidenceScore = default;
            IList<HealthcareRelationEntity> entities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("relationType"u8))
                {
                    relationType = new HealthcareEntityRelationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("confidenceScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    confidenceScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("entities"u8))
                {
                    List<HealthcareRelationEntity> array = new List<HealthcareRelationEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareRelationEntity.DeserializeHealthcareRelationEntity(item));
                    }
                    entities = array;
                    continue;
                }
            }
            return new HealthcareRelationInternal(relationType, confidenceScore, entities);
        }
    }
}
