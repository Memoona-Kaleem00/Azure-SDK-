// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class IngestionSettingToken
    {
        internal static IngestionSettingToken DeserializeIngestionSettingToken(JsonElement element)
        {
            Optional<string> token = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("token"))
                {
                    token = property.Value.GetString();
                    continue;
                }
            }
            return new IngestionSettingToken(token.Value);
        }
    }
}
