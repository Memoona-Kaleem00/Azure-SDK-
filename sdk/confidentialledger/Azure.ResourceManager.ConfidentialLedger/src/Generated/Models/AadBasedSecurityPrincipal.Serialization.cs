// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    public partial class AadBasedSecurityPrincipal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PrincipalId))
            {
                writer.WritePropertyName("principalId");
                writer.WriteStringValue(PrincipalId.Value);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId");
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(LedgerRoleName))
            {
                writer.WritePropertyName("ledgerRoleName");
                writer.WriteStringValue(LedgerRoleName.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AadBasedSecurityPrincipal DeserializeAadBasedSecurityPrincipal(JsonElement element)
        {
            Optional<Guid> principalId = default;
            Optional<Guid> tenantId = default;
            Optional<ConfidentialLedgerRoleName> ledgerRoleName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principalId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    principalId = property.Value.GetGuid();
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
                if (property.NameEquals("ledgerRoleName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ledgerRoleName = new ConfidentialLedgerRoleName(property.Value.GetString());
                    continue;
                }
            }
            return new AadBasedSecurityPrincipal(Optional.ToNullable(principalId), Optional.ToNullable(tenantId), Optional.ToNullable(ledgerRoleName));
        }
    }
}
