// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class OnlineDeploymentPropertiesTrackedResourceLongRunningOperationResponse
    {
        internal static OnlineDeploymentPropertiesTrackedResourceLongRunningOperationResponse DeserializeOnlineDeploymentPropertiesTrackedResourceLongRunningOperationResponse(JsonElement element)
        {
            Optional<OnlineDeploymentPropertiesTrackedResource> completionResult = default;
            Optional<string> location = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("completionResult"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    completionResult = OnlineDeploymentPropertiesTrackedResource.DeserializeOnlineDeploymentPropertiesTrackedResource(property.Value);
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
            }
            return new OnlineDeploymentPropertiesTrackedResourceLongRunningOperationResponse(completionResult.Value, location.Value);
        }
    }
}
