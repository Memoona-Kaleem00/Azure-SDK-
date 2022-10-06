// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    public partial class RolloutOperationInfo
    {
        internal static RolloutOperationInfo DeserializeRolloutOperationInfo(JsonElement element)
        {
            Optional<int> retryAttempt = default;
            Optional<bool> skipSucceededOnRetry = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<ResponseError> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("retryAttempt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retryAttempt = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("skipSucceededOnRetry"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    skipSucceededOnRetry = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.ToString());
                    continue;
                }
            }
            return new RolloutOperationInfo(Optional.ToNullable(retryAttempt), Optional.ToNullable(skipSucceededOnRetry), Optional.ToNullable(startTime), Optional.ToNullable(endTime), error.Value);
        }
    }
}
