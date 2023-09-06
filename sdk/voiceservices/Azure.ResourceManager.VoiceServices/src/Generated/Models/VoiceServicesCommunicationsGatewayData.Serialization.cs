// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.VoiceServices.Models;

namespace Azure.ResourceManager.VoiceServices
{
    public partial class VoiceServicesCommunicationsGatewayData : IUtf8JsonSerializable, IModelJsonSerializable<VoiceServicesCommunicationsGatewayData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VoiceServicesCommunicationsGatewayData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VoiceServicesCommunicationsGatewayData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VoiceServicesCommunicationsGatewayData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ServiceLocations))
            {
                writer.WritePropertyName("serviceLocations"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceLocations)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<VoiceServicesServiceRegionProperties>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Connectivity))
            {
                writer.WritePropertyName("connectivity"u8);
                writer.WriteStringValue(Connectivity.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Codecs))
            {
                writer.WritePropertyName("codecs"u8);
                writer.WriteStartArray();
                foreach (var item in Codecs)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(E911Type))
            {
                writer.WritePropertyName("e911Type"u8);
                writer.WriteStringValue(E911Type.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Platforms))
            {
                writer.WritePropertyName("platforms"u8);
                writer.WriteStartArray();
                foreach (var item in Platforms)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ApiBridge))
            {
                writer.WritePropertyName("apiBridge"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ApiBridge);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ApiBridge.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(AutoGeneratedDomainNameLabelScope))
            {
                writer.WritePropertyName("autoGeneratedDomainNameLabelScope"u8);
                writer.WriteStringValue(AutoGeneratedDomainNameLabelScope.Value.ToString());
            }
            if (Optional.IsDefined(TeamsVoicemailPilotNumber))
            {
                writer.WritePropertyName("teamsVoicemailPilotNumber"u8);
                writer.WriteStringValue(TeamsVoicemailPilotNumber);
            }
            if (Optional.IsDefined(IsOnPremMcpEnabled))
            {
                writer.WritePropertyName("onPremMcpEnabled"u8);
                writer.WriteBooleanValue(IsOnPremMcpEnabled.Value);
            }
            if (Optional.IsCollectionDefined(EmergencyDialStrings))
            {
                writer.WritePropertyName("emergencyDialStrings"u8);
                writer.WriteStartArray();
                foreach (var item in EmergencyDialStrings)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static VoiceServicesCommunicationsGatewayData DeserializeVoiceServicesCommunicationsGatewayData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<VoiceServicesProvisioningState> provisioningState = default;
            Optional<VoiceServicesCommunicationsGatewayStatus> status = default;
            Optional<IList<VoiceServicesServiceRegionProperties>> serviceLocations = default;
            Optional<VoiceServicesCommunicationsGatewayConnectivity> connectivity = default;
            Optional<IList<VoiceServicesTeamsCodec>> codecs = default;
            Optional<VoiceServicesEmergencyCallType> e911Type = default;
            Optional<IList<VoiceServicesCommunicationsPlatform>> platforms = default;
            Optional<BinaryData> apiBridge = default;
            Optional<VoiceServicesAutoGeneratedDomainNameLabelScope> autoGeneratedDomainNameLabelScope = default;
            Optional<string> autoGeneratedDomainNameLabel = default;
            Optional<string> teamsVoicemailPilotNumber = default;
            Optional<bool> onPremMcpEnabled = default;
            Optional<IList<string>> emergencyDialStrings = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new VoiceServicesProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new VoiceServicesCommunicationsGatewayStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serviceLocations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VoiceServicesServiceRegionProperties> array = new List<VoiceServicesServiceRegionProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VoiceServicesServiceRegionProperties.DeserializeVoiceServicesServiceRegionProperties(item));
                            }
                            serviceLocations = array;
                            continue;
                        }
                        if (property0.NameEquals("connectivity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectivity = new VoiceServicesCommunicationsGatewayConnectivity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("codecs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VoiceServicesTeamsCodec> array = new List<VoiceServicesTeamsCodec>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new VoiceServicesTeamsCodec(item.GetString()));
                            }
                            codecs = array;
                            continue;
                        }
                        if (property0.NameEquals("e911Type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            e911Type = new VoiceServicesEmergencyCallType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("platforms"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VoiceServicesCommunicationsPlatform> array = new List<VoiceServicesCommunicationsPlatform>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new VoiceServicesCommunicationsPlatform(item.GetString()));
                            }
                            platforms = array;
                            continue;
                        }
                        if (property0.NameEquals("apiBridge"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            apiBridge = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("autoGeneratedDomainNameLabelScope"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoGeneratedDomainNameLabelScope = new VoiceServicesAutoGeneratedDomainNameLabelScope(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("autoGeneratedDomainNameLabel"u8))
                        {
                            autoGeneratedDomainNameLabel = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("teamsVoicemailPilotNumber"u8))
                        {
                            teamsVoicemailPilotNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("onPremMcpEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            onPremMcpEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("emergencyDialStrings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            emergencyDialStrings = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VoiceServicesCommunicationsGatewayData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(provisioningState), Optional.ToNullable(status), Optional.ToList(serviceLocations), Optional.ToNullable(connectivity), Optional.ToList(codecs), Optional.ToNullable(e911Type), Optional.ToList(platforms), apiBridge.Value, Optional.ToNullable(autoGeneratedDomainNameLabelScope), autoGeneratedDomainNameLabel.Value, teamsVoicemailPilotNumber.Value, Optional.ToNullable(onPremMcpEnabled), Optional.ToList(emergencyDialStrings), rawData);
        }

        VoiceServicesCommunicationsGatewayData IModelJsonSerializable<VoiceServicesCommunicationsGatewayData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VoiceServicesCommunicationsGatewayData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVoiceServicesCommunicationsGatewayData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VoiceServicesCommunicationsGatewayData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VoiceServicesCommunicationsGatewayData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VoiceServicesCommunicationsGatewayData IModelSerializable<VoiceServicesCommunicationsGatewayData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<VoiceServicesCommunicationsGatewayData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVoiceServicesCommunicationsGatewayData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VoiceServicesCommunicationsGatewayData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VoiceServicesCommunicationsGatewayData"/> to convert. </param>
        public static implicit operator RequestContent(VoiceServicesCommunicationsGatewayData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VoiceServicesCommunicationsGatewayData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VoiceServicesCommunicationsGatewayData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVoiceServicesCommunicationsGatewayData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
