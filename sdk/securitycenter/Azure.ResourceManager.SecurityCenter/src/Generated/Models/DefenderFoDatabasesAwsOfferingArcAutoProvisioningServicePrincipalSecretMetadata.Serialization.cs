// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderFoDatabasesAwsOfferingArcAutoProvisioningServicePrincipalSecretMetadata : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ExpiryOn))
            {
                writer.WritePropertyName("expiryDate");
                writer.WriteStringValue(ExpiryOn.Value, "O");
            }
            if (Optional.IsDefined(ParameterStoreRegion))
            {
                writer.WritePropertyName("parameterStoreRegion");
                writer.WriteStringValue(ParameterStoreRegion);
            }
            if (Optional.IsDefined(ParameterNameInStore))
            {
                writer.WritePropertyName("parameterNameInStore");
                writer.WriteStringValue(ParameterNameInStore);
            }
            writer.WriteEndObject();
        }

        internal static DefenderFoDatabasesAwsOfferingArcAutoProvisioningServicePrincipalSecretMetadata DeserializeDefenderFoDatabasesAwsOfferingArcAutoProvisioningServicePrincipalSecretMetadata(JsonElement element)
        {
            Optional<DateTimeOffset> expiryDate = default;
            Optional<string> parameterStoreRegion = default;
            Optional<string> parameterNameInStore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expiryDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expiryDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("parameterStoreRegion"))
                {
                    parameterStoreRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameterNameInStore"))
                {
                    parameterNameInStore = property.Value.GetString();
                    continue;
                }
            }
            return new DefenderFoDatabasesAwsOfferingArcAutoProvisioningServicePrincipalSecretMetadata(Optional.ToNullable(expiryDate), parameterStoreRegion.Value, parameterNameInStore.Value);
        }
    }
}
