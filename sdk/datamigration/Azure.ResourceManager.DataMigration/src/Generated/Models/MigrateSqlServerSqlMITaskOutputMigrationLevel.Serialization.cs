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
    public partial class MigrateSqlServerSqlMITaskOutputMigrationLevel : IUtf8JsonSerializable, IJsonModel<MigrateSqlServerSqlMITaskOutputMigrationLevel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateSqlServerSqlMITaskOutputMigrationLevel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateSqlServerSqlMITaskOutputMigrationLevel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMITaskOutputMigrationLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlMITaskOutputMigrationLevel)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(StartedOn))
            {
                writer.WritePropertyName("startedOn"u8);
                writer.WriteStringValue(StartedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(EndedOn))
            {
                writer.WritePropertyName("endedOn"u8);
                writer.WriteStringValue(EndedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AgentJobs))
            {
                writer.WritePropertyName("agentJobs"u8);
                writer.WriteStringValue(AgentJobs);
            }
            if (options.Format != "W" && Optional.IsDefined(Logins))
            {
                writer.WritePropertyName("logins"u8);
                writer.WriteStringValue(Logins);
            }
            if (options.Format != "W" && Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (options.Format != "W" && Optional.IsDefined(ServerRoleResults))
            {
                writer.WritePropertyName("serverRoleResults"u8);
                writer.WriteStringValue(ServerRoleResults);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(OrphanedUsersInfo))
            {
                writer.WritePropertyName("orphanedUsersInfo"u8);
                writer.WriteStartArray();
                foreach (var item in OrphanedUsersInfo)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Databases))
            {
                writer.WritePropertyName("databases"u8);
                writer.WriteStringValue(Databases);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceServerVersion))
            {
                writer.WritePropertyName("sourceServerVersion"u8);
                writer.WriteStringValue(SourceServerVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceServerBrandVersion))
            {
                writer.WritePropertyName("sourceServerBrandVersion"u8);
                writer.WriteStringValue(SourceServerBrandVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetServerVersion))
            {
                writer.WritePropertyName("targetServerVersion"u8);
                writer.WriteStringValue(TargetServerVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetServerBrandVersion))
            {
                writer.WritePropertyName("targetServerBrandVersion"u8);
                writer.WriteStringValue(TargetServerBrandVersion);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ExceptionsAndWarnings))
            {
                writer.WritePropertyName("exceptionsAndWarnings"u8);
                writer.WriteStartArray();
                foreach (var item in ExceptionsAndWarnings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Id))
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

        MigrateSqlServerSqlMITaskOutputMigrationLevel IJsonModel<MigrateSqlServerSqlMITaskOutputMigrationLevel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMITaskOutputMigrationLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlMITaskOutputMigrationLevel)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlMITaskOutputMigrationLevel(document.RootElement, options);
        }

        internal static MigrateSqlServerSqlMITaskOutputMigrationLevel DeserializeMigrateSqlServerSqlMITaskOutputMigrationLevel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? startedOn = default;
            DateTimeOffset? endedOn = default;
            MigrationStatus? status = default;
            MigrationState? state = default;
            string agentJobs = default;
            string logins = default;
            string message = default;
            string serverRoleResults = default;
            IReadOnlyList<OrphanedUserInfo> orphanedUsersInfo = default;
            string databases = default;
            string sourceServerVersion = default;
            string sourceServerBrandVersion = default;
            string targetServerVersion = default;
            string targetServerBrandVersion = default;
            IReadOnlyList<ReportableException> exceptionsAndWarnings = default;
            string id = default;
            string resultType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new MigrationStatus(property.Value.GetString());
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
                if (property.NameEquals("agentJobs"u8))
                {
                    agentJobs = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logins"u8))
                {
                    logins = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverRoleResults"u8))
                {
                    serverRoleResults = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("orphanedUsersInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OrphanedUserInfo> array = new List<OrphanedUserInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OrphanedUserInfo.DeserializeOrphanedUserInfo(item, options));
                    }
                    orphanedUsersInfo = array;
                    continue;
                }
                if (property.NameEquals("databases"u8))
                {
                    databases = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServerVersion"u8))
                {
                    sourceServerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServerBrandVersion"u8))
                {
                    sourceServerBrandVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerVersion"u8))
                {
                    targetServerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerBrandVersion"u8))
                {
                    targetServerBrandVersion = property.Value.GetString();
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
            return new MigrateSqlServerSqlMITaskOutputMigrationLevel(
                id,
                resultType,
                serializedAdditionalRawData,
                startedOn,
                endedOn,
                status,
                state,
                agentJobs,
                logins,
                message,
                serverRoleResults,
                orphanedUsersInfo ?? new ChangeTrackingList<OrphanedUserInfo>(),
                databases,
                sourceServerVersion,
                sourceServerBrandVersion,
                targetServerVersion,
                targetServerBrandVersion,
                exceptionsAndWarnings ?? new ChangeTrackingList<ReportableException>());
        }

        BinaryData IPersistableModel<MigrateSqlServerSqlMITaskOutputMigrationLevel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMITaskOutputMigrationLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlMITaskOutputMigrationLevel)} does not support '{options.Format}' format.");
            }
        }

        MigrateSqlServerSqlMITaskOutputMigrationLevel IPersistableModel<MigrateSqlServerSqlMITaskOutputMigrationLevel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMITaskOutputMigrationLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateSqlServerSqlMITaskOutputMigrationLevel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlMITaskOutputMigrationLevel)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateSqlServerSqlMITaskOutputMigrationLevel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
