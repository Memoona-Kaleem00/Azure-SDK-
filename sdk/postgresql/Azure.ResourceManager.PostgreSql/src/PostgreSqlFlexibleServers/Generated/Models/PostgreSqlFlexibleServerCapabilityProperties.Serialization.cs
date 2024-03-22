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
    public partial class PostgreSqlFlexibleServerCapabilityProperties : IUtf8JsonSerializable, IJsonModel<PostgreSqlFlexibleServerCapabilityProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlFlexibleServerCapabilityProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostgreSqlFlexibleServerCapabilityProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerCapabilityProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerCapabilityProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedServerEditions))
            {
                writer.WritePropertyName("supportedServerEditions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedServerEditions)
                {
                    writer.WriteObjectValue<PostgreSqlFlexibleServerEditionCapability>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedServerVersions))
            {
                writer.WritePropertyName("supportedServerVersions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedServerVersions)
                {
                    writer.WriteObjectValue<PostgreSqlFlexibleServerServerVersionCapability>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(SupportFastProvisioning))
            {
                writer.WritePropertyName("fastProvisioningSupported"u8);
                writer.WriteStringValue(SupportFastProvisioning.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedFastProvisioningEditions))
            {
                writer.WritePropertyName("supportedFastProvisioningEditions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedFastProvisioningEditions)
                {
                    writer.WriteObjectValue<PostgreSqlFlexibleServerFastProvisioningEditionCapability>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(GeoBackupSupported))
            {
                writer.WritePropertyName("geoBackupSupported"u8);
                writer.WriteStringValue(GeoBackupSupported.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ZoneRedundantHaSupported))
            {
                writer.WritePropertyName("zoneRedundantHaSupported"u8);
                writer.WriteStringValue(ZoneRedundantHaSupported.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ZoneRedundantHaAndGeoBackupSupported))
            {
                writer.WritePropertyName("zoneRedundantHaAndGeoBackupSupported"u8);
                writer.WriteStringValue(ZoneRedundantHaAndGeoBackupSupported.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(StorageAutoGrowthSupported))
            {
                writer.WritePropertyName("storageAutoGrowthSupported"u8);
                writer.WriteStringValue(StorageAutoGrowthSupported.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(OnlineResizeSupported))
            {
                writer.WritePropertyName("onlineResizeSupported"u8);
                writer.WriteStringValue(OnlineResizeSupported.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Restricted))
            {
                writer.WritePropertyName("restricted"u8);
                writer.WriteStringValue(Restricted.Value.ToString());
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

        PostgreSqlFlexibleServerCapabilityProperties IJsonModel<PostgreSqlFlexibleServerCapabilityProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerCapabilityProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerCapabilityProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerCapabilityProperties(document.RootElement, options);
        }

        internal static PostgreSqlFlexibleServerCapabilityProperties DeserializePostgreSqlFlexibleServerCapabilityProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IReadOnlyList<PostgreSqlFlexibleServerEditionCapability> supportedServerEditions = default;
            IReadOnlyList<PostgreSqlFlexibleServerServerVersionCapability> supportedServerVersions = default;
            PostgreSqlFlexibleServerFastProvisioningSupported? fastProvisioningSupported = default;
            IReadOnlyList<PostgreSqlFlexibleServerFastProvisioningEditionCapability> supportedFastProvisioningEditions = default;
            PostgreSqlFlexibleServerGeoBackupSupported? geoBackupSupported = default;
            PostgreSqlFlexibleServerZoneRedundantHaSupported? zoneRedundantHaSupported = default;
            PostgreSqlFlexibleServerZoneRedundantHaAndGeoBackupSupported? zoneRedundantHaAndGeoBackupSupported = default;
            PostgreSqlFlexibleServerStorageAutoGrowthSupported? storageAutoGrowthSupported = default;
            PostgreSqlFlexibleServerOnlineResizeSupported? onlineResizeSupported = default;
            PostgreSqlFlexibleServerZoneRedundantRestricted? restricted = default;
            PostgreSqlFlexbileServerCapabilityStatus? status = default;
            string reason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedServerEditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlFlexibleServerEditionCapability> array = new List<PostgreSqlFlexibleServerEditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerEditionCapability.DeserializePostgreSqlFlexibleServerEditionCapability(item, options));
                    }
                    supportedServerEditions = array;
                    continue;
                }
                if (property.NameEquals("supportedServerVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlFlexibleServerServerVersionCapability> array = new List<PostgreSqlFlexibleServerServerVersionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerServerVersionCapability.DeserializePostgreSqlFlexibleServerServerVersionCapability(item, options));
                    }
                    supportedServerVersions = array;
                    continue;
                }
                if (property.NameEquals("fastProvisioningSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fastProvisioningSupported = new PostgreSqlFlexibleServerFastProvisioningSupported(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("supportedFastProvisioningEditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlFlexibleServerFastProvisioningEditionCapability> array = new List<PostgreSqlFlexibleServerFastProvisioningEditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerFastProvisioningEditionCapability.DeserializePostgreSqlFlexibleServerFastProvisioningEditionCapability(item, options));
                    }
                    supportedFastProvisioningEditions = array;
                    continue;
                }
                if (property.NameEquals("geoBackupSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    geoBackupSupported = new PostgreSqlFlexibleServerGeoBackupSupported(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("zoneRedundantHaSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zoneRedundantHaSupported = new PostgreSqlFlexibleServerZoneRedundantHaSupported(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("zoneRedundantHaAndGeoBackupSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zoneRedundantHaAndGeoBackupSupported = new PostgreSqlFlexibleServerZoneRedundantHaAndGeoBackupSupported(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAutoGrowthSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAutoGrowthSupported = new PostgreSqlFlexibleServerStorageAutoGrowthSupported(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("onlineResizeSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onlineResizeSupported = new PostgreSqlFlexibleServerOnlineResizeSupported(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("restricted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restricted = new PostgreSqlFlexibleServerZoneRedundantRestricted(property.Value.GetString());
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
            return new PostgreSqlFlexibleServerCapabilityProperties(
                status,
                reason,
                serializedAdditionalRawData,
                name,
                supportedServerEditions ?? new ChangeTrackingList<PostgreSqlFlexibleServerEditionCapability>(),
                supportedServerVersions ?? new ChangeTrackingList<PostgreSqlFlexibleServerServerVersionCapability>(),
                fastProvisioningSupported,
                supportedFastProvisioningEditions ?? new ChangeTrackingList<PostgreSqlFlexibleServerFastProvisioningEditionCapability>(),
                geoBackupSupported,
                zoneRedundantHaSupported,
                zoneRedundantHaAndGeoBackupSupported,
                storageAutoGrowthSupported,
                onlineResizeSupported,
                restricted);
        }

        BinaryData IPersistableModel<PostgreSqlFlexibleServerCapabilityProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerCapabilityProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerCapabilityProperties)} does not support writing '{options.Format}' format.");
            }
        }

        PostgreSqlFlexibleServerCapabilityProperties IPersistableModel<PostgreSqlFlexibleServerCapabilityProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerCapabilityProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlFlexibleServerCapabilityProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerCapabilityProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlFlexibleServerCapabilityProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
