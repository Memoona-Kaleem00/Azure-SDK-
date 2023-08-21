// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class ConditionFailingPeriods : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(NumberOfEvaluationPeriods))
            {
                writer.WritePropertyName("numberOfEvaluationPeriods"u8);
                writer.WriteNumberValue(NumberOfEvaluationPeriods.Value);
            }
            if (Core.Optional.IsDefined(MinFailingPeriodsToAlert))
            {
                writer.WritePropertyName("minFailingPeriodsToAlert"u8);
                writer.WriteNumberValue(MinFailingPeriodsToAlert.Value);
            }
            writer.WriteEndObject();
        }

        internal static ConditionFailingPeriods DeserializeConditionFailingPeriods(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<long> numberOfEvaluationPeriods = default;
            Core.Optional<long> minFailingPeriodsToAlert = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("numberOfEvaluationPeriods"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfEvaluationPeriods = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("minFailingPeriodsToAlert"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minFailingPeriodsToAlert = property.Value.GetInt64();
                    continue;
                }
            }
            return new ConditionFailingPeriods(Core.Optional.ToNullable(numberOfEvaluationPeriods), Core.Optional.ToNullable(minFailingPeriodsToAlert));
        }
    }
}
