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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryJobErrorDetails : IUtf8JsonSerializable, IJsonModel<SiteRecoveryJobErrorDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryJobErrorDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryJobErrorDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryJobErrorDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryJobErrorDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceErrorDetails))
            {
                writer.WritePropertyName("serviceErrorDetails"u8);
                writer.WriteObjectValue(ServiceErrorDetails);
            }
            if (Optional.IsDefined(ProviderErrorDetails))
            {
                writer.WritePropertyName("providerErrorDetails"u8);
                writer.WriteObjectValue(ProviderErrorDetails);
            }
            if (Optional.IsDefined(ErrorLevel))
            {
                writer.WritePropertyName("errorLevel"u8);
                writer.WriteStringValue(ErrorLevel);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(TaskId))
            {
                writer.WritePropertyName("taskId"u8);
                writer.WriteStringValue(TaskId);
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

        SiteRecoveryJobErrorDetails IJsonModel<SiteRecoveryJobErrorDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryJobErrorDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryJobErrorDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryJobErrorDetails(document.RootElement, options);
        }

        internal static SiteRecoveryJobErrorDetails DeserializeSiteRecoveryJobErrorDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SiteRecoveryServiceError> serviceErrorDetails = default;
            Optional<SiteRecoveryJobProviderError> providerErrorDetails = default;
            Optional<string> errorLevel = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<string> taskId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceErrorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceErrorDetails = SiteRecoveryServiceError.DeserializeSiteRecoveryServiceError(property.Value);
                    continue;
                }
                if (property.NameEquals("providerErrorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerErrorDetails = SiteRecoveryJobProviderError.DeserializeSiteRecoveryJobProviderError(property.Value);
                    continue;
                }
                if (property.NameEquals("errorLevel"u8))
                {
                    errorLevel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("taskId"u8))
                {
                    taskId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryJobErrorDetails(serviceErrorDetails.Value, providerErrorDetails.Value, errorLevel.Value, Optional.ToNullable(creationTime), taskId.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ServiceErrorDetails))
            {
                builder.Append("  serviceErrorDetails:");
                AppendChildObject(builder, ServiceErrorDetails, options, 2, false);
            }

            if (Optional.IsDefined(ProviderErrorDetails))
            {
                builder.Append("  providerErrorDetails:");
                AppendChildObject(builder, ProviderErrorDetails, options, 2, false);
            }

            if (Optional.IsDefined(ErrorLevel))
            {
                builder.Append("  errorLevel:");
                if (ErrorLevel.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ErrorLevel}'''");
                }
                else
                {
                    builder.AppendLine($" '{ErrorLevel}'");
                }
            }

            if (Optional.IsDefined(CreatedOn))
            {
                builder.Append("  creationTime:");
                var formattedDateTimeString = TypeFormatters.ToString(CreatedOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(TaskId))
            {
                builder.Append("  taskId:");
                if (TaskId.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{TaskId}'''");
                }
                else
                {
                    builder.AppendLine($" '{TaskId}'");
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

        BinaryData IPersistableModel<SiteRecoveryJobErrorDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryJobErrorDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryJobErrorDetails)} does not support '{options.Format}' format.");
            }
        }

        SiteRecoveryJobErrorDetails IPersistableModel<SiteRecoveryJobErrorDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryJobErrorDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryJobErrorDetails(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryJobErrorDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryJobErrorDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
