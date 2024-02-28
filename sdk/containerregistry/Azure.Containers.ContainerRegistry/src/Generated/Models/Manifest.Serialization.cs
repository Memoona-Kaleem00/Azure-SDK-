// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class Manifest
    {
        internal static Manifest DeserializeManifest(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? schemaVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("schemaVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schemaVersion = property.Value.GetInt32();
                    continue;
                }
            }
            return new Manifest(schemaVersion);
        }
    }
}
