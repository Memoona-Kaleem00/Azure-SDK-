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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class ProcessModuleInfoData : IUtf8JsonSerializable, IModelJsonSerializable<ProcessModuleInfoData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ProcessModuleInfoData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ProcessModuleInfoData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProcessModuleInfoData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(BaseAddress))
            {
                writer.WritePropertyName("base_address"u8);
                writer.WriteStringValue(BaseAddress);
            }
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("file_name"u8);
                writer.WriteStringValue(FileName);
            }
            if (Optional.IsDefined(Href))
            {
                writer.WritePropertyName("href"u8);
                writer.WriteStringValue(Href);
            }
            if (Optional.IsDefined(FilePath))
            {
                writer.WritePropertyName("file_path"u8);
                writer.WriteStringValue(FilePath);
            }
            if (Optional.IsDefined(ModuleMemorySize))
            {
                writer.WritePropertyName("module_memory_size"u8);
                writer.WriteNumberValue(ModuleMemorySize.Value);
            }
            if (Optional.IsDefined(FileVersion))
            {
                writer.WritePropertyName("file_version"u8);
                writer.WriteStringValue(FileVersion);
            }
            if (Optional.IsDefined(FileDescription))
            {
                writer.WritePropertyName("file_description"u8);
                writer.WriteStringValue(FileDescription);
            }
            if (Optional.IsDefined(Product))
            {
                writer.WritePropertyName("product"u8);
                writer.WriteStringValue(Product);
            }
            if (Optional.IsDefined(ProductVersion))
            {
                writer.WritePropertyName("product_version"u8);
                writer.WriteStringValue(ProductVersion);
            }
            if (Optional.IsDefined(IsDebug))
            {
                writer.WritePropertyName("is_debug"u8);
                writer.WriteBooleanValue(IsDebug.Value);
            }
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
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

        internal static ProcessModuleInfoData DeserializeProcessModuleInfoData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> baseAddress = default;
            Optional<string> fileName = default;
            Optional<string> href = default;
            Optional<string> filePath = default;
            Optional<int> moduleMemorySize = default;
            Optional<string> fileVersion = default;
            Optional<string> fileDescription = default;
            Optional<string> product = default;
            Optional<string> productVersion = default;
            Optional<bool> isDebug = default;
            Optional<string> language = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("base_address"u8))
                        {
                            baseAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("file_name"u8))
                        {
                            fileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("href"u8))
                        {
                            href = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("file_path"u8))
                        {
                            filePath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("module_memory_size"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            moduleMemorySize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("file_version"u8))
                        {
                            fileVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("file_description"u8))
                        {
                            fileDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("product"u8))
                        {
                            product = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("product_version"u8))
                        {
                            productVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("is_debug"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDebug = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("language"u8))
                        {
                            language = property0.Value.GetString();
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
            return new ProcessModuleInfoData(id, name, type, systemData.Value, baseAddress.Value, fileName.Value, href.Value, filePath.Value, Optional.ToNullable(moduleMemorySize), fileVersion.Value, fileDescription.Value, product.Value, productVersion.Value, Optional.ToNullable(isDebug), language.Value, kind.Value, rawData);
        }

        ProcessModuleInfoData IModelJsonSerializable<ProcessModuleInfoData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProcessModuleInfoData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProcessModuleInfoData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ProcessModuleInfoData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProcessModuleInfoData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ProcessModuleInfoData IModelSerializable<ProcessModuleInfoData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProcessModuleInfoData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeProcessModuleInfoData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ProcessModuleInfoData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ProcessModuleInfoData"/> to convert. </param>
        public static implicit operator RequestContent(ProcessModuleInfoData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ProcessModuleInfoData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ProcessModuleInfoData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeProcessModuleInfoData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
