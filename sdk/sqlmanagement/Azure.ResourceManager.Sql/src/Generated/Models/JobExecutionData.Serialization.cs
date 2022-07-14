// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class JobExecutionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(CurrentAttempts))
            {
                writer.WritePropertyName("currentAttempts");
                writer.WriteNumberValue(CurrentAttempts.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static JobExecutionData DeserializeJobExecutionData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> jobVersion = default;
            Optional<string> stepName = default;
            Optional<int> stepId = default;
            Optional<Guid> jobExecutionId = default;
            Optional<JobExecutionLifecycle> lifecycle = default;
            Optional<JobExecutionProvisioningState> provisioningState = default;
            Optional<DateTimeOffset> createTime = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<int> currentAttempts = default;
            Optional<DateTimeOffset> currentAttemptStartTime = default;
            Optional<string> lastMessage = default;
            Optional<JobExecutionTarget> target = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("jobVersion"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            jobVersion = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("stepName"))
                        {
                            stepName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("stepId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            stepId = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("jobExecutionId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            jobExecutionId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("lifecycle"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lifecycle = new JobExecutionLifecycle(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new JobExecutionProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("createTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("startTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("currentAttempts"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            currentAttempts = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("currentAttemptStartTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            currentAttemptStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastMessage"))
                        {
                            lastMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("target"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            target = JobExecutionTarget.DeserializeJobExecutionTarget(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new JobExecutionData(id, name, type, systemData.Value, Optional.ToNullable(jobVersion), stepName.Value, Optional.ToNullable(stepId), Optional.ToNullable(jobExecutionId), Optional.ToNullable(lifecycle), Optional.ToNullable(provisioningState), Optional.ToNullable(createTime), Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(currentAttempts), Optional.ToNullable(currentAttemptStartTime), lastMessage.Value, target.Value);
        }
    }
}
