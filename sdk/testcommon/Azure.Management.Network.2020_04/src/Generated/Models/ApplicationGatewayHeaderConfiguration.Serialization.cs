// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ApplicationGatewayHeaderConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (HeaderName != null)
            {
                writer.WritePropertyName("headerName");
                writer.WriteStringValue(HeaderName);
            }
            if (HeaderValue != null)
            {
                writer.WritePropertyName("headerValue");
                writer.WriteStringValue(HeaderValue);
            }
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayHeaderConfiguration DeserializeApplicationGatewayHeaderConfiguration(JsonElement element)
        {
            string headerName = default;
            string headerValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("headerName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    headerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("headerValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    headerValue = property.Value.GetString();
                    continue;
                }
            }
            return new ApplicationGatewayHeaderConfiguration(headerName, headerValue);
        }
    }
}
