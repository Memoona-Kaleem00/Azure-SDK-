// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    [PersistableModelProxy(typeof(UnknownDatabaseMigrationProperties))]
    public partial class DatabaseMigrationProperties : IUtf8JsonSerializable, IJsonModel<DatabaseMigrationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DatabaseMigrationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DatabaseMigrationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseMigrationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatabaseMigrationProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(MigrationStatus))
            {
                writer.WritePropertyName("migrationStatus"u8);
                writer.WriteStringValue(MigrationStatus);
            }
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
            if (Optional.IsDefined(SourceSqlConnection))
            {
                writer.WritePropertyName("sourceSqlConnection"u8);
                writer.WriteObjectValue(SourceSqlConnection);
            }
            if (Optional.IsDefined(SourceDatabaseName))
            {
                writer.WritePropertyName("sourceDatabaseName"u8);
                writer.WriteStringValue(SourceDatabaseName);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceServerName))
            {
                writer.WritePropertyName("sourceServerName"u8);
                writer.WriteStringValue(SourceServerName);
            }
            if (Optional.IsDefined(MigrationService))
            {
                writer.WritePropertyName("migrationService"u8);
                writer.WriteStringValue(MigrationService);
            }
            if (Optional.IsDefined(MigrationOperationId))
            {
                writer.WritePropertyName("migrationOperationId"u8);
                writer.WriteStringValue(MigrationOperationId);
            }
            if (options.Format != "W" && Optional.IsDefined(MigrationFailureError))
            {
                writer.WritePropertyName("migrationFailureError"u8);
                writer.WriteObjectValue(MigrationFailureError);
            }
            if (Optional.IsDefined(TargetDatabaseCollation))
            {
                writer.WritePropertyName("targetDatabaseCollation"u8);
                writer.WriteStringValue(TargetDatabaseCollation);
            }
            if (Optional.IsDefined(ProvisioningError))
            {
                writer.WritePropertyName("provisioningError"u8);
                writer.WriteStringValue(ProvisioningError);
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

        DatabaseMigrationProperties IJsonModel<DatabaseMigrationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseMigrationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatabaseMigrationProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDatabaseMigrationProperties(document.RootElement, options);
        }

        internal static DatabaseMigrationProperties DeserializeDatabaseMigrationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "SqlDb": return DatabaseMigrationSqlDBProperties.DeserializeDatabaseMigrationSqlDBProperties(element, options);
                    case "SqlMi": return DatabaseMigrationSqlMIProperties.DeserializeDatabaseMigrationSqlMIProperties(element, options);
                    case "SqlVm": return DatabaseMigrationSqlVmProperties.DeserializeDatabaseMigrationSqlVmProperties(element, options);
                }
            }
            return UnknownDatabaseMigrationProperties.DeserializeUnknownDatabaseMigrationProperties(element, options);
        }

        BinaryData IPersistableModel<DatabaseMigrationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseMigrationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DatabaseMigrationProperties)} does not support '{options.Format}' format.");
            }
        }

        DatabaseMigrationProperties IPersistableModel<DatabaseMigrationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseMigrationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDatabaseMigrationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DatabaseMigrationProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DatabaseMigrationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
