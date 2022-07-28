// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WindowsJavaContainerSettings
    {
        internal static WindowsJavaContainerSettings DeserializeWindowsJavaContainerSettings(JsonElement element)
        {
            Optional<string> javaContainer = default;
            Optional<string> javaContainerVersion = default;
            Optional<bool> isPreview = default;
            Optional<bool> isDeprecated = default;
            Optional<bool> isHidden = default;
            Optional<DateTimeOffset> endOfLifeDate = default;
            Optional<bool> isAutoUpdate = default;
            Optional<bool> isEarlyAccess = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("javaContainer"))
                {
                    javaContainer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("javaContainerVersion"))
                {
                    javaContainerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPreview"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isPreview = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDeprecated"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isDeprecated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isHidden"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isHidden = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("endOfLifeDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endOfLifeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isAutoUpdate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isAutoUpdate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isEarlyAccess"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isEarlyAccess = property.Value.GetBoolean();
                    continue;
                }
            }
            return new WindowsJavaContainerSettings(javaContainer.Value, javaContainerVersion.Value, Optional.ToNullable(isPreview), Optional.ToNullable(isDeprecated), Optional.ToNullable(isHidden), Optional.ToNullable(endOfLifeDate), Optional.ToNullable(isAutoUpdate), Optional.ToNullable(isEarlyAccess));
        }
    }
}
