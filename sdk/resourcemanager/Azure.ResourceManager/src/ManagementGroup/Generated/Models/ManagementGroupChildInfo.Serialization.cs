// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagementGroups.Models
{
    public partial class ManagementGroupChildInfo : IUtf8JsonSerializable, IJsonModel<ManagementGroupChildInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagementGroupChildInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagementGroupChildInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementGroupChildInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementGroupChildInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ChildType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ChildType.Value.ToString());
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsCollectionDefined(Children))
            {
                writer.WritePropertyName("children"u8);
                writer.WriteStartArray();
                foreach (var item in Children)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ManagementGroupChildInfo IJsonModel<ManagementGroupChildInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementGroupChildInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementGroupChildInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementGroupChildInfo(document.RootElement, options);
        }

        internal static ManagementGroupChildInfo DeserializeManagementGroupChildInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagementGroupChildType> type = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> displayName = default;
            Optional<IReadOnlyList<ManagementGroupChildInfo>> children = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ManagementGroupChildType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("children"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagementGroupChildInfo> array = new List<ManagementGroupChildInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeManagementGroupChildInfo(item, options));
                    }
                    children = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagementGroupChildInfo(Optional.ToNullable(type), id.Value, name.Value, displayName.Value, Optional.ToList(children), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagementGroupChildInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementGroupChildInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagementGroupChildInfo)} does not support '{options.Format}' format.");
            }
        }

        ManagementGroupChildInfo IPersistableModel<ManagementGroupChildInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementGroupChildInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagementGroupChildInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagementGroupChildInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagementGroupChildInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
