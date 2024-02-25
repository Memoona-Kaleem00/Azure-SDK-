// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    public partial class VMwareVmInstanceData : IUtf8JsonSerializable, IJsonModel<VMwareVmInstanceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareVmInstanceData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VMwareVmInstanceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVmInstanceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareVmInstanceData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ExtendedLocation != null)
            {
                writer.WritePropertyName("extendedLocation"u8);
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
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
            if (PlacementProfile != null)
            {
                writer.WritePropertyName("placementProfile"u8);
                writer.WriteObjectValue(PlacementProfile);
            }
            if (OSProfile != null)
            {
                writer.WritePropertyName("osProfile"u8);
                writer.WriteObjectValue(OSProfile);
            }
            if (HardwareProfile != null)
            {
                writer.WritePropertyName("hardwareProfile"u8);
                writer.WriteObjectValue(HardwareProfile);
            }
            if (NetworkProfile != null)
            {
                writer.WritePropertyName("networkProfile"u8);
                writer.WriteObjectValue(NetworkProfile);
            }
            if (StorageProfile != null)
            {
                writer.WritePropertyName("storageProfile"u8);
                writer.WriteObjectValue(StorageProfile);
            }
            if (SecurityProfile != null)
            {
                writer.WritePropertyName("securityProfile"u8);
                writer.WriteObjectValue(SecurityProfile);
            }
            if (InfrastructureProfile != null)
            {
                writer.WritePropertyName("infrastructureProfile"u8);
                writer.WriteObjectValue(InfrastructureProfile);
            }
            if (options.Format != "W" && PowerState != null)
            {
                writer.WritePropertyName("powerState"u8);
                writer.WriteStringValue(PowerState);
            }
            if (options.Format != "W" && !(Statuses is ChangeTrackingList<VMwareResourceStatus> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("statuses"u8);
                writer.WriteStartArray();
                foreach (var item in Statuses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && ResourceUid != null)
            {
                writer.WritePropertyName("resourceUid"u8);
                writer.WriteStringValue(ResourceUid);
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

        VMwareVmInstanceData IJsonModel<VMwareVmInstanceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVmInstanceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareVmInstanceData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareVmInstanceData(document.RootElement, options);
        }

        internal static VMwareVmInstanceData DeserializeVMwareVmInstanceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ExtendedLocation> extendedLocation = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<PlacementProfile> placementProfile = default;
            Optional<OSProfileForVmInstance> osProfile = default;
            Optional<VmInstanceHardwareProfile> hardwareProfile = default;
            Optional<VMwareNetworkProfile> networkProfile = default;
            Optional<VMwareStorageProfile> storageProfile = default;
            Optional<SecurityProfile> securityProfile = default;
            Optional<VCenterInfrastructureProfile> infrastructureProfile = default;
            Optional<string> powerState = default;
            IReadOnlyList<VMwareResourceStatus> statuses = default;
            Optional<VMwareResourceProvisioningState> provisioningState = default;
            Optional<string> resourceUid = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.GetRawText());
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
                        if (property0.NameEquals("placementProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            placementProfile = PlacementProfile.DeserializePlacementProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("osProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osProfile = OSProfileForVmInstance.DeserializeOSProfileForVmInstance(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("hardwareProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hardwareProfile = VmInstanceHardwareProfile.DeserializeVmInstanceHardwareProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("networkProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkProfile = VMwareNetworkProfile.DeserializeVMwareNetworkProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("storageProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageProfile = VMwareStorageProfile.DeserializeVMwareStorageProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("securityProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityProfile = SecurityProfile.DeserializeSecurityProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("infrastructureProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            infrastructureProfile = VCenterInfrastructureProfile.DeserializeVCenterInfrastructureProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("powerState"u8))
                        {
                            powerState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("statuses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VMwareResourceStatus> array = new List<VMwareResourceStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VMwareResourceStatus.DeserializeVMwareResourceStatus(item, options));
                            }
                            statuses = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new VMwareResourceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceUid"u8))
                        {
                            resourceUid = property0.Value.GetString();
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
            return new VMwareVmInstanceData(id, name, type, systemData.Value, extendedLocation, placementProfile.Value, osProfile.Value, hardwareProfile.Value, networkProfile.Value, storageProfile.Value, securityProfile.Value, infrastructureProfile.Value, powerState.Value, statuses ?? new ChangeTrackingList<VMwareResourceStatus>(), Optional.ToNullable(provisioningState), resourceUid.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VMwareVmInstanceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVmInstanceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VMwareVmInstanceData)} does not support '{options.Format}' format.");
            }
        }

        VMwareVmInstanceData IPersistableModel<VMwareVmInstanceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVmInstanceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareVmInstanceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VMwareVmInstanceData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareVmInstanceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
