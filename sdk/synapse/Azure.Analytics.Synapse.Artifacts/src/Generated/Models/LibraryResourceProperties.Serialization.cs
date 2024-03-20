// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Analytics.Synapse.Artifacts;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LibraryResourcePropertiesConverter))]
    public partial class LibraryResourceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static LibraryResourceProperties DeserializeLibraryResourceProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string path = default;
            string containerName = default;
            string uploadedTimestamp = default;
            string type = default;
            string provisioningStatus = default;
            string creatorId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uploadedTimestamp"u8))
                {
                    uploadedTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningStatus"u8))
                {
                    provisioningStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("creatorId"u8))
                {
                    creatorId = property.Value.GetString();
                    continue;
                }
            }
            return new LibraryResourceProperties(
                name,
                path,
                containerName,
                uploadedTimestamp,
                type,
                provisioningStatus,
                creatorId);
        }

        internal partial class LibraryResourcePropertiesConverter : JsonConverter<LibraryResourceProperties>
        {
            public override void Write(Utf8JsonWriter writer, LibraryResourceProperties model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LibraryResourceProperties Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLibraryResourceProperties(document.RootElement);
            }
        }
    }
}
