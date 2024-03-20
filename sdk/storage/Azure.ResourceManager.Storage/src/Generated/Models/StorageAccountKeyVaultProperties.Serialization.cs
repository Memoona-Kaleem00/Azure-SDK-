// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountKeyVaultProperties : IUtf8JsonSerializable, IJsonModel<StorageAccountKeyVaultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageAccountKeyVaultProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageAccountKeyVaultProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountKeyVaultProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(KeyName))
            {
                writer.WritePropertyName("keyname"u8);
                writer.WriteStringValue(KeyName);
            }
            if (Optional.IsDefined(KeyVersion))
            {
                writer.WritePropertyName("keyversion"u8);
                writer.WriteStringValue(KeyVersion);
            }
            if (Optional.IsDefined(KeyVaultUri))
            {
                writer.WritePropertyName("keyvaulturi"u8);
                writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentVersionedKeyIdentifier))
            {
                writer.WritePropertyName("currentVersionedKeyIdentifier"u8);
                writer.WriteStringValue(CurrentVersionedKeyIdentifier);
            }
            if (options.Format != "W" && Optional.IsDefined(LastKeyRotationTimestamp))
            {
                writer.WritePropertyName("lastKeyRotationTimestamp"u8);
                writer.WriteStringValue(LastKeyRotationTimestamp.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(CurrentVersionedKeyExpirationTimestamp))
            {
                writer.WritePropertyName("currentVersionedKeyExpirationTimestamp"u8);
                writer.WriteStringValue(CurrentVersionedKeyExpirationTimestamp.Value, "O");
            }
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

        StorageAccountKeyVaultProperties IJsonModel<StorageAccountKeyVaultProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountKeyVaultProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageAccountKeyVaultProperties(document.RootElement, options);
        }

        internal static StorageAccountKeyVaultProperties DeserializeStorageAccountKeyVaultProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keyname = default;
            string keyversion = default;
            Uri keyvaulturi = default;
            string currentVersionedKeyIdentifier = default;
            DateTimeOffset? lastKeyRotationTimestamp = default;
            DateTimeOffset? currentVersionedKeyExpirationTimestamp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyname"u8))
                {
                    keyname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyversion"u8))
                {
                    keyversion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyvaulturi"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyvaulturi = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("currentVersionedKeyIdentifier"u8))
                {
                    currentVersionedKeyIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastKeyRotationTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastKeyRotationTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentVersionedKeyExpirationTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentVersionedKeyExpirationTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageAccountKeyVaultProperties(
                keyname,
                keyversion,
                keyvaulturi,
                currentVersionedKeyIdentifier,
                lastKeyRotationTimestamp,
                currentVersionedKeyExpirationTimestamp,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageAccountKeyVaultProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageAccountKeyVaultProperties)} does not support '{options.Format}' format.");
            }
        }

        StorageAccountKeyVaultProperties IPersistableModel<StorageAccountKeyVaultProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountKeyVaultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageAccountKeyVaultProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageAccountKeyVaultProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageAccountKeyVaultProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
