// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class HttpHeaderCredentials : IUtf8JsonSerializable, IModelJsonSerializable<HttpHeaderCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HttpHeaderCredentials>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HttpHeaderCredentials>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HttpHeaderCredentials>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("headerName"u8);
            writer.WriteStringValue(HeaderName);
            writer.WritePropertyName("headerValue"u8);
            writer.WriteStringValue(HeaderValue);
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
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

        internal static HttpHeaderCredentials DeserializeHttpHeaderCredentials(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string headerName = default;
            string headerValue = default;
            string type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("headerName"u8))
                {
                    headerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("headerValue"u8))
                {
                    headerValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HttpHeaderCredentials(type, headerName, headerValue, rawData);
        }

        HttpHeaderCredentials IModelJsonSerializable<HttpHeaderCredentials>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HttpHeaderCredentials>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHttpHeaderCredentials(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HttpHeaderCredentials>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HttpHeaderCredentials>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HttpHeaderCredentials IModelSerializable<HttpHeaderCredentials>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HttpHeaderCredentials>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHttpHeaderCredentials(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HttpHeaderCredentials"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HttpHeaderCredentials"/> to convert. </param>
        public static implicit operator RequestContent(HttpHeaderCredentials model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HttpHeaderCredentials"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HttpHeaderCredentials(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHttpHeaderCredentials(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
