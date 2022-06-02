// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    internal partial class ScriptEnvironmentVariable : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteStringValue(Value);
            }
            if (Optional.IsDefined(SecureValue))
            {
                writer.WritePropertyName("secureValue");
                writer.WriteStringValue(SecureValue);
            }
            writer.WriteEndObject();
        }

        internal static ScriptEnvironmentVariable DeserializeScriptEnvironmentVariable(JsonElement element)
        {
            string name = default;
            Optional<string> value = default;
            Optional<string> secureValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secureValue"))
                {
                    secureValue = property.Value.GetString();
                    continue;
                }
            }
            return new ScriptEnvironmentVariable(name, value.Value, secureValue.Value);
        }
    }
}
