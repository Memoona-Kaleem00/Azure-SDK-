// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LargeInstance.Models
{
    public partial class HardwareProfile
    {
        internal static HardwareProfile DeserializeHardwareProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLargeInstanceHardwareTypeNamesEnum> hardwareType = default;
            Optional<AzureLargeInstanceSizeNamesEnum> azureLargeInstanceSize = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hardwareType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hardwareType = new AzureLargeInstanceHardwareTypeNamesEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azureLargeInstanceSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureLargeInstanceSize = new AzureLargeInstanceSizeNamesEnum(property.Value.GetString());
                    continue;
                }
            }
            return new HardwareProfile(Optional.ToNullable(hardwareType), Optional.ToNullable(azureLargeInstanceSize));
        }
    }
}
