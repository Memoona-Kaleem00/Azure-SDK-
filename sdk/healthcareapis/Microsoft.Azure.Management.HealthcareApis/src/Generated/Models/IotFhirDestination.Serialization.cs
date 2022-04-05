// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    public partial class IotFhirDestination : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("resourceIdentityResolutionType");
            writer.WriteStringValue(ResourceIdentityResolutionType.ToString());
            writer.WritePropertyName("fhirServiceResourceId");
            writer.WriteStringValue(FhirServiceResourceId);
            writer.WritePropertyName("fhirMapping");
            writer.WriteObjectValue(FhirMapping);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static IotFhirDestination DeserializeIotFhirDestination(JsonElement element)
        {
            Optional<SystemData> systemData = default;
            Optional<string> location = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> etag = default;
            Optional<ProvisioningState> provisioningState = default;
            IotIdentityResolutionType resourceIdentityResolutionType = default;
            string fhirServiceResourceId = default;
            IotMappingProperties fhirMapping = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = SystemData.DeserializeSystemData(property.Value);
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
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
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
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceIdentityResolutionType"))
                        {
                            resourceIdentityResolutionType = new IotIdentityResolutionType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("fhirServiceResourceId"))
                        {
                            fhirServiceResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fhirMapping"))
                        {
                            fhirMapping = IotMappingProperties.DeserializeIotMappingProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new IotFhirDestination(id.Value, name.Value, type.Value, etag.Value, location.Value, systemData.Value, Optional.ToNullable(provisioningState), resourceIdentityResolutionType, fhirServiceResourceId, fhirMapping);
        }
    }
}
