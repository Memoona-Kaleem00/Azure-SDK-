// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ExtendedCosmosDBSqlUserDefinedFunctionResourceInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteStringValue(FunctionName);
            if (Optional.IsDefined(Body))
            {
                writer.WritePropertyName("body");
                writer.WriteStringValue(Body);
            }
            writer.WriteEndObject();
        }

        internal static ExtendedCosmosDBSqlUserDefinedFunctionResourceInfo DeserializeExtendedCosmosDBSqlUserDefinedFunctionResourceInfo(JsonElement element)
        {
            Optional<string> rid = default;
            Optional<float> ts = default;
            Optional<ETag> etag = default;
            string id = default;
            Optional<string> body = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_ts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ts = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("_etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("body"))
                {
                    body = property.Value.GetString();
                    continue;
                }
            }
            return new ExtendedCosmosDBSqlUserDefinedFunctionResourceInfo(id, body.Value, rid.Value, Optional.ToNullable(ts), Optional.ToNullable(etag));
        }
    }
}
