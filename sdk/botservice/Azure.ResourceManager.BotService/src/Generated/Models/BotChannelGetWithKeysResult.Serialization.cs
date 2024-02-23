// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class BotChannelGetWithKeysResult : IUtf8JsonSerializable, IJsonModel<BotChannelGetWithKeysResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BotChannelGetWithKeysResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BotChannelGetWithKeysResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotChannelGetWithKeysResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BotChannelGetWithKeysResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Resource != null)
            {
                writer.WritePropertyName("resource"u8);
                writer.WriteObjectValue(Resource);
            }
            if (Setting != null)
            {
                writer.WritePropertyName("setting"u8);
                writer.WriteObjectValue(Setting);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (EntityTag != null)
            {
                writer.WritePropertyName("entityTag"u8);
                writer.WriteStringValue(EntityTag);
            }
            if (ChangedTime != null)
            {
                writer.WritePropertyName("changedTime"u8);
                writer.WriteStringValue(ChangedTime);
            }
            if (Properties != null)
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties);
            }
            if (Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Kind.HasValue)
            {
                if (Kind != null)
                {
                    writer.WritePropertyName("kind"u8);
                    writer.WriteStringValue(Kind.Value.ToString());
                }
                else
                {
                    writer.WriteNull("kind");
                }
            }
            if (ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (options.Format != "W" && !(Zones is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
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

        BotChannelGetWithKeysResult IJsonModel<BotChannelGetWithKeysResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotChannelGetWithKeysResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BotChannelGetWithKeysResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBotChannelGetWithKeysResult(document.RootElement, options);
        }

        internal static BotChannelGetWithKeysResult DeserializeBotChannelGetWithKeysResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BotChannelProperties> resource = default;
            Optional<BotChannelSettings> setting = default;
            Optional<string> provisioningState = default;
            Optional<string> entityTag = default;
            Optional<string> changedTime = default;
            Optional<BotChannelProperties> properties = default;
            Optional<BotServiceSku> sku = default;
            Optional<BotServiceKind?> kind = default;
            Optional<ETag> etag = default;
            Optional<IReadOnlyList<string>> zones = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resource = BotChannelProperties.DeserializeBotChannelProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("setting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    setting = BotChannelSettings.DeserializeBotChannelSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entityTag"u8))
                {
                    entityTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("changedTime"u8))
                {
                    changedTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = BotChannelProperties.DeserializeBotChannelProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = BotServiceSku.DeserializeBotServiceSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        kind = null;
                        continue;
                    }
                    kind = new BotServiceKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BotChannelGetWithKeysResult(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, resource.Value, setting.Value, provisioningState.Value, entityTag.Value, changedTime.Value, properties.Value, sku.Value, Optional.ToNullable(kind), Optional.ToNullable(etag), Optional.ToList(zones), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BotChannelGetWithKeysResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotChannelGetWithKeysResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BotChannelGetWithKeysResult)} does not support '{options.Format}' format.");
            }
        }

        BotChannelGetWithKeysResult IPersistableModel<BotChannelGetWithKeysResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotChannelGetWithKeysResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBotChannelGetWithKeysResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BotChannelGetWithKeysResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BotChannelGetWithKeysResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
