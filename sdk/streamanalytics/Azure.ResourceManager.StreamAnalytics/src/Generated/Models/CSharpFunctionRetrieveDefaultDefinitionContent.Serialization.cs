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

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class CSharpFunctionRetrieveDefaultDefinitionContent : IUtf8JsonSerializable, IModelJsonSerializable<CSharpFunctionRetrieveDefaultDefinitionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CSharpFunctionRetrieveDefaultDefinitionContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CSharpFunctionRetrieveDefaultDefinitionContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CSharpFunctionRetrieveDefaultDefinitionContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("bindingType"u8);
            writer.WriteStringValue(BindingType);
            writer.WritePropertyName("bindingRetrievalProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Script))
            {
                writer.WritePropertyName("script"u8);
                writer.WriteStringValue(Script);
            }
            if (Optional.IsDefined(UdfType))
            {
                writer.WritePropertyName("udfType"u8);
                writer.WriteStringValue(UdfType.Value.ToString());
            }
            writer.WriteEndObject();
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

        internal static CSharpFunctionRetrieveDefaultDefinitionContent DeserializeCSharpFunctionRetrieveDefaultDefinitionContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string bindingType = default;
            Optional<string> script = default;
            Optional<StreamingJobFunctionUdfType> udfType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bindingType"u8))
                {
                    bindingType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bindingRetrievalProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("script"u8))
                        {
                            script = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("udfType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            udfType = new StreamingJobFunctionUdfType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CSharpFunctionRetrieveDefaultDefinitionContent(bindingType, script.Value, Optional.ToNullable(udfType), rawData);
        }

        CSharpFunctionRetrieveDefaultDefinitionContent IModelJsonSerializable<CSharpFunctionRetrieveDefaultDefinitionContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CSharpFunctionRetrieveDefaultDefinitionContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCSharpFunctionRetrieveDefaultDefinitionContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CSharpFunctionRetrieveDefaultDefinitionContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CSharpFunctionRetrieveDefaultDefinitionContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CSharpFunctionRetrieveDefaultDefinitionContent IModelSerializable<CSharpFunctionRetrieveDefaultDefinitionContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CSharpFunctionRetrieveDefaultDefinitionContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCSharpFunctionRetrieveDefaultDefinitionContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CSharpFunctionRetrieveDefaultDefinitionContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CSharpFunctionRetrieveDefaultDefinitionContent"/> to convert. </param>
        public static implicit operator RequestContent(CSharpFunctionRetrieveDefaultDefinitionContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CSharpFunctionRetrieveDefaultDefinitionContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CSharpFunctionRetrieveDefaultDefinitionContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCSharpFunctionRetrieveDefaultDefinitionContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
