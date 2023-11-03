// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LargeInstance.Models
{
    public partial class StorageProperties
    {
        internal static StorageProperties DeserializeStorageProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> offeringType = default;
            Optional<string> storageType = default;
            Optional<string> generation = default;
            Optional<string> hardwareType = default;
            Optional<string> workloadType = default;
            Optional<StorageBillingProperties> storageBillingProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageType"u8))
                {
                    storageType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("generation"u8))
                {
                    generation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hardwareType"u8))
                {
                    hardwareType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadType"u8))
                {
                    workloadType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageBillingProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageBillingProperties = StorageBillingProperties.DeserializeStorageBillingProperties(property.Value);
                    continue;
                }
            }
            return new StorageProperties(Optional.ToNullable(provisioningState), offeringType.Value, storageType.Value, generation.Value, hardwareType.Value, workloadType.Value, storageBillingProperties.Value);
        }
    }
}
