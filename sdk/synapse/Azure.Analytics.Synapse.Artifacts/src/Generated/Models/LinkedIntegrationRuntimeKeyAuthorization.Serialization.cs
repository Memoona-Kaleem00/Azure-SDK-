// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LinkedIntegrationRuntimeKeyAuthorizationConverter))]
    public partial class LinkedIntegrationRuntimeKeyAuthorization : IUtf8JsonSerializable, IModelJsonSerializable<LinkedIntegrationRuntimeKeyAuthorization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LinkedIntegrationRuntimeKeyAuthorization>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LinkedIntegrationRuntimeKeyAuthorization>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkedIntegrationRuntimeKeyAuthorization>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("key"u8);
            if (Key is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SecureString>)Key).Serialize(writer, options);
            }
            writer.WritePropertyName("authorizationType"u8);
            writer.WriteStringValue(AuthorizationType);
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static LinkedIntegrationRuntimeKeyAuthorization DeserializeLinkedIntegrationRuntimeKeyAuthorization(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SecureString key = default;
            string authorizationType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = SecureString.DeserializeSecureString(property.Value);
                    continue;
                }
                if (property.NameEquals("authorizationType"u8))
                {
                    authorizationType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LinkedIntegrationRuntimeKeyAuthorization(authorizationType, key, rawData);
        }

        LinkedIntegrationRuntimeKeyAuthorization IModelJsonSerializable<LinkedIntegrationRuntimeKeyAuthorization>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkedIntegrationRuntimeKeyAuthorization>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkedIntegrationRuntimeKeyAuthorization(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LinkedIntegrationRuntimeKeyAuthorization>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkedIntegrationRuntimeKeyAuthorization>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LinkedIntegrationRuntimeKeyAuthorization IModelSerializable<LinkedIntegrationRuntimeKeyAuthorization>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<LinkedIntegrationRuntimeKeyAuthorization>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLinkedIntegrationRuntimeKeyAuthorization(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LinkedIntegrationRuntimeKeyAuthorization"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LinkedIntegrationRuntimeKeyAuthorization"/> to convert. </param>
        public static implicit operator RequestContent(LinkedIntegrationRuntimeKeyAuthorization model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LinkedIntegrationRuntimeKeyAuthorization"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LinkedIntegrationRuntimeKeyAuthorization(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLinkedIntegrationRuntimeKeyAuthorization(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class LinkedIntegrationRuntimeKeyAuthorizationConverter : JsonConverter<LinkedIntegrationRuntimeKeyAuthorization>
        {
            public override void Write(Utf8JsonWriter writer, LinkedIntegrationRuntimeKeyAuthorization model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LinkedIntegrationRuntimeKeyAuthorization Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkedIntegrationRuntimeKeyAuthorization(document.RootElement);
            }
        }
    }
}
