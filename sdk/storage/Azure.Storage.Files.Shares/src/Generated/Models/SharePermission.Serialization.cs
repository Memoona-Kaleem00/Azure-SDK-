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

namespace Azure.Storage.Files.Shares.Models
{
    internal partial class SharePermission : IUtf8JsonSerializable, IModelJsonSerializable<SharePermission>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SharePermission>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SharePermission>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SharePermission>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("permission"u8);
            writer.WriteStringValue(Permission);
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

        internal static SharePermission DeserializeSharePermission(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string permission = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("permission"u8))
                {
                    permission = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SharePermission(permission, rawData);
        }

        SharePermission IModelJsonSerializable<SharePermission>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SharePermission>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSharePermission(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SharePermission>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SharePermission>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SharePermission IModelSerializable<SharePermission>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SharePermission>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSharePermission(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SharePermission"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SharePermission"/> to convert. </param>
        public static implicit operator RequestContent(SharePermission model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SharePermission"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SharePermission(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSharePermission(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
