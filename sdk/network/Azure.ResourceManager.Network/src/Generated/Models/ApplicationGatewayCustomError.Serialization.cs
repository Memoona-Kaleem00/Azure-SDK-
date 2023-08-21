// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayCustomError : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(StatusCode))
            {
                writer.WritePropertyName("statusCode"u8);
                writer.WriteStringValue(StatusCode.Value.ToString());
            }
            if (Core.Optional.IsDefined(CustomErrorPageUri))
            {
                writer.WritePropertyName("customErrorPageUrl"u8);
                writer.WriteStringValue(CustomErrorPageUri.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayCustomError DeserializeApplicationGatewayCustomError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ApplicationGatewayCustomErrorStatusCode> statusCode = default;
            Core.Optional<Uri> customErrorPageUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statusCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusCode = new ApplicationGatewayCustomErrorStatusCode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customErrorPageUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customErrorPageUrl = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new ApplicationGatewayCustomError(Core.Optional.ToNullable(statusCode), customErrorPageUrl.Value);
        }
    }
}
