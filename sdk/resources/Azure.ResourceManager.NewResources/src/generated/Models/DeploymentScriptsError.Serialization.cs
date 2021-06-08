// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NewResources
{
    internal partial class DeploymentScriptsError
    {
        internal static DeploymentScriptsError DeserializeDeploymentScriptsError(JsonElement element)
        {
            Optional<ErrorResponse> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = ErrorResponse.DeserializeErrorResponse(property.Value);
                    continue;
                }
            }
            return new DeploymentScriptsError(error.Value);
        }
    }
}
