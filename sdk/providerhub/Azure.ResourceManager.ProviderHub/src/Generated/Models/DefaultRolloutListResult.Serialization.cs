// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ProviderHub;

namespace Azure.ResourceManager.ProviderHub.Models
{
    internal partial class DefaultRolloutListResult
    {
        internal static DefaultRolloutListResult DeserializeDefaultRolloutListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<DefaultRolloutData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DefaultRolloutData> array = new List<DefaultRolloutData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DefaultRolloutData.DeserializeDefaultRolloutData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DefaultRolloutListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
