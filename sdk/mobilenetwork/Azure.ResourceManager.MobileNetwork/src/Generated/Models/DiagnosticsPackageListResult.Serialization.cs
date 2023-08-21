// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    internal partial class DiagnosticsPackageListResult
    {
        internal static DiagnosticsPackageListResult DeserializeDiagnosticsPackageListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<MobileNetworkDiagnosticsPackageData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MobileNetworkDiagnosticsPackageData> array = new List<MobileNetworkDiagnosticsPackageData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MobileNetworkDiagnosticsPackageData.DeserializeMobileNetworkDiagnosticsPackageData(item));
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
            return new DiagnosticsPackageListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
