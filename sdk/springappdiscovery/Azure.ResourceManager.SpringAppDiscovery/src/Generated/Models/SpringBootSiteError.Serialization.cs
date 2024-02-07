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

namespace Azure.ResourceManager.SpringAppDiscovery.Models
{
    public partial class SpringBootSiteError : IUtf8JsonSerializable, IJsonModel<SpringBootSiteError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SpringBootSiteError>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SpringBootSiteError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootSiteError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpringBootSiteError)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteNumberValue(Id.Value);
            }
            if (Optional.IsDefined(Code))
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (Optional.IsDefined(SummaryMessage))
            {
                writer.WritePropertyName("summaryMessage"u8);
                writer.WriteStringValue(SummaryMessage);
            }
            if (Optional.IsDefined(RunAsAccountId))
            {
                writer.WritePropertyName("runAsAccountId"u8);
                writer.WriteStringValue(RunAsAccountId);
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(PossibleCauses))
            {
                writer.WritePropertyName("possibleCauses"u8);
                writer.WriteStringValue(PossibleCauses);
            }
            if (Optional.IsDefined(RecommendedAction))
            {
                writer.WritePropertyName("recommendedAction"u8);
                writer.WriteStringValue(RecommendedAction);
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity);
            }
            if (Optional.IsDefined(UpdatedTimeStamp))
            {
                writer.WritePropertyName("updatedTimeStamp"u8);
                writer.WriteStringValue(UpdatedTimeStamp.Value, "O");
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

        SpringBootSiteError IJsonModel<SpringBootSiteError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootSiteError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpringBootSiteError)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSpringBootSiteError(document.RootElement, options);
        }

        internal static SpringBootSiteError DeserializeSpringBootSiteError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> id = default;
            Optional<string> code = default;
            Optional<string> summaryMessage = default;
            Optional<string> runAsAccountId = default;
            Optional<string> message = default;
            Optional<string> possibleCauses = default;
            Optional<string> recommendedAction = default;
            Optional<string> severity = default;
            Optional<DateTimeOffset> updatedTimeStamp = default;
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
                    id = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("summaryMessage"u8))
                {
                    summaryMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runAsAccountId"u8))
                {
                    runAsAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("possibleCauses"u8))
                {
                    possibleCauses = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendedAction"u8))
                {
                    recommendedAction = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    severity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("updatedTimeStamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updatedTimeStamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SpringBootSiteError(Optional.ToNullable(id), code.Value, summaryMessage.Value, runAsAccountId.Value, message.Value, possibleCauses.Value, recommendedAction.Value, severity.Value, Optional.ToNullable(updatedTimeStamp), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.Value.ToString()}'");
            }

            if (Optional.IsDefined(Code))
            {
                builder.Append("  code:");
                if (Code.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Code}'''");
                }
                else
                {
                    builder.AppendLine($" '{Code}'");
                }
            }

            if (Optional.IsDefined(SummaryMessage))
            {
                builder.Append("  summaryMessage:");
                if (SummaryMessage.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{SummaryMessage}'''");
                }
                else
                {
                    builder.AppendLine($" '{SummaryMessage}'");
                }
            }

            if (Optional.IsDefined(RunAsAccountId))
            {
                builder.Append("  runAsAccountId:");
                if (RunAsAccountId.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{RunAsAccountId}'''");
                }
                else
                {
                    builder.AppendLine($" '{RunAsAccountId}'");
                }
            }

            if (Optional.IsDefined(Message))
            {
                builder.Append("  message:");
                if (Message.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Message}'''");
                }
                else
                {
                    builder.AppendLine($" '{Message}'");
                }
            }

            if (Optional.IsDefined(PossibleCauses))
            {
                builder.Append("  possibleCauses:");
                if (PossibleCauses.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{PossibleCauses}'''");
                }
                else
                {
                    builder.AppendLine($" '{PossibleCauses}'");
                }
            }

            if (Optional.IsDefined(RecommendedAction))
            {
                builder.Append("  recommendedAction:");
                if (RecommendedAction.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{RecommendedAction}'''");
                }
                else
                {
                    builder.AppendLine($" '{RecommendedAction}'");
                }
            }

            if (Optional.IsDefined(Severity))
            {
                builder.Append("  severity:");
                if (Severity.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Severity}'''");
                }
                else
                {
                    builder.AppendLine($" '{Severity}'");
                }
            }

            if (Optional.IsDefined(UpdatedTimeStamp))
            {
                builder.Append("  updatedTimeStamp:");
                var formattedDateTimeString = TypeFormatters.ToString(UpdatedTimeStamp.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
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

        BinaryData IPersistableModel<SpringBootSiteError>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootSiteError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SpringBootSiteError)} does not support '{options.Format}' format.");
            }
        }

        SpringBootSiteError IPersistableModel<SpringBootSiteError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootSiteError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSpringBootSiteError(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SpringBootSiteError)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SpringBootSiteError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
