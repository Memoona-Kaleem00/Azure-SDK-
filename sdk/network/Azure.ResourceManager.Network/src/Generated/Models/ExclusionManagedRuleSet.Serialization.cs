// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExclusionManagedRuleSet : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ruleSetType"u8);
            writer.WriteStringValue(RuleSetType);
            writer.WritePropertyName("ruleSetVersion"u8);
            writer.WriteStringValue(RuleSetVersion);
            if (Core.Optional.IsCollectionDefined(RuleGroups))
            {
                writer.WritePropertyName("ruleGroups"u8);
                writer.WriteStartArray();
                foreach (var item in RuleGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ExclusionManagedRuleSet DeserializeExclusionManagedRuleSet(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ruleSetType = default;
            string ruleSetVersion = default;
            Core.Optional<IList<ExclusionManagedRuleGroup>> ruleGroups = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleSetType"u8))
                {
                    ruleSetType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleSetVersion"u8))
                {
                    ruleSetVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExclusionManagedRuleGroup> array = new List<ExclusionManagedRuleGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExclusionManagedRuleGroup.DeserializeExclusionManagedRuleGroup(item));
                    }
                    ruleGroups = array;
                    continue;
                }
            }
            return new ExclusionManagedRuleSet(ruleSetType, ruleSetVersion, Core.Optional.ToList(ruleGroups));
        }
    }
}
