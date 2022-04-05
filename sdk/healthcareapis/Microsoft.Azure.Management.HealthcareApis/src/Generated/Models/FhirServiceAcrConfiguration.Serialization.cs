// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    public partial class FhirServiceAcrConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(LoginServers))
            {
                writer.WritePropertyName("loginServers");
                writer.WriteStartArray();
                foreach (var item in LoginServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(OciArtifacts))
            {
                writer.WritePropertyName("ociArtifacts");
                writer.WriteStartArray();
                foreach (var item in OciArtifacts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static FhirServiceAcrConfiguration DeserializeFhirServiceAcrConfiguration(JsonElement element)
        {
            Optional<IList<string>> loginServers = default;
            Optional<IList<ServiceOciArtifactEntry>> ociArtifacts = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("loginServers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    loginServers = array;
                    continue;
                }
                if (property.NameEquals("ociArtifacts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ServiceOciArtifactEntry> array = new List<ServiceOciArtifactEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceOciArtifactEntry.DeserializeServiceOciArtifactEntry(item));
                    }
                    ociArtifacts = array;
                    continue;
                }
            }
            return new FhirServiceAcrConfiguration(Optional.ToList(loginServers), Optional.ToList(ociArtifacts));
        }
    }
}
