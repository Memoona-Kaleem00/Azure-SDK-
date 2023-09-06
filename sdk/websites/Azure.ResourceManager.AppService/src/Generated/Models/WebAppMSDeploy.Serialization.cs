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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WebAppMSDeploy : IUtf8JsonSerializable, IModelJsonSerializable<WebAppMSDeploy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WebAppMSDeploy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WebAppMSDeploy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebAppMSDeploy>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PackageUri))
            {
                writer.WritePropertyName("packageUri"u8);
                writer.WriteStringValue(PackageUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ConnectionString))
            {
                writer.WritePropertyName("connectionString"u8);
                writer.WriteStringValue(ConnectionString);
            }
            if (Optional.IsDefined(DBType))
            {
                writer.WritePropertyName("dbType"u8);
                writer.WriteStringValue(DBType);
            }
            if (Optional.IsDefined(SetParametersXmlFileUri))
            {
                writer.WritePropertyName("setParametersXmlFileUri"u8);
                writer.WriteStringValue(SetParametersXmlFileUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(SetParameters))
            {
                writer.WritePropertyName("setParameters"u8);
                writer.WriteStartObject();
                foreach (var item in SetParameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(SkipAppData))
            {
                writer.WritePropertyName("skipAppData"u8);
                writer.WriteBooleanValue(SkipAppData.Value);
            }
            if (Optional.IsDefined(IsAppOffline))
            {
                writer.WritePropertyName("appOffline"u8);
                writer.WriteBooleanValue(IsAppOffline.Value);
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

        internal static WebAppMSDeploy DeserializeWebAppMSDeploy(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<Uri> packageUri = default;
            Optional<string> connectionString = default;
            Optional<string> dbType = default;
            Optional<Uri> setParametersXmlFileUri = default;
            Optional<IDictionary<string, string>> setParameters = default;
            Optional<bool> skipAppData = default;
            Optional<bool> appOffline = default;
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
                        if (property0.NameEquals("packageUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            packageUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("connectionString"u8))
                        {
                            connectionString = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dbType"u8))
                        {
                            dbType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("setParametersXmlFileUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            setParametersXmlFileUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("setParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            setParameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("skipAppData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            skipAppData = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("appOffline"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appOffline = property0.Value.GetBoolean();
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
            return new WebAppMSDeploy(id, name, type, systemData.Value, packageUri.Value, connectionString.Value, dbType.Value, setParametersXmlFileUri.Value, Optional.ToDictionary(setParameters), Optional.ToNullable(skipAppData), Optional.ToNullable(appOffline), kind.Value, rawData);
        }

        WebAppMSDeploy IModelJsonSerializable<WebAppMSDeploy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebAppMSDeploy>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeWebAppMSDeploy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WebAppMSDeploy>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebAppMSDeploy>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WebAppMSDeploy IModelSerializable<WebAppMSDeploy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebAppMSDeploy>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWebAppMSDeploy(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="WebAppMSDeploy"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="WebAppMSDeploy"/> to convert. </param>
        public static implicit operator RequestContent(WebAppMSDeploy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="WebAppMSDeploy"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator WebAppMSDeploy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeWebAppMSDeploy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
