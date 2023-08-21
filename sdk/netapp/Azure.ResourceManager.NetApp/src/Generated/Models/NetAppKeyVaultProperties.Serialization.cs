// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppKeyVaultProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyVaultUri"u8);
            writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
            writer.WritePropertyName("keyName"u8);
            writer.WriteStringValue(KeyName);
            writer.WritePropertyName("keyVaultResourceId"u8);
            writer.WriteStringValue(KeyVaultResourceId);
            writer.WriteEndObject();
        }

        internal static NetAppKeyVaultProperties DeserializeNetAppKeyVaultProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> keyVaultId = default;
            Uri keyVaultUri = default;
            string keyName = default;
            string keyVaultResourceId = default;
            Core.Optional<NetAppKeyVaultStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultId"u8))
                {
                    keyVaultId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultUri"u8))
                {
                    keyVaultUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultResourceId"u8))
                {
                    keyVaultResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new NetAppKeyVaultStatus(property.Value.GetString());
                    continue;
                }
            }
            return new NetAppKeyVaultProperties(keyVaultId.Value, keyVaultUri, keyName, keyVaultResourceId, Core.Optional.ToNullable(status));
        }
    }
}
