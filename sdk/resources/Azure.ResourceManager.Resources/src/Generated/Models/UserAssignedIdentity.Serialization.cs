// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class UserAssignedIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (PrincipalId != null)
            {
                writer.WritePropertyName("principalId");
                writer.WriteStringValue(PrincipalId);
            }
            if (ClientId != null)
            {
                writer.WritePropertyName("clientId");
                writer.WriteStringValue(ClientId);
            }
            writer.WriteEndObject();
        }

        internal static UserAssignedIdentity DeserializeUserAssignedIdentity(JsonElement element)
        {
            string principalId = default;
            string clientId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principalId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    principalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientId = property.Value.GetString();
                    continue;
                }
            }
            return new UserAssignedIdentity(principalId, clientId);
        }
    }
}
