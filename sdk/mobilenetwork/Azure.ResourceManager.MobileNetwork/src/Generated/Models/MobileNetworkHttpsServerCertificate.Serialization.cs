// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkHttpsServerCertificate : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("certificateUrl"u8);
            writer.WriteStringValue(CertificateUri.AbsoluteUri);
            writer.WriteEndObject();
        }

        internal static MobileNetworkHttpsServerCertificate DeserializeMobileNetworkHttpsServerCertificate(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri certificateUrl = default;
            Core.Optional<MobileNetworkCertificateProvisioning> provisioning = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateUrl"u8))
                {
                    certificateUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioning = MobileNetworkCertificateProvisioning.DeserializeMobileNetworkCertificateProvisioning(property.Value);
                    continue;
                }
            }
            return new MobileNetworkHttpsServerCertificate(certificateUrl, provisioning.Value);
        }
    }
}
