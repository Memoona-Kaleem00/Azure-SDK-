// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class DeploymentData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteNumberValue(Status.Value);
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message");
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(Author))
            {
                writer.WritePropertyName("author");
                writer.WriteStringValue(Author);
            }
            if (Optional.IsDefined(Deployer))
            {
                writer.WritePropertyName("deployer");
                writer.WriteStringValue(Deployer);
            }
            if (Optional.IsDefined(AuthorEmail))
            {
                writer.WritePropertyName("author_email");
                writer.WriteStringValue(AuthorEmail);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("start_time");
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("end_time");
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(Active))
            {
                writer.WritePropertyName("active");
                writer.WriteBooleanValue(Active.Value);
            }
            if (Optional.IsDefined(Details))
            {
                writer.WritePropertyName("details");
                writer.WriteStringValue(Details);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DeploymentData DeserializeDeploymentData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<int> status = default;
            Optional<string> message = default;
            Optional<string> author = default;
            Optional<string> deployer = default;
            Optional<string> authorEmail = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<bool> active = default;
            Optional<string> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                    type = (ResourceType)property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
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
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("message"))
                        {
                            message = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("author"))
                        {
                            author = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deployer"))
                        {
                            deployer = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("author_email"))
                        {
                            authorEmail = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("start_time"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("end_time"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("active"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            active = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("details"))
                        {
                            details = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DeploymentData(id, name, type, systemData, kind.Value, Optional.ToNullable(status), message.Value, author.Value, deployer.Value, authorEmail.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(active), details.Value);
        }
    }
}
