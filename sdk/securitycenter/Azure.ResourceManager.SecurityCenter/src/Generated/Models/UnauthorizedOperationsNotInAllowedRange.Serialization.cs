// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class UnauthorizedOperationsNotInAllowedRange : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("timeWindowSize");
            writer.WriteStringValue(TimeWindowSize, "P");
            writer.WritePropertyName("minThreshold");
            writer.WriteNumberValue(MinThreshold);
            writer.WritePropertyName("maxThreshold");
            writer.WriteNumberValue(MaxThreshold);
            writer.WritePropertyName("isEnabled");
            writer.WriteBooleanValue(IsEnabled);
            writer.WritePropertyName("ruleType");
            writer.WriteStringValue(RuleType);
            writer.WriteEndObject();
        }

        internal static UnauthorizedOperationsNotInAllowedRange DeserializeUnauthorizedOperationsNotInAllowedRange(JsonElement element)
        {
            TimeSpan timeWindowSize = default;
            int minThreshold = default;
            int maxThreshold = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            bool isEnabled = default;
            string ruleType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeWindowSize"))
                {
                    timeWindowSize = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("minThreshold"))
                {
                    minThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxThreshold"))
                {
                    maxThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ruleType"))
                {
                    ruleType = property.Value.GetString();
                    continue;
                }
            }
            return new UnauthorizedOperationsNotInAllowedRange(displayName.Value, description.Value, isEnabled, ruleType, minThreshold, maxThreshold, timeWindowSize);
        }
    }
}
