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
    public partial class SecurityAssessmentStatusResult : IUtf8JsonSerializable, IJsonModel<SecurityAssessmentStatusResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityAssessmentStatusResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityAssessmentStatusResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentStatusResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAssessmentStatusResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(FirstEvaluatedOn))
            {
                writer.WritePropertyName("firstEvaluationDate"u8);
                writer.WriteStringValue(FirstEvaluatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(StatusChangeOn))
            {
                writer.WritePropertyName("statusChangeDate"u8);
                writer.WriteStringValue(StatusChangeOn.Value, "O");
            }
            writer.WritePropertyName("code"u8);
            writer.WriteStringValue(Code.ToString());
            if (Optional.IsDefined(Cause))
            {
                writer.WritePropertyName("cause"u8);
                writer.WriteStringValue(Cause);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        SecurityAssessmentStatusResult IJsonModel<SecurityAssessmentStatusResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentStatusResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAssessmentStatusResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityAssessmentStatusResult(document.RootElement, options);
        }

        internal static SecurityAssessmentStatusResult DeserializeSecurityAssessmentStatusResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? firstEvaluationDate = default;
            DateTimeOffset? statusChangeDate = default;
            SecurityAssessmentStatusCode code = default;
            string cause = default;
            string description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firstEvaluationDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstEvaluationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("statusChangeDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusChangeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("code"u8))
                {
                    code = new SecurityAssessmentStatusCode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cause"u8))
                {
                    cause = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityAssessmentStatusResult(
                code,
                cause,
                description,
                serializedAdditionalRawData,
                firstEvaluationDate,
                statusChangeDate);
        }

        BinaryData IPersistableModel<SecurityAssessmentStatusResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentStatusResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityAssessmentStatusResult)} does not support '{options.Format}' format.");
            }
        }

        SecurityAssessmentStatusResult IPersistableModel<SecurityAssessmentStatusResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentStatusResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityAssessmentStatusResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityAssessmentStatusResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityAssessmentStatusResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
