// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineImage : IUtf8JsonSerializable, IJsonModel<VirtualMachineImage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineImage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineImage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineImage)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
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
            if (ExtendedLocation != null)
            {
                writer.WritePropertyName("extendedLocation"u8);
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Plan != null)
            {
                writer.WritePropertyName("plan"u8);
                writer.WriteObjectValue(Plan);
            }
            if (OSDiskImage != null)
            {
                writer.WritePropertyName("osDiskImage"u8);
                writer.WriteObjectValue(OSDiskImage);
            }
            if (!(DataDiskImages is ChangeTrackingList<DataDiskImage> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("dataDiskImages"u8);
                writer.WriteStartArray();
                foreach (var item in DataDiskImages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (AutomaticOSUpgradeProperties != null)
            {
                writer.WritePropertyName("automaticOSUpgradeProperties"u8);
                writer.WriteObjectValue(AutomaticOSUpgradeProperties);
            }
            if (HyperVGeneration.HasValue)
            {
                writer.WritePropertyName("hyperVGeneration"u8);
                writer.WriteStringValue(HyperVGeneration.Value.ToString());
            }
            if (Disallowed != null)
            {
                writer.WritePropertyName("disallowed"u8);
                writer.WriteObjectValue(Disallowed);
            }
            if (!(Features is ChangeTrackingList<VirtualMachineImageFeature> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("features"u8);
                writer.WriteStartArray();
                foreach (var item in Features)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Architecture.HasValue)
            {
                writer.WritePropertyName("architecture"u8);
                writer.WriteStringValue(Architecture.Value.ToString());
            }
            if (ImageDeprecationStatus != null)
            {
                writer.WritePropertyName("imageDeprecationStatus"u8);
                writer.WriteObjectValue(ImageDeprecationStatus);
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

        VirtualMachineImage IJsonModel<VirtualMachineImage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineImage)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineImage(document.RootElement, options);
        }

        internal static VirtualMachineImage DeserializeVirtualMachineImage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            AzureLocation location = default;
            IDictionary<string, string> tags = default;
            Optional<ExtendedLocation> extendedLocation = default;
            Optional<ResourceIdentifier> id = default;
            Optional<PurchasePlan> plan = default;
            Optional<OSDiskImage> osDiskImage = default;
            IList<DataDiskImage> dataDiskImages = default;
            Optional<AutomaticOSUpgradeProperties> automaticOSUpgradeProperties = default;
            Optional<HyperVGeneration> hyperVGeneration = default;
            Optional<DisallowedConfiguration> disallowed = default;
            IList<VirtualMachineImageFeature> features = default;
            Optional<ArchitectureType> architecture = default;
            Optional<ImageDeprecationStatus> imageDeprecationStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
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
                        if (property0.NameEquals("plan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            plan = PurchasePlan.DeserializePurchasePlan(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("osDiskImage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osDiskImage = OSDiskImage.DeserializeOSDiskImage(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("dataDiskImages"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataDiskImage> array = new List<DataDiskImage>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataDiskImage.DeserializeDataDiskImage(item, options));
                            }
                            dataDiskImages = array;
                            continue;
                        }
                        if (property0.NameEquals("automaticOSUpgradeProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            automaticOSUpgradeProperties = AutomaticOSUpgradeProperties.DeserializeAutomaticOSUpgradeProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("hyperVGeneration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hyperVGeneration = new HyperVGeneration(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("disallowed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disallowed = DisallowedConfiguration.DeserializeDisallowedConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("features"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualMachineImageFeature> array = new List<VirtualMachineImageFeature>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualMachineImageFeature.DeserializeVirtualMachineImageFeature(item, options));
                            }
                            features = array;
                            continue;
                        }
                        if (property0.NameEquals("architecture"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            architecture = new ArchitectureType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("imageDeprecationStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            imageDeprecationStatus = ImageDeprecationStatus.DeserializeImageDeprecationStatus(property0.Value, options);
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
            return new VirtualMachineImage(id.Value, serializedAdditionalRawData, name, location, tags ?? new ChangeTrackingDictionary<string, string>(), extendedLocation, plan.Value, osDiskImage.Value, dataDiskImages ?? new ChangeTrackingList<DataDiskImage>(), automaticOSUpgradeProperties.Value, Optional.ToNullable(hyperVGeneration), disallowed.Value, features ?? new ChangeTrackingList<VirtualMachineImageFeature>(), Optional.ToNullable(architecture), imageDeprecationStatus.Value);
        }

        BinaryData IPersistableModel<VirtualMachineImage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineImage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineImage)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineImage IPersistableModel<VirtualMachineImage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineImage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineImage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineImage)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineImage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
