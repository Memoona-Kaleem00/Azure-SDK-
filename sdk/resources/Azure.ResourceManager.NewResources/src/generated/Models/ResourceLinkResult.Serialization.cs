// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NewResources
{
    internal partial class ResourceLinkResult
    {
        internal static ResourceLinkResult DeserializeResourceLinkResult(JsonElement element)
        {
            IReadOnlyList<ResourceLink> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ResourceLink> array = new List<ResourceLink>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceLink.DeserializeResourceLink(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceLinkResult(value, nextLink.Value);
        }
    }
}
