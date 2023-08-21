// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class PolicyState
    {
        internal static PolicyState DeserializePolicyState(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> odataId = default;
            Core.Optional<string> odataContext = default;
            Core.Optional<DateTimeOffset> timestamp = default;
            Core.Optional<ResourceIdentifier> resourceId = default;
            Core.Optional<ResourceIdentifier> policyAssignmentId = default;
            Core.Optional<ResourceIdentifier> policyDefinitionId = default;
            Core.Optional<string> effectiveParameters = default;
            Core.Optional<bool> isCompliant = default;
            Core.Optional<string> subscriptionId = default;
            Core.Optional<string> resourceType = default;
            Core.Optional<AzureLocation> resourceLocation = default;
            Core.Optional<string> resourceGroup = default;
            Core.Optional<string> resourceTags = default;
            Core.Optional<string> policyAssignmentName = default;
            Core.Optional<string> policyAssignmentOwner = default;
            Core.Optional<string> policyAssignmentParameters = default;
            Core.Optional<string> policyAssignmentScope = default;
            Core.Optional<string> policyDefinitionName = default;
            Core.Optional<string> policyDefinitionAction = default;
            Core.Optional<string> policyDefinitionCategory = default;
            Core.Optional<ResourceIdentifier> policySetDefinitionId = default;
            Core.Optional<string> policySetDefinitionName = default;
            Core.Optional<string> policySetDefinitionOwner = default;
            Core.Optional<string> policySetDefinitionCategory = default;
            Core.Optional<string> policySetDefinitionParameters = default;
            Core.Optional<string> managementGroupIds = default;
            Core.Optional<string> policyDefinitionReferenceId = default;
            Core.Optional<string> complianceState = default;
            Core.Optional<PolicyEvaluationDetails> policyEvaluationDetails = default;
            Core.Optional<IReadOnlyList<string>> policyDefinitionGroupNames = default;
            Core.Optional<IReadOnlyList<ComponentStateDetails>> components = default;
            Core.Optional<string> policyDefinitionVersion = default;
            Core.Optional<string> policySetDefinitionVersion = default;
            Core.Optional<string> policyAssignmentVersion = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.id"u8))
                {
                    odataId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.context"u8))
                {
                    odataContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyAssignmentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    policyAssignmentId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyDefinitionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    policyDefinitionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("effectiveParameters"u8))
                {
                    effectiveParameters = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isCompliant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCompliant = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceTags"u8))
                {
                    resourceTags = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyAssignmentName"u8))
                {
                    policyAssignmentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyAssignmentOwner"u8))
                {
                    policyAssignmentOwner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyAssignmentParameters"u8))
                {
                    policyAssignmentParameters = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyAssignmentScope"u8))
                {
                    policyAssignmentScope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionName"u8))
                {
                    policyDefinitionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionAction"u8))
                {
                    policyDefinitionAction = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionCategory"u8))
                {
                    policyDefinitionCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policySetDefinitionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    policySetDefinitionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policySetDefinitionName"u8))
                {
                    policySetDefinitionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policySetDefinitionOwner"u8))
                {
                    policySetDefinitionOwner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policySetDefinitionCategory"u8))
                {
                    policySetDefinitionCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policySetDefinitionParameters"u8))
                {
                    policySetDefinitionParameters = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managementGroupIds"u8))
                {
                    managementGroupIds = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionReferenceId"u8))
                {
                    policyDefinitionReferenceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("complianceState"u8))
                {
                    complianceState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyEvaluationDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyEvaluationDetails = PolicyEvaluationDetails.DeserializePolicyEvaluationDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("policyDefinitionGroupNames"u8))
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
                    policyDefinitionGroupNames = array;
                    continue;
                }
                if (property.NameEquals("components"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ComponentStateDetails> array = new List<ComponentStateDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComponentStateDetails.DeserializeComponentStateDetails(item));
                    }
                    components = array;
                    continue;
                }
                if (property.NameEquals("policyDefinitionVersion"u8))
                {
                    policyDefinitionVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policySetDefinitionVersion"u8))
                {
                    policySetDefinitionVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyAssignmentVersion"u8))
                {
                    policyAssignmentVersion = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new PolicyState(odataId.Value, odataContext.Value, Core.Optional.ToNullable(timestamp), resourceId.Value, policyAssignmentId.Value, policyDefinitionId.Value, effectiveParameters.Value, Core.Optional.ToNullable(isCompliant), subscriptionId.Value, resourceType.Value, Core.Optional.ToNullable(resourceLocation), resourceGroup.Value, resourceTags.Value, policyAssignmentName.Value, policyAssignmentOwner.Value, policyAssignmentParameters.Value, policyAssignmentScope.Value, policyDefinitionName.Value, policyDefinitionAction.Value, policyDefinitionCategory.Value, policySetDefinitionId.Value, policySetDefinitionName.Value, policySetDefinitionOwner.Value, policySetDefinitionCategory.Value, policySetDefinitionParameters.Value, managementGroupIds.Value, policyDefinitionReferenceId.Value, complianceState.Value, policyEvaluationDetails.Value, Core.Optional.ToList(policyDefinitionGroupNames), Core.Optional.ToList(components), policyDefinitionVersion.Value, policySetDefinitionVersion.Value, policyAssignmentVersion.Value, additionalProperties);
        }
    }
}
