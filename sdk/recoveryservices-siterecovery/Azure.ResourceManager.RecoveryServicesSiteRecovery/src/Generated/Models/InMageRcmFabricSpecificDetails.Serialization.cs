// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmFabricSpecificDetails : IUtf8JsonSerializable, IJsonModel<InMageRcmFabricSpecificDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageRcmFabricSpecificDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageRcmFabricSpecificDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFabricSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmFabricSpecificDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(VMwareSiteId))
            {
                writer.WritePropertyName("vmwareSiteId"u8);
                writer.WriteStringValue(VMwareSiteId);
            }
            if (options.Format != "W" && Optional.IsDefined(PhysicalSiteId))
            {
                writer.WritePropertyName("physicalSiteId"u8);
                writer.WriteStringValue(PhysicalSiteId);
            }
            if (options.Format != "W" && Optional.IsDefined(ServiceEndpoint))
            {
                writer.WritePropertyName("serviceEndpoint"u8);
                writer.WriteStringValue(ServiceEndpoint);
            }
            if (options.Format != "W" && Optional.IsDefined(ServiceResourceId))
            {
                writer.WritePropertyName("serviceResourceId"u8);
                writer.WriteStringValue(ServiceResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(ServiceContainerId))
            {
                writer.WritePropertyName("serviceContainerId"u8);
                writer.WriteStringValue(ServiceContainerId);
            }
            if (options.Format != "W" && Optional.IsDefined(DataPlaneUri))
            {
                writer.WritePropertyName("dataPlaneUri"u8);
                writer.WriteStringValue(DataPlaneUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(ControlPlaneUri))
            {
                writer.WritePropertyName("controlPlaneUri"u8);
                writer.WriteStringValue(ControlPlaneUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SourceAgentIdentityDetails))
            {
                writer.WritePropertyName("sourceAgentIdentityDetails"u8);
                writer.WriteObjectValue<IdentityProviderDetails>(SourceAgentIdentityDetails, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ProcessServers))
            {
                writer.WritePropertyName("processServers"u8);
                writer.WriteStartArray();
                foreach (var item in ProcessServers)
                {
                    writer.WriteObjectValue<SiteRecoveryProcessServerDetails>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RcmProxies))
            {
                writer.WritePropertyName("rcmProxies"u8);
                writer.WriteStartArray();
                foreach (var item in RcmProxies)
                {
                    writer.WriteObjectValue<RcmProxyDetails>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PushInstallers))
            {
                writer.WritePropertyName("pushInstallers"u8);
                writer.WriteStartArray();
                foreach (var item in PushInstallers)
                {
                    writer.WriteObjectValue<PushInstallerDetails>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ReplicationAgents))
            {
                writer.WritePropertyName("replicationAgents"u8);
                writer.WriteStartArray();
                foreach (var item in ReplicationAgents)
                {
                    writer.WriteObjectValue<ReplicationAgentDetails>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ReprotectAgents))
            {
                writer.WritePropertyName("reprotectAgents"u8);
                writer.WriteStartArray();
                foreach (var item in ReprotectAgents)
                {
                    writer.WriteObjectValue<ReprotectAgentDetails>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(MarsAgents))
            {
                writer.WritePropertyName("marsAgents"u8);
                writer.WriteStartArray();
                foreach (var item in MarsAgents)
                {
                    writer.WriteObjectValue<MarsAgentDetails>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Dras))
            {
                writer.WritePropertyName("dras"u8);
                writer.WriteStartArray();
                foreach (var item in Dras)
                {
                    writer.WriteObjectValue<SiteRecoveryDraDetails>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AgentDetails))
            {
                writer.WritePropertyName("agentDetails"u8);
                writer.WriteStartArray();
                foreach (var item in AgentDetails)
                {
                    writer.WriteObjectValue<SiteRecoveryAgentDetails>(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        InMageRcmFabricSpecificDetails IJsonModel<InMageRcmFabricSpecificDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFabricSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmFabricSpecificDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmFabricSpecificDetails(document.RootElement, options);
        }

        internal static InMageRcmFabricSpecificDetails DeserializeInMageRcmFabricSpecificDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier vmwareSiteId = default;
            ResourceIdentifier physicalSiteId = default;
            string serviceEndpoint = default;
            ResourceIdentifier serviceResourceId = default;
            string serviceContainerId = default;
            Uri dataPlaneUri = default;
            Uri controlPlaneUri = default;
            IdentityProviderDetails sourceAgentIdentityDetails = default;
            IReadOnlyList<SiteRecoveryProcessServerDetails> processServers = default;
            IReadOnlyList<RcmProxyDetails> rcmProxies = default;
            IReadOnlyList<PushInstallerDetails> pushInstallers = default;
            IReadOnlyList<ReplicationAgentDetails> replicationAgents = default;
            IReadOnlyList<ReprotectAgentDetails> reprotectAgents = default;
            IReadOnlyList<MarsAgentDetails> marsAgents = default;
            IReadOnlyList<SiteRecoveryDraDetails> dras = default;
            IReadOnlyList<SiteRecoveryAgentDetails> agentDetails = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmwareSiteId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmwareSiteId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("physicalSiteId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    physicalSiteId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceEndpoint"u8))
                {
                    serviceEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceContainerId"u8))
                {
                    serviceContainerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataPlaneUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataPlaneUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("controlPlaneUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    controlPlaneUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceAgentIdentityDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceAgentIdentityDetails = IdentityProviderDetails.DeserializeIdentityProviderDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("processServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryProcessServerDetails> array = new List<SiteRecoveryProcessServerDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryProcessServerDetails.DeserializeSiteRecoveryProcessServerDetails(item, options));
                    }
                    processServers = array;
                    continue;
                }
                if (property.NameEquals("rcmProxies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RcmProxyDetails> array = new List<RcmProxyDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RcmProxyDetails.DeserializeRcmProxyDetails(item, options));
                    }
                    rcmProxies = array;
                    continue;
                }
                if (property.NameEquals("pushInstallers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PushInstallerDetails> array = new List<PushInstallerDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PushInstallerDetails.DeserializePushInstallerDetails(item, options));
                    }
                    pushInstallers = array;
                    continue;
                }
                if (property.NameEquals("replicationAgents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReplicationAgentDetails> array = new List<ReplicationAgentDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReplicationAgentDetails.DeserializeReplicationAgentDetails(item, options));
                    }
                    replicationAgents = array;
                    continue;
                }
                if (property.NameEquals("reprotectAgents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReprotectAgentDetails> array = new List<ReprotectAgentDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReprotectAgentDetails.DeserializeReprotectAgentDetails(item, options));
                    }
                    reprotectAgents = array;
                    continue;
                }
                if (property.NameEquals("marsAgents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MarsAgentDetails> array = new List<MarsAgentDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MarsAgentDetails.DeserializeMarsAgentDetails(item, options));
                    }
                    marsAgents = array;
                    continue;
                }
                if (property.NameEquals("dras"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryDraDetails> array = new List<SiteRecoveryDraDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryDraDetails.DeserializeSiteRecoveryDraDetails(item, options));
                    }
                    dras = array;
                    continue;
                }
                if (property.NameEquals("agentDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryAgentDetails> array = new List<SiteRecoveryAgentDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryAgentDetails.DeserializeSiteRecoveryAgentDetails(item, options));
                    }
                    agentDetails = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageRcmFabricSpecificDetails(
                instanceType,
                serializedAdditionalRawData,
                vmwareSiteId,
                physicalSiteId,
                serviceEndpoint,
                serviceResourceId,
                serviceContainerId,
                dataPlaneUri,
                controlPlaneUri,
                sourceAgentIdentityDetails,
                processServers ?? new ChangeTrackingList<SiteRecoveryProcessServerDetails>(),
                rcmProxies ?? new ChangeTrackingList<RcmProxyDetails>(),
                pushInstallers ?? new ChangeTrackingList<PushInstallerDetails>(),
                replicationAgents ?? new ChangeTrackingList<ReplicationAgentDetails>(),
                reprotectAgents ?? new ChangeTrackingList<ReprotectAgentDetails>(),
                marsAgents ?? new ChangeTrackingList<MarsAgentDetails>(),
                dras ?? new ChangeTrackingList<SiteRecoveryDraDetails>(),
                agentDetails ?? new ChangeTrackingList<SiteRecoveryAgentDetails>());
        }

        BinaryData IPersistableModel<InMageRcmFabricSpecificDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFabricSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageRcmFabricSpecificDetails)} does not support writing '{options.Format}' format.");
            }
        }

        InMageRcmFabricSpecificDetails IPersistableModel<InMageRcmFabricSpecificDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmFabricSpecificDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageRcmFabricSpecificDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageRcmFabricSpecificDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageRcmFabricSpecificDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
