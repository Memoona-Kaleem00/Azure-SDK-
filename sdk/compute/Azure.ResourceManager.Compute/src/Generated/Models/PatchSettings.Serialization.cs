// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class PatchSettings : IUtf8JsonSerializable, IJsonModel<PatchSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PatchSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PatchSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatchSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PatchSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PatchMode))
            {
                writer.WritePropertyName("patchMode"u8);
                writer.WriteStringValue(PatchMode.Value.ToString());
            }
            if (Optional.IsDefined(EnableHotpatching))
            {
                writer.WritePropertyName("enableHotpatching"u8);
                writer.WriteBooleanValue(EnableHotpatching.Value);
            }
            if (Optional.IsDefined(AssessmentMode))
            {
                writer.WritePropertyName("assessmentMode"u8);
                writer.WriteStringValue(AssessmentMode.Value.ToString());
            }
            if (Optional.IsDefined(AutomaticByPlatformSettings))
            {
                writer.WritePropertyName("automaticByPlatformSettings"u8);
                writer.WriteObjectValue(AutomaticByPlatformSettings);
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

        PatchSettings IJsonModel<PatchSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatchSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PatchSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePatchSettings(document.RootElement, options);
        }

        internal static PatchSettings DeserializePatchSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WindowsVmGuestPatchMode? patchMode = default;
            bool? enableHotpatching = default;
            WindowsPatchAssessmentMode? assessmentMode = default;
            WindowsVmGuestPatchAutomaticByPlatformSettings automaticByPlatformSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patchMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    patchMode = new WindowsVmGuestPatchMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enableHotpatching"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableHotpatching = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("assessmentMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assessmentMode = new WindowsPatchAssessmentMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("automaticByPlatformSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    automaticByPlatformSettings = WindowsVmGuestPatchAutomaticByPlatformSettings.DeserializeWindowsVmGuestPatchAutomaticByPlatformSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PatchSettings(patchMode, enableHotpatching, assessmentMode, automaticByPlatformSettings, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PatchSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatchSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PatchSettings)} does not support '{options.Format}' format.");
            }
        }

        PatchSettings IPersistableModel<PatchSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatchSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePatchSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PatchSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PatchSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
