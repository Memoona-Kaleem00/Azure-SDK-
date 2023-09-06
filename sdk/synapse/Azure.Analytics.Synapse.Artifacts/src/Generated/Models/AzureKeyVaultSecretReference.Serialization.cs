// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(AzureKeyVaultSecretReferenceConverter))]
    public partial class AzureKeyVaultSecretReference : IUtf8JsonSerializable, IModelJsonSerializable<AzureKeyVaultSecretReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AzureKeyVaultSecretReference>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AzureKeyVaultSecretReference>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureKeyVaultSecretReference>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("store"u8);
            if (Store is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<LinkedServiceReference>)Store).Serialize(writer, options);
            }
            writer.WritePropertyName("secretName"u8);
            writer.WriteObjectValue(SecretName);
            if (Optional.IsDefined(SecretVersion))
            {
                writer.WritePropertyName("secretVersion"u8);
                writer.WriteObjectValue(SecretVersion);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
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

        internal static AzureKeyVaultSecretReference DeserializeAzureKeyVaultSecretReference(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LinkedServiceReference store = default;
            object secretName = default;
            Optional<object> secretVersion = default;
            string type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("store"u8))
                {
                    store = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("secretName"u8))
                {
                    secretName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("secretVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secretVersion = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AzureKeyVaultSecretReference(type, store, secretName, secretVersion.Value, rawData);
        }

        AzureKeyVaultSecretReference IModelJsonSerializable<AzureKeyVaultSecretReference>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureKeyVaultSecretReference>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureKeyVaultSecretReference(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AzureKeyVaultSecretReference>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureKeyVaultSecretReference>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AzureKeyVaultSecretReference IModelSerializable<AzureKeyVaultSecretReference>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AzureKeyVaultSecretReference>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAzureKeyVaultSecretReference(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AzureKeyVaultSecretReference"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AzureKeyVaultSecretReference"/> to convert. </param>
        public static implicit operator RequestContent(AzureKeyVaultSecretReference model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AzureKeyVaultSecretReference"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AzureKeyVaultSecretReference(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAzureKeyVaultSecretReference(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class AzureKeyVaultSecretReferenceConverter : JsonConverter<AzureKeyVaultSecretReference>
        {
            public override void Write(Utf8JsonWriter writer, AzureKeyVaultSecretReference model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AzureKeyVaultSecretReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAzureKeyVaultSecretReference(document.RootElement);
            }
        }
    }
}
