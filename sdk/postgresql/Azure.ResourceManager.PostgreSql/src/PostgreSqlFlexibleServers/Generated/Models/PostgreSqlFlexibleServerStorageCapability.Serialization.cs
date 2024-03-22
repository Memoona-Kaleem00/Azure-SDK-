// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerStorageCapability : IUtf8JsonSerializable, IJsonModel<PostgreSqlFlexibleServerStorageCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlFlexibleServerStorageCapability>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostgreSqlFlexibleServerStorageCapability>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerStorageCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerStorageCapability)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(SupportedIops))
            {
                writer.WritePropertyName("supportedIops"u8);
                writer.WriteNumberValue(SupportedIops.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(StorageSizeInMB))
            {
                writer.WritePropertyName("storageSizeMb"u8);
                writer.WriteNumberValue(StorageSizeInMB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DefaultIopsTier))
            {
                writer.WritePropertyName("defaultIopsTier"u8);
                writer.WriteStringValue(DefaultIopsTier);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedIopsTiers))
            {
                writer.WritePropertyName("supportedIopsTiers"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedIopsTiers)
                {
                    writer.WriteObjectValue<PostgreSqlFlexibleServerStorageTierCapability>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(CapabilityStatus))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(CapabilityStatus.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
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

        PostgreSqlFlexibleServerStorageCapability IJsonModel<PostgreSqlFlexibleServerStorageCapability>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerStorageCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerStorageCapability)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerStorageCapability(document.RootElement, options);
        }

        internal static PostgreSqlFlexibleServerStorageCapability DeserializePostgreSqlFlexibleServerStorageCapability(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? supportedIops = default;
            long? storageSizeMb = default;
            string defaultIopsTier = default;
            IReadOnlyList<PostgreSqlFlexibleServerStorageTierCapability> supportedIopsTiers = default;
            PostgreSqlFlexbileServerCapabilityStatus? status = default;
            string reason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("supportedIops"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportedIops = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("storageSizeMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageSizeMb = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("defaultIopsTier"u8))
                {
                    defaultIopsTier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedIopsTiers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlFlexibleServerStorageTierCapability> array = new List<PostgreSqlFlexibleServerStorageTierCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerStorageTierCapability.DeserializePostgreSqlFlexibleServerStorageTierCapability(item, options));
                    }
                    supportedIopsTiers = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToPostgreSqlFlexbileServerCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlFlexibleServerStorageCapability(
                status,
                reason,
                serializedAdditionalRawData,
                supportedIops,
                storageSizeMb,
                defaultIopsTier,
                supportedIopsTiers ?? new ChangeTrackingList<PostgreSqlFlexibleServerStorageTierCapability>());
        }

        BinaryData IPersistableModel<PostgreSqlFlexibleServerStorageCapability>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerStorageCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerStorageCapability)} does not support writing '{options.Format}' format.");
            }
        }

        PostgreSqlFlexibleServerStorageCapability IPersistableModel<PostgreSqlFlexibleServerStorageCapability>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerStorageCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlFlexibleServerStorageCapability(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerStorageCapability)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlFlexibleServerStorageCapability>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
