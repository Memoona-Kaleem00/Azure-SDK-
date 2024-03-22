// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(RecurrenceScheduleOccurrenceConverter))]
    public partial class RecurrenceScheduleOccurrence : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Day))
            {
                writer.WritePropertyName("day"u8);
                writer.WriteStringValue(Day.Value.ToSerialString());
            }
            if (Optional.IsDefined(Occurrence))
            {
                writer.WritePropertyName("occurrence"u8);
                writer.WriteNumberValue(Occurrence.Value);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue<object>(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static RecurrenceScheduleOccurrence DeserializeRecurrenceScheduleOccurrence(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DayOfWeek? day = default;
            int? occurrence = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("day"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    day = property.Value.GetString().ToDayOfWeek();
                    continue;
                }
                if (property.NameEquals("occurrence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    occurrence = property.Value.GetInt32();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new RecurrenceScheduleOccurrence(day, occurrence, additionalProperties);
        }

        internal partial class RecurrenceScheduleOccurrenceConverter : JsonConverter<RecurrenceScheduleOccurrence>
        {
            public override void Write(Utf8JsonWriter writer, RecurrenceScheduleOccurrence model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue<RecurrenceScheduleOccurrence>(model);
            }
            public override RecurrenceScheduleOccurrence Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRecurrenceScheduleOccurrence(document.RootElement);
            }
        }
    }
}
