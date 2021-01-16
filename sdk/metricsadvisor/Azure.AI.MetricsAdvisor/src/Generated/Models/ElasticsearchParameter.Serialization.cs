// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class ElasticsearchParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Host != null)
            {
                writer.WritePropertyName("host");
                writer.WriteStringValue(Host);
            }
            else
            {
                writer.WriteNull("host");
            }
            if (Port != null)
            {
                writer.WritePropertyName("port");
                writer.WriteStringValue(Port);
            }
            else
            {
                writer.WriteNull("port");
            }
            if (AuthHeader != null)
            {
                writer.WritePropertyName("authHeader");
                writer.WriteStringValue(AuthHeader);
            }
            else
            {
                writer.WriteNull("authHeader");
            }
            if (Query != null)
            {
                writer.WritePropertyName("query");
                writer.WriteStringValue(Query);
            }
            else
            {
                writer.WriteNull("query");
            }
            writer.WriteEndObject();
        }

        internal static ElasticsearchParameter DeserializeElasticsearchParameter(JsonElement element)
        {
            string host = default;
            string port = default;
            string authHeader = default;
            string query = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("host"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        host = null;
                        continue;
                    }
                    host = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        port = null;
                        continue;
                    }
                    port = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authHeader"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        authHeader = null;
                        continue;
                    }
                    authHeader = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("query"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        query = null;
                        continue;
                    }
                    query = property.Value.GetString();
                    continue;
                }
            }
            return new ElasticsearchParameter(host, port, authHeader, query);
        }
    }
}
