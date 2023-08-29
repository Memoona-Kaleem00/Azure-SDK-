// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class HyperVToAzStackHCIRecoveryPointModelCustomProperties
    {
        internal static HyperVToAzStackHCIRecoveryPointModelCustomProperties DeserializeHyperVToAzStackHCIRecoveryPointModelCustomProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<string>> diskIds = default;
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    diskIds = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new HyperVToAzStackHCIRecoveryPointModelCustomProperties(instanceType, Optional.ToList(diskIds));
        }
    }
}
