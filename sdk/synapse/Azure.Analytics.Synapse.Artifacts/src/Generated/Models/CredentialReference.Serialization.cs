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
    [JsonConverter(typeof(CredentialReferenceConverter))]
    public partial class CredentialReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("referenceName"u8);
            writer.WriteStringValue(ReferenceName);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue<object>(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static CredentialReference DeserializeCredentialReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CredentialReferenceType type = default;
            string referenceName = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new CredentialReferenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("referenceName"u8))
                {
                    referenceName = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new CredentialReference(type, referenceName, additionalProperties);
        }

        internal partial class CredentialReferenceConverter : JsonConverter<CredentialReference>
        {
            public override void Write(Utf8JsonWriter writer, CredentialReference model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue<CredentialReference>(model);
            }
            public override CredentialReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeCredentialReference(document.RootElement);
            }
        }
    }
}
