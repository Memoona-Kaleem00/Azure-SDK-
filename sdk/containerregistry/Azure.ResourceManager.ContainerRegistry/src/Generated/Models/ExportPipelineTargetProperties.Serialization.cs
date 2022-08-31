// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ExportPipelineTargetProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PipelineTargetType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(PipelineTargetType);
            }
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("uri");
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            writer.WritePropertyName("keyVaultUri");
            writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
            writer.WriteEndObject();
        }

        internal static ExportPipelineTargetProperties DeserializeExportPipelineTargetProperties(JsonElement element)
        {
            Optional<string> type = default;
            Optional<Uri> uri = default;
            Uri keyVaultUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        uri = null;
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVaultUri"))
                {
                    keyVaultUri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new ExportPipelineTargetProperties(type.Value, uri.Value, keyVaultUri);
        }
    }
}
