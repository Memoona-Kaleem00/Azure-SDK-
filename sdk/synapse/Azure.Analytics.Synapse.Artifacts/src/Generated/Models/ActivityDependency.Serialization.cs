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
    [JsonConverter(typeof(ActivityDependencyConverter))]
    public partial class ActivityDependency : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("activity"u8);
            writer.WriteStringValue(Activity);
            writer.WritePropertyName("dependencyConditions"u8);
            writer.WriteStartArray();
            foreach (var item in DependencyConditions)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue<object>(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static ActivityDependency DeserializeActivityDependency(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string activity = default;
            IList<DependencyCondition> dependencyConditions = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activity"u8))
                {
                    activity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependencyConditions"u8))
                {
                    List<DependencyCondition> array = new List<DependencyCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new DependencyCondition(item.GetString()));
                    }
                    dependencyConditions = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ActivityDependency(activity, dependencyConditions, additionalProperties);
        }

        internal partial class ActivityDependencyConverter : JsonConverter<ActivityDependency>
        {
            public override void Write(Utf8JsonWriter writer, ActivityDependency model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue<ActivityDependency>(model);
            }
            public override ActivityDependency Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeActivityDependency(document.RootElement);
            }
        }
    }
}
