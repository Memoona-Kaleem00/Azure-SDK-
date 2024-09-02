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
    public partial class VolumeDefinition : IUtf8JsonSerializable, IJsonModel<VolumeDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VolumeDefinition>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VolumeDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VolumeDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VolumeDefinition)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DefinitionType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(DefinitionType.Value.ToString());
            }
            if (Optional.IsDefined(ReadOnly))
            {
                if (ReadOnly != null)
                {
                    writer.WritePropertyName("readOnly"u8);
                    writer.WriteBooleanValue(ReadOnly.Value);
                }
                else
                {
                    writer.WriteNull("readOnly");
                }
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Optional.IsDefined(Consistency))
            {
                writer.WritePropertyName("consistency"u8);
                writer.WriteStringValue(Consistency);
            }
            if (Optional.IsDefined(Bind))
            {
                writer.WritePropertyName("bind"u8);
                writer.WriteObjectValue(Bind, options);
            }
            if (Optional.IsDefined(Volume))
            {
                writer.WritePropertyName("volume"u8);
                writer.WriteObjectValue(Volume, options);
            }
            if (Optional.IsDefined(Tmpfs))
            {
                writer.WritePropertyName("tmpfs"u8);
                writer.WriteObjectValue(Tmpfs, options);
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

        VolumeDefinition IJsonModel<VolumeDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VolumeDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VolumeDefinition)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVolumeDefinition(document.RootElement, options);
        }

        internal static VolumeDefinition DeserializeVolumeDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VolumeDefinitionType? type = default;
            bool? readOnly = default;
            string source = default;
            string target = default;
            string consistency = default;
            MountBindOptions bind = default;
            VolumeOptions volume = default;
            TmpfsOptions tmpfs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new VolumeDefinitionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("readOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        readOnly = null;
                        continue;
                    }
                    readOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("consistency"u8))
                {
                    consistency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bind = MountBindOptions.DeserializeMountBindOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("volume"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    volume = VolumeOptions.DeserializeVolumeOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tmpfs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tmpfs = TmpfsOptions.DeserializeTmpfsOptions(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VolumeDefinition(
                type,
                readOnly,
                source,
                target,
                consistency,
                bind,
                volume,
                tmpfs,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VolumeDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VolumeDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VolumeDefinition)} does not support writing '{options.Format}' format.");
            }
        }

        VolumeDefinition IPersistableModel<VolumeDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VolumeDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVolumeDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VolumeDefinition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VolumeDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
