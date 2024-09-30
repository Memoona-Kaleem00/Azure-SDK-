// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ContainerInstance.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerInstance
{
    /// <summary>
    /// A class representing the ContainerGroup data model.
    /// A container group.
    /// </summary>
    public partial class ContainerGroupData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerGroupData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="containers"> The containers within the container group. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containers"/> is null. </exception>
        public ContainerGroupData(AzureLocation location, IEnumerable<ContainerInstanceContainer> containers) : base(location)
        {
            Argument.AssertNotNull(containers, nameof(containers));

            Containers = containers.ToList();
            ImageRegistryCredentials = new ChangeTrackingList<ContainerGroupImageRegistryCredential>();
            Volumes = new ChangeTrackingList<ContainerVolume>();
            SubnetIds = new ChangeTrackingList<ContainerGroupSubnetId>();
            InitContainers = new ChangeTrackingList<InitContainerDefinitionContent>();
            Extensions = new ChangeTrackingList<DeploymentExtensionSpec>();
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The identity of the container group, if configured. </param>
        /// <param name="provisioningState"> The provisioning state of the container group. This only appears in the response. </param>
        /// <param name="containers"> The containers within the container group. </param>
        /// <param name="imageRegistryCredentials"> The image registry credentials by which the container group is created from. </param>
        /// <param name="restartPolicy">
        /// Restart policy for all containers within the container group.
        /// - `Always` Always restart
        /// - `OnFailure` Restart on failure
        /// - `Never` Never restart
        ///
        /// </param>
        /// <param name="ipAddress"> The IP address type of the container group. </param>
        /// <param name="operatingSystemType"> The operating system type required by the containers in the container group. </param>
        /// <param name="volumes"> The list of volumes that can be mounted by containers in this container group. </param>
        /// <param name="instanceView"> The instance view of the container group. Only valid in response. </param>
        /// <param name="diagnostics"> The diagnostic information for a container group. </param>
        /// <param name="subnetIds"> The subnet resource IDs for a container group. </param>
        /// <param name="dnsConfig"> The DNS config information for a container group. </param>
        /// <param name="sku"> The SKU for a container group. </param>
        /// <param name="encryptionProperties"> The encryption properties for a container group. </param>
        /// <param name="initContainers"> The init containers for a container group. </param>
        /// <param name="extensions"> extensions used by virtual kubelet. </param>
        /// <param name="confidentialComputeProperties"> The properties for confidential container group. </param>
        /// <param name="priority"> The priority of the container group. </param>
        /// <param name="containerGroupProfile"> The reference container group profile properties. </param>
        /// <param name="standbyPoolProfile"> The reference standby pool profile properties. </param>
        /// <param name="isCreatedFromStandbyPool"> The flag indicating whether the container group is created by standby pool. </param>
        /// <param name="zones"> The zones for the container group. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, string provisioningState, IList<ContainerInstanceContainer> containers, IList<ContainerGroupImageRegistryCredential> imageRegistryCredentials, ContainerGroupRestartPolicy? restartPolicy, ContainerGroupIPAddress ipAddress, ContainerInstanceOperatingSystemType? operatingSystemType, IList<ContainerVolume> volumes, ContainerGroupInstanceView instanceView, ContainerGroupDiagnostics diagnostics, IList<ContainerGroupSubnetId> subnetIds, ContainerGroupDnsConfiguration dnsConfig, ContainerGroupSku? sku, ContainerGroupEncryptionProperties encryptionProperties, IList<InitContainerDefinitionContent> initContainers, IList<DeploymentExtensionSpec> extensions, ConfidentialComputeProperties confidentialComputeProperties, ContainerGroupPriority? priority, ContainerGroupProfileReferenceDefinition containerGroupProfile, StandbyPoolProfileDefinition standbyPoolProfile, bool? isCreatedFromStandbyPool, IList<string> zones, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            ProvisioningState = provisioningState;
            Containers = containers;
            ImageRegistryCredentials = imageRegistryCredentials;
            RestartPolicy = restartPolicy;
            IPAddress = ipAddress;
            OperatingSystemType = operatingSystemType;
            Volumes = volumes;
            InstanceView = instanceView;
            Diagnostics = diagnostics;
            SubnetIds = subnetIds;
            DnsConfig = dnsConfig;
            Sku = sku;
            EncryptionProperties = encryptionProperties;
            InitContainers = initContainers;
            Extensions = extensions;
            ConfidentialComputeProperties = confidentialComputeProperties;
            Priority = priority;
            ContainerGroupProfile = containerGroupProfile;
            StandbyPoolProfile = standbyPoolProfile;
            IsCreatedFromStandbyPool = isCreatedFromStandbyPool;
            Zones = zones;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerGroupData"/> for deserialization. </summary>
        internal ContainerGroupData()
        {
        }

        /// <summary> The identity of the container group, if configured. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The provisioning state of the container group. This only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The containers within the container group. </summary>
        public IList<ContainerInstanceContainer> Containers { get; }
        /// <summary> The image registry credentials by which the container group is created from. </summary>
        public IList<ContainerGroupImageRegistryCredential> ImageRegistryCredentials { get; }
        /// <summary>
        /// Restart policy for all containers within the container group.
        /// - `Always` Always restart
        /// - `OnFailure` Restart on failure
        /// - `Never` Never restart
        ///
        /// </summary>
        public ContainerGroupRestartPolicy? RestartPolicy { get; set; }
        /// <summary> The IP address type of the container group. </summary>
        public ContainerGroupIPAddress IPAddress { get; set; }
        /// <summary> The operating system type required by the containers in the container group. </summary>
        public ContainerInstanceOperatingSystemType? OperatingSystemType { get; set; }
        /// <summary> The list of volumes that can be mounted by containers in this container group. </summary>
        public IList<ContainerVolume> Volumes { get; }
        /// <summary> The instance view of the container group. Only valid in response. </summary>
        public ContainerGroupInstanceView InstanceView { get; }
        /// <summary> The diagnostic information for a container group. </summary>
        internal ContainerGroupDiagnostics Diagnostics { get; set; }
        /// <summary> Container group log analytics information. </summary>
        public ContainerGroupLogAnalytics DiagnosticsLogAnalytics
        {
            get => Diagnostics is null ? default : Diagnostics.LogAnalytics;
            set
            {
                if (Diagnostics is null)
                    Diagnostics = new ContainerGroupDiagnostics();
                Diagnostics.LogAnalytics = value;
            }
        }

        /// <summary> The subnet resource IDs for a container group. </summary>
        public IList<ContainerGroupSubnetId> SubnetIds { get; }
        /// <summary> The DNS config information for a container group. </summary>
        public ContainerGroupDnsConfiguration DnsConfig { get; set; }
        /// <summary> The SKU for a container group. </summary>
        public ContainerGroupSku? Sku { get; set; }
        /// <summary> The encryption properties for a container group. </summary>
        public ContainerGroupEncryptionProperties EncryptionProperties { get; set; }
        /// <summary> The init containers for a container group. </summary>
        public IList<InitContainerDefinitionContent> InitContainers { get; }
        /// <summary> extensions used by virtual kubelet. </summary>
        public IList<DeploymentExtensionSpec> Extensions { get; }
        /// <summary> The properties for confidential container group. </summary>
        internal ConfidentialComputeProperties ConfidentialComputeProperties { get; set; }
        /// <summary> The base64 encoded confidential compute enforcement policy. </summary>
        public string ConfidentialComputeCcePolicy
        {
            get => ConfidentialComputeProperties is null ? default : ConfidentialComputeProperties.CcePolicy;
            set
            {
                if (ConfidentialComputeProperties is null)
                    ConfidentialComputeProperties = new ConfidentialComputeProperties();
                ConfidentialComputeProperties.CcePolicy = value;
            }
        }

        /// <summary> The priority of the container group. </summary>
        public ContainerGroupPriority? Priority { get; set; }
        /// <summary> The reference container group profile properties. </summary>
        public ContainerGroupProfileReferenceDefinition ContainerGroupProfile { get; set; }
        /// <summary> The reference standby pool profile properties. </summary>
        public StandbyPoolProfileDefinition StandbyPoolProfile { get; set; }
        /// <summary> The flag indicating whether the container group is created by standby pool. </summary>
        public bool? IsCreatedFromStandbyPool { get; }
        /// <summary> The zones for the container group. </summary>
        public IList<string> Zones { get; }
    }
}
