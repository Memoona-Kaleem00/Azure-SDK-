// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    internal partial class ErrorDetails
    {
        internal static ErrorDetails DeserializeErrorDetails(JsonElement element)
        {
            Optional<ErrorDetailsInternal> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = ErrorDetailsInternal.DeserializeErrorDetailsInternal(property.Value);
                    continue;
                }
            }
            return new ErrorDetails(error.Value);
        }
    }
}
