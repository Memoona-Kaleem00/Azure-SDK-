// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Peering.Models
{
    public partial class LookingGlassOutput
    {
        internal static LookingGlassOutput DeserializeLookingGlassOutput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<LookingGlassCommand> command = default;
            Core.Optional<string> output = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("command"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    command = new LookingGlassCommand(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    output = property.Value.GetString();
                    continue;
                }
            }
            return new LookingGlassOutput(Core.Optional.ToNullable(command), output.Value);
        }
    }
}
