// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(RunNotebookResultConverter))]
    public partial class RunNotebookResult
    {
        internal static RunNotebookResult DeserializeRunNotebookResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> runId = default;
            Optional<string> runStatus = default;
            Optional<string> lastCheckedOn = default;
            Optional<string> sessionId = default;
            Optional<string> sparkPool = default;
            Optional<object> sessionDetail = default;
            Optional<string> exitValue = default;
            Optional<RunNotebookError> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("runId"u8))
                {
                    runId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runStatus"u8))
                {
                    runStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastCheckedOn"u8))
                {
                    lastCheckedOn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sessionId"u8))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sparkPool"u8))
                {
                    sparkPool = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sessionDetail"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionDetail = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("exitValue"u8))
                {
                    exitValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = RunNotebookError.DeserializeRunNotebookError(property.Value);
                    continue;
                }
            }
            return new RunNotebookResult(
                runId.Value,
                runStatus.Value,
                lastCheckedOn.Value,
                sessionId.Value,
                sparkPool.Value,
                sessionDetail.Value,
                exitValue.Value,
                error.Value);
        }

        internal partial class RunNotebookResultConverter : JsonConverter<RunNotebookResult>
        {
            public override void Write(Utf8JsonWriter writer, RunNotebookResult model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override RunNotebookResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRunNotebookResult(document.RootElement);
            }
        }
    }
}
