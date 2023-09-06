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

namespace Azure.ResourceManager.Storage.Models
{
    public partial class GetServiceSasResult : IUtf8JsonSerializable, IModelJsonSerializable<GetServiceSasResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GetServiceSasResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GetServiceSasResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetServiceSasResult>(this, options.Format);

            writer.WriteStartObject();
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

        internal static GetServiceSasResult DeserializeGetServiceSasResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> serviceSasToken = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceSasToken"u8))
                {
                    serviceSasToken = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GetServiceSasResult(serviceSasToken.Value, rawData);
        }

        GetServiceSasResult IModelJsonSerializable<GetServiceSasResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetServiceSasResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGetServiceSasResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GetServiceSasResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetServiceSasResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GetServiceSasResult IModelSerializable<GetServiceSasResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetServiceSasResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGetServiceSasResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GetServiceSasResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GetServiceSasResult"/> to convert. </param>
        public static implicit operator RequestContent(GetServiceSasResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GetServiceSasResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GetServiceSasResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGetServiceSasResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
