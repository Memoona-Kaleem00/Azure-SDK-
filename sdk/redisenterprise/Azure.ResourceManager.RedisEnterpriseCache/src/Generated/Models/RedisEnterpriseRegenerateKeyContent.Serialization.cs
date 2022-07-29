// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterpriseCache.Models
{
    public partial class RedisEnterpriseRegenerateKeyContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyType");
            writer.WriteStringValue(KeyType.ToSerialString());
            writer.WriteEndObject();
        }
    }
}
