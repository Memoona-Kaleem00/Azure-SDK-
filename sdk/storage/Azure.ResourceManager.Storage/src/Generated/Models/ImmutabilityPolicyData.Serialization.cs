// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    public partial class ImmutabilityPolicyData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ImmutabilityPeriodSinceCreationInDays))
            {
                writer.WritePropertyName("immutabilityPeriodSinceCreationInDays");
                writer.WriteNumberValue(ImmutabilityPeriodSinceCreationInDays.Value);
            }
            if (Optional.IsDefined(AllowProtectedAppendWrites))
            {
                writer.WritePropertyName("allowProtectedAppendWrites");
                writer.WriteBooleanValue(AllowProtectedAppendWrites.Value);
            }
            if (Optional.IsDefined(AllowProtectedAppendWritesAll))
            {
                writer.WritePropertyName("allowProtectedAppendWritesAll");
                writer.WriteBooleanValue(AllowProtectedAppendWritesAll.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ImmutabilityPolicyData DeserializeImmutabilityPolicyData(JsonElement element)
        {
            Optional<ETag> eTag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> immutabilityPeriodSinceCreationInDays = default;
            Optional<ImmutabilityPolicyState> state = default;
            Optional<bool> allowProtectedAppendWrites = default;
            Optional<bool> allowProtectedAppendWritesAll = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("immutabilityPeriodSinceCreationInDays"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            immutabilityPeriodSinceCreationInDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("state"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            state = new ImmutabilityPolicyState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("allowProtectedAppendWrites"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowProtectedAppendWrites = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowProtectedAppendWritesAll"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowProtectedAppendWritesAll = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ImmutabilityPolicyData(id, name, type, systemData.Value, Optional.ToNullable(immutabilityPeriodSinceCreationInDays), Optional.ToNullable(state), Optional.ToNullable(allowProtectedAppendWrites), Optional.ToNullable(allowProtectedAppendWritesAll), Optional.ToNullable(eTag));
        }
    }
}
