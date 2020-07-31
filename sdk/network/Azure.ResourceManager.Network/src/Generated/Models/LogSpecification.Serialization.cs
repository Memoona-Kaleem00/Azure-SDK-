// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class LogSpecification
    {
        internal static LogSpecification DeserializeLogSpecification(JsonElement element)
        {
            string name = default;
            string displayName = default;
            string blobDuration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("blobDuration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blobDuration = property.Value.GetString();
                    continue;
                }
            }
            return new LogSpecification(name, displayName, blobDuration);
        }
    }
}
