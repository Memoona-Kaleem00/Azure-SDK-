// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(JsonFormatConverter))]
    public partial class JsonFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FilePattern))
            {
                writer.WritePropertyName("filePattern"u8);
                writer.WriteObjectValue(FilePattern);
            }
            if (Optional.IsDefined(NestingSeparator))
            {
                writer.WritePropertyName("nestingSeparator"u8);
                writer.WriteObjectValue(NestingSeparator);
            }
            if (Optional.IsDefined(EncodingName))
            {
                writer.WritePropertyName("encodingName"u8);
                writer.WriteObjectValue(EncodingName);
            }
            if (Optional.IsDefined(JsonNodeReference))
            {
                writer.WritePropertyName("jsonNodeReference"u8);
                writer.WriteObjectValue(JsonNodeReference);
            }
            if (Optional.IsDefined(JsonPathDefinition))
            {
                writer.WritePropertyName("jsonPathDefinition"u8);
                writer.WriteObjectValue(JsonPathDefinition);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Serializer))
            {
                writer.WritePropertyName("serializer"u8);
                writer.WriteObjectValue(Serializer);
            }
            if (Optional.IsDefined(Deserializer))
            {
                writer.WritePropertyName("deserializer"u8);
                writer.WriteObjectValue(Deserializer);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static JsonFormat DeserializeJsonFormat(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object filePattern = default;
            object nestingSeparator = default;
            object encodingName = default;
            object jsonNodeReference = default;
            object jsonPathDefinition = default;
            string type = default;
            object serializer = default;
            object deserializer = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filePattern"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filePattern = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("nestingSeparator"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nestingSeparator = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("encodingName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encodingName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("jsonNodeReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jsonNodeReference = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("jsonPathDefinition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jsonPathDefinition = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serializer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serializer = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("deserializer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deserializer = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new JsonFormat(
                type,
                serializer,
                deserializer,
                additionalProperties,
                filePattern,
                nestingSeparator,
                encodingName,
                jsonNodeReference,
                jsonPathDefinition);
        }

        internal partial class JsonFormatConverter : JsonConverter<JsonFormat>
        {
            public override void Write(Utf8JsonWriter writer, JsonFormat model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override JsonFormat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeJsonFormat(document.RootElement);
            }
        }
    }
}
