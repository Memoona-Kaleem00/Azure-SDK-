// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    public partial class NotificationHubApnsCredential : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ApnsCertificate))
            {
                writer.WritePropertyName("apnsCertificate"u8);
                writer.WriteStringValue(ApnsCertificate);
            }
            if (Core.Optional.IsDefined(CertificateKey))
            {
                writer.WritePropertyName("certificateKey"u8);
                writer.WriteStringValue(CertificateKey);
            }
            if (Core.Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint.AbsoluteUri);
            }
            if (Core.Optional.IsDefined(ThumbprintString))
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(ThumbprintString);
            }
            if (Core.Optional.IsDefined(KeyId))
            {
                writer.WritePropertyName("keyId"u8);
                writer.WriteStringValue(KeyId);
            }
            if (Core.Optional.IsDefined(AppName))
            {
                writer.WritePropertyName("appName"u8);
                writer.WriteStringValue(AppName);
            }
            if (Core.Optional.IsDefined(AppId))
            {
                writer.WritePropertyName("appId"u8);
                writer.WriteStringValue(AppId);
            }
            if (Core.Optional.IsDefined(Token))
            {
                writer.WritePropertyName("token"u8);
                writer.WriteStringValue(Token);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NotificationHubApnsCredential DeserializeNotificationHubApnsCredential(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> apnsCertificate = default;
            Core.Optional<string> certificateKey = default;
            Core.Optional<Uri> endpoint = default;
            Core.Optional<string> thumbprint = default;
            Core.Optional<string> keyId = default;
            Core.Optional<string> appName = default;
            Core.Optional<string> appId = default;
            Core.Optional<string> token = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("apnsCertificate"u8))
                        {
                            apnsCertificate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("certificateKey"u8))
                        {
                            certificateKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpoint = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("thumbprint"u8))
                        {
                            thumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("keyId"u8))
                        {
                            keyId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("appName"u8))
                        {
                            appName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("appId"u8))
                        {
                            appId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("token"u8))
                        {
                            token = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NotificationHubApnsCredential(apnsCertificate.Value, certificateKey.Value, endpoint.Value, thumbprint.Value, keyId.Value, appName.Value, appId.Value, token.Value);
        }
    }
}
