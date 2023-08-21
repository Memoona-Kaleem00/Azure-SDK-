// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Administration
{
    public partial class ServicePrincipalCredentialEntity : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("parameters"u8);
            writer.WriteObjectValue(Parameters);
            writer.WritePropertyName("dataSourceCredentialType"u8);
            writer.WriteStringValue(CredentialKind.ToString());
            writer.WritePropertyName("dataSourceCredentialName"u8);
            writer.WriteStringValue(Name);
            if (Core.Optional.IsDefined(Description))
            {
                writer.WritePropertyName("dataSourceCredentialDescription"u8);
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static ServicePrincipalCredentialEntity DeserializeServicePrincipalCredentialEntity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ServicePrincipalParam parameters = default;
            DataSourceCredentialKind dataSourceCredentialType = default;
            Core.Optional<string> dataSourceCredentialId = default;
            string dataSourceCredentialName = default;
            Core.Optional<string> dataSourceCredentialDescription = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parameters"u8))
                {
                    parameters = ServicePrincipalParam.DeserializeServicePrincipalParam(property.Value);
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialType"u8))
                {
                    dataSourceCredentialType = new DataSourceCredentialKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialId"u8))
                {
                    dataSourceCredentialId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialName"u8))
                {
                    dataSourceCredentialName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceCredentialDescription"u8))
                {
                    dataSourceCredentialDescription = property.Value.GetString();
                    continue;
                }
            }
            return new ServicePrincipalCredentialEntity(dataSourceCredentialType, dataSourceCredentialId.Value, dataSourceCredentialName, dataSourceCredentialDescription.Value, parameters);
        }
    }
}
