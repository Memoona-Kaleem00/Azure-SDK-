// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class ServerEndpointSyncSessionStatus : IUtf8JsonSerializable, IJsonModel<ServerEndpointSyncSessionStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServerEndpointSyncSessionStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServerEndpointSyncSessionStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEndpointSyncSessionStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerEndpointSyncSessionStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(LastSyncResult))
            {
                writer.WritePropertyName("lastSyncResult"u8);
                writer.WriteNumberValue(LastSyncResult.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LastSyncTimestamp))
            {
                writer.WritePropertyName("lastSyncTimestamp"u8);
                writer.WriteStringValue(LastSyncTimestamp.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastSyncSuccessTimestamp))
            {
                writer.WritePropertyName("lastSyncSuccessTimestamp"u8);
                writer.WriteStringValue(LastSyncSuccessTimestamp.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastSyncPerItemErrorCount))
            {
                writer.WritePropertyName("lastSyncPerItemErrorCount"u8);
                writer.WriteNumberValue(LastSyncPerItemErrorCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PersistentFilesNotSyncingCount))
            {
                writer.WritePropertyName("persistentFilesNotSyncingCount"u8);
                writer.WriteNumberValue(PersistentFilesNotSyncingCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TransientFilesNotSyncingCount))
            {
                writer.WritePropertyName("transientFilesNotSyncingCount"u8);
                writer.WriteNumberValue(TransientFilesNotSyncingCount.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(FilesNotSyncingErrors))
            {
                writer.WritePropertyName("filesNotSyncingErrors"u8);
                writer.WriteStartArray();
                foreach (var item in FilesNotSyncingErrors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(LastSyncMode))
            {
                writer.WritePropertyName("lastSyncMode"u8);
                writer.WriteStringValue(LastSyncMode.Value.ToString());
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

        ServerEndpointSyncSessionStatus IJsonModel<ServerEndpointSyncSessionStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEndpointSyncSessionStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerEndpointSyncSessionStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServerEndpointSyncSessionStatus(document.RootElement, options);
        }

        internal static ServerEndpointSyncSessionStatus DeserializeServerEndpointSyncSessionStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? lastSyncResult = default;
            DateTimeOffset? lastSyncTimestamp = default;
            DateTimeOffset? lastSyncSuccessTimestamp = default;
            long? lastSyncPerItemErrorCount = default;
            long? persistentFilesNotSyncingCount = default;
            long? transientFilesNotSyncingCount = default;
            IReadOnlyList<ServerEndpointFilesNotSyncingError> filesNotSyncingErrors = default;
            ServerEndpointSyncMode? lastSyncMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastSyncResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSyncResult = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lastSyncTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSyncTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastSyncSuccessTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSyncSuccessTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastSyncPerItemErrorCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSyncPerItemErrorCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("persistentFilesNotSyncingCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    persistentFilesNotSyncingCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("transientFilesNotSyncingCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transientFilesNotSyncingCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("filesNotSyncingErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServerEndpointFilesNotSyncingError> array = new List<ServerEndpointFilesNotSyncingError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServerEndpointFilesNotSyncingError.DeserializeServerEndpointFilesNotSyncingError(item, options));
                    }
                    filesNotSyncingErrors = array;
                    continue;
                }
                if (property.NameEquals("lastSyncMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSyncMode = new ServerEndpointSyncMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServerEndpointSyncSessionStatus(
                lastSyncResult,
                lastSyncTimestamp,
                lastSyncSuccessTimestamp,
                lastSyncPerItemErrorCount,
                persistentFilesNotSyncingCount,
                transientFilesNotSyncingCount,
                filesNotSyncingErrors ?? new ChangeTrackingList<ServerEndpointFilesNotSyncingError>(),
                lastSyncMode,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServerEndpointSyncSessionStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEndpointSyncSessionStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServerEndpointSyncSessionStatus)} does not support '{options.Format}' format.");
            }
        }

        ServerEndpointSyncSessionStatus IPersistableModel<ServerEndpointSyncSessionStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerEndpointSyncSessionStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServerEndpointSyncSessionStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServerEndpointSyncSessionStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServerEndpointSyncSessionStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
