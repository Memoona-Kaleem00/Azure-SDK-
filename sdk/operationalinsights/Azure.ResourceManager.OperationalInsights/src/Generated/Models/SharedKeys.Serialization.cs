// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class SharedKeys
    {
        internal static SharedKeys DeserializeSharedKeys(JsonElement element)
        {
            Optional<string> primarySharedKey = default;
            Optional<string> secondarySharedKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primarySharedKey"))
                {
                    primarySharedKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondarySharedKey"))
                {
                    secondarySharedKey = property.Value.GetString();
                    continue;
                }
            }
            return new SharedKeys(primarySharedKey.Value, secondarySharedKey.Value);
        }
    }
}
