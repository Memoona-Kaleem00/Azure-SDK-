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
    [JsonConverter(typeof(XmlReadSettingsConverter))]
    public partial class XmlReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CompressionProperties))
            {
                writer.WritePropertyName("compressionProperties"u8);
                writer.WriteObjectValue<CompressionReadSettings>(CompressionProperties);
            }
            if (Optional.IsDefined(ValidationMode))
            {
                writer.WritePropertyName("validationMode"u8);
                writer.WriteObjectValue<object>(ValidationMode);
            }
            if (Optional.IsDefined(DetectDataType))
            {
                writer.WritePropertyName("detectDataType"u8);
                writer.WriteObjectValue<object>(DetectDataType);
            }
            if (Optional.IsDefined(Namespaces))
            {
                writer.WritePropertyName("namespaces"u8);
                writer.WriteObjectValue<object>(Namespaces);
            }
            if (Optional.IsDefined(NamespacePrefixes))
            {
                writer.WritePropertyName("namespacePrefixes"u8);
                writer.WriteObjectValue<object>(NamespacePrefixes);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue<object>(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static XmlReadSettings DeserializeXmlReadSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CompressionReadSettings compressionProperties = default;
            object validationMode = default;
            object detectDataType = default;
            object namespaces = default;
            object namespacePrefixes = default;
            string type = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("compressionProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compressionProperties = CompressionReadSettings.DeserializeCompressionReadSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("validationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationMode = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("detectDataType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    detectDataType = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("namespaces"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    namespaces = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("namespacePrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    namespacePrefixes = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new XmlReadSettings(
                type,
                additionalProperties,
                compressionProperties,
                validationMode,
                detectDataType,
                namespaces,
                namespacePrefixes);
        }

        internal partial class XmlReadSettingsConverter : JsonConverter<XmlReadSettings>
        {
            public override void Write(Utf8JsonWriter writer, XmlReadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue<XmlReadSettings>(model);
            }
            public override XmlReadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeXmlReadSettings(document.RootElement);
            }
        }
    }
}
