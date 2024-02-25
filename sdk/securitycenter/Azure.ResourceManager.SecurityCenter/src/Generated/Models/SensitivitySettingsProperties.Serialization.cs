// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SensitivitySettingsProperties : IUtf8JsonSerializable, IJsonModel<SensitivitySettingsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SensitivitySettingsProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SensitivitySettingsProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SensitivitySettingsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SensitivitySettingsProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(SensitiveInfoTypesIds is ChangeTrackingList<Guid> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("sensitiveInfoTypesIds"u8);
                writer.WriteStartArray();
                foreach (var item in SensitiveInfoTypesIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (SensitivityThresholdLabelOrder.HasValue)
            {
                writer.WritePropertyName("sensitivityThresholdLabelOrder"u8);
                writer.WriteNumberValue(SensitivityThresholdLabelOrder.Value);
            }
            if (SensitivityThresholdLabelId.HasValue)
            {
                writer.WritePropertyName("sensitivityThresholdLabelId"u8);
                writer.WriteStringValue(SensitivityThresholdLabelId.Value);
            }
            if (MipInformation != null)
            {
                writer.WritePropertyName("mipInformation"u8);
                writer.WriteObjectValue(MipInformation);
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

        SensitivitySettingsProperties IJsonModel<SensitivitySettingsProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SensitivitySettingsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SensitivitySettingsProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSensitivitySettingsProperties(document.RootElement, options);
        }

        internal static SensitivitySettingsProperties DeserializeSensitivitySettingsProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<Guid> sensitiveInfoTypesIds = default;
            Optional<float> sensitivityThresholdLabelOrder = default;
            Optional<Guid> sensitivityThresholdLabelId = default;
            Optional<GetSensitivitySettingsResponsePropertiesMipInformation> mipInformation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sensitiveInfoTypesIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Guid> array = new List<Guid>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetGuid());
                    }
                    sensitiveInfoTypesIds = array;
                    continue;
                }
                if (property.NameEquals("sensitivityThresholdLabelOrder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sensitivityThresholdLabelOrder = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("sensitivityThresholdLabelId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sensitivityThresholdLabelId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("mipInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mipInformation = GetSensitivitySettingsResponsePropertiesMipInformation.DeserializeGetSensitivitySettingsResponsePropertiesMipInformation(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SensitivitySettingsProperties(sensitiveInfoTypesIds ?? new ChangeTrackingList<Guid>(), Optional.ToNullable(sensitivityThresholdLabelOrder), Optional.ToNullable(sensitivityThresholdLabelId), mipInformation.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SensitivitySettingsProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SensitivitySettingsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SensitivitySettingsProperties)} does not support '{options.Format}' format.");
            }
        }

        SensitivitySettingsProperties IPersistableModel<SensitivitySettingsProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SensitivitySettingsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSensitivitySettingsProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SensitivitySettingsProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SensitivitySettingsProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
