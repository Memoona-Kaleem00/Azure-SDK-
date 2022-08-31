// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicyRestrictionTokenKey : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WriteEndObject();
        }

        internal static ContentKeyPolicyRestrictionTokenKey DeserializeContentKeyPolicyRestrictionTokenKey(JsonElement element)
        {
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.ContentKeyPolicyRsaTokenKey": return ContentKeyPolicyRsaTokenKey.DeserializeContentKeyPolicyRsaTokenKey(element);
                    case "#Microsoft.Media.ContentKeyPolicySymmetricTokenKey": return ContentKeyPolicySymmetricTokenKey.DeserializeContentKeyPolicySymmetricTokenKey(element);
                    case "#Microsoft.Media.ContentKeyPolicyX509CertificateTokenKey": return ContentKeyPolicyX509CertificateTokenKey.DeserializeContentKeyPolicyX509CertificateTokenKey(element);
                }
            }
            string odataType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownContentKeyPolicyRestrictionTokenKey(odataType);
        }
    }
}
