// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesDataReplication;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> VMware to AzStackHCI Protected item model custom properties. </summary>
    public partial class VMwareToAzStackHciProtectedItemModelCustomProperties : ProtectedItemModelCustomProperties
    {
        /// <summary> Initializes a new instance of <see cref="VMwareToAzStackHciProtectedItemModelCustomProperties"/>. </summary>
        /// <param name="targetHciClusterId"> Gets or sets the Target HCI Cluster ARM Id. </param>
        /// <param name="targetArcClusterCustomLocationId"> Gets or sets the Target Arc Cluster Custom Location ARM Id. </param>
        /// <param name="storageContainerId"> Gets or sets the target storage container ARM Id. </param>
        /// <param name="targetResourceGroupId"> Gets or sets the target resource group ARM Id. </param>
        /// <param name="customLocationRegion"> Gets or sets the location of Azure Arc HCI custom location resource. </param>
        /// <param name="disksToInclude"> Gets or sets the list of disks to replicate. </param>
        /// <param name="nicsToInclude"> Gets or sets the list of VM NIC to replicate. </param>
        /// <param name="hyperVGeneration"> Gets or sets the hypervisor generation of the virtual machine possible values are 1,2. </param>
        /// <param name="fabricDiscoveryMachineId"> Gets or sets the ARM Id of the discovered machine. </param>
        /// <param name="runAsAccountId"> Gets or sets the run as account Id. </param>
        /// <param name="sourceDraName"> Gets or sets the source DRA name. </param>
        /// <param name="targetDraName"> Gets or sets the target DRA name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetHciClusterId"/>, <paramref name="targetArcClusterCustomLocationId"/>, <paramref name="storageContainerId"/>, <paramref name="targetResourceGroupId"/>, <paramref name="customLocationRegion"/>, <paramref name="disksToInclude"/>, <paramref name="nicsToInclude"/>, <paramref name="hyperVGeneration"/>, <paramref name="fabricDiscoveryMachineId"/>, <paramref name="runAsAccountId"/>, <paramref name="sourceDraName"/> or <paramref name="targetDraName"/> is null. </exception>
        public VMwareToAzStackHciProtectedItemModelCustomProperties(ResourceIdentifier targetHciClusterId, ResourceIdentifier targetArcClusterCustomLocationId, ResourceIdentifier storageContainerId, ResourceIdentifier targetResourceGroupId, string customLocationRegion, IEnumerable<VMwareToAzStackHciDiskInput> disksToInclude, IEnumerable<VMwareToAzStackHciNicInput> nicsToInclude, string hyperVGeneration, ResourceIdentifier fabricDiscoveryMachineId, string runAsAccountId, string sourceDraName, string targetDraName)
        {
            Argument.AssertNotNull(targetHciClusterId, nameof(targetHciClusterId));
            Argument.AssertNotNull(targetArcClusterCustomLocationId, nameof(targetArcClusterCustomLocationId));
            Argument.AssertNotNull(storageContainerId, nameof(storageContainerId));
            Argument.AssertNotNull(targetResourceGroupId, nameof(targetResourceGroupId));
            Argument.AssertNotNull(customLocationRegion, nameof(customLocationRegion));
            Argument.AssertNotNull(disksToInclude, nameof(disksToInclude));
            Argument.AssertNotNull(nicsToInclude, nameof(nicsToInclude));
            Argument.AssertNotNull(hyperVGeneration, nameof(hyperVGeneration));
            Argument.AssertNotNull(fabricDiscoveryMachineId, nameof(fabricDiscoveryMachineId));
            Argument.AssertNotNull(runAsAccountId, nameof(runAsAccountId));
            Argument.AssertNotNull(sourceDraName, nameof(sourceDraName));
            Argument.AssertNotNull(targetDraName, nameof(targetDraName));

            TargetHciClusterId = targetHciClusterId;
            TargetArcClusterCustomLocationId = targetArcClusterCustomLocationId;
            StorageContainerId = storageContainerId;
            TargetResourceGroupId = targetResourceGroupId;
            CustomLocationRegion = customLocationRegion;
            DisksToInclude = disksToInclude.ToList();
            NicsToInclude = nicsToInclude.ToList();
            ProtectedDisks = new ChangeTrackingList<VMwareToAzStackHciProtectedDiskProperties>();
            ProtectedNics = new ChangeTrackingList<VMwareToAzStackHciProtectedNicProperties>();
            HyperVGeneration = hyperVGeneration;
            FabricDiscoveryMachineId = fabricDiscoveryMachineId;
            RunAsAccountId = runAsAccountId;
            SourceDraName = sourceDraName;
            TargetDraName = targetDraName;
            InstanceType = "VMwareToAzStackHCI";
        }

        /// <summary> Initializes a new instance of <see cref="VMwareToAzStackHciProtectedItemModelCustomProperties"/>. </summary>
        /// <param name="instanceType"> Gets or sets the instance type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="activeLocation"> Gets or sets the location of the protected item. </param>
        /// <param name="targetHciClusterId"> Gets or sets the Target HCI Cluster ARM Id. </param>
        /// <param name="targetArcClusterCustomLocationId"> Gets or sets the Target Arc Cluster Custom Location ARM Id. </param>
        /// <param name="targetAzStackHciClusterName"> Gets or sets the Target AzStackHCI cluster name. </param>
        /// <param name="storageContainerId"> Gets or sets the target storage container ARM Id. </param>
        /// <param name="targetResourceGroupId"> Gets or sets the target resource group ARM Id. </param>
        /// <param name="targetLocation"> Gets or sets the target location. </param>
        /// <param name="customLocationRegion"> Gets or sets the location of Azure Arc HCI custom location resource. </param>
        /// <param name="disksToInclude"> Gets or sets the list of disks to replicate. </param>
        /// <param name="nicsToInclude"> Gets or sets the list of VM NIC to replicate. </param>
        /// <param name="protectedDisks"> Gets or sets the list of protected disks. </param>
        /// <param name="protectedNics"> Gets or sets the VM NIC details. </param>
        /// <param name="targetVmBiosId"> Gets or sets the BIOS Id of the target AzStackHCI VM. </param>
        /// <param name="targetVmName"> Gets or sets the target VM display name. </param>
        /// <param name="hyperVGeneration"> Gets or sets the hypervisor generation of the virtual machine possible values are 1,2. </param>
        /// <param name="targetNetworkId"> Gets or sets the target network Id within AzStackHCI Cluster. </param>
        /// <param name="testNetworkId"> Gets or sets the target test network Id within AzStackHCI Cluster. </param>
        /// <param name="targetCpuCores"> Gets or sets the target CPU cores. </param>
        /// <param name="isDynamicRam"> Gets or sets a value indicating whether memory is dynamical. </param>
        /// <param name="dynamicMemoryConfig"> Protected item dynamic memory config. </param>
        /// <param name="targetMemoryInMegaBytes"> Gets or sets the target memory in mega-bytes. </param>
        /// <param name="osType"> Gets or sets the type of the OS. </param>
        /// <param name="osName"> Gets or sets the name of the OS. </param>
        /// <param name="firmwareType"> Gets or sets the firmware type. </param>
        /// <param name="fabricDiscoveryMachineId"> Gets or sets the ARM Id of the discovered machine. </param>
        /// <param name="sourceVmName"> Gets or sets the source VM display name. </param>
        /// <param name="sourceCpuCores"> Gets or sets the source VM CPU cores. </param>
        /// <param name="sourceMemoryInMegaBytes"> Gets or sets the source VM ram memory size in megabytes. </param>
        /// <param name="runAsAccountId"> Gets or sets the run as account Id. </param>
        /// <param name="sourceDraName"> Gets or sets the source DRA name. </param>
        /// <param name="targetDraName"> Gets or sets the target DRA name. </param>
        /// <param name="sourceApplianceName"> Gets or sets the source appliance name. </param>
        /// <param name="targetApplianceName"> Gets or sets the target appliance name. </param>
        /// <param name="failoverRecoveryPointId"> Gets or sets the recovery point Id to which the VM was failed over. </param>
        /// <param name="lastRecoveryPointReceived"> Gets or sets the last recovery point received time. </param>
        /// <param name="lastRecoveryPointId"> Gets or sets the last recovery point Id. </param>
        /// <param name="initialReplicationProgressPercentage">
        /// Gets or sets the initial replication progress percentage. This is calculated based on
        /// total bytes processed for all disks in the source VM.
        /// </param>
        /// <param name="migrationProgressPercentage"> Gets or sets the migration progress percentage. </param>
        /// <param name="resumeProgressPercentage"> Gets or sets the resume progress percentage. </param>
        /// <param name="resyncProgressPercentage">
        /// Gets or sets the resync progress percentage. This is calculated based on total bytes
        /// processed for all disks in the source VM.
        /// </param>
        /// <param name="resyncRetryCount"> Gets or sets the resync retry count. </param>
        /// <param name="resyncRequired"> Gets or sets a value indicating whether resync is required. </param>
        /// <param name="resyncState"> Gets or sets the resync state. </param>
        /// <param name="performAutoResync"> Gets or sets a value indicating whether auto resync is to be done. </param>
        /// <param name="resumeRetryCount"> Gets or sets the resume retry count. </param>
        /// <param name="lastReplicationUpdateOn"> Gets or sets the latest timestamp that replication status is updated. </param>
        internal VMwareToAzStackHciProtectedItemModelCustomProperties(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ProtectedItemActiveLocation? activeLocation, ResourceIdentifier targetHciClusterId, ResourceIdentifier targetArcClusterCustomLocationId, string targetAzStackHciClusterName, ResourceIdentifier storageContainerId, ResourceIdentifier targetResourceGroupId, string targetLocation, string customLocationRegion, IList<VMwareToAzStackHciDiskInput> disksToInclude, IList<VMwareToAzStackHciNicInput> nicsToInclude, IReadOnlyList<VMwareToAzStackHciProtectedDiskProperties> protectedDisks, IReadOnlyList<VMwareToAzStackHciProtectedNicProperties> protectedNics, string targetVmBiosId, string targetVmName, string hyperVGeneration, string targetNetworkId, string testNetworkId, int? targetCpuCores, bool? isDynamicRam, ProtectedItemDynamicMemoryConfig dynamicMemoryConfig, int? targetMemoryInMegaBytes, string osType, string osName, string firmwareType, ResourceIdentifier fabricDiscoveryMachineId, string sourceVmName, int? sourceCpuCores, double? sourceMemoryInMegaBytes, string runAsAccountId, string sourceDraName, string targetDraName, string sourceApplianceName, string targetApplianceName, string failoverRecoveryPointId, DateTimeOffset? lastRecoveryPointReceived, string lastRecoveryPointId, int? initialReplicationProgressPercentage, int? migrationProgressPercentage, int? resumeProgressPercentage, int? resyncProgressPercentage, long? resyncRetryCount, bool? resyncRequired, VMwareToAzureMigrateResyncState? resyncState, bool? performAutoResync, long? resumeRetryCount, DateTimeOffset? lastReplicationUpdateOn) : base(instanceType, serializedAdditionalRawData)
        {
            ActiveLocation = activeLocation;
            TargetHciClusterId = targetHciClusterId;
            TargetArcClusterCustomLocationId = targetArcClusterCustomLocationId;
            TargetAzStackHciClusterName = targetAzStackHciClusterName;
            StorageContainerId = storageContainerId;
            TargetResourceGroupId = targetResourceGroupId;
            TargetLocation = targetLocation;
            CustomLocationRegion = customLocationRegion;
            DisksToInclude = disksToInclude;
            NicsToInclude = nicsToInclude;
            ProtectedDisks = protectedDisks;
            ProtectedNics = protectedNics;
            TargetVmBiosId = targetVmBiosId;
            TargetVmName = targetVmName;
            HyperVGeneration = hyperVGeneration;
            TargetNetworkId = targetNetworkId;
            TestNetworkId = testNetworkId;
            TargetCpuCores = targetCpuCores;
            IsDynamicRam = isDynamicRam;
            DynamicMemoryConfig = dynamicMemoryConfig;
            TargetMemoryInMegaBytes = targetMemoryInMegaBytes;
            OSType = osType;
            OSName = osName;
            FirmwareType = firmwareType;
            FabricDiscoveryMachineId = fabricDiscoveryMachineId;
            SourceVmName = sourceVmName;
            SourceCpuCores = sourceCpuCores;
            SourceMemoryInMegaBytes = sourceMemoryInMegaBytes;
            RunAsAccountId = runAsAccountId;
            SourceDraName = sourceDraName;
            TargetDraName = targetDraName;
            SourceApplianceName = sourceApplianceName;
            TargetApplianceName = targetApplianceName;
            FailoverRecoveryPointId = failoverRecoveryPointId;
            LastRecoveryPointReceived = lastRecoveryPointReceived;
            LastRecoveryPointId = lastRecoveryPointId;
            InitialReplicationProgressPercentage = initialReplicationProgressPercentage;
            MigrationProgressPercentage = migrationProgressPercentage;
            ResumeProgressPercentage = resumeProgressPercentage;
            ResyncProgressPercentage = resyncProgressPercentage;
            ResyncRetryCount = resyncRetryCount;
            ResyncRequired = resyncRequired;
            ResyncState = resyncState;
            PerformAutoResync = performAutoResync;
            ResumeRetryCount = resumeRetryCount;
            LastReplicationUpdateOn = lastReplicationUpdateOn;
            InstanceType = instanceType ?? "VMwareToAzStackHCI";
        }

        /// <summary> Initializes a new instance of <see cref="VMwareToAzStackHciProtectedItemModelCustomProperties"/> for deserialization. </summary>
        internal VMwareToAzStackHciProtectedItemModelCustomProperties()
        {
        }

        /// <summary> Gets or sets the location of the protected item. </summary>
        public ProtectedItemActiveLocation? ActiveLocation { get; }
        /// <summary> Gets or sets the Target HCI Cluster ARM Id. </summary>
        public ResourceIdentifier TargetHciClusterId { get; set; }
        /// <summary> Gets or sets the Target Arc Cluster Custom Location ARM Id. </summary>
        public ResourceIdentifier TargetArcClusterCustomLocationId { get; set; }
        /// <summary> Gets or sets the Target AzStackHCI cluster name. </summary>
        public string TargetAzStackHciClusterName { get; }
        /// <summary> Gets or sets the target storage container ARM Id. </summary>
        public ResourceIdentifier StorageContainerId { get; set; }
        /// <summary> Gets or sets the target resource group ARM Id. </summary>
        public ResourceIdentifier TargetResourceGroupId { get; set; }
        /// <summary> Gets or sets the target location. </summary>
        public string TargetLocation { get; }
        /// <summary> Gets or sets the location of Azure Arc HCI custom location resource. </summary>
        public string CustomLocationRegion { get; set; }
        /// <summary> Gets or sets the list of disks to replicate. </summary>
        public IList<VMwareToAzStackHciDiskInput> DisksToInclude { get; }
        /// <summary> Gets or sets the list of VM NIC to replicate. </summary>
        public IList<VMwareToAzStackHciNicInput> NicsToInclude { get; }
        /// <summary> Gets or sets the list of protected disks. </summary>
        public IReadOnlyList<VMwareToAzStackHciProtectedDiskProperties> ProtectedDisks { get; }
        /// <summary> Gets or sets the VM NIC details. </summary>
        public IReadOnlyList<VMwareToAzStackHciProtectedNicProperties> ProtectedNics { get; }
        /// <summary> Gets or sets the BIOS Id of the target AzStackHCI VM. </summary>
        public string TargetVmBiosId { get; }
        /// <summary> Gets or sets the target VM display name. </summary>
        public string TargetVmName { get; set; }
        /// <summary> Gets or sets the hypervisor generation of the virtual machine possible values are 1,2. </summary>
        public string HyperVGeneration { get; set; }
        /// <summary> Gets or sets the target network Id within AzStackHCI Cluster. </summary>
        public string TargetNetworkId { get; set; }
        /// <summary> Gets or sets the target test network Id within AzStackHCI Cluster. </summary>
        public string TestNetworkId { get; set; }
        /// <summary> Gets or sets the target CPU cores. </summary>
        public int? TargetCpuCores { get; set; }
        /// <summary> Gets or sets a value indicating whether memory is dynamical. </summary>
        public bool? IsDynamicRam { get; set; }
        /// <summary> Protected item dynamic memory config. </summary>
        public ProtectedItemDynamicMemoryConfig DynamicMemoryConfig { get; set; }
        /// <summary> Gets or sets the target memory in mega-bytes. </summary>
        public int? TargetMemoryInMegaBytes { get; set; }
        /// <summary> Gets or sets the type of the OS. </summary>
        public string OSType { get; }
        /// <summary> Gets or sets the name of the OS. </summary>
        public string OSName { get; }
        /// <summary> Gets or sets the firmware type. </summary>
        public string FirmwareType { get; }
        /// <summary> Gets or sets the ARM Id of the discovered machine. </summary>
        public ResourceIdentifier FabricDiscoveryMachineId { get; set; }
        /// <summary> Gets or sets the source VM display name. </summary>
        public string SourceVmName { get; }
        /// <summary> Gets or sets the source VM CPU cores. </summary>
        public int? SourceCpuCores { get; }
        /// <summary> Gets or sets the source VM ram memory size in megabytes. </summary>
        public double? SourceMemoryInMegaBytes { get; }
        /// <summary> Gets or sets the run as account Id. </summary>
        public string RunAsAccountId { get; set; }
        /// <summary> Gets or sets the source DRA name. </summary>
        public string SourceDraName { get; set; }
        /// <summary> Gets or sets the target DRA name. </summary>
        public string TargetDraName { get; set; }
        /// <summary> Gets or sets the source appliance name. </summary>
        public string SourceApplianceName { get; }
        /// <summary> Gets or sets the target appliance name. </summary>
        public string TargetApplianceName { get; }
        /// <summary> Gets or sets the recovery point Id to which the VM was failed over. </summary>
        public string FailoverRecoveryPointId { get; }
        /// <summary> Gets or sets the last recovery point received time. </summary>
        public DateTimeOffset? LastRecoveryPointReceived { get; }
        /// <summary> Gets or sets the last recovery point Id. </summary>
        public string LastRecoveryPointId { get; }
        /// <summary>
        /// Gets or sets the initial replication progress percentage. This is calculated based on
        /// total bytes processed for all disks in the source VM.
        /// </summary>
        public int? InitialReplicationProgressPercentage { get; }
        /// <summary> Gets or sets the migration progress percentage. </summary>
        public int? MigrationProgressPercentage { get; }
        /// <summary> Gets or sets the resume progress percentage. </summary>
        public int? ResumeProgressPercentage { get; }
        /// <summary>
        /// Gets or sets the resync progress percentage. This is calculated based on total bytes
        /// processed for all disks in the source VM.
        /// </summary>
        public int? ResyncProgressPercentage { get; }
        /// <summary> Gets or sets the resync retry count. </summary>
        public long? ResyncRetryCount { get; }
        /// <summary> Gets or sets a value indicating whether resync is required. </summary>
        public bool? ResyncRequired { get; }
        /// <summary> Gets or sets the resync state. </summary>
        public VMwareToAzureMigrateResyncState? ResyncState { get; }
        /// <summary> Gets or sets a value indicating whether auto resync is to be done. </summary>
        public bool? PerformAutoResync { get; set; }
        /// <summary> Gets or sets the resume retry count. </summary>
        public long? ResumeRetryCount { get; }
        /// <summary> Gets or sets the latest timestamp that replication status is updated. </summary>
        public DateTimeOffset? LastReplicationUpdateOn { get; }
    }
}
