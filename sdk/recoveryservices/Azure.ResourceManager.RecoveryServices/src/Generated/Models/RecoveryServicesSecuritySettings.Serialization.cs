// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    public partial class RecoveryServicesSecuritySettings : IUtf8JsonSerializable, IJsonModel<RecoveryServicesSecuritySettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryServicesSecuritySettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecoveryServicesSecuritySettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServicesSecuritySettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryServicesSecuritySettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ImmutabilitySettings))
            {
                writer.WritePropertyName("immutabilitySettings"u8);
                writer.WriteObjectValue<ImmutabilitySettings>(ImmutabilitySettings, options);
            }
            if (Optional.IsDefined(SoftDeleteSettings))
            {
                writer.WritePropertyName("softDeleteSettings"u8);
                writer.WriteObjectValue<RecoveryServicesSoftDeleteSettings>(SoftDeleteSettings, options);
            }
            if (options.Format != "W" && Optional.IsDefined(MultiUserAuthorization))
            {
                writer.WritePropertyName("multiUserAuthorization"u8);
                writer.WriteStringValue(MultiUserAuthorization.Value.ToString());
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

        RecoveryServicesSecuritySettings IJsonModel<RecoveryServicesSecuritySettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServicesSecuritySettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryServicesSecuritySettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryServicesSecuritySettings(document.RootElement, options);
        }

        internal static RecoveryServicesSecuritySettings DeserializeRecoveryServicesSecuritySettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ImmutabilitySettings immutabilitySettings = default;
            RecoveryServicesSoftDeleteSettings softDeleteSettings = default;
            MultiUserAuthorization? multiUserAuthorization = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("immutabilitySettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    immutabilitySettings = ImmutabilitySettings.DeserializeImmutabilitySettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("softDeleteSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softDeleteSettings = RecoveryServicesSoftDeleteSettings.DeserializeRecoveryServicesSoftDeleteSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("multiUserAuthorization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    multiUserAuthorization = new MultiUserAuthorization(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RecoveryServicesSecuritySettings(immutabilitySettings, softDeleteSettings, multiUserAuthorization, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecoveryServicesSecuritySettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServicesSecuritySettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryServicesSecuritySettings)} does not support writing '{options.Format}' format.");
            }
        }

        RecoveryServicesSecuritySettings IPersistableModel<RecoveryServicesSecuritySettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServicesSecuritySettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryServicesSecuritySettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryServicesSecuritySettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryServicesSecuritySettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
