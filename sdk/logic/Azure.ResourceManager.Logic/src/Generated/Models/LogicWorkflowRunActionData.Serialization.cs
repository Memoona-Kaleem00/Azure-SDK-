// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic
{
    public partial class LogicWorkflowRunActionData
    {
        internal static LogicWorkflowRunActionData DeserializeLogicWorkflowRunActionData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<LogicWorkflowStatus> status = default;
            Optional<string> code = default;
            Optional<BinaryData> error = default;
            Optional<Guid> trackingId = default;
            Optional<LogicWorkflowRunActionCorrelation> correlation = default;
            Optional<LogicContentLink> inputsLink = default;
            Optional<LogicContentLink> outputsLink = default;
            Optional<BinaryData> trackedProperties = default;
            Optional<IReadOnlyList<LogicWorkRetryHistory>> retryHistory = default;
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
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new LogicWorkflowStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("code"))
                        {
                            code = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("error"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            error = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("trackingId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            trackingId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("correlation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            correlation = LogicWorkflowRunActionCorrelation.DeserializeLogicWorkflowRunActionCorrelation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("inputsLink"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            inputsLink = LogicContentLink.DeserializeLogicContentLink(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("outputsLink"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            outputsLink = LogicContentLink.DeserializeLogicContentLink(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("trackedProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            trackedProperties = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("retryHistory"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<LogicWorkRetryHistory> array = new List<LogicWorkRetryHistory>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LogicWorkRetryHistory.DeserializeLogicWorkRetryHistory(item));
                            }
                            retryHistory = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new LogicWorkflowRunActionData(id, name, type, systemData.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(status), code.Value, error.Value, Optional.ToNullable(trackingId), correlation.Value, inputsLink.Value, outputsLink.Value, trackedProperties.Value, Optional.ToList(retryHistory));
        }
    }
}
