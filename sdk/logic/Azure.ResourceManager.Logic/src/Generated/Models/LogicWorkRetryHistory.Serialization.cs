// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicWorkRetryHistory : IUtf8JsonSerializable, IJsonModel<LogicWorkRetryHistory>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicWorkRetryHistory>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogicWorkRetryHistory>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkRetryHistory>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicWorkRetryHistory)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(Code))
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (Optional.IsDefined(ClientRequestId))
            {
                writer.WritePropertyName("clientRequestId"u8);
                writer.WriteStringValue(ClientRequestId);
            }
            if (Optional.IsDefined(ServiceRequestId))
            {
                writer.WritePropertyName("serviceRequestId"u8);
                writer.WriteStringValue(ServiceRequestId);
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
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

        LogicWorkRetryHistory IJsonModel<LogicWorkRetryHistory>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkRetryHistory>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicWorkRetryHistory)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicWorkRetryHistory(document.RootElement, options);
        }

        internal static LogicWorkRetryHistory DeserializeLogicWorkRetryHistory(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            string code = default;
            string clientRequestId = default;
            string serviceRequestId = default;
            LogicErrorResponse error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientRequestId"u8))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceRequestId"u8))
                {
                    serviceRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = LogicErrorResponse.DeserializeLogicErrorResponse(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogicWorkRetryHistory(
                startTime,
                endTime,
                code,
                clientRequestId,
                serviceRequestId,
                error,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LogicWorkRetryHistory>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkRetryHistory>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogicWorkRetryHistory)} does not support '{options.Format}' format.");
            }
        }

        LogicWorkRetryHistory IPersistableModel<LogicWorkRetryHistory>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWorkRetryHistory>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogicWorkRetryHistory(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogicWorkRetryHistory)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogicWorkRetryHistory>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
