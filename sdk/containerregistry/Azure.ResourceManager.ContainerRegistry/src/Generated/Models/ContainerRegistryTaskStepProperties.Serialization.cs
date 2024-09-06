// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    [PersistableModelProxy(typeof(UnknownTaskStepProperties))]
    public partial class ContainerRegistryTaskStepProperties : IUtf8JsonSerializable, IJsonModel<ContainerRegistryTaskStepProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryTaskStepProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerRegistryTaskStepProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTaskStepProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryTaskStepProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ContainerRegistryTaskStepType.ToString());
            if (options.Format != "W" && Optional.IsCollectionDefined(BaseImageDependencies))
            {
                writer.WritePropertyName("baseImageDependencies"u8);
                writer.WriteStartArray();
                foreach (var item in BaseImageDependencies)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ContextPath))
            {
                writer.WritePropertyName("contextPath"u8);
                writer.WriteStringValue(ContextPath);
            }
            if (Optional.IsDefined(ContextAccessToken))
            {
                writer.WritePropertyName("contextAccessToken"u8);
                writer.WriteStringValue(ContextAccessToken);
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

        ContainerRegistryTaskStepProperties IJsonModel<ContainerRegistryTaskStepProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTaskStepProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryTaskStepProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryTaskStepProperties(document.RootElement, options);
        }

        internal static ContainerRegistryTaskStepProperties DeserializeContainerRegistryTaskStepProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Docker": return ContainerRegistryDockerBuildStep.DeserializeContainerRegistryDockerBuildStep(element, options);
                    case "EncodedTask": return ContainerRegistryEncodedTaskStep.DeserializeContainerRegistryEncodedTaskStep(element, options);
                    case "FileTask": return ContainerRegistryFileTaskStep.DeserializeContainerRegistryFileTaskStep(element, options);
                }
            }
            return UnknownTaskStepProperties.DeserializeUnknownTaskStepProperties(element, options);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ContainerRegistryTaskStepType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  type: ");
                builder.AppendLine($"'{ContainerRegistryTaskStepType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BaseImageDependencies), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  baseImageDependencies: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(BaseImageDependencies))
                {
                    if (BaseImageDependencies.Any())
                    {
                        builder.Append("  baseImageDependencies: ");
                        builder.AppendLine("[");
                        foreach (var item in BaseImageDependencies)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  baseImageDependencies: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ContextPath), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  contextPath: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ContextPath))
                {
                    builder.Append("  contextPath: ");
                    if (ContextPath.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ContextPath}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ContextPath}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ContextAccessToken), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  contextAccessToken: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ContextAccessToken))
                {
                    builder.Append("  contextAccessToken: ");
                    if (ContextAccessToken.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ContextAccessToken}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ContextAccessToken}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerRegistryTaskStepProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTaskStepProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryTaskStepProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerRegistryTaskStepProperties IPersistableModel<ContainerRegistryTaskStepProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryTaskStepProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryTaskStepProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryTaskStepProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryTaskStepProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
