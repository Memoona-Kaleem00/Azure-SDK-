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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SqlVirtualMachine.Models;

namespace Azure.ResourceManager.SqlVirtualMachine
{
    public partial class AvailabilityGroupListenerData : IUtf8JsonSerializable, IJsonModel<AvailabilityGroupListenerData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvailabilityGroupListenerData>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AvailabilityGroupListenerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AvailabilityGroupListenerData>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AvailabilityGroupListenerData>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState);
                }
            }
            if (Optional.IsDefined(AvailabilityGroupName))
            {
                writer.WritePropertyName("availabilityGroupName"u8);
                writer.WriteStringValue(AvailabilityGroupName);
            }
            if (Optional.IsCollectionDefined(LoadBalancerConfigurations))
            {
                writer.WritePropertyName("loadBalancerConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in LoadBalancerConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MultiSubnetIPConfigurations))
            {
                writer.WritePropertyName("multiSubnetIpConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in MultiSubnetIPConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CreateDefaultAvailabilityGroupIfNotExist))
            {
                writer.WritePropertyName("createDefaultAvailabilityGroupIfNotExist"u8);
                writer.WriteBooleanValue(CreateDefaultAvailabilityGroupIfNotExist.Value);
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
            }
            if (Optional.IsDefined(AvailabilityGroupConfiguration))
            {
                writer.WritePropertyName("availabilityGroupConfiguration"u8);
                writer.WriteObjectValue(AvailabilityGroupConfiguration);
            }
            writer.WriteEndObject();
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

        AvailabilityGroupListenerData IJsonModel<AvailabilityGroupListenerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvailabilityGroupListenerData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailabilityGroupListenerData(document.RootElement, options);
        }

        internal static AvailabilityGroupListenerData DeserializeAvailabilityGroupListenerData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> provisioningState = default;
            Optional<string> availabilityGroupName = default;
            Optional<IList<AvailabilityGroupListenerLoadBalancerConfiguration>> loadBalancerConfigurations = default;
            Optional<IList<MultiSubnetIPConfiguration>> multiSubnetIPConfigurations = default;
            Optional<bool> createDefaultAvailabilityGroupIfNotExist = default;
            Optional<int> port = default;
            Optional<AvailabilityGroupConfiguration> availabilityGroupConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("availabilityGroupName"u8))
                        {
                            availabilityGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AvailabilityGroupListenerLoadBalancerConfiguration> array = new List<AvailabilityGroupListenerLoadBalancerConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AvailabilityGroupListenerLoadBalancerConfiguration.DeserializeAvailabilityGroupListenerLoadBalancerConfiguration(item));
                            }
                            loadBalancerConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("multiSubnetIpConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MultiSubnetIPConfiguration> array = new List<MultiSubnetIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MultiSubnetIPConfiguration.DeserializeMultiSubnetIPConfiguration(item));
                            }
                            multiSubnetIPConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("createDefaultAvailabilityGroupIfNotExist"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createDefaultAvailabilityGroupIfNotExist = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("port"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            port = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("availabilityGroupConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            availabilityGroupConfiguration = AvailabilityGroupConfiguration.DeserializeAvailabilityGroupConfiguration(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AvailabilityGroupListenerData(id, name, type, systemData.Value, provisioningState.Value, availabilityGroupName.Value, Optional.ToList(loadBalancerConfigurations), Optional.ToList(multiSubnetIPConfigurations), Optional.ToNullable(createDefaultAvailabilityGroupIfNotExist), Optional.ToNullable(port), availabilityGroupConfiguration.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvailabilityGroupListenerData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvailabilityGroupListenerData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AvailabilityGroupListenerData IPersistableModel<AvailabilityGroupListenerData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvailabilityGroupListenerData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAvailabilityGroupListenerData(document.RootElement, options);
        }

        string IPersistableModel<AvailabilityGroupListenerData>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
