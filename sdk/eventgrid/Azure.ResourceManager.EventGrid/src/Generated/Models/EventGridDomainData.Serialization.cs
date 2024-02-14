// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    public partial class EventGridDomainData : IUtf8JsonSerializable, IJsonModel<EventGridDomainData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventGridDomainData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventGridDomainData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridDomainData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridDomainData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
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
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(MinimumTlsVersionAllowed))
            {
                writer.WritePropertyName("minimumTlsVersionAllowed"u8);
                writer.WriteStringValue(MinimumTlsVersionAllowed.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint.AbsoluteUri);
            }
            if (Optional.IsDefined(InputSchema))
            {
                writer.WritePropertyName("inputSchema"u8);
                writer.WriteStringValue(InputSchema.Value.ToString());
            }
            if (Optional.IsDefined(EventTypeInfo))
            {
                writer.WritePropertyName("eventTypeInfo"u8);
                writer.WriteObjectValue(EventTypeInfo);
            }
            if (Optional.IsDefined(InputSchemaMapping))
            {
                writer.WritePropertyName("inputSchemaMapping"u8);
                writer.WriteObjectValue(InputSchemaMapping);
            }
            if (options.Format != "W" && Optional.IsDefined(MetricResourceId))
            {
                writer.WritePropertyName("metricResourceId"u8);
                writer.WriteStringValue(MetricResourceId);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsCollectionDefined(InboundIPRules))
            {
                writer.WritePropertyName("inboundIpRules"u8);
                writer.WriteStartArray();
                foreach (var item in InboundIPRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsLocalAuthDisabled))
            {
                writer.WritePropertyName("disableLocalAuth"u8);
                writer.WriteBooleanValue(IsLocalAuthDisabled.Value);
            }
            if (Optional.IsDefined(AutoCreateTopicWithFirstSubscription))
            {
                writer.WritePropertyName("autoCreateTopicWithFirstSubscription"u8);
                writer.WriteBooleanValue(AutoCreateTopicWithFirstSubscription.Value);
            }
            if (Optional.IsDefined(AutoDeleteTopicWithLastSubscription))
            {
                writer.WritePropertyName("autoDeleteTopicWithLastSubscription"u8);
                writer.WriteBooleanValue(AutoDeleteTopicWithLastSubscription.Value);
            }
            if (Optional.IsDefined(DataResidencyBoundary))
            {
                writer.WritePropertyName("dataResidencyBoundary"u8);
                writer.WriteStringValue(DataResidencyBoundary.Value.ToString());
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

        EventGridDomainData IJsonModel<EventGridDomainData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridDomainData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridDomainData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventGridDomainData(document.RootElement, options);
        }

        internal static EventGridDomainData DeserializeEventGridDomainData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceSku> sku = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyList<EventGridPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<EventGridDomainProvisioningState> provisioningState = default;
            Optional<TlsVersion> minimumTlsVersionAllowed = default;
            Optional<Uri> endpoint = default;
            Optional<EventGridInputSchema> inputSchema = default;
            Optional<PartnerTopicEventTypeInfo> eventTypeInfo = default;
            Optional<EventGridInputSchemaMapping> inputSchemaMapping = default;
            Optional<string> metricResourceId = default;
            Optional<EventGridPublicNetworkAccess> publicNetworkAccess = default;
            Optional<IList<EventGridInboundIPRule>> inboundIPRules = default;
            Optional<bool> disableLocalAuth = default;
            Optional<bool> autoCreateTopicWithFirstSubscription = default;
            Optional<bool> autoDeleteTopicWithLastSubscription = default;
            Optional<DataResidencyBoundary> dataResidencyBoundary = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ResourceSku.DeserializeResourceSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
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
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EventGridPrivateEndpointConnectionData> array = new List<EventGridPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EventGridPrivateEndpointConnectionData.DeserializeEventGridPrivateEndpointConnectionData(item, options));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new EventGridDomainProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("minimumTlsVersionAllowed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minimumTlsVersionAllowed = new TlsVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("endpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpoint = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("inputSchema"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            inputSchema = new EventGridInputSchema(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("eventTypeInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventTypeInfo = PartnerTopicEventTypeInfo.DeserializePartnerTopicEventTypeInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("inputSchemaMapping"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            inputSchemaMapping = EventGridInputSchemaMapping.DeserializeEventGridInputSchemaMapping(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("metricResourceId"u8))
                        {
                            metricResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new EventGridPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("inboundIpRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EventGridInboundIPRule> array = new List<EventGridInboundIPRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EventGridInboundIPRule.DeserializeEventGridInboundIPRule(item, options));
                            }
                            inboundIPRules = array;
                            continue;
                        }
                        if (property0.NameEquals("disableLocalAuth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableLocalAuth = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("autoCreateTopicWithFirstSubscription"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoCreateTopicWithFirstSubscription = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("autoDeleteTopicWithLastSubscription"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoDeleteTopicWithLastSubscription = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("dataResidencyBoundary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataResidencyBoundary = new DataResidencyBoundary(property0.Value.GetString());
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
            return new EventGridDomainData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku.Value, identity, Optional.ToList(privateEndpointConnections), Optional.ToNullable(provisioningState), Optional.ToNullable(minimumTlsVersionAllowed), endpoint.Value, Optional.ToNullable(inputSchema), eventTypeInfo.Value, inputSchemaMapping.Value, metricResourceId.Value, Optional.ToNullable(publicNetworkAccess), Optional.ToList(inboundIPRules), Optional.ToNullable(disableLocalAuth), Optional.ToNullable(autoCreateTopicWithFirstSubscription), Optional.ToNullable(autoDeleteTopicWithLastSubscription), Optional.ToNullable(dataResidencyBoundary), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EventGridDomainData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridDomainData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventGridDomainData)} does not support '{options.Format}' format.");
            }
        }

        EventGridDomainData IPersistableModel<EventGridDomainData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridDomainData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventGridDomainData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventGridDomainData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventGridDomainData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
