// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class DeploymentScriptManagedIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToString());
            }
            if (Optional.IsCollectionDefined(UserAssignedIdentities))
            {
                writer.WritePropertyName("userAssignedIdentities");
                writer.WriteStartObject();
                foreach (var item in UserAssignedIdentities)
                {
                    writer.WritePropertyName(item.Key);
                    JsonSerializer.Serialize(writer, item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static DeploymentScriptManagedIdentity DeserializeDeploymentScriptManagedIdentity(JsonElement element)
        {
            Optional<DeploymentScriptManagedIdentityType> type = default;
            Optional<string> tenantId = default;
            Optional<IDictionary<string, UserAssignedIdentity>> userAssignedIdentities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new DeploymentScriptManagedIdentityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tenantId"))
                {
                    tenantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userAssignedIdentities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, UserAssignedIdentity> dictionary = new Dictionary<string, UserAssignedIdentity>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, JsonSerializer.Deserialize<UserAssignedIdentity>(property0.Value.ToString()));
                    }
                    userAssignedIdentities = dictionary;
                    continue;
                }
            }
            return new DeploymentScriptManagedIdentity(Optional.ToNullable(type), tenantId.Value, Optional.ToDictionary(userAssignedIdentities));
        }
    }
}
