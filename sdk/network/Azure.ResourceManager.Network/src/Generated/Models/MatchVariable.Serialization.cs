// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class MatchVariable : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("variableName"u8);
            writer.WriteStringValue(VariableName.ToString());
            if (Core.Optional.IsDefined(Selector))
            {
                writer.WritePropertyName("selector"u8);
                writer.WriteStringValue(Selector);
            }
            writer.WriteEndObject();
        }

        internal static MatchVariable DeserializeMatchVariable(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WebApplicationFirewallMatchVariable variableName = default;
            Core.Optional<string> selector = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("variableName"u8))
                {
                    variableName = new WebApplicationFirewallMatchVariable(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("selector"u8))
                {
                    selector = property.Value.GetString();
                    continue;
                }
            }
            return new MatchVariable(variableName, selector.Value);
        }
    }
}
