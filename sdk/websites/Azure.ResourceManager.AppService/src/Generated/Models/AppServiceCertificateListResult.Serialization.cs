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
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class AppServiceCertificateListResult : IUtf8JsonSerializable, IModelJsonSerializable<AppServiceCertificateListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppServiceCertificateListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppServiceCertificateListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceCertificateListResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AppServiceCertificateData>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
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

        internal static AppServiceCertificateListResult DeserializeAppServiceCertificateListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<AppServiceCertificateData> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<AppServiceCertificateData> array = new List<AppServiceCertificateData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppServiceCertificateData.DeserializeAppServiceCertificateData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AppServiceCertificateListResult(value, nextLink.Value, rawData);
        }

        AppServiceCertificateListResult IModelJsonSerializable<AppServiceCertificateListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceCertificateListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceCertificateListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppServiceCertificateListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceCertificateListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppServiceCertificateListResult IModelSerializable<AppServiceCertificateListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceCertificateListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppServiceCertificateListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AppServiceCertificateListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AppServiceCertificateListResult"/> to convert. </param>
        public static implicit operator RequestContent(AppServiceCertificateListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AppServiceCertificateListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AppServiceCertificateListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppServiceCertificateListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
