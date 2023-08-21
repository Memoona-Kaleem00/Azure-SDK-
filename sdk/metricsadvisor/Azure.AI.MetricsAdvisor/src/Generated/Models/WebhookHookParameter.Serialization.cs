// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class WebhookHookParameter : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("endpoint"u8);
            writer.WriteStringValue(Endpoint);
            if (Core.Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username"u8);
                writer.WriteStringValue(Username);
            }
            if (Core.Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (Core.Optional.IsCollectionDefined(Headers))
            {
                writer.WritePropertyName("headers"u8);
                writer.WriteStartObject();
                foreach (var item in Headers)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Core.Optional.IsDefined(CertificateKey))
            {
                writer.WritePropertyName("certificateKey"u8);
                writer.WriteStringValue(CertificateKey);
            }
            if (Core.Optional.IsDefined(CertificatePassword))
            {
                writer.WritePropertyName("certificatePassword"u8);
                writer.WriteStringValue(CertificatePassword);
            }
            writer.WriteEndObject();
        }

        internal static WebhookHookParameter DeserializeWebhookHookParameter(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string endpoint = default;
            Core.Optional<string> username = default;
            Core.Optional<string> password = default;
            Core.Optional<IDictionary<string, string>> headers = default;
            Core.Optional<string> certificateKey = default;
            Core.Optional<string> certificatePassword = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("username"u8))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("headers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    headers = dictionary;
                    continue;
                }
                if (property.NameEquals("certificateKey"u8))
                {
                    certificateKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificatePassword"u8))
                {
                    certificatePassword = property.Value.GetString();
                    continue;
                }
            }
            return new WebhookHookParameter(endpoint, username.Value, password.Value, Core.Optional.ToDictionary(headers), certificateKey.Value, certificatePassword.Value);
        }
    }
}
