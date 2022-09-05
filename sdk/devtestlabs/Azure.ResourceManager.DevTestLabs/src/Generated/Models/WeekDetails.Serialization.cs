// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class WeekDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Weekdays))
            {
                writer.WritePropertyName("weekdays");
                writer.WriteStartArray();
                foreach (var item in Weekdays)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Time))
            {
                writer.WritePropertyName("time");
                writer.WriteStringValue(Time);
            }
            writer.WriteEndObject();
        }

        internal static WeekDetails DeserializeWeekDetails(JsonElement element)
        {
            Optional<IList<string>> weekdays = default;
            Optional<string> time = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("weekdays"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    weekdays = array;
                    continue;
                }
                if (property.NameEquals("time"))
                {
                    time = property.Value.GetString();
                    continue;
                }
            }
            return new WeekDetails(Optional.ToList(weekdays), time.Value);
        }
    }
}
