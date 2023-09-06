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

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class HanaDBProviderInstanceProperties : IUtf8JsonSerializable, IModelJsonSerializable<HanaDBProviderInstanceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HanaDBProviderInstanceProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HanaDBProviderInstanceProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HanaDBProviderInstanceProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Hostname))
            {
                writer.WritePropertyName("hostname"u8);
                writer.WriteStringValue(Hostname);
            }
            if (Optional.IsDefined(DBName))
            {
                writer.WritePropertyName("dbName"u8);
                writer.WriteStringValue(DBName);
            }
            if (Optional.IsDefined(SqlPort))
            {
                writer.WritePropertyName("sqlPort"u8);
                writer.WriteStringValue(SqlPort);
            }
            if (Optional.IsDefined(InstanceNumber))
            {
                writer.WritePropertyName("instanceNumber"u8);
                writer.WriteStringValue(InstanceNumber);
            }
            if (Optional.IsDefined(DBUsername))
            {
                writer.WritePropertyName("dbUsername"u8);
                writer.WriteStringValue(DBUsername);
            }
            if (Optional.IsDefined(DBPassword))
            {
                writer.WritePropertyName("dbPassword"u8);
                writer.WriteStringValue(DBPassword);
            }
            if (Optional.IsDefined(DBPasswordUri))
            {
                writer.WritePropertyName("dbPasswordUri"u8);
                writer.WriteStringValue(DBPasswordUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SslCertificateUri))
            {
                writer.WritePropertyName("sslCertificateUri"u8);
                writer.WriteStringValue(SslCertificateUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SslHostNameInCertificate))
            {
                writer.WritePropertyName("sslHostNameInCertificate"u8);
                writer.WriteStringValue(SslHostNameInCertificate);
            }
            if (Optional.IsDefined(SslPreference))
            {
                writer.WritePropertyName("sslPreference"u8);
                writer.WriteStringValue(SslPreference.Value.ToString());
            }
            if (Optional.IsDefined(SapSid))
            {
                writer.WritePropertyName("sapSid"u8);
                writer.WriteStringValue(SapSid);
            }
            writer.WritePropertyName("providerType"u8);
            writer.WriteStringValue(ProviderType);
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

        internal static HanaDBProviderInstanceProperties DeserializeHanaDBProviderInstanceProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> hostname = default;
            Optional<string> dbName = default;
            Optional<string> sqlPort = default;
            Optional<string> instanceNumber = default;
            Optional<string> dbUsername = default;
            Optional<string> dbPassword = default;
            Optional<Uri> dbPasswordUri = default;
            Optional<Uri> sslCertificateUri = default;
            Optional<string> sslHostNameInCertificate = default;
            Optional<SapSslPreference> sslPreference = default;
            Optional<string> sapSid = default;
            string providerType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostname"u8))
                {
                    hostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbName"u8))
                {
                    dbName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sqlPort"u8))
                {
                    sqlPort = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceNumber"u8))
                {
                    instanceNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbUsername"u8))
                {
                    dbUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbPassword"u8))
                {
                    dbPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbPasswordUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dbPasswordUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sslCertificateUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslCertificateUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sslHostNameInCertificate"u8))
                {
                    sslHostNameInCertificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sslPreference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslPreference = new SapSslPreference(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sapSid"u8))
                {
                    sapSid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerType"u8))
                {
                    providerType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HanaDBProviderInstanceProperties(providerType, hostname.Value, dbName.Value, sqlPort.Value, instanceNumber.Value, dbUsername.Value, dbPassword.Value, dbPasswordUri.Value, sslCertificateUri.Value, sslHostNameInCertificate.Value, Optional.ToNullable(sslPreference), sapSid.Value, rawData);
        }

        HanaDBProviderInstanceProperties IModelJsonSerializable<HanaDBProviderInstanceProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HanaDBProviderInstanceProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHanaDBProviderInstanceProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HanaDBProviderInstanceProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HanaDBProviderInstanceProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HanaDBProviderInstanceProperties IModelSerializable<HanaDBProviderInstanceProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HanaDBProviderInstanceProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHanaDBProviderInstanceProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HanaDBProviderInstanceProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HanaDBProviderInstanceProperties"/> to convert. </param>
        public static implicit operator RequestContent(HanaDBProviderInstanceProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HanaDBProviderInstanceProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HanaDBProviderInstanceProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHanaDBProviderInstanceProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
