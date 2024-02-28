// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSqlServerSqlDBTaskOutputDatabaseLevel : IUtf8JsonSerializable, IJsonModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBTaskOutputDatabaseLevel)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && DatabaseName != null)
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (options.Format != "W" && StartedOn.HasValue)
            {
                writer.WritePropertyName("startedOn"u8);
                writer.WriteStringValue(StartedOn.Value, "O");
            }
            if (options.Format != "W" && EndedOn.HasValue)
            {
                writer.WritePropertyName("endedOn"u8);
                writer.WriteStringValue(EndedOn.Value, "O");
            }
            if (options.Format != "W" && State.HasValue)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (options.Format != "W" && Stage.HasValue)
            {
                writer.WritePropertyName("stage"u8);
                writer.WriteStringValue(Stage.Value.ToString());
            }
            if (options.Format != "W" && StatusMessage != null)
            {
                writer.WritePropertyName("statusMessage"u8);
                writer.WriteStringValue(StatusMessage);
            }
            if (options.Format != "W" && Message != null)
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (options.Format != "W" && NumberOfObjects.HasValue)
            {
                writer.WritePropertyName("numberOfObjects"u8);
                writer.WriteNumberValue(NumberOfObjects.Value);
            }
            if (options.Format != "W" && NumberOfObjectsCompleted.HasValue)
            {
                writer.WritePropertyName("numberOfObjectsCompleted"u8);
                writer.WriteNumberValue(NumberOfObjectsCompleted.Value);
            }
            if (options.Format != "W" && ErrorCount.HasValue)
            {
                writer.WritePropertyName("errorCount"u8);
                writer.WriteNumberValue(ErrorCount.Value);
            }
            if (options.Format != "W" && ErrorPrefix != null)
            {
                writer.WritePropertyName("errorPrefix"u8);
                writer.WriteStringValue(ErrorPrefix);
            }
            if (options.Format != "W" && ResultPrefix != null)
            {
                writer.WritePropertyName("resultPrefix"u8);
                writer.WriteStringValue(ResultPrefix);
            }
            if (options.Format != "W" && !(ExceptionsAndWarnings is ChangeTrackingList<ReportableException> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("exceptionsAndWarnings"u8);
                writer.WriteStartArray();
                foreach (var item in ExceptionsAndWarnings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ObjectSummary != null)
            {
                writer.WritePropertyName("objectSummary"u8);
                writer.WriteStringValue(ObjectSummary);
            }
            if (options.Format != "W" && Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        MigrateSqlServerSqlDBTaskOutputDatabaseLevel IJsonModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBTaskOutputDatabaseLevel)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlDBTaskOutputDatabaseLevel(document.RootElement, options);
        }

        internal static MigrateSqlServerSqlDBTaskOutputDatabaseLevel DeserializeMigrateSqlServerSqlDBTaskOutputDatabaseLevel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string databaseName = default;
            DateTimeOffset? startedOn = default;
            DateTimeOffset? endedOn = default;
            MigrationState? state = default;
            DatabaseMigrationStage? stage = default;
            string statusMessage = default;
            string message = default;
            long? numberOfObjects = default;
            long? numberOfObjectsCompleted = default;
            long? errorCount = default;
            string errorPrefix = default;
            string resultPrefix = default;
            IReadOnlyList<ReportableException> exceptionsAndWarnings = default;
            string objectSummary = default;
            string id = default;
            string resultType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new MigrationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("stage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stage = new DatabaseMigrationStage(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusMessage"u8))
                {
                    statusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfObjects"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfObjects = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("numberOfObjectsCompleted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfObjectsCompleted = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("errorCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("errorPrefix"u8))
                {
                    errorPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultPrefix"u8))
                {
                    resultPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exceptionsAndWarnings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item, options));
                    }
                    exceptionsAndWarnings = array;
                    continue;
                }
                if (property.NameEquals("objectSummary"u8))
                {
                    objectSummary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrateSqlServerSqlDBTaskOutputDatabaseLevel(
                id,
                resultType,
                serializedAdditionalRawData,
                databaseName,
                startedOn,
                endedOn,
                state,
                stage,
                statusMessage,
                message,
                numberOfObjects,
                numberOfObjectsCompleted,
                errorCount,
                errorPrefix,
                resultPrefix,
                exceptionsAndWarnings ?? new ChangeTrackingList<ReportableException>(),
                objectSummary);
        }

        BinaryData IPersistableModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBTaskOutputDatabaseLevel)} does not support '{options.Format}' format.");
            }
        }

        MigrateSqlServerSqlDBTaskOutputDatabaseLevel IPersistableModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateSqlServerSqlDBTaskOutputDatabaseLevel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBTaskOutputDatabaseLevel)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateSqlServerSqlDBTaskOutputDatabaseLevel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
