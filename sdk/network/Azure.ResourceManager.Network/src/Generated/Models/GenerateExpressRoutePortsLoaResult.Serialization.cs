// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class GenerateExpressRoutePortsLoaResult
    {
        internal static GenerateExpressRoutePortsLoaResult DeserializeGenerateExpressRoutePortsLoaResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> encodedContent = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encodedContent"u8))
                {
                    encodedContent = property.Value.GetString();
                    continue;
                }
            }
            return new GenerateExpressRoutePortsLoaResult(encodedContent.Value);
        }
    }
}
