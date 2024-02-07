// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
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
                throw new FormatException($"The model {nameof(RecoveryServicesSecuritySettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ImmutabilitySettings))
            {
                writer.WritePropertyName("immutabilitySettings"u8);
                writer.WriteObjectValue(ImmutabilitySettings);
            }
            if (Optional.IsDefined(SoftDeleteSettings))
            {
                writer.WritePropertyName("softDeleteSettings"u8);
                writer.WriteObjectValue(SoftDeleteSettings);
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
                throw new FormatException($"The model {nameof(RecoveryServicesSecuritySettings)} does not support '{format}' format.");
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
            Optional<ImmutabilitySettings> immutabilitySettings = default;
            Optional<RecoveryServicesSoftDeleteSettings> softDeleteSettings = default;
            Optional<MultiUserAuthorization> multiUserAuthorization = default;
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
                    immutabilitySettings = ImmutabilitySettings.DeserializeImmutabilitySettings(property.Value);
                    continue;
                }
                if (property.NameEquals("softDeleteSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softDeleteSettings = RecoveryServicesSoftDeleteSettings.DeserializeRecoveryServicesSoftDeleteSettings(property.Value);
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
            return new RecoveryServicesSecuritySettings(immutabilitySettings.Value, softDeleteSettings.Value, Optional.ToNullable(multiUserAuthorization), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ImmutabilitySettings))
            {
                builder.Append("  immutabilitySettings:");
                AppendChildObject(builder, ImmutabilitySettings, options, 2, false);
            }

            if (Optional.IsDefined(SoftDeleteSettings))
            {
                builder.Append("  softDeleteSettings:");
                AppendChildObject(builder, SoftDeleteSettings, options, 2, false);
            }

            if (Optional.IsDefined(MultiUserAuthorization))
            {
                builder.Append("  multiUserAuthorization:");
                builder.AppendLine($" '{MultiUserAuthorization.Value.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            bool inMultilineString = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (inMultilineString)
                {
                    if (line.Contains("'''"))
                    {
                        inMultilineString = false;
                    }
                    stringBuilder.AppendLine(line);
                    continue;
                }
                if (line.Contains("'''"))
                {
                    inMultilineString = true;
                    stringBuilder.AppendLine($"{indent}{line}");
                    continue;
                }
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<RecoveryServicesSecuritySettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServicesSecuritySettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryServicesSecuritySettings)} does not support '{options.Format}' format.");
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
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(RecoveryServicesSecuritySettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryServicesSecuritySettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
