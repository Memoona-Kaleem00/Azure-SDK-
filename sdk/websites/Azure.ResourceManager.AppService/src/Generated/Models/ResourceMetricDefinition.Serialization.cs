// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ResourceMetricDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ResourceMetricDefinition DeserializeResourceMetricDefinition(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> unit = default;
            Optional<string> primaryAggregationType = default;
            Optional<IReadOnlyList<ResourceMetricAvailability>> metricAvailabilities = default;
            Optional<Uri> resourceUri = default;
            Optional<IReadOnlyDictionary<string, string>> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("unit"))
                        {
                            unit = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("primaryAggregationType"))
                        {
                            primaryAggregationType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metricAvailabilities"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ResourceMetricAvailability> array = new List<ResourceMetricAvailability>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ResourceMetricAvailability.DeserializeResourceMetricAvailability(item));
                            }
                            metricAvailabilities = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceUri"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                resourceUri = null;
                                continue;
                            }
                            resourceUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("properties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            properties = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ResourceMetricDefinition(id, name, type, systemData, unit.Value, primaryAggregationType.Value, Optional.ToList(metricAvailabilities), resourceUri.Value, Optional.ToDictionary(properties), kind.Value);
        }
    }
}
