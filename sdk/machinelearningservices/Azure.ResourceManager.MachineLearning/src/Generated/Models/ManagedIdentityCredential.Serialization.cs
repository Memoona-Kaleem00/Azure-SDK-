// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ManagedIdentityCredential : IUtf8JsonSerializable, IJsonModel<ManagedIdentityCredential>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedIdentityCredential>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedIdentityCredential>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedIdentityCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedIdentityCredential)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedIdentityType))
            {
                if (ManagedIdentityType != null)
                {
                    writer.WritePropertyName("managedIdentityType"u8);
                    writer.WriteStringValue(ManagedIdentityType);
                }
                else
                {
                    writer.WriteNull("managedIdentityType");
                }
            }
            if (Optional.IsDefined(UserManagedIdentityResourceId))
            {
                if (UserManagedIdentityResourceId != null)
                {
                    writer.WritePropertyName("userManagedIdentityResourceId"u8);
                    writer.WriteStringValue(UserManagedIdentityResourceId);
                }
                else
                {
                    writer.WriteNull("userManagedIdentityResourceId");
                }
            }
            if (Optional.IsDefined(UserManagedIdentityClientId))
            {
                if (UserManagedIdentityClientId != null)
                {
                    writer.WritePropertyName("userManagedIdentityClientId"u8);
                    writer.WriteStringValue(UserManagedIdentityClientId);
                }
                else
                {
                    writer.WriteNull("userManagedIdentityClientId");
                }
            }
            if (Optional.IsDefined(UserManagedIdentityPrincipalId))
            {
                if (UserManagedIdentityPrincipalId != null)
                {
                    writer.WritePropertyName("userManagedIdentityPrincipalId"u8);
                    writer.WriteStringValue(UserManagedIdentityPrincipalId);
                }
                else
                {
                    writer.WriteNull("userManagedIdentityPrincipalId");
                }
            }
            if (Optional.IsDefined(UserManagedIdentityTenantId))
            {
                if (UserManagedIdentityTenantId != null)
                {
                    writer.WritePropertyName("userManagedIdentityTenantId"u8);
                    writer.WriteStringValue(UserManagedIdentityTenantId);
                }
                else
                {
                    writer.WriteNull("userManagedIdentityTenantId");
                }
            }
            writer.WritePropertyName("credentialType"u8);
            writer.WriteStringValue(CredentialType.ToString());
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ManagedIdentityCredential IJsonModel<ManagedIdentityCredential>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedIdentityCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedIdentityCredential)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedIdentityCredential(document.RootElement, options);
        }

        internal static ManagedIdentityCredential DeserializeManagedIdentityCredential(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string managedIdentityType = default;
            string userManagedIdentityResourceId = default;
            string userManagedIdentityClientId = default;
            string userManagedIdentityPrincipalId = default;
            string userManagedIdentityTenantId = default;
            DataReferenceCredentialType credentialType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedIdentityType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        managedIdentityType = null;
                        continue;
                    }
                    managedIdentityType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userManagedIdentityResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        userManagedIdentityResourceId = null;
                        continue;
                    }
                    userManagedIdentityResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userManagedIdentityClientId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        userManagedIdentityClientId = null;
                        continue;
                    }
                    userManagedIdentityClientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userManagedIdentityPrincipalId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        userManagedIdentityPrincipalId = null;
                        continue;
                    }
                    userManagedIdentityPrincipalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userManagedIdentityTenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        userManagedIdentityTenantId = null;
                        continue;
                    }
                    userManagedIdentityTenantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credentialType"u8))
                {
                    credentialType = new DataReferenceCredentialType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedIdentityCredential(
                credentialType,
                serializedAdditionalRawData,
                managedIdentityType,
                userManagedIdentityResourceId,
                userManagedIdentityClientId,
                userManagedIdentityPrincipalId,
                userManagedIdentityTenantId);
        }

        BinaryData IPersistableModel<ManagedIdentityCredential>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedIdentityCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedIdentityCredential)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedIdentityCredential IPersistableModel<ManagedIdentityCredential>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedIdentityCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedIdentityCredential(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedIdentityCredential)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedIdentityCredential>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
