// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(RunNotebookSnapshotResultConverter))]
    public partial class RunNotebookSnapshotResult : IUtf8JsonSerializable, IJsonModel<RunNotebookSnapshotResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RunNotebookSnapshotResult>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<RunNotebookSnapshotResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<RunNotebookSnapshotResult>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<RunNotebookSnapshotResult>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("snapshot"u8);
            writer.WriteObjectValue(Snapshot);
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
            }
            writer.WritePropertyName("runId"u8);
            writer.WriteStringValue(RunId);
            writer.WritePropertyName("runStatus"u8);
            writer.WriteStringValue(RunStatus);
            if (Optional.IsDefined(LastCheckedOn))
            {
                writer.WritePropertyName("lastCheckedOn"u8);
                writer.WriteStringValue(LastCheckedOn);
            }
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId);
            }
            if (Optional.IsDefined(SparkPool))
            {
                writer.WritePropertyName("sparkPool"u8);
                writer.WriteStringValue(SparkPool);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        RunNotebookSnapshotResult IJsonModel<RunNotebookSnapshotResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RunNotebookSnapshotResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunNotebookSnapshotResult(document.RootElement, options);
        }

        internal static RunNotebookSnapshotResult DeserializeRunNotebookSnapshotResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RunNotebookSnapshot snapshot = default;
            Optional<RunNotebookError> error = default;
            string runId = default;
            string runStatus = default;
            Optional<string> lastCheckedOn = default;
            Optional<string> sessionId = default;
            Optional<string> sparkPool = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("snapshot"u8))
                {
                    snapshot = RunNotebookSnapshot.DeserializeRunNotebookSnapshot(property.Value);
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = RunNotebookError.DeserializeRunNotebookError(property.Value);
                    continue;
                }
                if (property.NameEquals("runId"u8))
                {
                    runId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runStatus"u8))
                {
                    runStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastCheckedOn"u8))
                {
                    lastCheckedOn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sessionId"u8))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sparkPool"u8))
                {
                    sparkPool = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RunNotebookSnapshotResult(snapshot, error.Value, runId, runStatus, lastCheckedOn.Value, sessionId.Value, sparkPool.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RunNotebookSnapshotResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RunNotebookSnapshotResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RunNotebookSnapshotResult IPersistableModel<RunNotebookSnapshotResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RunNotebookSnapshotResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRunNotebookSnapshotResult(document.RootElement, options);
        }

        string IPersistableModel<RunNotebookSnapshotResult>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        internal partial class RunNotebookSnapshotResultConverter : JsonConverter<RunNotebookSnapshotResult>
        {
            public override void Write(Utf8JsonWriter writer, RunNotebookSnapshotResult model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override RunNotebookSnapshotResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRunNotebookSnapshotResult(document.RootElement);
            }
        }
    }
}
