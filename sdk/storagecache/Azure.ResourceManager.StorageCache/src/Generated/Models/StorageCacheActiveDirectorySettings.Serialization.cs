// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class StorageCacheActiveDirectorySettings : IUtf8JsonSerializable, IJsonModel<StorageCacheActiveDirectorySettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageCacheActiveDirectorySettings>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<StorageCacheActiveDirectorySettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<StorageCacheActiveDirectorySettings>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<StorageCacheActiveDirectorySettings>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("primaryDnsIpAddress"u8);
            writer.WriteStringValue(PrimaryDnsIPAddress.ToString());
            if (Optional.IsDefined(SecondaryDnsIPAddress))
            {
                writer.WritePropertyName("secondaryDnsIpAddress"u8);
                writer.WriteStringValue(SecondaryDnsIPAddress.ToString());
            }
            writer.WritePropertyName("domainName"u8);
            writer.WriteStringValue(DomainName);
            writer.WritePropertyName("domainNetBiosName"u8);
            writer.WriteStringValue(DomainNetBiosName);
            writer.WritePropertyName("cacheNetBiosName"u8);
            writer.WriteStringValue(CacheNetBiosName);
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DomainJoined))
                {
                    writer.WritePropertyName("domainJoined"u8);
                    writer.WriteStringValue(DomainJoined.Value.ToString());
                }
            }
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteObjectValue(Credentials);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        StorageCacheActiveDirectorySettings IJsonModel<StorageCacheActiveDirectorySettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageCacheActiveDirectorySettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageCacheActiveDirectorySettings(document.RootElement, options);
        }

        internal static StorageCacheActiveDirectorySettings DeserializeStorageCacheActiveDirectorySettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IPAddress primaryDnsIPAddress = default;
            Optional<IPAddress> secondaryDnsIPAddress = default;
            string domainName = default;
            string domainNetBiosName = default;
            string cacheNetBiosName = default;
            Optional<DomainJoinedType> domainJoined = default;
            Optional<StorageCacheActiveDirectorySettingsCredentials> credentials = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryDnsIpAddress"u8))
                {
                    primaryDnsIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("secondaryDnsIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secondaryDnsIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainNetBiosName"u8))
                {
                    domainNetBiosName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cacheNetBiosName"u8))
                {
                    cacheNetBiosName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainJoined"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    domainJoined = new DomainJoinedType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("credentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credentials = StorageCacheActiveDirectorySettingsCredentials.DeserializeStorageCacheActiveDirectorySettingsCredentials(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageCacheActiveDirectorySettings(primaryDnsIPAddress, secondaryDnsIPAddress.Value, domainName, domainNetBiosName, cacheNetBiosName, Optional.ToNullable(domainJoined), credentials.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageCacheActiveDirectorySettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageCacheActiveDirectorySettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        StorageCacheActiveDirectorySettings IPersistableModel<StorageCacheActiveDirectorySettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageCacheActiveDirectorySettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeStorageCacheActiveDirectorySettings(document.RootElement, options);
        }

        string IPersistableModel<StorageCacheActiveDirectorySettings>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
