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
    public partial class StackMinorVersion : IUtf8JsonSerializable, IModelJsonSerializable<StackMinorVersion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StackMinorVersion>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StackMinorVersion>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StackMinorVersion>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayVersion))
            {
                writer.WritePropertyName("displayVersion"u8);
                writer.WriteStringValue(DisplayVersion);
            }
            if (Optional.IsDefined(RuntimeVersion))
            {
                writer.WritePropertyName("runtimeVersion"u8);
                writer.WriteStringValue(RuntimeVersion);
            }
            if (Optional.IsDefined(IsDefault))
            {
                writer.WritePropertyName("isDefault"u8);
                writer.WriteBooleanValue(IsDefault.Value);
            }
            if (Optional.IsDefined(IsRemoteDebuggingEnabled))
            {
                writer.WritePropertyName("isRemoteDebuggingEnabled"u8);
                writer.WriteBooleanValue(IsRemoteDebuggingEnabled.Value);
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

        internal static StackMinorVersion DeserializeStackMinorVersion(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayVersion = default;
            Optional<string> runtimeVersion = default;
            Optional<bool> isDefault = default;
            Optional<bool> isRemoteDebuggingEnabled = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayVersion"u8))
                {
                    displayVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeVersion"u8))
                {
                    runtimeVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDefault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDefault = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isRemoteDebuggingEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isRemoteDebuggingEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StackMinorVersion(displayVersion.Value, runtimeVersion.Value, Optional.ToNullable(isDefault), Optional.ToNullable(isRemoteDebuggingEnabled), rawData);
        }

        StackMinorVersion IModelJsonSerializable<StackMinorVersion>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StackMinorVersion>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStackMinorVersion(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StackMinorVersion>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StackMinorVersion>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StackMinorVersion IModelSerializable<StackMinorVersion>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StackMinorVersion>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStackMinorVersion(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StackMinorVersion"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StackMinorVersion"/> to convert. </param>
        public static implicit operator RequestContent(StackMinorVersion model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StackMinorVersion"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StackMinorVersion(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStackMinorVersion(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
