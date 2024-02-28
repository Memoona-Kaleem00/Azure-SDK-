// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumePatch : IUtf8JsonSerializable, IJsonModel<NetAppVolumePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppVolumePatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetAppVolumePatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumePatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (ServiceLevel.HasValue)
            {
                writer.WritePropertyName("serviceLevel"u8);
                writer.WriteStringValue(ServiceLevel.Value.ToString());
            }
            if (UsageThreshold.HasValue)
            {
                writer.WritePropertyName("usageThreshold"u8);
                writer.WriteNumberValue(UsageThreshold.Value);
            }
            if (ExportPolicy != null)
            {
                writer.WritePropertyName("exportPolicy"u8);
                writer.WriteObjectValue(ExportPolicy);
            }
            if (ThroughputMibps.HasValue)
            {
                writer.WritePropertyName("throughputMibps"u8);
                writer.WriteNumberValue(ThroughputMibps.Value);
            }
            if (DataProtection != null)
            {
                writer.WritePropertyName("dataProtection"u8);
                writer.WriteObjectValue(DataProtection);
            }
            if (IsDefaultQuotaEnabled.HasValue)
            {
                writer.WritePropertyName("isDefaultQuotaEnabled"u8);
                writer.WriteBooleanValue(IsDefaultQuotaEnabled.Value);
            }
            if (DefaultUserQuotaInKiBs.HasValue)
            {
                writer.WritePropertyName("defaultUserQuotaInKiBs"u8);
                writer.WriteNumberValue(DefaultUserQuotaInKiBs.Value);
            }
            if (DefaultGroupQuotaInKiBs.HasValue)
            {
                writer.WritePropertyName("defaultGroupQuotaInKiBs"u8);
                writer.WriteNumberValue(DefaultGroupQuotaInKiBs.Value);
            }
            if (UnixPermissions != null)
            {
                if (UnixPermissions != null)
                {
                    writer.WritePropertyName("unixPermissions"u8);
                    writer.WriteStringValue(UnixPermissions);
                }
                else
                {
                    writer.WriteNull("unixPermissions");
                }
            }
            if (IsCoolAccessEnabled.HasValue)
            {
                writer.WritePropertyName("coolAccess"u8);
                writer.WriteBooleanValue(IsCoolAccessEnabled.Value);
            }
            if (CoolnessPeriod.HasValue)
            {
                writer.WritePropertyName("coolnessPeriod"u8);
                writer.WriteNumberValue(CoolnessPeriod.Value);
            }
            if (CoolAccessRetrievalPolicy.HasValue)
            {
                writer.WritePropertyName("coolAccessRetrievalPolicy"u8);
                writer.WriteStringValue(CoolAccessRetrievalPolicy.Value.ToString());
            }
            if (IsSnapshotDirectoryVisible.HasValue)
            {
                writer.WritePropertyName("snapshotDirectoryVisible"u8);
                writer.WriteBooleanValue(IsSnapshotDirectoryVisible.Value);
            }
            if (SmbAccessBasedEnumeration.HasValue)
            {
                if (SmbAccessBasedEnumeration != null)
                {
                    writer.WritePropertyName("smbAccessBasedEnumeration"u8);
                    writer.WriteStringValue(SmbAccessBasedEnumeration.Value.ToString());
                }
                else
                {
                    writer.WriteNull("smbAccessBasedEnumeration");
                }
            }
            if (SmbNonBrowsable.HasValue)
            {
                writer.WritePropertyName("smbNonBrowsable"u8);
                writer.WriteStringValue(SmbNonBrowsable.Value.ToString());
            }
            writer.WriteEndObject();
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

        NetAppVolumePatch IJsonModel<NetAppVolumePatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppVolumePatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppVolumePatch(document.RootElement, options);
        }

        internal static NetAppVolumePatch DeserializeNetAppVolumePatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            NetAppFileServiceLevel? serviceLevel = default;
            long? usageThreshold = default;
            VolumePatchPropertiesExportPolicy exportPolicy = default;
            float? throughputMibps = default;
            NetAppVolumePatchDataProtection dataProtection = default;
            bool? isDefaultQuotaEnabled = default;
            long? defaultUserQuotaInKiBs = default;
            long? defaultGroupQuotaInKiBs = default;
            string unixPermissions = default;
            bool? coolAccess = default;
            int? coolnessPeriod = default;
            CoolAccessRetrievalPolicy? coolAccessRetrievalPolicy = default;
            bool? snapshotDirectoryVisible = default;
            SmbAccessBasedEnumeration? smbAccessBasedEnumeration = default;
            SmbNonBrowsable? smbNonBrowsable = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("serviceLevel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceLevel = new NetAppFileServiceLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("usageThreshold"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usageThreshold = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("exportPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            exportPolicy = VolumePatchPropertiesExportPolicy.DeserializeVolumePatchPropertiesExportPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("throughputMibps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            throughputMibps = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("dataProtection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataProtection = NetAppVolumePatchDataProtection.DeserializeNetAppVolumePatchDataProtection(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("isDefaultQuotaEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDefaultQuotaEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultUserQuotaInKiBs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultUserQuotaInKiBs = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("defaultGroupQuotaInKiBs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultGroupQuotaInKiBs = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("unixPermissions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                unixPermissions = null;
                                continue;
                            }
                            unixPermissions = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("coolAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coolAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("coolnessPeriod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coolnessPeriod = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("coolAccessRetrievalPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coolAccessRetrievalPolicy = new CoolAccessRetrievalPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("snapshotDirectoryVisible"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            snapshotDirectoryVisible = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("smbAccessBasedEnumeration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                smbAccessBasedEnumeration = null;
                                continue;
                            }
                            smbAccessBasedEnumeration = new SmbAccessBasedEnumeration(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("smbNonBrowsable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            smbNonBrowsable = new SmbNonBrowsable(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetAppVolumePatch(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                serviceLevel,
                usageThreshold,
                exportPolicy,
                throughputMibps,
                dataProtection,
                isDefaultQuotaEnabled,
                defaultUserQuotaInKiBs,
                defaultGroupQuotaInKiBs,
                unixPermissions,
                coolAccess,
                coolnessPeriod,
                coolAccessRetrievalPolicy,
                snapshotDirectoryVisible,
                smbAccessBasedEnumeration,
                smbNonBrowsable,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppVolumePatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumePatch)} does not support '{options.Format}' format.");
            }
        }

        NetAppVolumePatch IPersistableModel<NetAppVolumePatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppVolumePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetAppVolumePatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetAppVolumePatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppVolumePatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
