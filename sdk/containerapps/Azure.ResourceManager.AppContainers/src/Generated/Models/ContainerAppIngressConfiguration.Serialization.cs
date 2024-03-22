// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppIngressConfiguration : IUtf8JsonSerializable, IJsonModel<ContainerAppIngressConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppIngressConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppIngressConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppIngressConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppIngressConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Fqdn))
            {
                writer.WritePropertyName("fqdn"u8);
                writer.WriteStringValue(Fqdn);
            }
            if (Optional.IsDefined(External))
            {
                writer.WritePropertyName("external"u8);
                writer.WriteBooleanValue(External.Value);
            }
            if (Optional.IsDefined(TargetPort))
            {
                writer.WritePropertyName("targetPort"u8);
                writer.WriteNumberValue(TargetPort.Value);
            }
            if (Optional.IsDefined(ExposedPort))
            {
                writer.WritePropertyName("exposedPort"u8);
                writer.WriteNumberValue(ExposedPort.Value);
            }
            if (Optional.IsDefined(Transport))
            {
                writer.WritePropertyName("transport"u8);
                writer.WriteStringValue(Transport.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Traffic))
            {
                writer.WritePropertyName("traffic"u8);
                writer.WriteStartArray();
                foreach (var item in Traffic)
                {
                    writer.WriteObjectValue<ContainerAppRevisionTrafficWeight>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CustomDomains))
            {
                writer.WritePropertyName("customDomains"u8);
                writer.WriteStartArray();
                foreach (var item in CustomDomains)
                {
                    writer.WriteObjectValue<ContainerAppCustomDomain>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AllowInsecure))
            {
                writer.WritePropertyName("allowInsecure"u8);
                writer.WriteBooleanValue(AllowInsecure.Value);
            }
            if (Optional.IsCollectionDefined(IPSecurityRestrictions))
            {
                writer.WritePropertyName("ipSecurityRestrictions"u8);
                writer.WriteStartArray();
                foreach (var item in IPSecurityRestrictions)
                {
                    writer.WriteObjectValue<ContainerAppIPSecurityRestrictionRule>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(StickySessions))
            {
                writer.WritePropertyName("stickySessions"u8);
                writer.WriteObjectValue<IngressStickySessions>(StickySessions, options);
            }
            if (Optional.IsDefined(ClientCertificateMode))
            {
                writer.WritePropertyName("clientCertificateMode"u8);
                writer.WriteStringValue(ClientCertificateMode.Value.ToString());
            }
            if (Optional.IsDefined(CorsPolicy))
            {
                writer.WritePropertyName("corsPolicy"u8);
                writer.WriteObjectValue<ContainerAppCorsPolicy>(CorsPolicy, options);
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

        ContainerAppIngressConfiguration IJsonModel<ContainerAppIngressConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppIngressConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppIngressConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppIngressConfiguration(document.RootElement, options);
        }

        internal static ContainerAppIngressConfiguration DeserializeContainerAppIngressConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string fqdn = default;
            bool? external = default;
            int? targetPort = default;
            int? exposedPort = default;
            ContainerAppIngressTransportMethod? transport = default;
            IList<ContainerAppRevisionTrafficWeight> traffic = default;
            IList<ContainerAppCustomDomain> customDomains = default;
            bool? allowInsecure = default;
            IList<ContainerAppIPSecurityRestrictionRule> ipSecurityRestrictions = default;
            IngressStickySessions stickySessions = default;
            ContainerAppIngressClientCertificateMode? clientCertificateMode = default;
            ContainerAppCorsPolicy corsPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fqdn"u8))
                {
                    fqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("external"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    external = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("targetPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("exposedPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exposedPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("transport"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transport = new ContainerAppIngressTransportMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("traffic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppRevisionTrafficWeight> array = new List<ContainerAppRevisionTrafficWeight>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppRevisionTrafficWeight.DeserializeContainerAppRevisionTrafficWeight(item, options));
                    }
                    traffic = array;
                    continue;
                }
                if (property.NameEquals("customDomains"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppCustomDomain> array = new List<ContainerAppCustomDomain>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppCustomDomain.DeserializeContainerAppCustomDomain(item, options));
                    }
                    customDomains = array;
                    continue;
                }
                if (property.NameEquals("allowInsecure"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowInsecure = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ipSecurityRestrictions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppIPSecurityRestrictionRule> array = new List<ContainerAppIPSecurityRestrictionRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppIPSecurityRestrictionRule.DeserializeContainerAppIPSecurityRestrictionRule(item, options));
                    }
                    ipSecurityRestrictions = array;
                    continue;
                }
                if (property.NameEquals("stickySessions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stickySessions = IngressStickySessions.DeserializeIngressStickySessions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("clientCertificateMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientCertificateMode = new ContainerAppIngressClientCertificateMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("corsPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    corsPolicy = ContainerAppCorsPolicy.DeserializeContainerAppCorsPolicy(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppIngressConfiguration(
                fqdn,
                external,
                targetPort,
                exposedPort,
                transport,
                traffic ?? new ChangeTrackingList<ContainerAppRevisionTrafficWeight>(),
                customDomains ?? new ChangeTrackingList<ContainerAppCustomDomain>(),
                allowInsecure,
                ipSecurityRestrictions ?? new ChangeTrackingList<ContainerAppIPSecurityRestrictionRule>(),
                stickySessions,
                clientCertificateMode,
                corsPolicy,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppIngressConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppIngressConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppIngressConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppIngressConfiguration IPersistableModel<ContainerAppIngressConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppIngressConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppIngressConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppIngressConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppIngressConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
