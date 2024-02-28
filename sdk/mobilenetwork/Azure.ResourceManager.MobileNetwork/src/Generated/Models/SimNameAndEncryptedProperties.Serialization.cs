// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class SimNameAndEncryptedProperties : IUtf8JsonSerializable, IJsonModel<SimNameAndEncryptedProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SimNameAndEncryptedProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SimNameAndEncryptedProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimNameAndEncryptedProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SimNameAndEncryptedProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && SimState.HasValue)
            {
                writer.WritePropertyName("simState"u8);
                writer.WriteStringValue(SimState.Value.ToString());
            }
            if (options.Format != "W" && !(SiteProvisioningState is ChangeTrackingDictionary<string, MobileNetworkSiteProvisioningState> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("siteProvisioningState"u8);
                writer.WriteStartObject();
                foreach (var item in SiteProvisioningState)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value.ToString());
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("internationalMobileSubscriberIdentity"u8);
            writer.WriteStringValue(InternationalMobileSubscriberIdentity);
            if (IntegratedCircuitCardIdentifier != null)
            {
                writer.WritePropertyName("integratedCircuitCardIdentifier"u8);
                writer.WriteStringValue(IntegratedCircuitCardIdentifier);
            }
            if (DeviceType != null)
            {
                writer.WritePropertyName("deviceType"u8);
                writer.WriteStringValue(DeviceType);
            }
            if (SimPolicy != null)
            {
                writer.WritePropertyName("simPolicy"u8);
                JsonSerializer.Serialize(writer, SimPolicy);
            }
            if (!(StaticIPConfiguration is ChangeTrackingList<SimStaticIPProperties> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("staticIpConfiguration"u8);
                writer.WriteStartArray();
                foreach (var item in StaticIPConfiguration)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && VendorName != null)
            {
                writer.WritePropertyName("vendorName"u8);
                writer.WriteStringValue(VendorName);
            }
            if (options.Format != "W" && VendorKeyFingerprint != null)
            {
                writer.WritePropertyName("vendorKeyFingerprint"u8);
                writer.WriteStringValue(VendorKeyFingerprint);
            }
            if (EncryptedCredentials != null)
            {
                writer.WritePropertyName("encryptedCredentials"u8);
                writer.WriteStringValue(EncryptedCredentials);
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

        SimNameAndEncryptedProperties IJsonModel<SimNameAndEncryptedProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimNameAndEncryptedProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SimNameAndEncryptedProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSimNameAndEncryptedProperties(document.RootElement, options);
        }

        internal static SimNameAndEncryptedProperties DeserializeSimNameAndEncryptedProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            MobileNetworkProvisioningState? provisioningState = default;
            MobileNetworkSimState? simState = default;
            IReadOnlyDictionary<string, MobileNetworkSiteProvisioningState> siteProvisioningState = default;
            string internationalMobileSubscriberIdentity = default;
            string integratedCircuitCardIdentifier = default;
            string deviceType = default;
            WritableSubResource simPolicy = default;
            IList<SimStaticIPProperties> staticIPConfiguration = default;
            string vendorName = default;
            string vendorKeyFingerprint = default;
            string encryptedCredentials = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new MobileNetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("simState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            simState = new MobileNetworkSimState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("siteProvisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, MobileNetworkSiteProvisioningState> dictionary = new Dictionary<string, MobileNetworkSiteProvisioningState>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, new MobileNetworkSiteProvisioningState(property1.Value.GetString()));
                            }
                            siteProvisioningState = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("internationalMobileSubscriberIdentity"u8))
                        {
                            internationalMobileSubscriberIdentity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("integratedCircuitCardIdentifier"u8))
                        {
                            integratedCircuitCardIdentifier = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deviceType"u8))
                        {
                            deviceType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("simPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            simPolicy = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("staticIpConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SimStaticIPProperties> array = new List<SimStaticIPProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SimStaticIPProperties.DeserializeSimStaticIPProperties(item, options));
                            }
                            staticIPConfiguration = array;
                            continue;
                        }
                        if (property0.NameEquals("vendorName"u8))
                        {
                            vendorName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vendorKeyFingerprint"u8))
                        {
                            vendorKeyFingerprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredentials"u8))
                        {
                            encryptedCredentials = property0.Value.GetString();
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
            return new SimNameAndEncryptedProperties(
                name,
                provisioningState,
                simState,
                siteProvisioningState ?? new ChangeTrackingDictionary<string, MobileNetworkSiteProvisioningState>(),
                internationalMobileSubscriberIdentity,
                integratedCircuitCardIdentifier,
                deviceType,
                simPolicy,
                staticIPConfiguration ?? new ChangeTrackingList<SimStaticIPProperties>(),
                vendorName,
                vendorKeyFingerprint,
                encryptedCredentials,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SimNameAndEncryptedProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimNameAndEncryptedProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SimNameAndEncryptedProperties)} does not support '{options.Format}' format.");
            }
        }

        SimNameAndEncryptedProperties IPersistableModel<SimNameAndEncryptedProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimNameAndEncryptedProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSimNameAndEncryptedProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SimNameAndEncryptedProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SimNameAndEncryptedProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
