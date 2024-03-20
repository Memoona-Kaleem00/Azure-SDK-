// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceIPSecurityRestriction : IUtf8JsonSerializable, IJsonModel<AppServiceIPSecurityRestriction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceIPSecurityRestriction>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppServiceIPSecurityRestriction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceIPSecurityRestriction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceIPSecurityRestriction)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IPAddressOrCidr))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddressOrCidr);
            }
            if (Optional.IsDefined(SubnetMask))
            {
                writer.WritePropertyName("subnetMask"u8);
                writer.WriteStringValue(SubnetMask);
            }
            if (Optional.IsDefined(VnetSubnetResourceId))
            {
                writer.WritePropertyName("vnetSubnetResourceId"u8);
                writer.WriteStringValue(VnetSubnetResourceId);
            }
            if (Optional.IsDefined(VnetTrafficTag))
            {
                writer.WritePropertyName("vnetTrafficTag"u8);
                writer.WriteNumberValue(VnetTrafficTag.Value);
            }
            if (Optional.IsDefined(SubnetTrafficTag))
            {
                writer.WritePropertyName("subnetTrafficTag"u8);
                writer.WriteNumberValue(SubnetTrafficTag.Value);
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action);
            }
            if (Optional.IsDefined(Tag))
            {
                writer.WritePropertyName("tag"u8);
                writer.WriteStringValue(Tag.Value.ToString());
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Headers))
            {
                writer.WritePropertyName("headers"u8);
                writer.WriteStartObject();
                foreach (var item in Headers)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item.Value)
                    {
                        writer.WriteStringValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndObject();
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

        AppServiceIPSecurityRestriction IJsonModel<AppServiceIPSecurityRestriction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceIPSecurityRestriction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceIPSecurityRestriction)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceIPSecurityRestriction(document.RootElement, options);
        }

        internal static AppServiceIPSecurityRestriction DeserializeAppServiceIPSecurityRestriction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ipAddress = default;
            string subnetMask = default;
            ResourceIdentifier vnetSubnetResourceId = default;
            int? vnetTrafficTag = default;
            int? subnetTrafficTag = default;
            string action = default;
            AppServiceIPFilterTag? tag = default;
            int? priority = default;
            string name = default;
            string description = default;
            IDictionary<string, IList<string>> headers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddress"u8))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnetMask"u8))
                {
                    subnetMask = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vnetSubnetResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vnetSubnetResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vnetTrafficTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vnetTrafficTag = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("subnetTrafficTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnetTrafficTag = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    action = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tag = new AppServiceIPFilterTag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("headers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            dictionary.Add(property0.Name, array);
                        }
                    }
                    headers = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppServiceIPSecurityRestriction(
                ipAddress,
                subnetMask,
                vnetSubnetResourceId,
                vnetTrafficTag,
                subnetTrafficTag,
                action,
                tag,
                priority,
                name,
                description,
                headers ?? new ChangeTrackingDictionary<string, IList<string>>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppServiceIPSecurityRestriction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceIPSecurityRestriction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceIPSecurityRestriction)} does not support '{options.Format}' format.");
            }
        }

        AppServiceIPSecurityRestriction IPersistableModel<AppServiceIPSecurityRestriction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceIPSecurityRestriction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServiceIPSecurityRestriction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppServiceIPSecurityRestriction)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceIPSecurityRestriction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
