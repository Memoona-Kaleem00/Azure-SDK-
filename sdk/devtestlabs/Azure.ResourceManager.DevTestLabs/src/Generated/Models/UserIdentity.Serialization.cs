// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class UserIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PrincipalName))
            {
                writer.WritePropertyName("principalName");
                writer.WriteStringValue(PrincipalName);
            }
            if (Optional.IsDefined(PrincipalId))
            {
                writer.WritePropertyName("principalId");
                writer.WriteStringValue(PrincipalId);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId");
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(ObjectId))
            {
                writer.WritePropertyName("objectId");
                writer.WriteStringValue(ObjectId);
            }
            if (Optional.IsDefined(AppId))
            {
                writer.WritePropertyName("appId");
                writer.WriteStringValue(AppId);
            }
            writer.WriteEndObject();
        }

        internal static UserIdentity DeserializeUserIdentity(JsonElement element)
        {
            Optional<string> principalName = default;
            Optional<string> principalId = default;
            Optional<Guid> tenantId = default;
            Optional<string> objectId = default;
            Optional<string> appId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principalName"))
                {
                    principalName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("principalId"))
                {
                    principalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("objectId"))
                {
                    objectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appId"))
                {
                    appId = property.Value.GetString();
                    continue;
                }
            }
            return new UserIdentity(principalName.Value, principalId.Value, Optional.ToNullable(tenantId), objectId.Value, appId.Value);
        }
    }
}
