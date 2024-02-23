// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class RunbookTestJob : IUtf8JsonSerializable, IJsonModel<RunbookTestJob>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RunbookTestJob>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RunbookTestJob>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunbookTestJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunbookTestJob)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (CreatedOn.HasValue)
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Status != null)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (StatusDetails != null)
            {
                writer.WritePropertyName("statusDetails"u8);
                writer.WriteStringValue(StatusDetails);
            }
            if (RunOn != null)
            {
                writer.WritePropertyName("runOn"u8);
                writer.WriteStringValue(RunOn);
            }
            if (StartOn.HasValue)
            {
                if (StartOn != null)
                {
                    writer.WritePropertyName("startTime"u8);
                    writer.WriteStringValue(StartOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("startTime");
                }
            }
            if (EndOn.HasValue)
            {
                if (EndOn != null)
                {
                    writer.WritePropertyName("endTime"u8);
                    writer.WriteStringValue(EndOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("endTime");
                }
            }
            if (Exception != null)
            {
                writer.WritePropertyName("exception"u8);
                writer.WriteStringValue(Exception);
            }
            if (LastModifiedOn.HasValue)
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (LastStatusModifiedOn.HasValue)
            {
                if (LastStatusModifiedOn != null)
                {
                    writer.WritePropertyName("lastStatusModifiedTime"u8);
                    writer.WriteStringValue(LastStatusModifiedOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("lastStatusModifiedTime");
                }
            }
            if (!(Parameters is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (LogActivityTrace.HasValue)
            {
                writer.WritePropertyName("logActivityTrace"u8);
                writer.WriteNumberValue(LogActivityTrace.Value);
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

        RunbookTestJob IJsonModel<RunbookTestJob>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunbookTestJob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RunbookTestJob)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunbookTestJob(document.RootElement, options);
        }

        internal static RunbookTestJob DeserializeRunbookTestJob(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> creationTime = default;
            Optional<string> status = default;
            Optional<string> statusDetails = default;
            Optional<string> runOn = default;
            Optional<DateTimeOffset?> startTime = default;
            Optional<DateTimeOffset?> endTime = default;
            Optional<string> exception = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<DateTimeOffset?> lastStatusModifiedTime = default;
            Optional<IReadOnlyDictionary<string, string>> parameters = default;
            Optional<int> logActivityTrace = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusDetails"u8))
                {
                    statusDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runOn"u8))
                {
                    runOn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startTime = null;
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endTime = null;
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("exception"u8))
                {
                    exception = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastStatusModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        lastStatusModifiedTime = null;
                        continue;
                    }
                    lastStatusModifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("logActivityTrace"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logActivityTrace = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RunbookTestJob(Optional.ToNullable(creationTime), status.Value, statusDetails.Value, runOn.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), exception.Value, Optional.ToNullable(lastModifiedTime), Optional.ToNullable(lastStatusModifiedTime), Optional.ToDictionary(parameters), Optional.ToNullable(logActivityTrace), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RunbookTestJob>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunbookTestJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RunbookTestJob)} does not support '{options.Format}' format.");
            }
        }

        RunbookTestJob IPersistableModel<RunbookTestJob>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunbookTestJob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRunbookTestJob(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RunbookTestJob)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RunbookTestJob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
