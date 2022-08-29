// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    public partial class TopicTypeInfoData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Provider))
            {
                writer.WritePropertyName("provider");
                writer.WriteStringValue(Provider);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ResourceRegionType))
            {
                writer.WritePropertyName("resourceRegionType");
                writer.WriteStringValue(ResourceRegionType.Value.ToString());
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(SupportedLocations))
            {
                writer.WritePropertyName("supportedLocations");
                writer.WriteStartArray();
                foreach (var item in SupportedLocations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SourceResourceFormat))
            {
                writer.WritePropertyName("sourceResourceFormat");
                writer.WriteStringValue(SourceResourceFormat);
            }
            if (Optional.IsCollectionDefined(SupportedScopesForSource))
            {
                writer.WritePropertyName("supportedScopesForSource");
                writer.WriteStartArray();
                foreach (var item in SupportedScopesForSource)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static TopicTypeInfoData DeserializeTopicTypeInfoData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> provider = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<ResourceRegionType> resourceRegionType = default;
            Optional<TopicTypeProvisioningState> provisioningState = default;
            Optional<IList<string>> supportedLocations = default;
            Optional<string> sourceResourceFormat = default;
            Optional<IList<TopicTypeSourceScope>> supportedScopesForSource = default;
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
                        if (property0.NameEquals("provider"))
                        {
                            provider = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceRegionType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resourceRegionType = new ResourceRegionType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new TopicTypeProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("supportedLocations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            supportedLocations = array;
                            continue;
                        }
                        if (property0.NameEquals("sourceResourceFormat"))
                        {
                            sourceResourceFormat = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("supportedScopesForSource"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<TopicTypeSourceScope> array = new List<TopicTypeSourceScope>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new TopicTypeSourceScope(item.GetString()));
                            }
                            supportedScopesForSource = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new TopicTypeInfoData(id, name, type, systemData.Value, provider.Value, displayName.Value, description.Value, Optional.ToNullable(resourceRegionType), Optional.ToNullable(provisioningState), Optional.ToList(supportedLocations), sourceResourceFormat.Value, Optional.ToList(supportedScopesForSource));
        }
    }
}
