// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkStatementOutput : IUtf8JsonSerializable, IJsonModel<SparkStatementOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SparkStatementOutput>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<SparkStatementOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SparkStatementOutput>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SparkStatementOutput>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            writer.WritePropertyName("execution_count"u8);
            writer.WriteNumberValue(ExecutionCount);
            if (Optional.IsDefined(Data))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteObjectValue(Data);
            }
            if (Optional.IsDefined(ErrorName))
            {
                if (ErrorName != null)
                {
                    writer.WritePropertyName("ename"u8);
                    writer.WriteStringValue(ErrorName);
                }
                else
                {
                    writer.WriteNull("ename");
                }
            }
            if (Optional.IsDefined(ErrorValue))
            {
                if (ErrorValue != null)
                {
                    writer.WritePropertyName("evalue"u8);
                    writer.WriteStringValue(ErrorValue);
                }
                else
                {
                    writer.WriteNull("evalue");
                }
            }
            if (Optional.IsCollectionDefined(Traceback))
            {
                if (Traceback != null)
                {
                    writer.WritePropertyName("traceback"u8);
                    writer.WriteStartArray();
                    foreach (var item in Traceback)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("traceback");
                }
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

        SparkStatementOutput IJsonModel<SparkStatementOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SparkStatementOutput)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSparkStatementOutput(document.RootElement, options);
        }

        internal static SparkStatementOutput DeserializeSparkStatementOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> status = default;
            int executionCount = default;
            Optional<object> data = default;
            Optional<string> ename = default;
            Optional<string> evalue = default;
            Optional<IReadOnlyList<string>> traceback = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("execution_count"u8))
                {
                    executionCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    data = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("ename"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        ename = null;
                        continue;
                    }
                    ename = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("evalue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        evalue = null;
                        continue;
                    }
                    evalue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("traceback"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    traceback = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SparkStatementOutput(status.Value, executionCount, data.Value, ename.Value, evalue.Value, Optional.ToList(traceback), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SparkStatementOutput>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SparkStatementOutput)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SparkStatementOutput IPersistableModel<SparkStatementOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SparkStatementOutput)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSparkStatementOutput(document.RootElement, options);
        }

        string IPersistableModel<SparkStatementOutput>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
