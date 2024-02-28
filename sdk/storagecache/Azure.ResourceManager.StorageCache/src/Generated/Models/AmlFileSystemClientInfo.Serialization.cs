// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class AmlFileSystemClientInfo : IUtf8JsonSerializable, IJsonModel<AmlFileSystemClientInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AmlFileSystemClientInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AmlFileSystemClientInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemClientInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AmlFileSystemClientInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && MgsAddress != null)
            {
                writer.WritePropertyName("mgsAddress"u8);
                writer.WriteStringValue(MgsAddress);
            }
            if (options.Format != "W" && MountCommand != null)
            {
                writer.WritePropertyName("mountCommand"u8);
                writer.WriteStringValue(MountCommand);
            }
            if (options.Format != "W" && LustreVersion != null)
            {
                writer.WritePropertyName("lustreVersion"u8);
                writer.WriteStringValue(LustreVersion);
            }
            if (options.Format != "W" && ContainerStorageInterface != null)
            {
                writer.WritePropertyName("containerStorageInterface"u8);
                writer.WriteObjectValue(ContainerStorageInterface);
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

        AmlFileSystemClientInfo IJsonModel<AmlFileSystemClientInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemClientInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AmlFileSystemClientInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAmlFileSystemClientInfo(document.RootElement, options);
        }

        internal static AmlFileSystemClientInfo DeserializeAmlFileSystemClientInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string mgsAddress = default;
            string mountCommand = default;
            string lustreVersion = default;
            AmlFileSystemContainerStorageInterface containerStorageInterface = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mgsAddress"u8))
                {
                    mgsAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mountCommand"u8))
                {
                    mountCommand = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lustreVersion"u8))
                {
                    lustreVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerStorageInterface"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerStorageInterface = AmlFileSystemContainerStorageInterface.DeserializeAmlFileSystemContainerStorageInterface(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AmlFileSystemClientInfo(mgsAddress, mountCommand, lustreVersion, containerStorageInterface, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AmlFileSystemClientInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemClientInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AmlFileSystemClientInfo)} does not support '{options.Format}' format.");
            }
        }

        AmlFileSystemClientInfo IPersistableModel<AmlFileSystemClientInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlFileSystemClientInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAmlFileSystemClientInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AmlFileSystemClientInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AmlFileSystemClientInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
