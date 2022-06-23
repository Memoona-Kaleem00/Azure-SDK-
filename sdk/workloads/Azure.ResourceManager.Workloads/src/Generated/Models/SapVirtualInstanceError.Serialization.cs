// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    internal partial class SapVirtualInstanceError
    {
        internal static SapVirtualInstanceError DeserializeSapVirtualInstanceError(JsonElement element)
        {
            Optional<SapVirtualInstanceErrorDetail> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    properties = SapVirtualInstanceErrorDetail.DeserializeSapVirtualInstanceErrorDetail(property.Value);
                    continue;
                }
            }
            return new SapVirtualInstanceError(properties.Value);
        }
    }
}
