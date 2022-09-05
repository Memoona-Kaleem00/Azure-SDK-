// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class WebApplicationCustomRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("priority");
            writer.WriteNumberValue(Priority);
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState");
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            writer.WritePropertyName("ruleType");
            writer.WriteStringValue(RuleType.ToString());
            if (Optional.IsDefined(RateLimitDurationInMinutes))
            {
                writer.WritePropertyName("rateLimitDurationInMinutes");
                writer.WriteNumberValue(RateLimitDurationInMinutes.Value);
            }
            if (Optional.IsDefined(RateLimitThreshold))
            {
                writer.WritePropertyName("rateLimitThreshold");
                writer.WriteNumberValue(RateLimitThreshold.Value);
            }
            writer.WritePropertyName("matchConditions");
            writer.WriteStartArray();
            foreach (var item in MatchConditions)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("action");
            writer.WriteStringValue(Action.ToString());
            writer.WriteEndObject();
        }

        internal static WebApplicationCustomRule DeserializeWebApplicationCustomRule(JsonElement element)
        {
            Optional<string> name = default;
            int priority = default;
            Optional<CustomRuleEnabledState> enabledState = default;
            WebApplicationRuleType ruleType = default;
            Optional<int> rateLimitDurationInMinutes = default;
            Optional<int> rateLimitThreshold = default;
            IList<WebApplicationRuleMatchCondition> matchConditions = default;
            RuleMatchActionType action = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"))
                {
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enabledState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabledState = new CustomRuleEnabledState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ruleType"))
                {
                    ruleType = new WebApplicationRuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rateLimitDurationInMinutes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rateLimitDurationInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rateLimitThreshold"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rateLimitThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("matchConditions"))
                {
                    List<WebApplicationRuleMatchCondition> array = new List<WebApplicationRuleMatchCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebApplicationRuleMatchCondition.DeserializeWebApplicationRuleMatchCondition(item));
                    }
                    matchConditions = array;
                    continue;
                }
                if (property.NameEquals("action"))
                {
                    action = new RuleMatchActionType(property.Value.GetString());
                    continue;
                }
            }
            return new WebApplicationCustomRule(name.Value, priority, Optional.ToNullable(enabledState), ruleType, Optional.ToNullable(rateLimitDurationInMinutes), Optional.ToNullable(rateLimitThreshold), matchConditions, action);
        }
    }
}
