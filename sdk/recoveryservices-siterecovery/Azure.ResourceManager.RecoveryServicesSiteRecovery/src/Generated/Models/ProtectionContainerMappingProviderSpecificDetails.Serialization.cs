// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [PersistableModelProxy(typeof(UnknownProtectionContainerMappingProviderSpecificDetails))]
    public partial class ProtectionContainerMappingProviderSpecificDetails : IUtf8JsonSerializable, IJsonModel<ProtectionContainerMappingProviderSpecificDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProtectionContainerMappingProviderSpecificDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProtectionContainerMappingProviderSpecificDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectionContainerMappingProviderSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProtectionContainerMappingProviderSpecificDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        ProtectionContainerMappingProviderSpecificDetails IJsonModel<ProtectionContainerMappingProviderSpecificDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectionContainerMappingProviderSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProtectionContainerMappingProviderSpecificDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProtectionContainerMappingProviderSpecificDetails(document.RootElement, options);
        }

        internal static ProtectionContainerMappingProviderSpecificDetails DeserializeProtectionContainerMappingProviderSpecificDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "A2A": return A2AProtectionContainerMappingDetails.DeserializeA2AProtectionContainerMappingDetails(element);
                    case "InMageRcm": return InMageRcmProtectionContainerMappingDetails.DeserializeInMageRcmProtectionContainerMappingDetails(element);
                    case "VMwareCbt": return VMwareCbtProtectionContainerMappingDetails.DeserializeVMwareCbtProtectionContainerMappingDetails(element);
                }
            }
            return UnknownProtectionContainerMappingProviderSpecificDetails.DeserializeUnknownProtectionContainerMappingProviderSpecificDetails(element);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(InstanceType))
            {
                builder.Append("  instanceType:");
                if (InstanceType.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{InstanceType}'''");
                }
                else
                {
                    builder.AppendLine($" '{InstanceType}'");
                }
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

        BinaryData IPersistableModel<ProtectionContainerMappingProviderSpecificDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectionContainerMappingProviderSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ProtectionContainerMappingProviderSpecificDetails)} does not support '{options.Format}' format.");
            }
        }

        ProtectionContainerMappingProviderSpecificDetails IPersistableModel<ProtectionContainerMappingProviderSpecificDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectionContainerMappingProviderSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProtectionContainerMappingProviderSpecificDetails(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ProtectionContainerMappingProviderSpecificDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProtectionContainerMappingProviderSpecificDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
