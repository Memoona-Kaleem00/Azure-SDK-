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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DefaultAuthorizationPolicy : IUtf8JsonSerializable, IModelJsonSerializable<DefaultAuthorizationPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DefaultAuthorizationPolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DefaultAuthorizationPolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DefaultAuthorizationPolicy>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AllowedPrincipals))
            {
                writer.WritePropertyName("allowedPrincipals"u8);
                if (AllowedPrincipals is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AppServiceAadAllowedPrincipals>)AllowedPrincipals).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(AllowedApplications))
            {
                writer.WritePropertyName("allowedApplications"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedApplications)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
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

        internal static DefaultAuthorizationPolicy DeserializeDefaultAuthorizationPolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppServiceAadAllowedPrincipals> allowedPrincipals = default;
            Optional<IList<string>> allowedApplications = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedPrincipals"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowedPrincipals = AppServiceAadAllowedPrincipals.DeserializeAppServiceAadAllowedPrincipals(property.Value);
                    continue;
                }
                if (property.NameEquals("allowedApplications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedApplications = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DefaultAuthorizationPolicy(allowedPrincipals.Value, Optional.ToList(allowedApplications), rawData);
        }

        DefaultAuthorizationPolicy IModelJsonSerializable<DefaultAuthorizationPolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DefaultAuthorizationPolicy>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDefaultAuthorizationPolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DefaultAuthorizationPolicy>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DefaultAuthorizationPolicy>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DefaultAuthorizationPolicy IModelSerializable<DefaultAuthorizationPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DefaultAuthorizationPolicy>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDefaultAuthorizationPolicy(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DefaultAuthorizationPolicy"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DefaultAuthorizationPolicy"/> to convert. </param>
        public static implicit operator RequestContent(DefaultAuthorizationPolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DefaultAuthorizationPolicy"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DefaultAuthorizationPolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDefaultAuthorizationPolicy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
