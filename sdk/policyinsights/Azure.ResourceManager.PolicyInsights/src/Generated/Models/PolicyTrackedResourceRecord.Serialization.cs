// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class PolicyTrackedResourceRecord
    {
        internal static PolicyTrackedResourceRecord DeserializePolicyTrackedResourceRecord(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ResourceIdentifier> trackedResourceId = default;
            Core.Optional<PolicyDetails> policyDetails = default;
            Core.Optional<TrackedResourceModificationDetails> createdBy = default;
            Core.Optional<TrackedResourceModificationDetails> lastModifiedBy = default;
            Core.Optional<DateTimeOffset> lastUpdateUtc = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trackedResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trackedResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyDetails = PolicyDetails.DeserializePolicyDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("createdBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdBy = TrackedResourceModificationDetails.DeserializeTrackedResourceModificationDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("lastModifiedBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedBy = TrackedResourceModificationDetails.DeserializeTrackedResourceModificationDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUpdateUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdateUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new PolicyTrackedResourceRecord(trackedResourceId.Value, policyDetails.Value, createdBy.Value, lastModifiedBy.Value, Core.Optional.ToNullable(lastUpdateUtc));
        }
    }
}
