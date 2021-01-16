// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class AnalyzeJobMetadata
    {
        internal static AnalyzeJobMetadata DeserializeAnalyzeJobMetadata(JsonElement element)
        {
            Optional<string> displayName = default;
            DateTimeOffset createdDateTime = default;
            Optional<DateTimeOffset> expirationDateTime = default;
            string jobId = default;
            DateTimeOffset lastUpdateDateTime = default;
            JobStatus status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expirationDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expirationDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("jobId"))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new JobStatus(property.Value.GetString());
                    continue;
                }
            }
            return new AnalyzeJobMetadata(createdDateTime, Optional.ToNullable(expirationDateTime), jobId, lastUpdateDateTime, status, displayName.Value);
        }
    }
}
