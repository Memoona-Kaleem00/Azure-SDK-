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

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverResourceDependency : IUtf8JsonSerializable, IJsonModel<MoverResourceDependency>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MoverResourceDependency>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MoverResourceDependency>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverResourceDependency>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverResourceDependency)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(ResolutionStatus))
            {
                writer.WritePropertyName("resolutionStatus"u8);
                writer.WriteStringValue(ResolutionStatus);
            }
            if (Optional.IsDefined(ResolutionType))
            {
                writer.WritePropertyName("resolutionType"u8);
                writer.WriteStringValue(ResolutionType.Value.ToString());
            }
            if (Optional.IsDefined(DependencyType))
            {
                writer.WritePropertyName("dependencyType"u8);
                writer.WriteStringValue(DependencyType.Value.ToString());
            }
            if (Optional.IsDefined(ManualResolution))
            {
                writer.WritePropertyName("manualResolution"u8);
                writer.WriteObjectValue(ManualResolution);
            }
            if (Optional.IsDefined(AutomaticResolution))
            {
                writer.WritePropertyName("automaticResolution"u8);
                writer.WriteObjectValue(AutomaticResolution);
            }
            if (Optional.IsDefined(IsOptional))
            {
                writer.WritePropertyName("isOptional"u8);
                writer.WriteBooleanValue(IsOptional.Value);
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

        MoverResourceDependency IJsonModel<MoverResourceDependency>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverResourceDependency>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverResourceDependency)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMoverResourceDependency(document.RootElement, options);
        }

        internal static MoverResourceDependency DeserializeMoverResourceDependency(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<string> resolutionStatus = default;
            Optional<MoverResourceResolutionType> resolutionType = default;
            Optional<MoverDependencyType> dependencyType = default;
            Optional<ManualResolutionProperties> manualResolution = default;
            Optional<AutomaticResolutionProperties> automaticResolution = default;
            Optional<bool> isOptional = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resolutionStatus"u8))
                {
                    resolutionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resolutionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resolutionType = new MoverResourceResolutionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dependencyType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dependencyType = new MoverDependencyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("manualResolution"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    manualResolution = ManualResolutionProperties.DeserializeManualResolutionProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("automaticResolution"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    automaticResolution = AutomaticResolutionProperties.DeserializeAutomaticResolutionProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("isOptional"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOptional = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MoverResourceDependency(id.Value, resolutionStatus.Value, Optional.ToNullable(resolutionType), Optional.ToNullable(dependencyType), manualResolution.Value, automaticResolution.Value, Optional.ToNullable(isOptional), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(ResolutionStatus))
            {
                builder.Append("  resolutionStatus:");
                if (ResolutionStatus.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ResolutionStatus}'''");
                }
                else
                {
                    builder.AppendLine($" '{ResolutionStatus}'");
                }
            }

            if (Optional.IsDefined(ResolutionType))
            {
                builder.Append("  resolutionType:");
                builder.AppendLine($" '{ResolutionType.Value.ToString()}'");
            }

            if (Optional.IsDefined(DependencyType))
            {
                builder.Append("  dependencyType:");
                builder.AppendLine($" '{DependencyType.Value.ToString()}'");
            }

            if (Optional.IsDefined(ManualResolution))
            {
                builder.Append("  manualResolution:");
                AppendChildObject(builder, ManualResolution, options, 2, false);
            }

            if (Optional.IsDefined(AutomaticResolution))
            {
                builder.Append("  automaticResolution:");
                AppendChildObject(builder, AutomaticResolution, options, 2, false);
            }

            if (Optional.IsDefined(IsOptional))
            {
                builder.Append("  isOptional:");
                var boolValue = IsOptional.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
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

        BinaryData IPersistableModel<MoverResourceDependency>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverResourceDependency>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MoverResourceDependency)} does not support '{options.Format}' format.");
            }
        }

        MoverResourceDependency IPersistableModel<MoverResourceDependency>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverResourceDependency>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMoverResourceDependency(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(MoverResourceDependency)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MoverResourceDependency>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
