// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    public partial class TimeSeriesType : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("variables"u8);
            writer.WriteStartObject();
            foreach (var item in Variables)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue<TimeSeriesVariable>(item.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static TimeSeriesType DeserializeTimeSeriesType(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string name = default;
            string description = default;
            IDictionary<string, TimeSeriesVariable> variables = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("variables"u8))
                {
                    Dictionary<string, TimeSeriesVariable> dictionary = new Dictionary<string, TimeSeriesVariable>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, TimeSeriesVariable.DeserializeTimeSeriesVariable(property0.Value));
                    }
                    variables = dictionary;
                    continue;
                }
            }
            return new TimeSeriesType(id, name, description, variables);
        }
    }
}
