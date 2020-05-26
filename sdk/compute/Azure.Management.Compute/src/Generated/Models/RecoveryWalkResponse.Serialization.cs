// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class RecoveryWalkResponse
    {
        internal static RecoveryWalkResponse DeserializeRecoveryWalkResponse(JsonElement element)
        {
            bool? walkPerformed = default;
            int? nextPlatformUpdateDomain = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("walkPerformed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    walkPerformed = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("nextPlatformUpdateDomain"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextPlatformUpdateDomain = property.Value.GetInt32();
                    continue;
                }
            }
            return new RecoveryWalkResponse(walkPerformed, nextPlatformUpdateDomain);
        }
    }
}
