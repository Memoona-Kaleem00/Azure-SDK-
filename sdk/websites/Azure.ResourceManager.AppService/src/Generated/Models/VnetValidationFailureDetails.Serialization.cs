// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class VnetValidationFailureDetails : IUtf8JsonSerializable
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
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message");
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(Failed))
            {
                writer.WritePropertyName("failed");
                writer.WriteBooleanValue(Failed.Value);
            }
            if (Optional.IsCollectionDefined(FailedTests))
            {
                writer.WritePropertyName("failedTests");
                writer.WriteStartArray();
                foreach (var item in FailedTests)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Warnings))
            {
                writer.WritePropertyName("warnings");
                writer.WriteStartArray();
                foreach (var item in Warnings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VnetValidationFailureDetails DeserializeVnetValidationFailureDetails(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> message = default;
            Optional<bool> failed = default;
            Optional<IList<VnetValidationTestFailure>> failedTests = default;
            Optional<IList<VnetValidationTestFailure>> warnings = default;
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
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("message"))
                        {
                            message = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("failed"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            failed = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("failedTests"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VnetValidationTestFailure> array = new List<VnetValidationTestFailure>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VnetValidationTestFailure.DeserializeVnetValidationTestFailure(item));
                            }
                            failedTests = array;
                            continue;
                        }
                        if (property0.NameEquals("warnings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VnetValidationTestFailure> array = new List<VnetValidationTestFailure>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VnetValidationTestFailure.DeserializeVnetValidationTestFailure(item));
                            }
                            warnings = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VnetValidationFailureDetails(id, name, type, systemData, message.Value, Optional.ToNullable(failed), Optional.ToList(failedTests), Optional.ToList(warnings), kind.Value);
        }
    }
}
