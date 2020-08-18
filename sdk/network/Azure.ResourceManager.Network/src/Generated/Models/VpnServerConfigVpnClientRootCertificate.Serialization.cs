// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnServerConfigVpnClientRootCertificate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(PublicCertData))
            {
                writer.WritePropertyName("publicCertData");
                writer.WriteStringValue(PublicCertData);
            }
            writer.WriteEndObject();
        }

        internal static VpnServerConfigVpnClientRootCertificate DeserializeVpnServerConfigVpnClientRootCertificate(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> publicCertData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicCertData"))
                {
                    publicCertData = property.Value.GetString();
                    continue;
                }
            }
            return new VpnServerConfigVpnClientRootCertificate(name.Value, publicCertData.Value);
        }
    }
}
