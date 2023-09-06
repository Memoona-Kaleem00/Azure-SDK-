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
    public partial class FunctionAppMinorVersion : IUtf8JsonSerializable, IModelJsonSerializable<FunctionAppMinorVersion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FunctionAppMinorVersion>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FunctionAppMinorVersion>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FunctionAppMinorVersion>(this, options.Format);

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

        internal static FunctionAppMinorVersion DeserializeFunctionAppMinorVersion(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayText = default;
            Optional<string> value = default;
            Optional<FunctionAppRuntimes> stackSettings = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayText"u8))
                {
                    displayText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stackSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stackSettings = FunctionAppRuntimes.DeserializeFunctionAppRuntimes(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new FunctionAppMinorVersion(displayText.Value, value.Value, stackSettings.Value, rawData);
        }

        FunctionAppMinorVersion IModelJsonSerializable<FunctionAppMinorVersion>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FunctionAppMinorVersion>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFunctionAppMinorVersion(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FunctionAppMinorVersion>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FunctionAppMinorVersion>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FunctionAppMinorVersion IModelSerializable<FunctionAppMinorVersion>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FunctionAppMinorVersion>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFunctionAppMinorVersion(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FunctionAppMinorVersion"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FunctionAppMinorVersion"/> to convert. </param>
        public static implicit operator RequestContent(FunctionAppMinorVersion model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FunctionAppMinorVersion"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FunctionAppMinorVersion(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFunctionAppMinorVersion(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
