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
    [JsonConverter(typeof(WebAnonymousAuthenticationConverter))]
    public partial class WebAnonymousAuthentication : IUtf8JsonSerializable, IModelJsonSerializable<WebAnonymousAuthentication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WebAnonymousAuthentication>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WebAnonymousAuthentication>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebAnonymousAuthentication>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("url"u8);
            writer.WriteObjectValue(Url);
            writer.WritePropertyName("authenticationType"u8);
            writer.WriteStringValue(AuthenticationType.ToString());
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

        internal static WebAnonymousAuthentication DeserializeWebAnonymousAuthentication(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object url = default;
            WebAuthenticationType authenticationType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    authenticationType = new WebAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new WebAnonymousAuthentication(url, authenticationType, rawData);
        }

        WebAnonymousAuthentication IModelJsonSerializable<WebAnonymousAuthentication>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebAnonymousAuthentication>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeWebAnonymousAuthentication(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WebAnonymousAuthentication>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebAnonymousAuthentication>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WebAnonymousAuthentication IModelSerializable<WebAnonymousAuthentication>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebAnonymousAuthentication>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWebAnonymousAuthentication(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="WebAnonymousAuthentication"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="WebAnonymousAuthentication"/> to convert. </param>
        public static implicit operator RequestContent(WebAnonymousAuthentication model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="WebAnonymousAuthentication"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator WebAnonymousAuthentication(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeWebAnonymousAuthentication(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class WebAnonymousAuthenticationConverter : JsonConverter<WebAnonymousAuthentication>
        {
            public override void Write(Utf8JsonWriter writer, WebAnonymousAuthentication model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override WebAnonymousAuthentication Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeWebAnonymousAuthentication(document.RootElement);
            }
        }
    }
}
