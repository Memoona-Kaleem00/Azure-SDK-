// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class AdaptiveNetworkHardeningData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Rules))
            {
                writer.WritePropertyName("rules");
                writer.WriteStartArray();
                foreach (var item in Rules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RulesCalculationOn))
            {
                writer.WritePropertyName("rulesCalculationTime");
                writer.WriteStringValue(RulesCalculationOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(EffectiveNetworkSecurityGroups))
            {
                writer.WritePropertyName("effectiveNetworkSecurityGroups");
                writer.WriteStartArray();
                foreach (var item in EffectiveNetworkSecurityGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AdaptiveNetworkHardeningData DeserializeAdaptiveNetworkHardeningData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IList<Rule>> rules = default;
            Optional<DateTimeOffset> rulesCalculationTime = default;
            Optional<IList<EffectiveNetworkSecurityGroups>> effectiveNetworkSecurityGroups = default;
            foreach (var property in element.EnumerateObject())
            {
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
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
                        if (property0.NameEquals("rules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<Rule> array = new List<Rule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Rule.DeserializeRule(item));
                            }
                            rules = array;
                            continue;
                        }
                        if (property0.NameEquals("rulesCalculationTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            rulesCalculationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("effectiveNetworkSecurityGroups"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<EffectiveNetworkSecurityGroups> array = new List<EffectiveNetworkSecurityGroups>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Models.EffectiveNetworkSecurityGroups.DeserializeEffectiveNetworkSecurityGroups(item));
                            }
                            effectiveNetworkSecurityGroups = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AdaptiveNetworkHardeningData(id, name, type, systemData.Value, Optional.ToList(rules), Optional.ToNullable(rulesCalculationTime), Optional.ToList(effectiveNetworkSecurityGroups));
        }
    }
}
