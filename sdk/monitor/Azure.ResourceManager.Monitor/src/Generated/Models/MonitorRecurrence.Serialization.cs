// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorRecurrence : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("frequency"u8);
            writer.WriteStringValue(Frequency.ToSerialString());
            writer.WritePropertyName("schedule"u8);
            writer.WriteObjectValue(Schedule);
            writer.WriteEndObject();
        }

        internal static MonitorRecurrence DeserializeMonitorRecurrence(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RecurrenceFrequency frequency = default;
            RecurrentSchedule schedule = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("frequency"u8))
                {
                    frequency = property.Value.GetString().ToRecurrenceFrequency();
                    continue;
                }
                if (property.NameEquals("schedule"u8))
                {
                    schedule = RecurrentSchedule.DeserializeRecurrentSchedule(property.Value);
                    continue;
                }
            }
            return new MonitorRecurrence(frequency, schedule);
        }
    }
}
