// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    internal partial class ErrorDetail
    {
        internal static ErrorDetail DeserializeErrorDetail(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string code = default;
            string message = default;
            Core.Optional<string> target = default;
            Core.Optional<string> value = default;
            Core.Optional<IReadOnlyList<string>> resources = default;
            Core.Optional<object> additionalProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resources = array;
                    continue;
                }
                if (property.NameEquals("additionalProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalProperties = property.Value.GetObject();
                    continue;
                }
            }
            return new ErrorDetail(code, message, target.Value, value.Value, Core.Optional.ToList(resources), additionalProperties.Value);
        }
    }
}
