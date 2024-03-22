// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class ScriptActivityTypePropertiesLogSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("logDestination"u8);
            writer.WriteStringValue(LogDestination.ToString());
            if (Optional.IsDefined(LogLocationSettings))
            {
                writer.WritePropertyName("logLocationSettings"u8);
                writer.WriteObjectValue<LogLocationSettings>(LogLocationSettings);
            }
            writer.WriteEndObject();
        }

        internal static ScriptActivityTypePropertiesLogSettings DeserializeScriptActivityTypePropertiesLogSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ScriptActivityLogDestination logDestination = default;
            LogLocationSettings logLocationSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logDestination"u8))
                {
                    logDestination = new ScriptActivityLogDestination(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("logLocationSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logLocationSettings = LogLocationSettings.DeserializeLogLocationSettings(property.Value);
                    continue;
                }
            }
            return new ScriptActivityTypePropertiesLogSettings(logDestination, logLocationSettings);
        }
    }
}
