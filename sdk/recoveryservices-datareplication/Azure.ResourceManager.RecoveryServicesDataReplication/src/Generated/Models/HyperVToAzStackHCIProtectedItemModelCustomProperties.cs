// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> HyperV to AzStackHCI Protected item model custom properties. </summary>
    public partial class HyperVToAzStackHCIProtectedItemModelCustomProperties : ProtectedItemModelCustomProperties
    {
        /// <summary> Initializes a new instance of HyperVToAzStackHCIProtectedItemModelCustomProperties. </summary>
        /// <param name="targetHciClusterId"> Gets or sets the Target HCI Cluster ARM Id. </param>
        /// <param name="targetArcClusterCustomLocationId"> Gets or sets the Target Arc Cluster Custom Location ARM Id. </param>
        /// <param name="fabricDiscoveryMachineId"> Gets or sets the ARM Id of the discovered machine. </param>
        /// <param name="disksToInclude"> Gets or sets the list of disks to replicate. </param>
        /// <param name="nicsToInclude"> Gets or sets the list of VM NIC to replicate. </param>
        /// <param name="targetResourceGroupId"> Gets or sets the target resource group ARM Id. </param>
        /// <param name="storageContainerId"> Gets or sets the target storage container ARM Id. </param>
        /// <param name="hyperVGeneration"> Gets or sets the hypervisor generation of the virtual machine. </param>
        /// <param name="runAsAccountId"> Gets or sets the Run As account Id. </param>
        /// <param name="sourceDraName"> Gets or sets the source DRA name. </param>
        /// <param name="targetDraName"> Gets or sets the target DRA name. </param>
        /// <param name="customLocationRegion"> Gets or sets the location of Azure Arc HCI custom location resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetHciClusterId"/>, <paramref name="targetArcClusterCustomLocationId"/>, <paramref name="fabricDiscoveryMachineId"/>, <paramref name="disksToInclude"/>, <paramref name="nicsToInclude"/>, <paramref name="targetResourceGroupId"/>, <paramref name="storageContainerId"/>, <paramref name="hyperVGeneration"/>, <paramref name="runAsAccountId"/>, <paramref name="sourceDraName"/>, <paramref name="targetDraName"/> or <paramref name="customLocationRegion"/> is null. </exception>
        public HyperVToAzStackHCIProtectedItemModelCustomProperties(string targetHciClusterId, string targetArcClusterCustomLocationId, string fabricDiscoveryMachineId, IEnumerable<HyperVToAzStackHCIDiskInput> disksToInclude, IEnumerable<HyperVToAzStackHCINicInput> nicsToInclude, string targetResourceGroupId, string storageContainerId, string hyperVGeneration, string runAsAccountId, string sourceDraName, string targetDraName, string customLocationRegion)
        {
            Argument.AssertNotNull(targetHciClusterId, nameof(targetHciClusterId));
            Argument.AssertNotNull(targetArcClusterCustomLocationId, nameof(targetArcClusterCustomLocationId));
            Argument.AssertNotNull(fabricDiscoveryMachineId, nameof(fabricDiscoveryMachineId));
            Argument.AssertNotNull(disksToInclude, nameof(disksToInclude));
            Argument.AssertNotNull(nicsToInclude, nameof(nicsToInclude));
            Argument.AssertNotNull(targetResourceGroupId, nameof(targetResourceGroupId));
            Argument.AssertNotNull(storageContainerId, nameof(storageContainerId));
            Argument.AssertNotNull(hyperVGeneration, nameof(hyperVGeneration));
            Argument.AssertNotNull(runAsAccountId, nameof(runAsAccountId));
            Argument.AssertNotNull(sourceDraName, nameof(sourceDraName));
            Argument.AssertNotNull(targetDraName, nameof(targetDraName));
            Argument.AssertNotNull(customLocationRegion, nameof(customLocationRegion));

            TargetHciClusterId = targetHciClusterId;
            TargetArcClusterCustomLocationId = targetArcClusterCustomLocationId;
            FabricDiscoveryMachineId = fabricDiscoveryMachineId;
            DisksToInclude = disksToInclude.ToList();
            NicsToInclude = nicsToInclude.ToList();
            TargetResourceGroupId = targetResourceGroupId;
            StorageContainerId = storageContainerId;
            HyperVGeneration = hyperVGeneration;
            RunAsAccountId = runAsAccountId;
            SourceDraName = sourceDraName;
            TargetDraName = targetDraName;
            CustomLocationRegion = customLocationRegion;
            ProtectedDisks = new ChangeTrackingList<HyperVToAzStackHCIProtectedDiskProperties>();
            ProtectedNics = new ChangeTrackingList<HyperVToAzStackHCIProtectedNicProperties>();
            InstanceType = "HyperVToAzStackHCI";
        }

        /// <summary> Initializes a new instance of HyperVToAzStackHCIProtectedItemModelCustomProperties. </summary>
        /// <param name="instanceType"> Gets or sets the instance type. </param>
        /// <param name="activeLocation"> Gets or sets the location of the protected item. </param>
        /// <param name="targetHciClusterId"> Gets or sets the Target HCI Cluster ARM Id. </param>
        /// <param name="targetArcClusterCustomLocationId"> Gets or sets the Target Arc Cluster Custom Location ARM Id. </param>
        /// <param name="targetAzStackHciClusterName"> Gets or sets the Target AzStackHCI cluster name. </param>
        /// <param name="fabricDiscoveryMachineId"> Gets or sets the ARM Id of the discovered machine. </param>
        /// <param name="disksToInclude"> Gets or sets the list of disks to replicate. </param>
        /// <param name="nicsToInclude"> Gets or sets the list of VM NIC to replicate. </param>
        /// <param name="sourceVmName"> Gets or sets the source VM display name. </param>
        /// <param name="sourceCpuCores"> Gets or sets the source VM CPU cores. </param>
        /// <param name="sourceMemoryInMegaBytes"> Gets or sets the source VM ram memory size in megabytes. </param>
        /// <param name="targetVmName"> Gets or sets the target VM display name. </param>
        /// <param name="targetResourceGroupId"> Gets or sets the target resource group ARM Id. </param>
        /// <param name="storageContainerId"> Gets or sets the target storage container ARM Id. </param>
        /// <param name="hyperVGeneration"> Gets or sets the hypervisor generation of the virtual machine. </param>
        /// <param name="targetNetworkId"> Gets or sets the target network Id within AzStackHCI Cluster. </param>
        /// <param name="testNetworkId"> Gets or sets the target test network Id within AzStackHCI Cluster. </param>
        /// <param name="targetCpuCores"> Gets or sets the target CPU cores. </param>
        /// <param name="isDynamicRam"> Gets or sets a value indicating whether memory is dynamical. </param>
        /// <param name="dynamicMemoryConfig"> Protected item dynamic memory config. </param>
        /// <param name="targetMemoryInMegaBytes"> Gets or sets the target memory in mega-bytes. </param>
        /// <param name="runAsAccountId"> Gets or sets the Run As account Id. </param>
        /// <param name="sourceDraName"> Gets or sets the source DRA name. </param>
        /// <param name="targetDraName"> Gets or sets the target DRA name. </param>
        /// <param name="sourceApplianceName"> Gets or sets the source appliance name. </param>
        /// <param name="targetApplianceName"> Gets or sets the target appliance name. </param>
        /// <param name="osType"> Gets or sets the type of the OS. </param>
        /// <param name="osName"> Gets or sets the name of the OS. </param>
        /// <param name="firmwareType"> Gets or sets the firmware type. </param>
        /// <param name="targetLocation"> Gets or sets the target location. </param>
        /// <param name="customLocationRegion"> Gets or sets the location of Azure Arc HCI custom location resource. </param>
        /// <param name="failoverRecoveryPointId"> Gets or sets the recovery point Id to which the VM was failed over. </param>
        /// <param name="lastRecoveryPointReceived"> Gets or sets the last recovery point received time. </param>
        /// <param name="lastRecoveryPointId"> Gets or sets the last recovery point Id. </param>
        /// <param name="initialReplicationProgressPercentage">
        /// Gets or sets the initial replication progress percentage. This is calculated based on
        /// total bytes processed for all disks in the source VM.
        /// </param>
        /// <param name="resyncProgressPercentage">
        /// Gets or sets the resync progress percentage. This is calculated based on total bytes
        /// processed for all disks in the source VM.
        /// </param>
        /// <param name="protectedDisks"> Gets or sets the list of protected disks. </param>
        /// <param name="protectedNics"> Gets or sets the VM NIC details. </param>
        /// <param name="targetVmBiosId"> Gets or sets the BIOS Id of the target AzStackHCI VM. </param>
        /// <param name="lastReplicationUpdateOn"> Gets or sets the latest timestamp that replication status is updated. </param>
        internal HyperVToAzStackHCIProtectedItemModelCustomProperties(string instanceType, ProtectedItemActiveLocation? activeLocation, string targetHciClusterId, string targetArcClusterCustomLocationId, string targetAzStackHciClusterName, string fabricDiscoveryMachineId, IList<HyperVToAzStackHCIDiskInput> disksToInclude, IList<HyperVToAzStackHCINicInput> nicsToInclude, string sourceVmName, int? sourceCpuCores, double? sourceMemoryInMegaBytes, string targetVmName, string targetResourceGroupId, string storageContainerId, string hyperVGeneration, string targetNetworkId, string testNetworkId, int? targetCpuCores, bool? isDynamicRam, ProtectedItemDynamicMemoryConfig dynamicMemoryConfig, int? targetMemoryInMegaBytes, string runAsAccountId, string sourceDraName, string targetDraName, string sourceApplianceName, string targetApplianceName, string osType, string osName, string firmwareType, string targetLocation, string customLocationRegion, string failoverRecoveryPointId, DateTimeOffset? lastRecoveryPointReceived, string lastRecoveryPointId, int? initialReplicationProgressPercentage, int? resyncProgressPercentage, IReadOnlyList<HyperVToAzStackHCIProtectedDiskProperties> protectedDisks, IReadOnlyList<HyperVToAzStackHCIProtectedNicProperties> protectedNics, string targetVmBiosId, DateTimeOffset? lastReplicationUpdateOn) : base(instanceType)
        {
            ActiveLocation = activeLocation;
            TargetHciClusterId = targetHciClusterId;
            TargetArcClusterCustomLocationId = targetArcClusterCustomLocationId;
            TargetAzStackHciClusterName = targetAzStackHciClusterName;
            FabricDiscoveryMachineId = fabricDiscoveryMachineId;
            DisksToInclude = disksToInclude;
            NicsToInclude = nicsToInclude;
            SourceVmName = sourceVmName;
            SourceCpuCores = sourceCpuCores;
            SourceMemoryInMegaBytes = sourceMemoryInMegaBytes;
            TargetVmName = targetVmName;
            TargetResourceGroupId = targetResourceGroupId;
            StorageContainerId = storageContainerId;
            HyperVGeneration = hyperVGeneration;
            TargetNetworkId = targetNetworkId;
            TestNetworkId = testNetworkId;
            TargetCpuCores = targetCpuCores;
            IsDynamicRam = isDynamicRam;
            DynamicMemoryConfig = dynamicMemoryConfig;
            TargetMemoryInMegaBytes = targetMemoryInMegaBytes;
            RunAsAccountId = runAsAccountId;
            SourceDraName = sourceDraName;
            TargetDraName = targetDraName;
            SourceApplianceName = sourceApplianceName;
            TargetApplianceName = targetApplianceName;
            OSType = osType;
            OSName = osName;
            FirmwareType = firmwareType;
            TargetLocation = targetLocation;
            CustomLocationRegion = customLocationRegion;
            FailoverRecoveryPointId = failoverRecoveryPointId;
            LastRecoveryPointReceived = lastRecoveryPointReceived;
            LastRecoveryPointId = lastRecoveryPointId;
            InitialReplicationProgressPercentage = initialReplicationProgressPercentage;
            ResyncProgressPercentage = resyncProgressPercentage;
            ProtectedDisks = protectedDisks;
            ProtectedNics = protectedNics;
            TargetVmBiosId = targetVmBiosId;
            LastReplicationUpdateOn = lastReplicationUpdateOn;
            InstanceType = instanceType ?? "HyperVToAzStackHCI";
        }

        /// <summary> Gets or sets the location of the protected item. </summary>
        public ProtectedItemActiveLocation? ActiveLocation { get; }
        /// <summary> Gets or sets the Target HCI Cluster ARM Id. </summary>
        public string TargetHciClusterId { get; set; }
        /// <summary> Gets or sets the Target Arc Cluster Custom Location ARM Id. </summary>
        public string TargetArcClusterCustomLocationId { get; set; }
        /// <summary> Gets or sets the Target AzStackHCI cluster name. </summary>
        public string TargetAzStackHciClusterName { get; }
        /// <summary> Gets or sets the ARM Id of the discovered machine. </summary>
        public string FabricDiscoveryMachineId { get; set; }
        /// <summary> Gets or sets the list of disks to replicate. </summary>
        public IList<HyperVToAzStackHCIDiskInput> DisksToInclude { get; }
        /// <summary> Gets or sets the list of VM NIC to replicate. </summary>
        public IList<HyperVToAzStackHCINicInput> NicsToInclude { get; }
        /// <summary> Gets or sets the source VM display name. </summary>
        public string SourceVmName { get; }
        /// <summary> Gets or sets the source VM CPU cores. </summary>
        public int? SourceCpuCores { get; }
        /// <summary> Gets or sets the source VM ram memory size in megabytes. </summary>
        public double? SourceMemoryInMegaBytes { get; }
        /// <summary> Gets or sets the target VM display name. </summary>
        public string TargetVmName { get; set; }
        /// <summary> Gets or sets the target resource group ARM Id. </summary>
        public string TargetResourceGroupId { get; set; }
        /// <summary> Gets or sets the target storage container ARM Id. </summary>
        public string StorageContainerId { get; set; }
        /// <summary> Gets or sets the hypervisor generation of the virtual machine. </summary>
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
        /// <summary> Gets or sets the Run As account Id. </summary>
        public string RunAsAccountId { get; set; }
        /// <summary> Gets or sets the source DRA name. </summary>
        public string SourceDraName { get; set; }
        /// <summary> Gets or sets the target DRA name. </summary>
        public string TargetDraName { get; set; }
        /// <summary> Gets or sets the source appliance name. </summary>
        public string SourceApplianceName { get; }
        /// <summary> Gets or sets the target appliance name. </summary>
        public string TargetApplianceName { get; }
        /// <summary> Gets or sets the type of the OS. </summary>
        public string OSType { get; }
        /// <summary> Gets or sets the name of the OS. </summary>
        public string OSName { get; }
        /// <summary> Gets or sets the firmware type. </summary>
        public string FirmwareType { get; }
        /// <summary> Gets or sets the target location. </summary>
        public string TargetLocation { get; }
        /// <summary> Gets or sets the location of Azure Arc HCI custom location resource. </summary>
        public string CustomLocationRegion { get; set; }
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
        /// <summary>
        /// Gets or sets the resync progress percentage. This is calculated based on total bytes
        /// processed for all disks in the source VM.
        /// </summary>
        public int? ResyncProgressPercentage { get; }
        /// <summary> Gets or sets the list of protected disks. </summary>
        public IReadOnlyList<HyperVToAzStackHCIProtectedDiskProperties> ProtectedDisks { get; }
        /// <summary> Gets or sets the VM NIC details. </summary>
        public IReadOnlyList<HyperVToAzStackHCIProtectedNicProperties> ProtectedNics { get; }
        /// <summary> Gets or sets the BIOS Id of the target AzStackHCI VM. </summary>
        public string TargetVmBiosId { get; }
        /// <summary> Gets or sets the latest timestamp that replication status is updated. </summary>
        public DateTimeOffset? LastReplicationUpdateOn { get; }
    }
}
