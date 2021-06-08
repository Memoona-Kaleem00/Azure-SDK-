// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.NewResources
{
    public partial class ApplicationDefinitionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedBy))
            {
                writer.WritePropertyName("managedBy");
                writer.WriteStringValue(ManagedBy);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("lockLevel");
            writer.WriteStringValue(LockLevel.ToSerialString());
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("isEnabled");
                writer.WriteStringValue(IsEnabled);
            }
            writer.WritePropertyName("authorizations");
            writer.WriteStartArray();
            foreach (var item in Authorizations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Artifacts))
            {
                writer.WritePropertyName("artifacts");
                writer.WriteStartArray();
                foreach (var item in Artifacts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(PackageFileUri))
            {
                writer.WritePropertyName("packageFileUri");
                writer.WriteStringValue(PackageFileUri);
            }
            if (Optional.IsDefined(MainTemplate))
            {
                writer.WritePropertyName("mainTemplate");
                writer.WriteObjectValue(MainTemplate);
            }
            if (Optional.IsDefined(CreateUiDefinition))
            {
                writer.WritePropertyName("createUiDefinition");
                writer.WriteObjectValue(CreateUiDefinition);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationDefinitionData DeserializeApplicationDefinitionData(JsonElement element)
        {
            Optional<string> managedBy = default;
            Optional<Sku> sku = default;
            Optional<IdentityAutoGenerated> identity = default;
            IDictionary<string, string> tags = default;
            LocationData location = default;
            ResourceGroupResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            ApplicationLockLevel lockLevel = default;
            Optional<string> displayName = default;
            Optional<string> isEnabled = default;
            IList<ApplicationProviderAuthorization> authorizations = default;
            Optional<IList<ApplicationArtifact>> artifacts = default;
            Optional<string> description = default;
            Optional<string> packageFileUri = default;
            Optional<object> mainTemplate = default;
            Optional<object> createUiDefinition = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedBy"))
                {
                    managedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = Sku.DeserializeSku(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = IdentityAutoGenerated.DeserializeIdentityAutoGenerated(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("lockLevel"))
                        {
                            lockLevel = property0.Value.GetString().ToApplicationLockLevel();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isEnabled"))
                        {
                            isEnabled = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authorizations"))
                        {
                            List<ApplicationProviderAuthorization> array = new List<ApplicationProviderAuthorization>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationProviderAuthorization.DeserializeApplicationProviderAuthorization(item));
                            }
                            authorizations = array;
                            continue;
                        }
                        if (property0.NameEquals("artifacts"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ApplicationArtifact> array = new List<ApplicationArtifact>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationArtifact.DeserializeApplicationArtifact(item));
                            }
                            artifacts = array;
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageFileUri"))
                        {
                            packageFileUri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("mainTemplate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            mainTemplate = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("createUiDefinition"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createUiDefinition = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationDefinitionData(id, name, type, location, tags, managedBy.Value, sku.Value, identity.Value, lockLevel, displayName.Value, isEnabled.Value, authorizations, Optional.ToList(artifacts), description.Value, packageFileUri.Value, mainTemplate.Value, createUiDefinition.Value);
        }
    }
}
